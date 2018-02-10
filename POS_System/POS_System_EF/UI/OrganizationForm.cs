using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class OrganizationForm : Form
    {
        ManagerContext db=new ManagerContext();
        Organization org=new Organization();
        private bool IsUpdateMode=false;
        public OrganizationForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
           var dgvShow   = (from org in db.Organizations where org.IsDelete==false
                                           select new
                                           {
                                               org.Id,
                                               org.Name,
                                               org.Code,
                                               org.ContactNo,
                                               org.Address,
                                               org.Logo
                                           }).ToList();
            dgvOrganization.DataSource = dgvShow;
            var dataGridViewColumn = dgvOrganization.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            for (int i = 0; i < dgvOrganization.Columns.Count; i++)
            {
                var column = dgvOrganization.Columns[i] as DataGridViewImageColumn;
                if (column == null) continue;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                break;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOranizationName.Text)&&string.IsNullOrEmpty(txtContactNo.Text)&&string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please fill text box");
                    return;
                }
                if (!IsUpdateMode)
                {
                    FillFormToOrganizationInfo();
                    bool isContactNoExist = db.Organizations.Count(c => c.ContactNo == org.ContactNo) > 0;
                    if (isContactNoExist)
                    {
                        MessageBox.Show("Contact No Allready Exist");
                        return;
                    }
                    DialogResult result = MessageBox.Show("Do you want to Save?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        db.Organizations.Add(org);
                        int count = db.SaveChanges();
                        MessageBox.Show(count > 0 ? "Organization Saved" : "Save Failed");
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("You have clicked Cancel Button");
                    }
                }
                else if (IsUpdateMode)
                {

                    FillFormToOrganizationInfo();
                    bool isContactNoExist = db.Organizations.Count(c => c.ContactNo == org.ContactNo) > 1;
                    if (isContactNoExist)
                    {
                        MessageBox.Show("Contact No Allready Exist");
                        return;
                    }
                    DialogResult result = MessageBox.Show("Do you want to Update?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        db.Organizations.Attach(org);
                        db.Entry(org).State = EntityState.Modified;
                        bool isUpdate = db.SaveChanges() > 0;
                        MessageBox.Show(isUpdate ? "Update successfully saved" : "Update Failed");
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("You have clicked Cancel Button");
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + " Check technical error !");
            }
            LoadDataGridView();
            ClearTextBoxAll();
            SetFormToNewMode();
        }

        private void FillFormToOrganizationInfo()
        {
            org.Name = txtOranizationName.Text;
            org.ContactNo = txtContactNo.Text;
            org.Address = txtAddress.Text;
            org.Code = org.GenerateCode(org.Name, org.Address);
            txtOrgnizationCode.Text = org.Code;
            org.Logo = org.Logo;
        }

        private void SetFormToNewMode()
        {
            buttonDelete.Visible = false;
            btnSave.Text = "Save";
            IsUpdateMode = false;
        }

        private void ClearTextBoxAll()
        {
            txtOranizationName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtOrgnizationCode.Clear();
            pictureBoxOrg.Image = null;
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string logo = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPG Files (*.Jpg)|*.JPG|GIF Files(*.gif)|*.GIF|All Files(*.*)|*.*";
                openFileDialog.FileName = "Upload Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    logo = openFileDialog.FileName;
                    pictureBoxOrg.ImageLocation = logo;
                }
                FileStream fs = new FileStream(logo, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                org.Logo = br.ReadBytes((int)fs.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "Do you want to cancel!");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
            SetFormToNewMode();
        }
        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBoxOrg.Image = null;
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Close();
        }
        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            var organization = (from org in db.Organizations
                               where org.Name.StartsWith(textSearch) && org.IsDelete==false
                               select new
                               {
                                   org.Name,
                                   org.Code,
                                   org.ContactNo
                               }).ToList();
            dgvOrganization.DataSource = organization;
        }

        private void btnClearSrcBox_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            textBoxSrc.Clear();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvOrganization.SelectedRows[0].Cells["Id"].Value;
            var updateOrg = db.Organizations.FirstOrDefault(c => c.Id == id);
            if (updateOrg != null)
            {
                org = updateOrg;
                updateOrg.IsDelete = true;


                DialogResult result = MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        db.SaveChanges();
                        MessageBox.Show("Successfully deleted");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("You have clicked Cancel Button");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
            SetFormToNewMode();
            LoadDataGridView();
            ClearTextBoxAll();
        }

        private void dgvOrganization_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvOrganization.SelectedRows[0].Cells["Id"].Value;
            var updateOrg = db.Organizations.FirstOrDefault(c => c.Id == id);
            if (updateOrg != null)
            {
                org = updateOrg;
                txtOranizationName.Text = updateOrg.Name;
                txtOrgnizationCode.Text = updateOrg.Code;
                txtAddress.Text = updateOrg.Address;
                txtContactNo.Text = updateOrg.ContactNo;
                org.Logo = updateOrg.Logo;
                MemoryStream memoryStream = new MemoryStream(org.Logo);
                pictureBoxOrg.Image = Image.FromStream(memoryStream);
            }
            SetFormToUpdateMode();
        }

        private void SetFormToUpdateMode()
        {
            IsUpdateMode = true;
            buttonDelete.Visible = true;
            btnSave.Text = "Update";
        }
    }
}

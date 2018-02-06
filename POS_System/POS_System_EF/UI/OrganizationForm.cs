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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class OrganizationForm : Form
    {
        ManagerContext db=new ManagerContext();
        Organization org=new Organization();
        public OrganizationForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
           var dgvShow   = (from org in db.Organizations
                                           select new
                                           {
                                               org.Name,
                                               org.Code,
                                               org.ContactNo,
                                               org.Address,
                                               org.Logo
                                           }).ToList();
            dgvOrganization.DataSource = dgvShow;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                org.Name = txtOranizationName.Text;
                org.ContactNo = txtContactNo.Text;
                org.Address = txtAddress.Text;
                org.Code = org.GenerateCode(org.Name, org.Address);
                org.Logo = org.Logo;
                db = new ManagerContext();
                bool IsContactNoExist = db.Organizations.Count(c => c.ContactNo == org.ContactNo) > 0;
                if(IsContactNoExist)
                {
                    MessageBox.Show("Contact No Allready Exist");
                }
                else
                {
                    db.Organizations.Add(org);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Saved");


                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    LoadDataGridView();
                    ClearTextBoxAll();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + " Please fill text Box!");
            }
            
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

                MessageBox.Show(ex.Message + "\n" + "Image format is not valid");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBoxOrg.Image = null;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm=new OpeningForm();
            openingForm.Show();
            this.Hide();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            ManagerContext db = new ManagerContext();
            var organization = (from org in db.Organizations
                               where org.Name.StartsWith(textSearch)
                               select new
                               {
                                   org.Name,
                                   org.Code,
                                   org.ContactNo
                               }).ToList();
            dgvOrganization.DataSource = organization;
            

        }
    }
}

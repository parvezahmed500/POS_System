using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class OutletForm : Form
    {
        ManagerContext db = new ManagerContext();
        Outlet outlet = new Outlet();
        Organization org = new Organization();
        public OutletForm()
        {
            InitializeComponent();
            ComboBoxData();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            outlet.OrganizationId = (int)cmbOrganizationName.SelectedValue;
            outlet.Name = textBoxOutletName.Text;
            outlet.ContactNo = txtContactNo.Text;
            outlet.Address = txtAddress.Text;
            outlet.Code = outlet.GenerateCode(outlet.Name, outlet.Address);
            bool IsExistContactNo = db.Outlets.Count(c => c.ContactNo == outlet.ContactNo) > 0;
            if(IsExistContactNo)
            {
                MessageBox.Show("Contact No Exist");
            }
            else
            {
                db.Outlets.Add(outlet);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Outlet Saved");

                }
                else
                {
                    MessageBox.Show(" Save Failed");
                }

            }
            
            LoadDataGridView();
            ClearTextBoxAll();
        }

        private void ClearTextBoxAll()
        {
            textBoxOutletName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtOutletCode.Clear();
            cmbOrganizationName.SelectedIndex = -1;
        }

        private void ComboBoxData()
        {
            cmbOrganizationName.DataSource = db.Organizations.ToList();
            cmbOrganizationName.DisplayMember = "Name";
            cmbOrganizationName.ValueMember = "Id";
            cmbOrganizationName.SelectedIndex = -1;
        }
        private void LoadDataGridView()
        {
            var aOutlet = (from outlet in db.Outlets
                           join org in db.Organizations on outlet.OrganizationId equals org.Id
                           select new
                           {
                               OrganizationName = org.Name,
                               OutletName=outlet.Name,
                                outlet.Code,
                                outlet.ContactNo,
                                outlet.Address
                            }).ToList();
                        dgvOutlet.DataSource = aOutlet;
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            var outlet = (from outlet1 in db.Outlets
                                where outlet1.Name.StartsWith(textSearch)
                                select new
                                {
                                    OrganizationName=outlet1.Organization.Name,
                                    OutletName= outlet1.Name,
                                    outlet1.Code,
                                    outlet1.ContactNo,
                                    outlet1.Address,
                                }).ToList();
            dgvOutlet.DataSource = outlet;
        }

        private void btnClearSrcBox_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            textBoxSrc.Clear();
        }
    }
}

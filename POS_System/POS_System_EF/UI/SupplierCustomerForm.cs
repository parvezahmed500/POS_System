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
    public partial class SupplierCustomerForm : Form
    {
        ManagerContext db=new ManagerContext();
        Supplier supplier=new Supplier();
        Customer aCustomer=new Customer();
        public SupplierCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                supplier.Name = txtPartyName.Text;
                supplier.ContactNo = txtContactNo.Text;
                supplier.Email = txtEmail.Text;
                supplier.Address = txtAddress.Text;
                supplier.Code = supplier.GenerateCode(supplier.Name, supplier.Address, supplier.ContactNo);
                if (chkSupplier.Checked)
                {

                    db.Suppliers.Add(supplier);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Successfully Saved");
                    }
                    else
                    {
                        MessageBox.Show("Save failed");
                    }
                    LoadDataGridViewSupplier();
                }
                else if (chkCustomer.Checked)
                {

                    aCustomer.Name = txtPartyName.Text;
                    aCustomer.Email = txtEmail.Text;
                    aCustomer.ContactNo = txtContactNo.Text;
                    aCustomer.Address = txtAddress.Text;
                    aCustomer.Code = aCustomer.GenerateCode(aCustomer.Name, aCustomer.Address, aCustomer.ContactNo);
                    db.Customers.Add(aCustomer);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Successfully Saved");
                    }
                    else
                    {
                        MessageBox.Show("Save failed");
                    }
                    LoadDataGridViewCustomr();
                }


                ClearAllTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
            }
        }

        private void ClearAllTextBox()
        {
            txtPartyName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtPartyCode.Clear();
            txtAddress.Clear();
            chkCustomer.Checked = false;
            chkSupplier.Checked = false;

        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            LoadDataGridViewSupplier();
        }

        private void LoadDataGridViewSupplier()
        {                
            
            dataGridView.DataSource = db.Suppliers.ToList();
        }
        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            LoadDataGridViewCustomr();
        }

        private void LoadDataGridViewCustomr()
        {
            dataGridView.DataSource = db.Customers.ToList();
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
            var customer = (from c in db.Customers
                                where c.Name.StartsWith(textSearch)
                                select new
                                {
                                    c.Name,
                                    c.Code,
                                    c.ContactNo
                                }).ToList();
            dataGridView.DataSource = customer;
        }
    }
}

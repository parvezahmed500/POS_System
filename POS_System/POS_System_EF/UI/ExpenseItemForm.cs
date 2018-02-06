using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System_EF.EntityModels;
using POS_System_EF.Managers;

namespace POS_System_EF.UI
{
    public partial class ExpenseItemForm : Form
    {
        ManagerContext db = new ManagerContext();
        ExpenseItem expenseItem=new ExpenseItem();
        public ExpenseItemForm()
        {
            InitializeComponent();
            ComboxData();
            LoadDataGridViewItem();
        }
        private void ComboxData()
        {
            cmbCategory.DataSource = db.ItemCategories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                expenseItem.ExpenseCategoryId = (int)cmbCategory.SelectedValue;
                expenseItem.Name = txtName.Text;
                expenseItem.Code = expenseItem.GenearateExpItemCode(expenseItem.Name, cmbCategory.Text);
                expenseItem.Description = txtDescription.Text;

                db.ExpenseItems.Add(expenseItem);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Successfully Item Saved");
                }
                else
                {
                    MessageBox.Show("Failed Insertion");
                }
                LoadDataGridViewItem();
                ClearAllTextBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
            }
        }
        private void ClearAllTextBox()
        {
            txtName.Clear();
            txtCode.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

       
        private void LoadDataGridViewItem()
        {
            var item = (from expItems in db.ExpenseItems
                        select new
                        {
                            expItems.Name,
                            expItems.Code,
                            expItems.Description
                        }).ToList();
            dgvItem.DataSource = item;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}

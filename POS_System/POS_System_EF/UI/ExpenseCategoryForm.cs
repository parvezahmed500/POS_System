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
    public partial class ExpenseCategoryForm : Form
    {
        ManagerContext db = new ManagerContext();
        ExpenseCategory expenseCategory=new ExpenseCategory();
        public ExpenseCategoryForm()
        {
            InitializeComponent();
            LoadCombobox();
            LoadDataGridView();
        }
        private void LoadCombobox()
        {
            var loadCategory = (from expenseCategory in db.ExpenseCategories
                where expenseCategory.RootCategoryId == 0
                select expenseCategory
                ).ToList();
            
            cmbRootCategory.DataSource = loadCategory;
            cmbRootCategory.DisplayMember = "Name";
            cmbRootCategory.ValueMember = "Id";
            cmbRootCategory.SelectedIndex = -1;
        }
        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbRootCategory.Checked)
                {

                    expenseCategory.Name = txtName.Text;
                    expenseCategory.Code = expenseCategory.GenearateCodeExpRoot(expenseCategory.Name);
                    expenseCategory.Description = txtDescription.Text;
                    db.ExpenseCategories.Add(expenseCategory);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Root Category saved!");
                    }
                    else
                    {
                        MessageBox.Show("Save failed!");
                    }
                    LoadCombobox();
                }
                else if (rbSubCategory.Checked)
                {

                    expenseCategory.RootCategoryId = (int)cmbRootCategory.SelectedValue;
                    expenseCategory.RootCategoryName = cmbRootCategory.Text;
                    expenseCategory.Name = txtName.Text;
                    expenseCategory.Code = expenseCategory.GenearateCodeExpSub(expenseCategory.Name);
                    expenseCategory.Description = txtDescription.Text;
                    db.ExpenseCategories.Add(expenseCategory);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Sub Category saved!");
                    }
                    else
                    {
                        MessageBox.Show("Save failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Category!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + "[NB] Operating system found error!");
            }
            LoadDataGridView();
            ClearAllTextBox();
        }
        private void ClearAllTextBox()
        {
            rbRootCategory.Checked = false;
            rbSubCategory.Checked = false;
            cmbRootCategory.SelectedIndex = -1;
            txtName.Clear();
            txtCode.Clear();
            txtDescription.Clear();
        }
        private void LoadDataGridView()
        {
            var item = (from expenseCategory in db.ExpenseCategories
                        select new
                        {
                            expenseCategory.Name,
                            expenseCategory.Code,
                            expenseCategory.Description,
                            expenseCategory.RootCategoryName
                        }).ToList();
            dgvCategoryList.DataSource = item;
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

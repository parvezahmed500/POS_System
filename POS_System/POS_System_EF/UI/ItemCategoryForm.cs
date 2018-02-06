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
    public partial class ItemCategoryForm : Form
    {
        ManagerContext db = new ManagerContext();
        ItemCategory itemCategory = new ItemCategory();
        public ItemCategoryForm()
        {
            InitializeComponent();
            LoadCombobox();
            LoadDataGridView();
        }

        private void LoadCombobox()
        {
            var loadCategory = db.ItemCategories.ToList();
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
                    
                    itemCategory.Name = txtName.Text;
                    itemCategory.Code = itemCategory.GenearateCodeRoot(itemCategory.Name);
                    itemCategory.Description = txtDescription.Text;
                    db.ItemCategories.Add(itemCategory);
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

                    itemCategory.CategoryId = (int)cmbRootCategory.SelectedValue;
                    itemCategory.Name = txtName.Text;
                    itemCategory.Code = itemCategory.GenearateCodeSub(itemCategory.Name);
                    itemCategory.Description = txtDescription.Text;
                    db.ItemCategories.Add(itemCategory);
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
            var dgvLoad = (from itemCategory in db.ItemCategories.Where(c=>c.Id==c.CategoryId)
                           select new
                           {
                               itemCategory.Name,
                               itemCategory.Code,
                               itemCategory.Description,
                               SubCategory=itemCategory.Name
                           }).ToList();

            dgvCategoryList.DataSource = dgvLoad;
        }
        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            OpeningForm openingForm=new OpeningForm();
            openingForm.Show();
            this.Hide();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            ManagerContext db = new ManagerContext();
            var category = (from cat in db.ItemCategories
                                where cat.Name.StartsWith(textSearch)
                                select new
                                {
                                    cat.Name,
                                    cat.Code,
                                    cat.Description
                                }).ToList();
            dgvCategoryList.DataSource = category;
        }

        private void btnSaveCategory_Click_1(object sender, EventArgs e)
        {

        }
    }
}

using POS_System_EF.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void addorganizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.Show();
        }

        private void addBranchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OutletForm outForm = new OutletForm();
            outForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm eForm = new EmployeeForm();
            eForm.Show();
        }
        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemCategoryForm itemCategoryForm = new ItemCategoryForm();
            itemCategoryForm.Show();
        }
        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm iForm = new ItemForm();
            iForm.Show();
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierCustomerForm partyForm = new SupplierCustomerForm();
            partyForm.Show();
        }

        private void addPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierCustomerForm partyForm = new SupplierCustomerForm();
            partyForm.Show();
        }

        private void addPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm pForm = new PurchaseForm();
            pForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainForm main=new MainForm();
            //main.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expenseCategorySetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseCategoryForm expense=new ExpenseCategoryForm();
            expense.Show();
        }

        private void itemSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpenseItemForm expenseItem=new ExpenseItemForm();
            expenseItem.Show();
        }
    }
}

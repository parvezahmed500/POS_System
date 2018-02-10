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
    public partial class ExpenseOperationForm : Form
    {
        ManagerContext db=new ManagerContext();
        ExpenseOperation exOperation=new ExpenseOperation();
        public ExpenseOperationForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            var loadData = (from ex in db.ExpenseOperations
                select new
                {
                    ex.Id,
                    ex.ExpenseName,
                    ex.Qty,
                    ex.Amount,
                    ex.Paid,
                    ex.Due,
                    ex.Date,
                    ex.Remarks,
                    ex.EmployeeName,
                    ex.OutletName,
                    ex.OrganizationName
                }).ToList();
            dgvExpense.DataSource = loadData;
            var dgvColumn = dgvExpense.Columns["Id"];
            if (dgvColumn!=null )
            {
                dgvColumn.Visible = false;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Close();
        }
    }
}

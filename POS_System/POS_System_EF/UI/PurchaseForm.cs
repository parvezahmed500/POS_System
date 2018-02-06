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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            ComboBoxData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void ComboBoxData()
        {
            ManagerContext db = new ManagerContext();
            var item = db.Items.ToList();
            cmbItem.DataSource = item;
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";


            cmbOutlet.DataSource = db.Outlets.ToList();
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";


            cmbEmployee.DataSource = db.Employees.ToList();
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";


            cmbSupplier.DataSource = db.Suppliers.ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
        }
    }
}

namespace POS_System_EF.UI
{
    partial class PurchaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOutlet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbShowPurchaseItem = new System.Windows.Forms.GroupBox();
            this.gbPurchaseRecieving = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPurchaseList = new System.Windows.Forms.DataGridView();
            this.gbSummary.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.gbShowPurchaseItem.SuspendLayout();
            this.gbPurchaseRecieving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(911, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(820, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.label11);
            this.gbSummary.Controls.Add(this.label10);
            this.gbSummary.Location = new System.Drawing.Point(680, 341);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(306, 76);
            this.gbSummary.TabIndex = 23;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Purchase Summary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Amount Due";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtRemarks);
            this.gbDetails.Controls.Add(this.dtpPurchase);
            this.gbDetails.Controls.Add(this.cmbSupplier);
            this.gbDetails.Controls.Add(this.cmbEmployee);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.cmbOutlet);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Location = new System.Drawing.Point(680, 91);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(306, 244);
            this.gbDetails.TabIndex = 22;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Information Details";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(85, 194);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(202, 20);
            this.txtRemarks.TabIndex = 9;
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Location = new System.Drawing.Point(87, 157);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(200, 20);
            this.dtpPurchase.TabIndex = 12;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(85, 117);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(202, 21);
            this.cmbSupplier.TabIndex = 11;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(85, 79);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(202, 21);
            this.cmbEmployee.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Remarks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Purchase Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee";
            // 
            // cmbOutlet
            // 
            this.cmbOutlet.FormattingEnabled = true;
            this.cmbOutlet.Location = new System.Drawing.Point(85, 41);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.Size = new System.Drawing.Size(202, 21);
            this.cmbOutlet.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Outlet";
            // 
            // gbShowPurchaseItem
            // 
            this.gbShowPurchaseItem.Controls.Add(this.dgvPurchaseList);
            this.gbShowPurchaseItem.Location = new System.Drawing.Point(39, 91);
            this.gbShowPurchaseItem.Name = "gbShowPurchaseItem";
            this.gbShowPurchaseItem.Size = new System.Drawing.Size(635, 364);
            this.gbShowPurchaseItem.TabIndex = 21;
            this.gbShowPurchaseItem.TabStop = false;
            this.gbShowPurchaseItem.Text = "Purchase Details";
            // 
            // gbPurchaseRecieving
            // 
            this.gbPurchaseRecieving.Controls.Add(this.label1);
            this.gbPurchaseRecieving.Controls.Add(this.btnClear);
            this.gbPurchaseRecieving.Controls.Add(this.cmbItem);
            this.gbPurchaseRecieving.Controls.Add(this.txtQty);
            this.gbPurchaseRecieving.Controls.Add(this.btnAdd);
            this.gbPurchaseRecieving.Controls.Add(this.txtCostPrice);
            this.gbPurchaseRecieving.Controls.Add(this.label3);
            this.gbPurchaseRecieving.Controls.Add(this.label2);
            this.gbPurchaseRecieving.Location = new System.Drawing.Point(30, 12);
            this.gbPurchaseRecieving.Name = "gbPurchaseRecieving";
            this.gbPurchaseRecieving.Size = new System.Drawing.Size(968, 73);
            this.gbPurchaseRecieving.TabIndex = 20;
            this.gbPurchaseRecieving.TabStop = false;
            this.gbPurchaseRecieving.Text = "Purchase Receiving";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(881, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(93, 26);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(202, 21);
            this.cmbItem.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(375, 25);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(779, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(571, 25);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(120, 20);
            this.txtCostPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseList.Location = new System.Drawing.Point(3, 16);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.Size = new System.Drawing.Size(626, 342);
            this.dgvPurchaseList.TabIndex = 0;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbShowPurchaseItem);
            this.Controls.Add(this.gbPurchaseRecieving);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbShowPurchaseItem.ResumeLayout(false);
            this.gbPurchaseRecieving.ResumeLayout(false);
            this.gbPurchaseRecieving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOutlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbShowPurchaseItem;
        private System.Windows.Forms.DataGridView dgvPurchaseList;
        private System.Windows.Forms.GroupBox gbPurchaseRecieving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
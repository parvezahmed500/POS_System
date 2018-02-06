namespace POS_System_EF.UI
{
    partial class OutletForm
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
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.btnClearSrcBox = new System.Windows.Forms.Button();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOutlet = new System.Windows.Forms.DataGridView();
            this.groupBoxAddOraganization = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOutletName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOrganizationName = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOutletCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBoxShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).BeginInit();
            this.groupBoxAddOraganization.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Controls.Add(this.btnClearSrcBox);
            this.groupBoxShow.Controls.Add(this.textBoxSrc);
            this.groupBoxShow.Controls.Add(this.label6);
            this.groupBoxShow.Controls.Add(this.dgvOutlet);
            this.groupBoxShow.Location = new System.Drawing.Point(438, 13);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Size = new System.Drawing.Size(626, 328);
            this.groupBoxShow.TabIndex = 10;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Show Group Box";
            // 
            // btnClearSrcBox
            // 
            this.btnClearSrcBox.Location = new System.Drawing.Point(542, 17);
            this.btnClearSrcBox.Name = "btnClearSrcBox";
            this.btnClearSrcBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearSrcBox.TabIndex = 29;
            this.btnClearSrcBox.Text = "Clear";
            this.btnClearSrcBox.UseVisualStyleBackColor = true;
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(238, 19);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(270, 20);
            this.textBoxSrc.TabIndex = 28;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Search Box";
            // 
            // dgvOutlet
            // 
            this.dgvOutlet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutlet.Location = new System.Drawing.Point(6, 59);
            this.dgvOutlet.Name = "dgvOutlet";
            this.dgvOutlet.Size = new System.Drawing.Size(614, 252);
            this.dgvOutlet.TabIndex = 4;
            // 
            // groupBoxAddOraganization
            // 
            this.groupBoxAddOraganization.Controls.Add(this.label7);
            this.groupBoxAddOraganization.Controls.Add(this.textBoxOutletName);
            this.groupBoxAddOraganization.Controls.Add(this.label4);
            this.groupBoxAddOraganization.Controls.Add(this.cmbOrganizationName);
            this.groupBoxAddOraganization.Controls.Add(this.buttonClear);
            this.groupBoxAddOraganization.Controls.Add(this.btnSave);
            this.groupBoxAddOraganization.Controls.Add(this.txtAddress);
            this.groupBoxAddOraganization.Controls.Add(this.txtContactNo);
            this.groupBoxAddOraganization.Controls.Add(this.txtOutletCode);
            this.groupBoxAddOraganization.Controls.Add(this.label5);
            this.groupBoxAddOraganization.Controls.Add(this.label3);
            this.groupBoxAddOraganization.Controls.Add(this.label2);
            this.groupBoxAddOraganization.Controls.Add(this.label1);
            this.groupBoxAddOraganization.Location = new System.Drawing.Point(14, 13);
            this.groupBoxAddOraganization.Name = "groupBoxAddOraganization";
            this.groupBoxAddOraganization.Size = new System.Drawing.Size(402, 328);
            this.groupBoxAddOraganization.TabIndex = 9;
            this.groupBoxAddOraganization.TabStop = false;
            this.groupBoxAddOraganization.Text = "Add Outlet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "+88 -";
            // 
            // textBoxOutletName
            // 
            this.textBoxOutletName.Location = new System.Drawing.Point(121, 59);
            this.textBoxOutletName.Name = "textBoxOutletName";
            this.textBoxOutletName.Size = new System.Drawing.Size(238, 20);
            this.textBoxOutletName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Outlet Name";
            // 
            // cmbOrganizationName
            // 
            this.cmbOrganizationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizationName.FormattingEnabled = true;
            this.cmbOrganizationName.Location = new System.Drawing.Point(121, 24);
            this.cmbOrganizationName.Name = "cmbOrganizationName";
            this.cmbOrganizationName.Size = new System.Drawing.Size(238, 21);
            this.cmbOrganizationName.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(203, 284);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 179);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 83);
            this.txtAddress.TabIndex = 1;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(155, 135);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(204, 20);
            this.txtContactNo.TabIndex = 1;
            // 
            // txtOutletCode
            // 
            this.txtOutletCode.Location = new System.Drawing.Point(121, 94);
            this.txtOutletCode.Name = "txtOutletCode";
            this.txtOutletCode.ReadOnly = true;
            this.txtOutletCode.Size = new System.Drawing.Size(238, 20);
            this.txtOutletCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organization Name";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(899, 392);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(980, 392);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // OutletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.groupBoxAddOraganization);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonPrint);
            this.Name = "OutletForm";
            this.Text = "Outlet Form";
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).EndInit();
            this.groupBoxAddOraganization.ResumeLayout(false);
            this.groupBoxAddOraganization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.DataGridView dgvOutlet;
        private System.Windows.Forms.GroupBox groupBoxAddOraganization;
        private System.Windows.Forms.ComboBox cmbOrganizationName;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtOutletCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearSrcBox;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOutletName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonClear;
    }
}
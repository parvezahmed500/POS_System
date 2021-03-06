﻿namespace POS_System_EF.UI
{
    partial class ItemCategoryForm
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSrcClear = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbRootCategory = new System.Windows.Forms.ComboBox();
            this.rbSubCategory = new System.Windows.Forms.RadioButton();
            this.rbRootCategory = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(847, 402);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 40;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonSrcClear
            // 
            this.buttonSrcClear.Location = new System.Drawing.Point(947, 31);
            this.buttonSrcClear.Name = "buttonSrcClear";
            this.buttonSrcClear.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcClear.TabIndex = 38;
            this.buttonSrcClear.Text = "Clear";
            this.buttonSrcClear.UseVisualStyleBackColor = true;
            this.buttonSrcClear.Click += new System.EventHandler(this.buttonSrcClear_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(947, 402);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 36;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click_1);
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Location = new System.Drawing.Point(399, 73);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.RowHeadersVisible = false;
            this.dgvCategoryList.Size = new System.Drawing.Size(623, 292);
            this.dgvCategoryList.TabIndex = 37;
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(729, 34);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(193, 20);
            this.textBoxSrc.TabIndex = 31;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveCategory);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbRootCategory);
            this.groupBox1.Controls.Add(this.rbSubCategory);
            this.groupBox1.Controls.Add(this.rbRootCategory);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 377);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Category Setup";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(235, 300);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCategory.TabIndex = 51;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbRootCategory
            // 
            this.cmbRootCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRootCategory.FormattingEnabled = true;
            this.cmbRootCategory.Location = new System.Drawing.Point(117, 91);
            this.cmbRootCategory.Name = "cmbRootCategory";
            this.cmbRootCategory.Size = new System.Drawing.Size(193, 21);
            this.cmbRootCategory.TabIndex = 49;
            // 
            // rbSubCategory
            // 
            this.rbSubCategory.AutoSize = true;
            this.rbSubCategory.Location = new System.Drawing.Point(221, 52);
            this.rbSubCategory.Name = "rbSubCategory";
            this.rbSubCategory.Size = new System.Drawing.Size(89, 17);
            this.rbSubCategory.TabIndex = 48;
            this.rbSubCategory.TabStop = true;
            this.rbSubCategory.Text = "Sub Category";
            this.rbSubCategory.UseVisualStyleBackColor = true;
            // 
            // rbRootCategory
            // 
            this.rbRootCategory.AutoSize = true;
            this.rbRootCategory.Location = new System.Drawing.Point(117, 52);
            this.rbRootCategory.Name = "rbRootCategory";
            this.rbRootCategory.Size = new System.Drawing.Size(93, 17);
            this.rbRootCategory.TabIndex = 47;
            this.rbRootCategory.TabStop = true;
            this.rbRootCategory.Text = "Root Category";
            this.rbRootCategory.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 212);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(193, 65);
            this.txtDescription.TabIndex = 44;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(117, 172);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(193, 20);
            this.txtCode.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Root Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Search Box";
            // 
            // ItemCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSrcClear);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.dgvCategoryList);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.label5);
            this.Name = "ItemCategoryForm";
            this.Text = "Item Category Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSrcClear;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbRootCategory;
        private System.Windows.Forms.RadioButton rbSubCategory;
        private System.Windows.Forms.RadioButton rbRootCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
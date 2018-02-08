namespace POS_System_EF.UI
{
    partial class OrganizationForm
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
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOrgnizationCode = new System.Windows.Forms.TextBox();
            this.txtOranizationName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearSrcBox = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.pictureBoxOrg = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSelectUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganization
            // 
            this.dgvOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganization.Location = new System.Drawing.Point(404, 70);
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.RowHeadersVisible = false;
            this.dgvOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganization.Size = new System.Drawing.Size(608, 283);
            this.dgvOrganization.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 279);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 73);
            this.txtAddress.TabIndex = 21;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(146, 98);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(209, 20);
            this.txtContactNo.TabIndex = 23;
            // 
            // txtOrgnizationCode
            // 
            this.txtOrgnizationCode.Location = new System.Drawing.Point(85, 63);
            this.txtOrgnizationCode.Name = "txtOrgnizationCode";
            this.txtOrgnizationCode.ReadOnly = true;
            this.txtOrgnizationCode.Size = new System.Drawing.Size(270, 20);
            this.txtOrgnizationCode.TabIndex = 24;
            // 
            // txtOranizationName
            // 
            this.txtOranizationName.Location = new System.Drawing.Point(85, 27);
            this.txtOranizationName.Name = "txtOranizationName";
            this.txtOranizationName.Size = new System.Drawing.Size(270, 20);
            this.txtOranizationName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Logo/Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // btnClearSrcBox
            // 
            this.btnClearSrcBox.Location = new System.Drawing.Point(937, 25);
            this.btnClearSrcBox.Name = "btnClearSrcBox";
            this.btnClearSrcBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearSrcBox.TabIndex = 26;
            this.btnClearSrcBox.Text = "Clear";
            this.btnClearSrcBox.UseVisualStyleBackColor = true;
            this.btnClearSrcBox.Click += new System.EventHandler(this.btnClearSrcBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search Box";
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(624, 27);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(270, 20);
            this.textBoxSrc.TabIndex = 25;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(278, 238);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 30;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // pictureBoxOrg
            // 
            this.pictureBoxOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOrg.Location = new System.Drawing.Point(83, 140);
            this.pictureBoxOrg.Name = "pictureBoxOrg";
            this.pictureBoxOrg.Size = new System.Drawing.Size(108, 121);
            this.pictureBoxOrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrg.TabIndex = 29;
            this.pictureBoxOrg.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(937, 391);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 27;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(837, 391);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 27;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(197, 238);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(75, 23);
            this.btnClearImage.TabIndex = 125;
            this.btnClearImage.Text = "Clear";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(197, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 92);
            this.textBox1.TabIndex = 124;
            this.textBox1.Text = "\r\nImage size must  300 X 300 PX and image format JPEG/JPG.Image size MAX 100KB.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "+88 -";
            // 
            // buttonSelectUpdate
            // 
            this.buttonSelectUpdate.Location = new System.Drawing.Point(717, 391);
            this.buttonSelectUpdate.Name = "buttonSelectUpdate";
            this.buttonSelectUpdate.Size = new System.Drawing.Size(89, 23);
            this.buttonSelectUpdate.TabIndex = 126;
            this.buttonSelectUpdate.Text = "Select Update";
            this.buttonSelectUpdate.UseVisualStyleBackColor = true;
            this.buttonSelectUpdate.Click += new System.EventHandler(this.buttonSelectUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(624, 391);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 126;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(87, 358);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 126;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelectUpdate);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBoxOrg);
            this.Controls.Add(this.dgvOrganization);
            this.Controls.Add(this.btnClearSrcBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtOrgnizationCode);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.txtOranizationName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrganizationForm";
            this.Text = "Organization Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtOrgnizationCode;
        private System.Windows.Forms.TextBox txtOranizationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearSrcBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.PictureBox pictureBoxOrg;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSelectUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
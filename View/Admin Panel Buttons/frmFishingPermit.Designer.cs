namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmFishingPermit
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.lblPermitNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPermit = new System.Windows.Forms.DataGridView();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.cmbVessels = new System.Windows.Forms.ComboBox();
            this.pnlUsernametxt = new System.Windows.Forms.Panel();
            this.txtPermitNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.Aqua;
            this.btnEdit.Location = new System.Drawing.Point(167, 312);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIssueDate.ForeColor = System.Drawing.Color.Aqua;
            this.lbIssueDate.Location = new System.Drawing.Point(102, 92);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(88, 21);
            this.lbIssueDate.TabIndex = 36;
            this.lbIssueDate.Text = "Issue Date";
            // 
            // lblPermitNumber
            // 
            this.lblPermitNumber.AutoSize = true;
            this.lblPermitNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPermitNumber.ForeColor = System.Drawing.Color.Aqua;
            this.lblPermitNumber.Location = new System.Drawing.Point(73, 47);
            this.lblPermitNumber.Name = "lblPermitNumber";
            this.lblPermitNumber.Size = new System.Drawing.Size(128, 21);
            this.lblPermitNumber.TabIndex = 35;
            this.lblPermitNumber.Text = "Permit Number";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Aqua;
            this.btnDelete.Location = new System.Drawing.Point(117, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.Aqua;
            this.btnCreate.Location = new System.Drawing.Point(218, 276);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 30);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // dgvPermit
            // 
            this.dgvPermit.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvPermit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermit.Location = new System.Drawing.Point(436, 80);
            this.dgvPermit.Name = "dgvPermit";
            this.dgvPermit.RowHeadersWidth = 51;
            this.dgvPermit.RowTemplate.Height = 25;
            this.dgvPermit.Size = new System.Drawing.Size(322, 150);
            this.dgvPermit.TabIndex = 38;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Aqua;
            this.lblExpirationDate.Location = new System.Drawing.Point(73, 146);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(129, 21);
            this.lblExpirationDate.TabIndex = 39;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEquipment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquipment.ForeColor = System.Drawing.Color.Aqua;
            this.lblEquipment.Location = new System.Drawing.Point(98, 198);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(94, 21);
            this.lblEquipment.TabIndex = 41;
            this.lblEquipment.Text = "Equipment";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CalendarForeColor = System.Drawing.Color.Aqua;
            this.dtpIssueDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpIssueDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpIssueDate.CalendarTitleForeColor = System.Drawing.Color.Aqua;
            this.dtpIssueDate.CalendarTrailingForeColor = System.Drawing.Color.Aqua;
            this.dtpIssueDate.Location = new System.Drawing.Point(218, 93);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(134, 23);
            this.dtpIssueDate.TabIndex = 43;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.CalendarForeColor = System.Drawing.Color.Aqua;
            this.dtpExpirationDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpExpirationDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpExpirationDate.CalendarTitleForeColor = System.Drawing.Color.Aqua;
            this.dtpExpirationDate.CalendarTrailingForeColor = System.Drawing.Color.Aqua;
            this.dtpExpirationDate.Location = new System.Drawing.Point(218, 148);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(134, 23);
            this.dtpExpirationDate.TabIndex = 44;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // cmbVessels
            // 
            this.cmbVessels.BackColor = System.Drawing.Color.Gray;
            this.cmbVessels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVessels.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbVessels.ForeColor = System.Drawing.Color.Aqua;
            this.cmbVessels.FormattingEnabled = true;
            this.cmbVessels.Location = new System.Drawing.Point(167, 232);
            this.cmbVessels.Name = "cmbVessels";
            this.cmbVessels.Size = new System.Drawing.Size(121, 23);
            this.cmbVessels.TabIndex = 77;
            this.cmbVessels.Text = "Vessels";
            // 
            // pnlUsernametxt
            // 
            this.pnlUsernametxt.BackColor = System.Drawing.Color.Aqua;
            this.pnlUsernametxt.Location = new System.Drawing.Point(218, 67);
            this.pnlUsernametxt.Name = "pnlUsernametxt";
            this.pnlUsernametxt.Size = new System.Drawing.Size(134, 1);
            this.pnlUsernametxt.TabIndex = 79;
            // 
            // txtPermitNumber
            // 
            this.txtPermitNumber.BackColor = System.Drawing.Color.Black;
            this.txtPermitNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPermitNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPermitNumber.ForeColor = System.Drawing.Color.White;
            this.txtPermitNumber.Location = new System.Drawing.Point(218, 46);
            this.txtPermitNumber.Name = "txtPermitNumber";
            this.txtPermitNumber.Size = new System.Drawing.Size(134, 22);
            this.txtPermitNumber.TabIndex = 78;
            this.txtPermitNumber.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(218, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 1);
            this.panel1.TabIndex = 81;
            // 
            // txtEquipment
            // 
            this.txtEquipment.BackColor = System.Drawing.Color.Black;
            this.txtEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEquipment.ForeColor = System.Drawing.Color.White;
            this.txtEquipment.Location = new System.Drawing.Point(218, 197);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(134, 22);
            this.txtEquipment.TabIndex = 80;
            // 
            // frmFishingPermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.pnlUsernametxt);
            this.Controls.Add(this.txtPermitNumber);
            this.Controls.Add(this.cmbVessels);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.dgvPermit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIssueDate);
            this.Controls.Add(this.lblPermitNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmFishingPermit";
            this.Text = "frmFishingPermit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lbIssueDate;
        private Label lblPermitNumber;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvPermit;
        private Label lblExpirationDate;
        private Label lblEquipment;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpExpirationDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbVessels;
        private Panel pnlUsernametxt;
        private TextBox txtPermitNumber;
        private Panel panel1;
        private TextBox txtEquipment;
    }
}
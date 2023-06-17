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
            btnEdit = new Button();
            lbIssueDate = new Label();
            lblPermitNumber = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvPermit = new DataGridView();
            lblExpirationDate = new Label();
            lblEquipment = new Label();
            dtpIssueDate = new DateTimePicker();
            dtpExpirationDate = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbVessels = new ComboBox();
            pnlUsernametxt = new Panel();
            txtPermitNumber = new TextBox();
            panel1 = new Panel();
            txtEquipment = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPermit).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(158, 296);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.Enter += btnEdit_Enter;
            btnEdit.Leave += btnEdit_Leave;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // lbIssueDate
            // 
            lbIssueDate.AutoSize = true;
            lbIssueDate.FlatStyle = FlatStyle.System;
            lbIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIssueDate.ForeColor = Color.Aqua;
            lbIssueDate.Location = new Point(93, 76);
            lbIssueDate.Name = "lbIssueDate";
            lbIssueDate.Size = new Size(88, 21);
            lbIssueDate.TabIndex = 36;
            lbIssueDate.Text = "Issue Date";
            // 
            // lblPermitNumber
            // 
            lblPermitNumber.AutoSize = true;
            lblPermitNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermitNumber.ForeColor = Color.Aqua;
            lblPermitNumber.Location = new Point(64, 31);
            lblPermitNumber.Name = "lblPermitNumber";
            lblPermitNumber.Size = new Size(128, 21);
            lblPermitNumber.TabIndex = 35;
            lblPermitNumber.Text = "Permit Number";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(108, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.Enter += btnDelete_Enter;
            btnDelete.Leave += btnDelete_Leave;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Aqua;
            btnCreate.Location = new Point(209, 260);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.Enter += btnCreate_Enter;
            btnCreate.Leave += btnCreate_Leave;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            btnCreate.MouseLeave += btnCreate_MouseLeave;
            // 
            // dgvPermit
            // 
            dgvPermit.BackgroundColor = Color.Aqua;
            dgvPermit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermit.Location = new Point(428, 80);
            dgvPermit.Name = "dgvPermit";
            dgvPermit.RowHeadersWidth = 51;
            dgvPermit.RowTemplate.Height = 25;
            dgvPermit.Size = new Size(356, 159);
            dgvPermit.TabIndex = 8;
            dgvPermit.CellClick += dgvPermit_CellClick;
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpirationDate.ForeColor = Color.Aqua;
            lblExpirationDate.Location = new Point(64, 130);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(129, 21);
            lblExpirationDate.TabIndex = 39;
            lblExpirationDate.Text = "Expiration Date";
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.FlatStyle = FlatStyle.System;
            lblEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipment.ForeColor = Color.Aqua;
            lblEquipment.Location = new Point(89, 182);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(94, 21);
            lblEquipment.TabIndex = 41;
            lblEquipment.Text = "Equipment";
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.CalendarForeColor = Color.Aqua;
            dtpIssueDate.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpIssueDate.CalendarTitleBackColor = Color.FromArgb(64, 64, 64);
            dtpIssueDate.CalendarTitleForeColor = Color.Aqua;
            dtpIssueDate.CalendarTrailingForeColor = Color.Aqua;
            dtpIssueDate.Cursor = Cursors.Hand;
            dtpIssueDate.Location = new Point(209, 77);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(134, 23);
            dtpIssueDate.TabIndex = 1;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.CalendarForeColor = Color.Aqua;
            dtpExpirationDate.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpExpirationDate.CalendarTitleBackColor = Color.FromArgb(64, 64, 64);
            dtpExpirationDate.CalendarTitleForeColor = Color.Aqua;
            dtpExpirationDate.CalendarTrailingForeColor = Color.Aqua;
            dtpExpirationDate.Cursor = Cursors.Hand;
            dtpExpirationDate.Location = new Point(209, 132);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(134, 23);
            dtpExpirationDate.TabIndex = 2;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // cmbVessels
            // 
            cmbVessels.BackColor = Color.Gray;
            cmbVessels.Cursor = Cursors.Hand;
            cmbVessels.FlatStyle = FlatStyle.Popup;
            cmbVessels.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbVessels.ForeColor = Color.Aqua;
            cmbVessels.FormattingEnabled = true;
            cmbVessels.Location = new Point(148, 216);
            cmbVessels.Name = "cmbVessels";
            cmbVessels.Size = new Size(121, 23);
            cmbVessels.TabIndex = 4;
            cmbVessels.Text = "Vessels";
            cmbVessels.DropDown += cmbVessels_DropDown;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(209, 51);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(134, 1);
            pnlUsernametxt.TabIndex = 79;
            // 
            // txtPermitNumber
            // 
            txtPermitNumber.BackColor = Color.Black;
            txtPermitNumber.BorderStyle = BorderStyle.None;
            txtPermitNumber.Cursor = Cursors.IBeam;
            txtPermitNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPermitNumber.ForeColor = Color.White;
            txtPermitNumber.Location = new Point(209, 30);
            txtPermitNumber.Name = "txtPermitNumber";
            txtPermitNumber.Size = new Size(134, 22);
            txtPermitNumber.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(209, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 1);
            panel1.TabIndex = 81;
            // 
            // txtEquipment
            // 
            txtEquipment.BackColor = Color.Black;
            txtEquipment.BorderStyle = BorderStyle.None;
            txtEquipment.Cursor = Cursors.IBeam;
            txtEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEquipment.ForeColor = Color.White;
            txtEquipment.Location = new Point(209, 181);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.Size = new Size(134, 22);
            txtEquipment.TabIndex = 3;
            // 
            // frmFishingPermit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(849, 356);
            Controls.Add(panel1);
            Controls.Add(txtEquipment);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtPermitNumber);
            Controls.Add(cmbVessels);
            Controls.Add(dtpExpirationDate);
            Controls.Add(dtpIssueDate);
            Controls.Add(lblEquipment);
            Controls.Add(lblExpirationDate);
            Controls.Add(dgvPermit);
            Controls.Add(btnEdit);
            Controls.Add(lbIssueDate);
            Controls.Add(lblPermitNumber);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmFishingPermit";
            Opacity = 0.93D;
            Text = "Fishing Permits";
            ((System.ComponentModel.ISupportInitialize)dgvPermit).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
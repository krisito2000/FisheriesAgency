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
            txtPermitNumber = new TextBox();
            btnDelete = new Button();
            btncreate = new Button();
            dgvFishingPermit = new DataGridView();
            lblExpirationDate = new Label();
            lblEquipment = new Label();
            txtEquipment = new TextBox();
            dtpIssueDate = new DateTimePicker();
            dtpExpirationDate = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvFishingPermit).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(167, 297);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbIssueDate
            // 
            lbIssueDate.AutoSize = true;
            lbIssueDate.FlatStyle = FlatStyle.System;
            lbIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIssueDate.Location = new Point(98, 94);
            lbIssueDate.Name = "lbIssueDate";
            lbIssueDate.Size = new Size(84, 21);
            lbIssueDate.TabIndex = 36;
            lbIssueDate.Text = "IssueDate";
            // 
            // lblPermitNumber
            // 
            lblPermitNumber.AutoSize = true;
            lblPermitNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermitNumber.Location = new Point(82, 48);
            lblPermitNumber.Name = "lblPermitNumber";
            lblPermitNumber.Size = new Size(124, 21);
            lblPermitNumber.TabIndex = 35;
            lblPermitNumber.Text = "PermitNumber";
            // 
            // txtPermitNumber
            // 
            txtPermitNumber.Location = new Point(222, 48);
            txtPermitNumber.Name = "txtPermitNumber";
            txtPermitNumber.Size = new Size(130, 23);
            txtPermitNumber.TabIndex = 33;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(117, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(218, 261);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(95, 30);
            btncreate.TabIndex = 31;
            btncreate.Text = "Create ";
            btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvFishingPermit
            // 
            dgvFishingPermit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFishingPermit.Location = new Point(436, 80);
            dgvFishingPermit.Name = "dgvFishingPermit";
            dgvFishingPermit.RowTemplate.Height = 25;
            dgvFishingPermit.Size = new Size(322, 150);
            dgvFishingPermit.TabIndex = 38;
            dgvFishingPermit.CellClick += dgvFishingPermit_CellClick;
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpirationDate.Location = new Point(81, 148);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(125, 21);
            lblExpirationDate.TabIndex = 39;
            lblExpirationDate.Text = "ExpirationDate";
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.FlatStyle = FlatStyle.System;
            lblEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipment.Location = new Point(98, 198);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(94, 21);
            lblEquipment.TabIndex = 41;
            lblEquipment.Text = "Equipment";
            // 
            // txtEquipment
            // 
            txtEquipment.Location = new Point(218, 196);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.Size = new Size(134, 23);
            txtEquipment.TabIndex = 42;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(218, 93);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(134, 23);
            dtpIssueDate.TabIndex = 43;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Location = new Point(218, 148);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(134, 23);
            dtpExpirationDate.TabIndex = 44;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // frmFishingPermit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 354);
            Controls.Add(dtpExpirationDate);
            Controls.Add(dtpIssueDate);
            Controls.Add(txtEquipment);
            Controls.Add(lblEquipment);
            Controls.Add(lblExpirationDate);
            Controls.Add(dgvFishingPermit);
            Controls.Add(btnEdit);
            Controls.Add(lbIssueDate);
            Controls.Add(lblPermitNumber);
            Controls.Add(txtPermitNumber);
            Controls.Add(btnDelete);
            Controls.Add(btncreate);
            Name = "frmFishingPermit";
            Text = "frmFishingPermit";
            ((System.ComponentModel.ISupportInitialize)dgvFishingPermit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lbIssueDate;
        private Label lblPermitNumber;
        private TextBox txtPermitNumber;
        private Button btnDelete;
        private Button btncreate;
        private DataGridView dgvFishingPermit;
        private Label lblExpirationDate;
        private Label lblEquipment;
        private TextBox txtEquipment;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpExpirationDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
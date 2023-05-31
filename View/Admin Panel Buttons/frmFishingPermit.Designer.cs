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
            btnCreate = new Button();
            dgvPermit = new DataGridView();
            lblExpirationDate = new Label();
            lblEquipment = new Label();
            txtEquipment = new TextBox();
            dtpIssueDate = new DateTimePicker();
            dtpExpirationDate = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cbVessels = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPermit).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(167, 312);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbIssueDate
            // 
            lbIssueDate.AutoSize = true;
            lbIssueDate.FlatStyle = FlatStyle.System;
            lbIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIssueDate.Location = new Point(102, 92);
            lbIssueDate.Name = "lbIssueDate";
            lbIssueDate.Size = new Size(88, 21);
            lbIssueDate.TabIndex = 36;
            lbIssueDate.Text = "Issue Date";
            // 
            // lblPermitNumber
            // 
            lblPermitNumber.AutoSize = true;
            lblPermitNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermitNumber.Location = new Point(73, 47);
            lblPermitNumber.Name = "lblPermitNumber";
            lblPermitNumber.Size = new Size(128, 21);
            lblPermitNumber.TabIndex = 35;
            lblPermitNumber.Text = "Permit Number";
            // 
            // txtPermitNumber
            // 
            txtPermitNumber.Location = new Point(218, 48);
            txtPermitNumber.Name = "txtPermitNumber";
            txtPermitNumber.Size = new Size(134, 23);
            txtPermitNumber.TabIndex = 33;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(117, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(218, 276);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 31;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvPermit
            // 
            dgvPermit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermit.Location = new Point(436, 80);
            dgvPermit.Name = "dgvPermit";
            dgvPermit.RowHeadersWidth = 51;
            dgvPermit.RowTemplate.Height = 25;
            dgvPermit.Size = new Size(322, 150);
            dgvPermit.TabIndex = 38;
            dgvPermit.CellClick += dgvPermit_CellClick;
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpirationDate.Location = new Point(73, 146);
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
            // cbVessels
            // 
            cbVessels.FormattingEnabled = true;
            cbVessels.Location = new Point(167, 232);
            cbVessels.Name = "cbVessels";
            cbVessels.Size = new Size(121, 23);
            cbVessels.TabIndex = 77;
            cbVessels.Text = "Vessels";
            cbVessels.SelectedIndexChanged += cbVessels_SelectedIndexChanged;
            // 
            // frmFishingPermit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 356);
            Controls.Add(cbVessels);
            Controls.Add(dtpExpirationDate);
            Controls.Add(dtpIssueDate);
            Controls.Add(txtEquipment);
            Controls.Add(lblEquipment);
            Controls.Add(lblExpirationDate);
            Controls.Add(dgvPermit);
            Controls.Add(btnEdit);
            Controls.Add(lbIssueDate);
            Controls.Add(lblPermitNumber);
            Controls.Add(txtPermitNumber);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmFishingPermit";
            Text = "frmFishingPermit";
            ((System.ComponentModel.ISupportInitialize)dgvPermit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lbIssueDate;
        private Label lblPermitNumber;
        private TextBox txtPermitNumber;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvPermit;
        private Label lblExpirationDate;
        private Label lblEquipment;
        private TextBox txtEquipment;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpExpirationDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cbVessels;
    }
}
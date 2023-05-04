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
            this.txtPermitNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.dgvFishingPermit = new System.Windows.Forms.DataGridView();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingPermit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(191, 396);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIssueDate.Location = new System.Drawing.Point(116, 123);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(110, 28);
            this.lbIssueDate.TabIndex = 36;
            this.lbIssueDate.Text = "Issue Date";
            // 
            // lblPermitNumber
            // 
            this.lblPermitNumber.AutoSize = true;
            this.lblPermitNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPermitNumber.Location = new System.Drawing.Point(83, 63);
            this.lblPermitNumber.Name = "lblPermitNumber";
            this.lblPermitNumber.Size = new System.Drawing.Size(157, 28);
            this.lblPermitNumber.TabIndex = 35;
            this.lblPermitNumber.Text = "Permit Number";
            // 
            // txtPermitNumber
            // 
            this.txtPermitNumber.Location = new System.Drawing.Point(254, 64);
            this.txtPermitNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPermitNumber.Name = "txtPermitNumber";
            this.txtPermitNumber.Size = new System.Drawing.Size(148, 27);
            this.txtPermitNumber.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 348);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(249, 348);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(109, 40);
            this.btncreate.TabIndex = 31;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvFishingPermit
            // 
            this.dgvFishingPermit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishingPermit.Location = new System.Drawing.Point(498, 107);
            this.dgvFishingPermit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFishingPermit.Name = "dgvFishingPermit";
            this.dgvFishingPermit.RowHeadersWidth = 51;
            this.dgvFishingPermit.RowTemplate.Height = 25;
            this.dgvFishingPermit.Size = new System.Drawing.Size(368, 200);
            this.dgvFishingPermit.TabIndex = 38;
            this.dgvFishingPermit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFishingPermit_CellClick);
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpirationDate.Location = new System.Drawing.Point(83, 195);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(160, 28);
            this.lblExpirationDate.TabIndex = 39;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEquipment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquipment.Location = new System.Drawing.Point(112, 264);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(114, 28);
            this.lblEquipment.TabIndex = 41;
            this.lblEquipment.Text = "Equipment";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(249, 261);
            this.txtEquipment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(153, 27);
            this.txtEquipment.TabIndex = 42;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(249, 124);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(153, 27);
            this.dtpIssueDate.TabIndex = 43;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Location = new System.Drawing.Point(249, 197);
            this.dtpExpirationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(153, 27);
            this.dtpExpirationDate.TabIndex = 44;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // frmFishingPermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 472);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.dgvFishingPermit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIssueDate);
            this.Controls.Add(this.lblPermitNumber);
            this.Controls.Add(this.txtPermitNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFishingPermit";
            this.Text = "frmFishingPermit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingPermit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
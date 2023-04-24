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
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.txtPermitNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.dgvFishingPermit = new System.Windows.Forms.DataGridView();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingPermit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(84, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIssueDate.Location = new System.Drawing.Point(87, 95);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(84, 21);
            this.lbIssueDate.TabIndex = 36;
            this.lbIssueDate.Text = "IssueDate";
            // 
            // lblPermitNumber
            // 
            this.lblPermitNumber.AutoSize = true;
            this.lblPermitNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPermitNumber.Location = new System.Drawing.Point(82, 48);
            this.lblPermitNumber.Name = "lblPermitNumber";
            this.lblPermitNumber.Size = new System.Drawing.Size(124, 21);
            this.lblPermitNumber.TabIndex = 35;
            this.lblPermitNumber.Text = "PermitNumber";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(175, 93);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(106, 23);
            this.txtIssueDate.TabIndex = 34;
            // 
            // txtPermitNumber
            // 
            this.txtPermitNumber.Location = new System.Drawing.Point(222, 48);
            this.txtPermitNumber.Name = "txtPermitNumber";
            this.txtPermitNumber.Size = new System.Drawing.Size(106, 23);
            this.txtPermitNumber.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(87, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(188, 290);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(95, 30);
            this.btncreate.TabIndex = 31;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvFishingPermit
            // 
            this.dgvFishingPermit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishingPermit.Location = new System.Drawing.Point(482, 290);
            this.dgvFishingPermit.Name = "dgvFishingPermit";
            this.dgvFishingPermit.RowTemplate.Height = 25;
            this.dgvFishingPermit.Size = new System.Drawing.Size(255, 123);
            this.dgvFishingPermit.TabIndex = 38;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpirationDate.Location = new System.Drawing.Point(87, 148);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(125, 21);
            this.lblExpirationDate.TabIndex = 39;
            this.lblExpirationDate.Text = "ExpirationDate";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(218, 150);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(106, 23);
            this.txtExpirationDate.TabIndex = 40;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEquipment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquipment.Location = new System.Drawing.Point(87, 198);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(94, 21);
            this.lblEquipment.TabIndex = 41;
            this.lblEquipment.Text = "Equipment";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(187, 200);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(106, 23);
            this.txtEquipment.TabIndex = 42;
            // 
            // frmFishingPermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.dgvFishingPermit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIssueDate);
            this.Controls.Add(this.lblPermitNumber);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.txtPermitNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Name = "frmFishingPermit";
            this.Text = "frmFishingPermit";
            this.Load += new System.EventHandler(this.frmFishingPermit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingPermit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lbIssueDate;
        private Label lblPermitNumber;
        private TextBox txtIssueDate;
        private TextBox txtPermitNumber;
        private Button btnDelete;
        private Button btncreate;
        private DataGridView dgvFishingPermit;
        private Label lblExpirationDate;
        private TextBox txtExpirationDate;
        private Label lblEquipment;
        private TextBox txtEquipment;
    }
}
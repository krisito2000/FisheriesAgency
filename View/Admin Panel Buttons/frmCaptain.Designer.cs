namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmCaptain
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
            lblAddress = new Label();
            lblName = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvCaptain = new DataGridView();
            pnlUsernametxt = new Panel();
            txtName = new TextBox();
            panel1 = new Panel();
            txtAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCaptain).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(123, 182);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.ActiveCaptionText;
            lblAddress.FlatStyle = FlatStyle.System;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.Aqua;
            lblAddress.Location = new Point(80, 100);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 29;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaptionText;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Aqua;
            lblName.Location = new Point(75, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 21);
            lblName.TabIndex = 28;
            lblName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(74, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Aqua;
            btnCreate.Location = new Point(178, 146);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvCaptain
            // 
            dgvCaptain.BackgroundColor = Color.Aqua;
            dgvCaptain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaptain.Location = new Point(380, 51);
            dgvCaptain.Name = "dgvCaptain";
            dgvCaptain.RowHeadersWidth = 51;
            dgvCaptain.RowTemplate.Height = 25;
            dgvCaptain.Size = new Size(283, 150);
            dgvCaptain.TabIndex = 33;
            dgvCaptain.CellClick += dgvCaptain_CellClick;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(168, 74);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(106, 1);
            pnlUsernametxt.TabIndex = 81;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Black;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(168, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 22);
            txtName.TabIndex = 80;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(167, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 1);
            panel1.TabIndex = 83;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Black;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(167, 100);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(106, 22);
            txtAddress.TabIndex = 82;
            // 
            // frmCaptain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(719, 247);
            Controls.Add(panel1);
            Controls.Add(txtAddress);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtName);
            Controls.Add(dgvCaptain);
            Controls.Add(btnEdit);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmCaptain";
            Text = "Captains";
            ((System.ComponentModel.ISupportInitialize)dgvCaptain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private Label lblAddress;
        private Label lblName;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvCaptain;
        private Panel pnlUsernametxt;
        private TextBox txtName;
        private Panel panel1;
        private TextBox txtAddress;
    }
}
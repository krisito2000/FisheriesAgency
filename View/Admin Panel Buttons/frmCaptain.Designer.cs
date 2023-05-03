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
            txtAddress = new TextBox();
            txtName = new TextBox();
            btnDelete = new Button();
            btncreate = new Button();
            dgvCaptain = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCaptain).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(123, 182);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.FlatStyle = FlatStyle.System;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(80, 100);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 29;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(75, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 21);
            lblName.TabIndex = 28;
            lblName.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(168, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(106, 23);
            txtAddress.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 23);
            txtName.TabIndex = 26;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(74, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(178, 146);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(95, 30);
            btncreate.TabIndex = 24;
            btncreate.Text = "Create ";
            btncreate.UseVisualStyleBackColor = true;
            // 
            // dgvCaptain
            // 
            dgvCaptain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaptain.Location = new Point(380, 51);
            dgvCaptain.Name = "dgvCaptain";
            dgvCaptain.RowTemplate.Height = 25;
            dgvCaptain.Size = new Size(283, 150);
            dgvCaptain.TabIndex = 33;
            dgvCaptain.CellClick += dgvCaptain_CellClick;
            // 
            // frmCaptain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 247);
            Controls.Add(dgvCaptain);
            Controls.Add(btnEdit);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btncreate);
            Name = "frmCaptain";
            Text = "frmCaptain";
            ((System.ComponentModel.ISupportInitialize)dgvCaptain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private Label lblAddress;
        private Label lblName;
        private TextBox txtAddress;
        private TextBox txtName;
        private Button btnDelete;
        private Button btncreate;
        private DataGridView dgvCaptain;
    }
}
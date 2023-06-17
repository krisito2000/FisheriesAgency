namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmOwner
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
            lbIAddress = new Label();
            lblName = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvOwner = new DataGridView();
            pnlUsernametxt = new Panel();
            txtName = new TextBox();
            panel1 = new Panel();
            txtAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOwner).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(114, 172);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbIAddress
            // 
            lbIAddress.AutoSize = true;
            lbIAddress.BackColor = SystemColors.ActiveCaptionText;
            lbIAddress.FlatStyle = FlatStyle.System;
            lbIAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIAddress.ForeColor = Color.Aqua;
            lbIAddress.Location = new Point(61, 88);
            lbIAddress.Name = "lbIAddress";
            lbIAddress.Size = new Size(70, 21);
            lbIAddress.TabIndex = 64;
            lbIAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaptionText;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Aqua;
            lblName.Location = new Point(61, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 21);
            lblName.TabIndex = 63;
            lblName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(64, 138);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DimGray;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Aqua;
            btnCreate.Location = new Point(164, 138);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 28);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvOwner
            // 
            dgvOwner.BackgroundColor = Color.Aqua;
            dgvOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwner.Location = new Point(345, 46);
            dgvOwner.Name = "dgvOwner";
            dgvOwner.RowHeadersWidth = 51;
            dgvOwner.RowTemplate.Height = 25;
            dgvOwner.Size = new Size(279, 150);
            dgvOwner.TabIndex = 5;
            dgvOwner.CellClick += dgvOwner_CellClick;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(154, 64);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(105, 1);
            pnlUsernametxt.TabIndex = 94;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Black;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(154, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(105, 22);
            txtName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(154, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 1);
            panel1.TabIndex = 96;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Black;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(154, 88);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(105, 22);
            txtAddress.TabIndex = 1;
            // 
            // frmOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(662, 242);
            Controls.Add(panel1);
            Controls.Add(txtAddress);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtName);
            Controls.Add(dgvOwner);
            Controls.Add(btnEdit);
            Controls.Add(lbIAddress);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmOwner";
            Opacity = 0.93D;
            Text = "Owners";
            ((System.ComponentModel.ISupportInitialize)dgvOwner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lbIAddress;
        private Label lblName;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvOwner;
        private Panel pnlUsernametxt;
        private TextBox txtName;
        private Panel panel1;
        private TextBox txtAddress;
    }
}
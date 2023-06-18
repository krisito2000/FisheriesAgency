namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmMember
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
            dgvMember = new DataGridView();
            pnlUsernametxt = new Panel();
            txtName = new TextBox();
            panel1 = new Panel();
            txtAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(114, 168);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.Enter += btnEdit_Enter;
            btnEdit.Leave += btnEdit_Leave;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // lbIAddress
            // 
            lbIAddress.AutoSize = true;
            lbIAddress.BackColor = SystemColors.ActiveCaptionText;
            lbIAddress.FlatStyle = FlatStyle.System;
            lbIAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIAddress.ForeColor = Color.Aqua;
            lbIAddress.Location = new Point(66, 81);
            lbIAddress.Name = "lbIAddress";
            lbIAddress.Size = new Size(70, 21);
            lbIAddress.TabIndex = 57;
            lbIAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaptionText;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Aqua;
            lblName.Location = new Point(63, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 21);
            lblName.TabIndex = 56;
            lblName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(63, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 3;
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
            btnCreate.Location = new Point(164, 132);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.Enter += btnCreate_Enter;
            btnCreate.Leave += btnCreate_Leave;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            btnCreate.MouseLeave += btnCreate_MouseLeave;
            // 
            // dgvMember
            // 
            dgvMember.BackgroundColor = Color.Aqua;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(334, 38);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(311, 150);
            dgvMember.TabIndex = 5;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(154, 57);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(106, 1);
            pnlUsernametxt.TabIndex = 86;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Black;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(154, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 22);
            txtName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(154, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 1);
            panel1.TabIndex = 88;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Black;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(154, 80);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(106, 22);
            txtAddress.TabIndex = 1;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(705, 233);
            Controls.Add(panel1);
            Controls.Add(txtAddress);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtName);
            Controls.Add(dgvMember);
            Controls.Add(btnEdit);
            Controls.Add(lbIAddress);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmMember";
            Opacity = 0.93D;
            ShowInTaskbar = false;
            Text = "Members";
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lbIAddress;
        private Label lblName;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvMember;
        private Panel pnlUsernametxt;
        private TextBox txtName;
        private Panel panel1;
        private TextBox txtAddress;
    }
}
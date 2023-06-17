namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmCatch
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
            lblQuantity = new Label();
            lblWeight = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvCatch = new DataGridView();
            cmbTrip = new ComboBox();
            pnlUsernametxt = new Panel();
            txtWeight = new TextBox();
            panel1 = new Panel();
            txtQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCatch).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(109, 204);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.Enter += btnEdit_Enter;
            btnEdit.Leave += btnEdit_Leave;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = SystemColors.ActiveCaptionText;
            lblQuantity.FlatStyle = FlatStyle.System;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Aqua;
            lblQuantity.Location = new Point(61, 78);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 21);
            lblQuantity.TabIndex = 36;
            lblQuantity.Text = "Quantity";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = SystemColors.ActiveCaptionText;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.ForeColor = Color.Aqua;
            lblWeight.Location = new Point(56, 31);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(66, 21);
            lblWeight.TabIndex = 35;
            lblWeight.Text = "Weight";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(56, 161);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 4;
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
            btnCreate.Location = new Point(159, 161);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.Enter += btnCreate_Enter;
            btnCreate.Leave += btnCreate_Leave;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            btnCreate.MouseLeave += btnCreate_MouseLeave;
            // 
            // dgvCatch
            // 
            dgvCatch.BackgroundColor = Color.Aqua;
            dgvCatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatch.Location = new Point(311, 46);
            dgvCatch.Name = "dgvCatch";
            dgvCatch.RowHeadersWidth = 51;
            dgvCatch.RowTemplate.Height = 25;
            dgvCatch.Size = new Size(353, 150);
            dgvCatch.TabIndex = 6;
            dgvCatch.CellClick += dgvCatch_CellClick;
            // 
            // cmbTrip
            // 
            cmbTrip.BackColor = Color.DimGray;
            cmbTrip.Cursor = Cursors.Hand;
            cmbTrip.FlatStyle = FlatStyle.Popup;
            cmbTrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTrip.ForeColor = Color.Aqua;
            cmbTrip.FormattingEnabled = true;
            cmbTrip.Location = new Point(74, 122);
            cmbTrip.Name = "cmbTrip";
            cmbTrip.Size = new Size(167, 23);
            cmbTrip.TabIndex = 2;
            cmbTrip.Text = "Select Trip";
            cmbTrip.DropDown += cmbTrip_DropDown;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(149, 52);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(106, 1);
            pnlUsernametxt.TabIndex = 86;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.Black;
            txtWeight.BorderStyle = BorderStyle.None;
            txtWeight.Cursor = Cursors.IBeam;
            txtWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWeight.ForeColor = Color.White;
            txtWeight.Location = new Point(149, 31);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(106, 22);
            txtWeight.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(148, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 1);
            panel1.TabIndex = 88;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.Black;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Cursor = Cursors.IBeam;
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(148, 78);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(106, 22);
            txtQuantity.TabIndex = 1;
            // 
            // frmCatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(721, 265);
            Controls.Add(panel1);
            Controls.Add(txtQuantity);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtWeight);
            Controls.Add(cmbTrip);
            Controls.Add(dgvCatch);
            Controls.Add(btnEdit);
            Controls.Add(lblQuantity);
            Controls.Add(lblWeight);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmCatch";
            Opacity = 0.93D;
            Text = "Catches";
            ((System.ComponentModel.ISupportInitialize)dgvCatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lblQuantity;
        private Label lblWeight;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvCatch;
        private ComboBox cmbTrip;
        private Panel pnlUsernametxt;
        private TextBox txtWeight;
        private Panel panel1;
        private TextBox txtQuantity;
    }
}
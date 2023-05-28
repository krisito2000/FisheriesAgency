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
            txtQuantity = new TextBox();
            txtWeight = new TextBox();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvCatch = new DataGridView();
            cmbTrip = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCatch).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(127, 219);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.FlatStyle = FlatStyle.System;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(79, 93);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 21);
            lblQuantity.TabIndex = 36;
            lblQuantity.Text = "Quantity";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.Location = new Point(74, 46);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(66, 21);
            lblWeight.TabIndex = 35;
            lblWeight.Text = "Weight";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(167, 92);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(106, 23);
            txtQuantity.TabIndex = 34;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(167, 44);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(106, 23);
            txtWeight.TabIndex = 33;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(74, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(177, 176);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 31;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvCatch
            // 
            dgvCatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatch.Location = new Point(347, 46);
            dgvCatch.Name = "dgvCatch";
            dgvCatch.RowHeadersWidth = 51;
            dgvCatch.RowTemplate.Height = 25;
            dgvCatch.Size = new Size(337, 150);
            dgvCatch.TabIndex = 38;
            dgvCatch.CellClick += dgvCatch_CellClick;
            // 
            // cmbTrip
            // 
            cmbTrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTrip.FormattingEnabled = true;
            cmbTrip.Location = new Point(92, 137);
            cmbTrip.Name = "cmbTrip";
            cmbTrip.Size = new Size(167, 23);
            cmbTrip.TabIndex = 79;
            cmbTrip.Text = "Select Trip";
            // 
            // frmCatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 280);
            Controls.Add(cmbTrip);
            Controls.Add(dgvCatch);
            Controls.Add(btnEdit);
            Controls.Add(lblQuantity);
            Controls.Add(lblWeight);
            Controls.Add(txtQuantity);
            Controls.Add(txtWeight);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmCatch";
            Text = "frmCatch";
            ((System.ComponentModel.ISupportInitialize)dgvCatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lblQuantity;
        private Label lblWeight;
        private TextBox txtQuantity;
        private TextBox txtWeight;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvCatch;
        private ComboBox cmbTrip;
    }
}
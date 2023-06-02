namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmVessel
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
            lblTonnage = new Label();
            lblWidth = new Label();
            txtTonnage = new TextBox();
            txtWidth = new TextBox();
            lblLength = new Label();
            lblMarking = new Label();
            txtLength = new TextBox();
            txtMarking = new TextBox();
            btnEdit = new Button();
            lbICallSign = new Label();
            lblInternationalNumber = new Label();
            txtCallSign = new TextBox();
            txtInternationalNumber = new TextBox();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvVessel = new DataGridView();
            lblGas = new Label();
            txtGas = new TextBox();
            lblEngine = new Label();
            txtEngine = new TextBox();
            lblFuel = new Label();
            txtFuel = new TextBox();
            cmbOwners = new ComboBox();
            cmbCaptains = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvVessel).BeginInit();
            SuspendLayout();
            // 
            // lblTonnage
            // 
            lblTonnage.AutoSize = true;
            lblTonnage.FlatStyle = FlatStyle.System;
            lblTonnage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTonnage.Location = new Point(81, 211);
            lblTonnage.Name = "lblTonnage";
            lblTonnage.Size = new Size(76, 21);
            lblTonnage.TabIndex = 88;
            lblTonnage.Text = "Tonnage";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWidth.Location = new Point(92, 173);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(57, 21);
            lblWidth.TabIndex = 87;
            lblWidth.Text = "Width";
            // 
            // txtTonnage
            // 
            txtTonnage.Location = new Point(162, 213);
            txtTonnage.Name = "txtTonnage";
            txtTonnage.Size = new Size(106, 23);
            txtTonnage.TabIndex = 86;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(162, 175);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(106, 23);
            txtWidth.TabIndex = 85;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.FlatStyle = FlatStyle.System;
            lblLength.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLength.Location = new Point(92, 137);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(63, 21);
            lblLength.TabIndex = 84;
            lblLength.Text = "Length";
            // 
            // lblMarking
            // 
            lblMarking.AutoSize = true;
            lblMarking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarking.Location = new Point(81, 101);
            lblMarking.Name = "lblMarking";
            lblMarking.Size = new Size(74, 21);
            lblMarking.TabIndex = 83;
            lblMarking.Text = "Marking";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(162, 137);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(106, 23);
            txtLength.TabIndex = 82;
            // 
            // txtMarking
            // 
            txtMarking.Location = new Point(162, 99);
            txtMarking.Name = "txtMarking";
            txtMarking.Size = new Size(106, 23);
            txtMarking.TabIndex = 81;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(481, 281);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 80;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbICallSign
            // 
            lbICallSign.AutoSize = true;
            lbICallSign.FlatStyle = FlatStyle.System;
            lbICallSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbICallSign.Location = new Point(81, 64);
            lbICallSign.Name = "lbICallSign";
            lbICallSign.Size = new Size(73, 21);
            lbICallSign.TabIndex = 79;
            lbICallSign.Text = "CallSign";
            // 
            // lblInternationalNumber
            // 
            lblInternationalNumber.AutoSize = true;
            lblInternationalNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInternationalNumber.Location = new Point(55, 32);
            lblInternationalNumber.Name = "lblInternationalNumber";
            lblInternationalNumber.Size = new Size(94, 21);
            lblInternationalNumber.TabIndex = 78;
            lblInternationalNumber.Text = "IntNumber";
            // 
            // txtCallSign
            // 
            txtCallSign.Location = new Point(162, 64);
            txtCallSign.Name = "txtCallSign";
            txtCallSign.Size = new Size(106, 23);
            txtCallSign.TabIndex = 77;
            // 
            // txtInternationalNumber
            // 
            txtInternationalNumber.Location = new Point(162, 30);
            txtInternationalNumber.Name = "txtInternationalNumber";
            txtInternationalNumber.Size = new Size(106, 23);
            txtInternationalNumber.TabIndex = 76;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(433, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 75;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(534, 229);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 74;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvVessel
            // 
            dgvVessel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVessel.Location = new Point(306, 37);
            dgvVessel.Name = "dgvVessel";
            dgvVessel.RowHeadersWidth = 51;
            dgvVessel.RowTemplate.Height = 25;
            dgvVessel.Size = new Size(443, 164);
            dgvVessel.TabIndex = 89;
            dgvVessel.CellClick += dgvVessel_CellClick;
            // 
            // lblGas
            // 
            lblGas.AutoSize = true;
            lblGas.FlatStyle = FlatStyle.System;
            lblGas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGas.Location = new Point(107, 253);
            lblGas.Name = "lblGas";
            lblGas.Size = new Size(37, 21);
            lblGas.TabIndex = 91;
            lblGas.Text = "Gas";
            // 
            // txtGas
            // 
            txtGas.Location = new Point(162, 251);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(106, 23);
            txtGas.TabIndex = 90;
            // 
            // lblEngine
            // 
            lblEngine.AutoSize = true;
            lblEngine.FlatStyle = FlatStyle.System;
            lblEngine.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEngine.Location = new Point(86, 290);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(63, 21);
            lblEngine.TabIndex = 93;
            lblEngine.Text = "Engine";
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(162, 292);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(106, 23);
            txtEngine.TabIndex = 92;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.FlatStyle = FlatStyle.System;
            lblFuel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuel.Location = new Point(102, 330);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(42, 21);
            lblFuel.TabIndex = 95;
            lblFuel.Text = "Fuel";
            // 
            // txtFuel
            // 
            txtFuel.Location = new Point(162, 332);
            txtFuel.Name = "txtFuel";
            txtFuel.Size = new Size(106, 23);
            txtFuel.TabIndex = 94;
            // 
            // cmbOwners
            // 
            cmbOwners.AccessibleName = "";
            cmbOwners.FormattingEnabled = true;
            cmbOwners.Location = new Point(347, 332);
            cmbOwners.Name = "cmbOwners";
            cmbOwners.Size = new Size(121, 23);
            cmbOwners.TabIndex = 96;
            cmbOwners.Text = "Owners";
            cmbOwners.DropDown += cbOwners_DropDown;
            // 
            // cmbCaptains
            // 
            cmbCaptains.FormattingEnabled = true;
            cmbCaptains.Location = new Point(585, 332);
            cmbCaptains.Name = "cmbCaptains";
            cmbCaptains.Size = new Size(121, 23);
            cmbCaptains.TabIndex = 97;
            cmbCaptains.Text = "Captains";
            cmbCaptains.DropDown += cbCaptains_DropDown;
            // 
            // frmVessel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(cmbCaptains);
            Controls.Add(cmbOwners);
            Controls.Add(lblFuel);
            Controls.Add(txtFuel);
            Controls.Add(lblEngine);
            Controls.Add(txtEngine);
            Controls.Add(lblGas);
            Controls.Add(txtGas);
            Controls.Add(dgvVessel);
            Controls.Add(lblTonnage);
            Controls.Add(lblWidth);
            Controls.Add(txtTonnage);
            Controls.Add(txtWidth);
            Controls.Add(lblLength);
            Controls.Add(lblMarking);
            Controls.Add(txtLength);
            Controls.Add(txtMarking);
            Controls.Add(btnEdit);
            Controls.Add(lbICallSign);
            Controls.Add(lblInternationalNumber);
            Controls.Add(txtCallSign);
            Controls.Add(txtInternationalNumber);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "frmVessel";
            Text = "frmVessel";
            ((System.ComponentModel.ISupportInitialize)dgvVessel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTonnage;
        private Label lblWidth;
        private TextBox txtTonnage;
        private TextBox txtWidth;
        private Label lblLength;
        private Label lblMarking;
        private TextBox txtLength;
        private TextBox txtMarking;
        private Button btnEdit;
        private Label lbICallSign;
        private Label lblInternationalNumber;
        private TextBox txtCallSign;
        private TextBox txtInternationalNumber;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvVessel;
        private Label lblGas;
        private TextBox txtGas;
        private Label lblEngine;
        private TextBox txtEngine;
        private Label lblFuel;
        private TextBox txtFuel;
        private ComboBox cmbOwners;
        private ComboBox cmbCaptains;
    }
}
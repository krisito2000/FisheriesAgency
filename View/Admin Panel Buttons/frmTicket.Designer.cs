namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmTicket
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
            dgvTicket = new DataGridView();
            btnEdit = new Button();
            lbIEndDate = new Label();
            lblStartDate = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            lblPrice = new Label();
            lblTelk = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            cbIsPensioner = new CheckBox();
            cbIsDisabled = new CheckBox();
            cmbMember = new ComboBox();
            pnlUsernametxt = new Panel();
            txtPrice = new TextBox();
            panel2 = new Panel();
            txtTelk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // dgvTicket
            // 
            dgvTicket.BackgroundColor = Color.Aqua;
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(438, 52);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.RowHeadersWidth = 51;
            dgvTicket.RowTemplate.Height = 25;
            dgvTicket.Size = new Size(304, 150);
            dgvTicket.TabIndex = 10;
            dgvTicket.CellClick += dgvTicket_CellClick;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(541, 255);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.Enter += btnEdit_Enter;
            btnEdit.Leave += btnEdit_Leave;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // lbIEndDate
            // 
            lbIEndDate.AutoSize = true;
            lbIEndDate.BackColor = SystemColors.ActiveCaptionText;
            lbIEndDate.FlatStyle = FlatStyle.System;
            lbIEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIEndDate.ForeColor = Color.Aqua;
            lbIEndDate.Location = new Point(65, 89);
            lbIEndDate.Name = "lbIEndDate";
            lbIEndDate.Size = new Size(79, 21);
            lbIEndDate.TabIndex = 64;
            lbIEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = SystemColors.ActiveCaptionText;
            lblStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartDate.ForeColor = Color.Aqua;
            lblStartDate.Location = new Point(58, 41);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(86, 21);
            lblStartDate.TabIndex = 63;
            lblStartDate.Text = "Start Date";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(489, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 8;
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
            btnCreate.Location = new Point(590, 219);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.Enter += btnCreate_Enter;
            btnCreate.Leave += btnCreate_Leave;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            btnCreate.MouseLeave += btnCreate_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.ActiveCaptionText;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Aqua;
            lblPrice.Location = new Point(73, 127);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 21);
            lblPrice.TabIndex = 68;
            lblPrice.Text = "Price";
            // 
            // lblTelk
            // 
            lblTelk.AutoSize = true;
            lblTelk.BackColor = SystemColors.ActiveCaptionText;
            lblTelk.FlatStyle = FlatStyle.System;
            lblTelk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelk.ForeColor = Color.Aqua;
            lblTelk.Location = new Point(80, 274);
            lblTelk.Name = "lblTelk";
            lblTelk.Size = new Size(41, 21);
            lblTelk.TabIndex = 73;
            lblTelk.Text = "Telk";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Cursor = Cursors.Hand;
            dtpStartDate.Location = new Point(165, 41);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Cursor = Cursors.Hand;
            dtpEndDate.Location = new Point(165, 88);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // cbIsPensioner
            // 
            cbIsPensioner.AutoSize = true;
            cbIsPensioner.Cursor = Cursors.Hand;
            cbIsPensioner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbIsPensioner.ForeColor = Color.Aqua;
            cbIsPensioner.Location = new Point(58, 173);
            cbIsPensioner.Name = "cbIsPensioner";
            cbIsPensioner.Size = new Size(105, 25);
            cbIsPensioner.TabIndex = 3;
            cbIsPensioner.Text = "Pensioner";
            cbIsPensioner.UseVisualStyleBackColor = true;
            // 
            // cbIsDisabled
            // 
            cbIsDisabled.AutoSize = true;
            cbIsDisabled.Cursor = Cursors.Hand;
            cbIsDisabled.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbIsDisabled.ForeColor = Color.Aqua;
            cbIsDisabled.Location = new Point(58, 216);
            cbIsDisabled.Name = "cbIsDisabled";
            cbIsDisabled.Size = new Size(96, 25);
            cbIsDisabled.TabIndex = 4;
            cbIsDisabled.Text = "Disabled";
            cbIsDisabled.UseVisualStyleBackColor = true;
            // 
            // cmbMember
            // 
            cmbMember.BackColor = Color.Gray;
            cmbMember.Cursor = Cursors.Hand;
            cmbMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMember.ForeColor = Color.Aqua;
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(188, 197);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(167, 23);
            cmbMember.TabIndex = 6;
            cmbMember.Text = "Select Member";
            cmbMember.DropDown += cmbMember_DropDown;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(188, 148);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(167, 1);
            pnlUsernametxt.TabIndex = 96;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.Black;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Cursor = Cursors.IBeam;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.White;
            txtPrice.Location = new Point(188, 127);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(167, 22);
            txtPrice.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Location = new Point(188, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 1);
            panel2.TabIndex = 100;
            // 
            // txtTelk
            // 
            txtTelk.BackColor = Color.Black;
            txtTelk.BorderStyle = BorderStyle.None;
            txtTelk.Cursor = Cursors.IBeam;
            txtTelk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelk.ForeColor = Color.White;
            txtTelk.Location = new Point(188, 274);
            txtTelk.Name = "txtTelk";
            txtTelk.Size = new Size(167, 22);
            txtTelk.TabIndex = 5;
            // 
            // frmTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(780, 336);
            Controls.Add(panel2);
            Controls.Add(txtTelk);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtPrice);
            Controls.Add(cmbMember);
            Controls.Add(cbIsDisabled);
            Controls.Add(cbIsPensioner);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblTelk);
            Controls.Add(lblPrice);
            Controls.Add(btnEdit);
            Controls.Add(lbIEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvTicket);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmTicket";
            Opacity = 0.93D;
            Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTicket;
        private Button btnEdit;
        private Label lbIEndDate;
        private Label lblStartDate;
        private Button btnDelete;
        private Button btnCreate;
        private Label lblPrice;
        private Label lblTelk;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private CheckBox cbIsPensioner;
        private CheckBox cbIsDisabled;
        private ComboBox cmbMember;
        private Panel pnlUsernametxt;
        private TextBox txtPrice;
        private Panel panel2;
        private TextBox txtTelk;
    }
}
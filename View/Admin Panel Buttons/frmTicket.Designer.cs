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
            btncreate = new Button();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblTelk = new Label();
            txtTalkDecisionNum = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            cbIsPensioner = new CheckBox();
            cbIsDisabled = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // dgvTicket
            // 
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(484, 55);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.RowTemplate.Height = 25;
            dgvTicket.Size = new Size(240, 150);
            dgvTicket.TabIndex = 0;
            dgvTicket.CellClick += dgvTicket_CellClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(553, 260);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 65;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbIEndDate
            // 
            lbIEndDate.AutoSize = true;
            lbIEndDate.FlatStyle = FlatStyle.System;
            lbIEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIEndDate.Location = new Point(66, 82);
            lbIEndDate.Name = "lbIEndDate";
            lbIEndDate.Size = new Size(79, 21);
            lbIEndDate.TabIndex = 64;
            lbIEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartDate.Location = new Point(61, 35);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(86, 21);
            lblStartDate.TabIndex = 63;
            lblStartDate.Text = "Start Date";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(494, 224);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(595, 224);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(95, 30);
            btncreate.TabIndex = 59;
            btncreate.Text = "Create ";
            btncreate.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(66, 122);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 21);
            lblPrice.TabIndex = 68;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(168, 124);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(106, 23);
            txtPrice.TabIndex = 66;
            // 
            // lblTelk
            // 
            lblTelk.AutoSize = true;
            lblTelk.FlatStyle = FlatStyle.System;
            lblTelk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelk.Location = new Point(73, 260);
            lblTelk.Name = "lblTelk";
            lblTelk.Size = new Size(41, 21);
            lblTelk.TabIndex = 73;
            lblTelk.Text = "Telk";
            // 
            // txtTalkDecisionNum
            // 
            txtTalkDecisionNum.Location = new Point(168, 258);
            txtTalkDecisionNum.Name = "txtTalkDecisionNum";
            txtTalkDecisionNum.Size = new Size(106, 23);
            txtTalkDecisionNum.TabIndex = 71;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(168, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 74;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(168, 82);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 75;
            // 
            // cbIsPensioner
            // 
            cbIsPensioner.AutoSize = true;
            cbIsPensioner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbIsPensioner.Location = new Point(115, 168);
            cbIsPensioner.Name = "cbIsPensioner";
            cbIsPensioner.Size = new Size(117, 25);
            cbIsPensioner.TabIndex = 76;
            cbIsPensioner.Text = "IsPensioner";
            cbIsPensioner.UseVisualStyleBackColor = true;
            // 
            // cbIsDisabled
            // 
            cbIsDisabled.AutoSize = true;
            cbIsDisabled.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbIsDisabled.Location = new Point(115, 211);
            cbIsDisabled.Name = "cbIsDisabled";
            cbIsDisabled.Size = new Size(108, 25);
            cbIsDisabled.TabIndex = 77;
            cbIsDisabled.Text = "IsDisabled";
            cbIsDisabled.UseVisualStyleBackColor = true;
            // 
            // frmTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 336);
            Controls.Add(cbIsDisabled);
            Controls.Add(cbIsPensioner);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblTelk);
            Controls.Add(txtTalkDecisionNum);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnEdit);
            Controls.Add(lbIEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(btnDelete);
            Controls.Add(btncreate);
            Controls.Add(dgvTicket);
            Name = "frmTicket";
            Text = "frmTicket";
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
        private Button btncreate;
        private Label lblIsPensioner;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblTelk;
        private Label lblIsDisabled;
        private TextBox txtTalkDecisionNum;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private CheckBox cbIsPensioner;
        private CheckBox cbIsDisabled;
    }
}
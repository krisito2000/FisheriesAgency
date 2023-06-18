namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmFishingTrip
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblTripStart = new Label();
            lblTripEnd = new Label();
            lblCatchAmount = new Label();
            dtpTripStart = new DateTimePicker();
            dtpTripEnd = new DateTimePicker();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvTrip = new DataGridView();
            cmbVessels = new ComboBox();
            pnlUsernametxt = new Panel();
            txtCatchAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTrip).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // lblTripStart
            // 
            lblTripStart.AutoSize = true;
            lblTripStart.BackColor = SystemColors.ActiveCaptionText;
            lblTripStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTripStart.ForeColor = Color.Aqua;
            lblTripStart.Location = new Point(90, 32);
            lblTripStart.Name = "lblTripStart";
            lblTripStart.Size = new Size(79, 21);
            lblTripStart.TabIndex = 64;
            lblTripStart.Text = "Trip Start";
            // 
            // lblTripEnd
            // 
            lblTripEnd.AutoSize = true;
            lblTripEnd.BackColor = SystemColors.ActiveCaptionText;
            lblTripEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTripEnd.ForeColor = Color.Aqua;
            lblTripEnd.Location = new Point(101, 66);
            lblTripEnd.Name = "lblTripEnd";
            lblTripEnd.Size = new Size(72, 21);
            lblTripEnd.TabIndex = 65;
            lblTripEnd.Text = "Trip End";
            // 
            // lblCatchAmount
            // 
            lblCatchAmount.AutoSize = true;
            lblCatchAmount.BackColor = SystemColors.ActiveCaptionText;
            lblCatchAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatchAmount.ForeColor = Color.Aqua;
            lblCatchAmount.Location = new Point(50, 103);
            lblCatchAmount.Name = "lblCatchAmount";
            lblCatchAmount.Size = new Size(119, 21);
            lblCatchAmount.TabIndex = 66;
            lblCatchAmount.Text = "Catch Amount";
            // 
            // dtpTripStart
            // 
            dtpTripStart.CalendarForeColor = Color.Aqua;
            dtpTripStart.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpTripStart.CalendarTitleBackColor = Color.FromArgb(64, 64, 64);
            dtpTripStart.CalendarTitleForeColor = Color.Aqua;
            dtpTripStart.CalendarTrailingForeColor = Color.Aqua;
            dtpTripStart.Cursor = Cursors.Hand;
            dtpTripStart.Location = new Point(205, 34);
            dtpTripStart.Name = "dtpTripStart";
            dtpTripStart.Size = new Size(213, 23);
            dtpTripStart.TabIndex = 0;
            // 
            // dtpTripEnd
            // 
            dtpTripEnd.CalendarForeColor = Color.Aqua;
            dtpTripEnd.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpTripEnd.CalendarTitleBackColor = Color.FromArgb(64, 64, 64);
            dtpTripEnd.CalendarTitleForeColor = Color.Aqua;
            dtpTripEnd.CalendarTrailingForeColor = Color.Aqua;
            dtpTripEnd.Cursor = Cursors.Hand;
            dtpTripEnd.Location = new Point(205, 68);
            dtpTripEnd.Name = "dtpTripEnd";
            dtpTripEnd.Size = new Size(213, 23);
            dtpTripEnd.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Aqua;
            btnEdit.Location = new Point(162, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.Enter += btnEdit_Enter;
            btnEdit.Leave += btnEdit_Leave;
            btnEdit.MouseEnter += btnEdit_MouseEnter;
            btnEdit.MouseLeave += btnEdit_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Aqua;
            btnDelete.Location = new Point(111, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 5;
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
            btnCreate.Location = new Point(211, 186);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            btnCreate.Enter += btnCreate_Enter;
            btnCreate.Leave += btnCreate_Leave;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            btnCreate.MouseLeave += btnCreate_MouseLeave;
            // 
            // dgvTrip
            // 
            dgvTrip.BackgroundColor = Color.Aqua;
            dgvTrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrip.Location = new Point(442, 45);
            dgvTrip.Name = "dgvTrip";
            dgvTrip.RowHeadersWidth = 51;
            dgvTrip.RowTemplate.Height = 25;
            dgvTrip.Size = new Size(453, 171);
            dgvTrip.TabIndex = 7;
            dgvTrip.CellClick += dgvTrip_CellClick;
            // 
            // cmbVessels
            // 
            cmbVessels.BackColor = Color.Gray;
            cmbVessels.Cursor = Cursors.Hand;
            cmbVessels.FlatStyle = FlatStyle.Popup;
            cmbVessels.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbVessels.ForeColor = Color.Aqua;
            cmbVessels.FormattingEnabled = true;
            cmbVessels.Location = new Point(153, 148);
            cmbVessels.Name = "cmbVessels";
            cmbVessels.Size = new Size(121, 23);
            cmbVessels.TabIndex = 3;
            cmbVessels.Text = "Vessels";
            cmbVessels.DropDown += cbVessels_DropDown;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(205, 124);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(213, 1);
            pnlUsernametxt.TabIndex = 84;
            // 
            // txtCatchAmount
            // 
            txtCatchAmount.BackColor = Color.Black;
            txtCatchAmount.BorderStyle = BorderStyle.None;
            txtCatchAmount.Cursor = Cursors.IBeam;
            txtCatchAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCatchAmount.ForeColor = Color.White;
            txtCatchAmount.Location = new Point(205, 103);
            txtCatchAmount.Name = "txtCatchAmount";
            txtCatchAmount.Size = new Size(213, 22);
            txtCatchAmount.TabIndex = 2;
            // 
            // frmFishingTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(945, 285);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtCatchAmount);
            Controls.Add(cmbVessels);
            Controls.Add(dgvTrip);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dtpTripEnd);
            Controls.Add(dtpTripStart);
            Controls.Add(lblCatchAmount);
            Controls.Add(lblTripEnd);
            Controls.Add(lblTripStart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmFishingTrip";
            Opacity = 0.93D;
            ShowInTaskbar = false;
            Text = "Fishing Trips";
            ((System.ComponentModel.ISupportInitialize)dgvTrip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTripStart;
        private Label lblTripEnd;
        private Label lblCatchAmount;
        private DateTimePicker dtpTripStart;
        private DateTimePicker dtpTripEnd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvTrip;
        private ComboBox cmbVessels;
        private Panel pnlUsernametxt;
        private TextBox txtCatchAmount;
    }
}
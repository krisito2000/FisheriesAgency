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
            txtCatchAmount = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            dgvTrip = new DataGridView();
            cbVessels = new ComboBox();
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
            lblTripStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTripStart.Location = new Point(77, 46);
            lblTripStart.Name = "lblTripStart";
            lblTripStart.Size = new Size(79, 21);
            lblTripStart.TabIndex = 64;
            lblTripStart.Text = "Trip Start";
            // 
            // lblTripEnd
            // 
            lblTripEnd.AutoSize = true;
            lblTripEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTripEnd.Location = new Point(88, 80);
            lblTripEnd.Name = "lblTripEnd";
            lblTripEnd.Size = new Size(72, 21);
            lblTripEnd.TabIndex = 65;
            lblTripEnd.Text = "Trip End";
            // 
            // lblCatchAmount
            // 
            lblCatchAmount.AutoSize = true;
            lblCatchAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatchAmount.Location = new Point(37, 117);
            lblCatchAmount.Name = "lblCatchAmount";
            lblCatchAmount.Size = new Size(119, 21);
            lblCatchAmount.TabIndex = 66;
            lblCatchAmount.Text = "Catch Amount";
            // 
            // dtpTripStart
            // 
            dtpTripStart.Location = new Point(192, 48);
            dtpTripStart.Name = "dtpTripStart";
            dtpTripStart.Size = new Size(213, 23);
            dtpTripStart.TabIndex = 75;
            // 
            // dtpTripEnd
            // 
            dtpTripEnd.Location = new Point(192, 82);
            dtpTripEnd.Name = "dtpTripEnd";
            dtpTripEnd.Size = new Size(213, 23);
            dtpTripEnd.TabIndex = 76;
            // 
            // txtCatchAmount
            // 
            txtCatchAmount.Location = new Point(192, 117);
            txtCatchAmount.Name = "txtCatchAmount";
            txtCatchAmount.Size = new Size(213, 23);
            txtCatchAmount.TabIndex = 77;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(149, 236);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 80;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(98, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 79;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(198, 200);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(95, 30);
            btnCreate.TabIndex = 78;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvTrip
            // 
            dgvTrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrip.Location = new Point(429, 48);
            dgvTrip.Name = "dgvTrip";
            dgvTrip.RowHeadersWidth = 51;
            dgvTrip.RowTemplate.Height = 25;
            dgvTrip.Size = new Size(368, 150);
            dgvTrip.TabIndex = 81;
            dgvTrip.CellClick += dgvTicket_CellClick;
            // 
            // cbVessels
            // 
            cbVessels.FormattingEnabled = true;
            cbVessels.Location = new Point(140, 162);
            cbVessels.Name = "cbVessels";
            cbVessels.Size = new Size(121, 23);
            cbVessels.TabIndex = 82;
            cbVessels.Text = "Vessels";
            cbVessels.SelectedIndexChanged += cbVessels_SelectedIndexChanged;
            // 
            // frmFishingTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 278);
            Controls.Add(cbVessels);
            Controls.Add(dgvTrip);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtCatchAmount);
            Controls.Add(dtpTripEnd);
            Controls.Add(dtpTripStart);
            Controls.Add(lblCatchAmount);
            Controls.Add(lblTripEnd);
            Controls.Add(lblTripStart);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFishingTrip";
            Text = "Fishing Trip";
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
        private TextBox txtCatchAmount;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvTrip;
        private ComboBox cbVessels;
    }
}
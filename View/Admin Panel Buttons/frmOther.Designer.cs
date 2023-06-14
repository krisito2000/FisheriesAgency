namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmOther
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
            btnBestCatchForTheYear = new Button();
            btnGetPermits = new Button();
            lblMonths = new Label();
            dgvOther = new DataGridView();
            pnlUsernametxt = new Panel();
            txtMonths = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOther).BeginInit();
            SuspendLayout();
            // 
            // btnBestCatchForTheYear
            // 
            btnBestCatchForTheYear.BackColor = Color.DimGray;
            btnBestCatchForTheYear.Cursor = Cursors.Hand;
            btnBestCatchForTheYear.FlatStyle = FlatStyle.Popup;
            btnBestCatchForTheYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBestCatchForTheYear.ForeColor = Color.Aqua;
            btnBestCatchForTheYear.Location = new Point(224, 325);
            btnBestCatchForTheYear.Name = "btnBestCatchForTheYear";
            btnBestCatchForTheYear.Size = new Size(86, 30);
            btnBestCatchForTheYear.TabIndex = 27;
            btnBestCatchForTheYear.Text = "Years Catch";
            btnBestCatchForTheYear.UseVisualStyleBackColor = false;
            btnBestCatchForTheYear.Click += btnBestCatchForTheYear_Click;
            // 
            // btnGetPermits
            // 
            btnGetPermits.BackColor = Color.DimGray;
            btnGetPermits.Cursor = Cursors.Hand;
            btnGetPermits.FlatStyle = FlatStyle.Popup;
            btnGetPermits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetPermits.ForeColor = Color.Aqua;
            btnGetPermits.Location = new Point(103, 60);
            btnGetPermits.Name = "btnGetPermits";
            btnGetPermits.Size = new Size(81, 33);
            btnGetPermits.TabIndex = 26;
            btnGetPermits.Text = "Permits";
            btnGetPermits.UseVisualStyleBackColor = false;
            btnGetPermits.Click += btnGetPermits_Click;
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonths.ForeColor = Color.Aqua;
            lblMonths.Location = new Point(302, 59);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(102, 30);
            lblMonths.TabIndex = 25;
            lblMonths.Text = "Month/s";
            // 
            // dgvOther
            // 
            dgvOther.BackgroundColor = Color.Aqua;
            dgvOther.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOther.Location = new Point(58, 127);
            dgvOther.Name = "dgvOther";
            dgvOther.RowHeadersWidth = 51;
            dgvOther.RowTemplate.Height = 25;
            dgvOther.Size = new Size(443, 164);
            dgvOther.TabIndex = 90;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(206, 87);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(90, 1);
            pnlUsernametxt.TabIndex = 92;
            // 
            // txtMonths
            // 
            txtMonths.BackColor = Color.Black;
            txtMonths.BorderStyle = BorderStyle.None;
            txtMonths.Cursor = Cursors.IBeam;
            txtMonths.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonths.ForeColor = Color.White;
            txtMonths.Location = new Point(206, 66);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(90, 22);
            txtMonths.TabIndex = 91;
            // 
            // frmOther
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(565, 391);
            Controls.Add(pnlUsernametxt);
            Controls.Add(txtMonths);
            Controls.Add(dgvOther);
            Controls.Add(btnBestCatchForTheYear);
            Controls.Add(btnGetPermits);
            Controls.Add(lblMonths);
            Name = "frmOther";
            Opacity = 0.93D;
            Text = "Other";
            ((System.ComponentModel.ISupportInitialize)dgvOther).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBestCatchForTheYear;
        private Button btnGetPermits;
        private Label lblMonths;
        private DataGridView dgvOther;
        private Panel pnlUsernametxt;
        private TextBox txtMonths;
    }
}
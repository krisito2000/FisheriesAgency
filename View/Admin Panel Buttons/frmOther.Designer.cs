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
            this.btnBestCatchForTheYear = new System.Windows.Forms.Button();
            this.btnGetPermits = new System.Windows.Forms.Button();
            this.lblMonths = new System.Windows.Forms.Label();
            this.dgvOther = new System.Windows.Forms.DataGridView();
            this.pnlUsernametxt = new System.Windows.Forms.Panel();
            this.txtMonths = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBestCatchForTheYear
            // 
            this.btnBestCatchForTheYear.BackColor = System.Drawing.Color.DimGray;
            this.btnBestCatchForTheYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBestCatchForTheYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBestCatchForTheYear.ForeColor = System.Drawing.Color.Aqua;
            this.btnBestCatchForTheYear.Location = new System.Drawing.Point(224, 325);
            this.btnBestCatchForTheYear.Name = "btnBestCatchForTheYear";
            this.btnBestCatchForTheYear.Size = new System.Drawing.Size(86, 30);
            this.btnBestCatchForTheYear.TabIndex = 27;
            this.btnBestCatchForTheYear.Text = "Years Catch";
            this.btnBestCatchForTheYear.UseVisualStyleBackColor = false;
            // 
            // btnGetPermits
            // 
            this.btnGetPermits.BackColor = System.Drawing.Color.DimGray;
            this.btnGetPermits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetPermits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetPermits.ForeColor = System.Drawing.Color.Aqua;
            this.btnGetPermits.Location = new System.Drawing.Point(103, 60);
            this.btnGetPermits.Name = "btnGetPermits";
            this.btnGetPermits.Size = new System.Drawing.Size(81, 33);
            this.btnGetPermits.TabIndex = 26;
            this.btnGetPermits.Text = "Permits";
            this.btnGetPermits.UseVisualStyleBackColor = false;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonths.ForeColor = System.Drawing.Color.Aqua;
            this.lblMonths.Location = new System.Drawing.Point(302, 59);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(102, 30);
            this.lblMonths.TabIndex = 25;
            this.lblMonths.Text = "Month/s";
            // 
            // dgvOther
            // 
            this.dgvOther.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOther.Location = new System.Drawing.Point(58, 127);
            this.dgvOther.Name = "dgvOther";
            this.dgvOther.RowHeadersWidth = 51;
            this.dgvOther.RowTemplate.Height = 25;
            this.dgvOther.Size = new System.Drawing.Size(443, 164);
            this.dgvOther.TabIndex = 90;
            // 
            // pnlUsernametxt
            // 
            this.pnlUsernametxt.BackColor = System.Drawing.Color.Aqua;
            this.pnlUsernametxt.Location = new System.Drawing.Point(206, 87);
            this.pnlUsernametxt.Name = "pnlUsernametxt";
            this.pnlUsernametxt.Size = new System.Drawing.Size(90, 1);
            this.pnlUsernametxt.TabIndex = 92;
            // 
            // txtMonths
            // 
            this.txtMonths.BackColor = System.Drawing.Color.Black;
            this.txtMonths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonths.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonths.ForeColor = System.Drawing.Color.White;
            this.txtMonths.Location = new System.Drawing.Point(206, 66);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(90, 22);
            this.txtMonths.TabIndex = 91;
            // 
            // frmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(565, 391);
            this.Controls.Add(this.pnlUsernametxt);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.dgvOther);
            this.Controls.Add(this.btnBestCatchForTheYear);
            this.Controls.Add(this.btnGetPermits);
            this.Controls.Add(this.lblMonths);
            this.Name = "frmOther";
            this.Text = "frmOther";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
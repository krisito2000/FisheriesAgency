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
            txtMonths = new TextBox();
            SuspendLayout();
            // 
            // btnBestCatchForTheYear
            // 
            btnBestCatchForTheYear.Location = new Point(250, 187);
            btnBestCatchForTheYear.Name = "btnBestCatchForTheYear";
            btnBestCatchForTheYear.Size = new Size(86, 30);
            btnBestCatchForTheYear.TabIndex = 27;
            btnBestCatchForTheYear.Text = "Years Catch";
            btnBestCatchForTheYear.UseVisualStyleBackColor = true;
            // 
            // btnGetPermits
            // 
            btnGetPermits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetPermits.Location = new Point(175, 148);
            btnGetPermits.Name = "btnGetPermits";
            btnGetPermits.Size = new Size(81, 33);
            btnGetPermits.TabIndex = 26;
            btnGetPermits.Text = "Permits";
            btnGetPermits.UseVisualStyleBackColor = true;
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonths.Location = new Point(342, 148);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(95, 30);
            lblMonths.TabIndex = 25;
            lblMonths.Text = "Month/s";
            // 
            // txtMonths
            // 
            txtMonths.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonths.Location = new Point(273, 145);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(62, 36);
            txtMonths.TabIndex = 24;
            // 
            // frmOther
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBestCatchForTheYear);
            Controls.Add(btnGetPermits);
            Controls.Add(lblMonths);
            Controls.Add(txtMonths);
            Name = "frmOther";
            Text = "frmOther";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBestCatchForTheYear;
        private Button btnGetPermits;
        private Label lblMonths;
        private TextBox txtMonths;
    }
}
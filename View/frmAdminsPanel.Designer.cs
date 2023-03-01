namespace FisheriesAgency.View
{
    partial class frmAdminsPanel
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(35, 165);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(123, 58);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create ";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(35, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 68);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(35, 88);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(83, 23);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "Login";
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(35, 39);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(83, 23);
            this.txtRegister.TabIndex = 5;
            this.txtRegister.Text = "Register";
            // 
            // frmAdminsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncreate);
            this.Name = "frmAdminsPanel";
            this.Text = "frmAdminsPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btncreate;
        private Button btnDelete;
        private TextBox txtLogin;
        private TextBox txtRegister;
    }
}
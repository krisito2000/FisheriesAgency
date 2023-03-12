namespace FisheriesAgency
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterNow = new System.Windows.Forms.Label();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUsernametxt = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(200, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(106, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(202, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(106, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Aqua;
            this.lblUsername.Location = new System.Drawing.Point(104, 138);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Aqua;
            this.lblPassword.Location = new System.Drawing.Point(106, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Aqua;
            this.btnLogin.Location = new System.Drawing.Point(114, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(194, 53);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Enter);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            this.btnLogin.Leave += new System.EventHandler(this.btnLogin_Leave);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DimGray;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Aqua;
            this.btnRegister.Location = new System.Drawing.Point(275, 351);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 28);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.Enter += new System.EventHandler(this.btnRegister_Enter);
            this.btnRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRegister_KeyDown);
            this.btnRegister.Leave += new System.EventHandler(this.btnRegister_Leave);
            this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            // 
            // lblRegisterNow
            // 
            this.lblRegisterNow.AutoSize = true;
            this.lblRegisterNow.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterNow.ForeColor = System.Drawing.Color.Aqua;
            this.lblRegisterNow.Location = new System.Drawing.Point(76, 354);
            this.lblRegisterNow.Name = "lblRegisterNow";
            this.lblRegisterNow.Size = new System.Drawing.Size(193, 21);
            this.lblRegisterNow.TabIndex = 6;
            this.lblRegisterNow.Text = "Don\'t have an account!?";
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.Color.DimGray;
            this.btnViewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPassword.BackgroundImage")));
            this.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPassword.Location = new System.Drawing.Point(314, 194);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(27, 27);
            this.btnViewPassword.TabIndex = 7;
            this.btnViewPassword.UseVisualStyleBackColor = false;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            this.btnViewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnViewPassword_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlUsernametxt);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnViewPassword);
            this.panel1.Controls.Add(this.lblRegisterNow);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(-22, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 504);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(202, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 1);
            this.panel2.TabIndex = 10;
            // 
            // pnlUsernametxt
            // 
            this.pnlUsernametxt.BackColor = System.Drawing.Color.Aqua;
            this.pnlUsernametxt.Location = new System.Drawing.Point(200, 159);
            this.pnlUsernametxt.Name = "pnlUsernametxt";
            this.pnlUsernametxt.Size = new System.Drawing.Size(106, 1);
            this.pnlUsernametxt.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Aqua;
            this.lblLogin.Location = new System.Drawing.Point(171, 54);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(89, 37);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 434);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblRegisterNow;
        private Button btnViewPassword;
        private Panel panel1;
        private Panel panel2;
        private Panel pnlUsernametxt;
        private Label lblLogin;
    }
}
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            lblRegisterNow = new Label();
            btnViewPassword = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlUsernametxt = new Panel();
            lblLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(200, 138);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(106, 22);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(202, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(106, 22);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // lblUsername
            // 
            lblUsername.AccessibleRole = AccessibleRole.OutlineButton;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Aqua;
            lblUsername.Location = new Point(104, 138);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Aqua;
            lblPassword.Location = new Point(106, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DimGray;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Aqua;
            btnLogin.Location = new Point(114, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Enter;
            btnLogin.KeyDown += btnLogin_KeyDown;
            btnLogin.Leave += btnLogin_Leave;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DimGray;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Aqua;
            btnRegister.Location = new Point(275, 351);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(80, 28);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.Enter += btnRegister_Enter;
            btnRegister.KeyDown += btnRegister_KeyDown;
            btnRegister.Leave += btnRegister_Leave;
            btnRegister.MouseEnter += btnRegister_MouseEnter;
            btnRegister.MouseLeave += btnRegister_MouseLeave;
            // 
            // lblRegisterNow
            // 
            lblRegisterNow.AutoSize = true;
            lblRegisterNow.BackColor = Color.Transparent;
            lblRegisterNow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterNow.ForeColor = Color.Aqua;
            lblRegisterNow.Location = new Point(76, 354);
            lblRegisterNow.Name = "lblRegisterNow";
            lblRegisterNow.Size = new Size(193, 21);
            lblRegisterNow.TabIndex = 6;
            lblRegisterNow.Text = "Don't have an account!?";
            // 
            // btnViewPassword
            // 
            btnViewPassword.BackColor = Color.DimGray;
            btnViewPassword.BackgroundImage = (Image)resources.GetObject("btnViewPassword.BackgroundImage");
            btnViewPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewPassword.Cursor = Cursors.Hand;
            btnViewPassword.FlatStyle = FlatStyle.Popup;
            btnViewPassword.Location = new Point(314, 194);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(27, 27);
            btnViewPassword.TabIndex = 7;
            btnViewPassword.UseVisualStyleBackColor = false;
            btnViewPassword.Click += btnViewPassword_Click;
            btnViewPassword.KeyDown += btnViewPassword_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlUsernametxt);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(btnViewPassword);
            panel1.Controls.Add(lblRegisterNow);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(-22, -16);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 504);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Location = new Point(202, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(106, 1);
            panel2.TabIndex = 10;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(200, 159);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(106, 1);
            pnlUsernametxt.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AccessibleRole = AccessibleRole.OutlineButton;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Aqua;
            lblLogin.Location = new Point(171, 54);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(89, 37);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 434);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
namespace FisheriesAgency.View
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            lblUsername = new Label();
            lblPassword = new Label();
            lblCofirmPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            pnlRegisterBAckground = new Panel();
            btnViewPassword = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            pnlUsernametxt = new Panel();
            lblRegister = new Label();
            pnlRegisterBAckground.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Aqua;
            lblUsername.Location = new Point(110, 95);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Aqua;
            lblPassword.Location = new Point(115, 144);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblCofirmPassword
            // 
            lblCofirmPassword.AutoSize = true;
            lblCofirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCofirmPassword.ForeColor = Color.Aqua;
            lblCofirmPassword.Location = new Point(54, 188);
            lblCofirmPassword.Name = "lblCofirmPassword";
            lblCofirmPassword.Size = new Size(148, 21);
            lblCofirmPassword.TabIndex = 3;
            lblCofirmPassword.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(223, 93);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(149, 22);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(223, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(149, 22);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.Black;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(223, 186);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(149, 22);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.KeyDown += txtConfirmPassword_KeyDown;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DimGray;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Aqua;
            btnRegister.Location = new Point(165, 249);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(147, 53);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.Enter += btnRegister_Enter;
            btnRegister.KeyDown += btnRegister_KeyDown;
            btnRegister.Leave += btnRegister_Leave;
            btnRegister.MouseEnter += btnRegister_MouseEnter;
            btnRegister.MouseLeave += btnRegister_MouseLeave;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DimGray;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Aqua;
            btnBack.Location = new Point(194, 322);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 40);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            btnBack.Enter += btnBack_Enter;
            btnBack.KeyDown += btnBack_KeyDown;
            btnBack.Leave += btnBack_Leave;
            btnBack.MouseEnter += btnBack_MouseEnter;
            btnBack.MouseLeave += btnBack_MouseLeave;
            // 
            // pnlRegisterBAckground
            // 
            pnlRegisterBAckground.BackColor = Color.Black;
            pnlRegisterBAckground.Controls.Add(btnViewPassword);
            pnlRegisterBAckground.Controls.Add(panel2);
            pnlRegisterBAckground.Controls.Add(panel1);
            pnlRegisterBAckground.Controls.Add(pnlUsernametxt);
            pnlRegisterBAckground.Controls.Add(lblRegister);
            pnlRegisterBAckground.Controls.Add(btnBack);
            pnlRegisterBAckground.Controls.Add(btnRegister);
            pnlRegisterBAckground.Controls.Add(txtConfirmPassword);
            pnlRegisterBAckground.Controls.Add(txtPassword);
            pnlRegisterBAckground.Controls.Add(txtUsername);
            pnlRegisterBAckground.Controls.Add(lblCofirmPassword);
            pnlRegisterBAckground.Controls.Add(lblPassword);
            pnlRegisterBAckground.Controls.Add(lblUsername);
            pnlRegisterBAckground.Location = new Point(-19, -17);
            pnlRegisterBAckground.Name = "pnlRegisterBAckground";
            pnlRegisterBAckground.Size = new Size(556, 454);
            pnlRegisterBAckground.TabIndex = 10;
            // 
            // btnViewPassword
            // 
            btnViewPassword.BackColor = Color.DimGray;
            btnViewPassword.BackgroundImage = (Image)resources.GetObject("btnViewPassword.BackgroundImage");
            btnViewPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewPassword.Cursor = Cursors.Hand;
            btnViewPassword.FlatStyle = FlatStyle.Popup;
            btnViewPassword.Location = new Point(390, 144);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(27, 27);
            btnViewPassword.TabIndex = 3;
            btnViewPassword.UseVisualStyleBackColor = false;
            btnViewPassword.Click += btnViewPassword_Click;
            btnViewPassword.KeyDown += btnViewPassword_KeyDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Location = new Point(223, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(149, 1);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Location = new Point(223, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 1);
            panel1.TabIndex = 12;
            // 
            // pnlUsernametxt
            // 
            pnlUsernametxt.BackColor = Color.Aqua;
            pnlUsernametxt.Location = new Point(223, 115);
            pnlUsernametxt.Name = "pnlUsernametxt";
            pnlUsernametxt.Size = new Size(149, 1);
            pnlUsernametxt.TabIndex = 11;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.Aqua;
            lblRegister.Location = new Point(176, 36);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(123, 37);
            lblRegister.TabIndex = 10;
            lblRegister.Text = "Register";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 375);
            Controls.Add(pnlRegisterBAckground);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            pnlRegisterBAckground.ResumeLayout(false);
            pnlRegisterBAckground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblCofirmPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnBack;
        private Panel pnlRegisterBAckground;
        private Label lblRegister;
        private Panel pnlUsernametxt;
        private Panel panel2;
        private Panel panel1;
        private Button btnViewPassword;
    }
}
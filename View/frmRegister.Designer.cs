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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCofirmPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlRegisterBAckground = new System.Windows.Forms.Panel();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUsernametxt = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.pnlRegisterBAckground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Aqua;
            this.lblUsername.Location = new System.Drawing.Point(110, 106);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Aqua;
            this.lblPassword.Location = new System.Drawing.Point(115, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblCofirmPassword
            // 
            this.lblCofirmPassword.AutoSize = true;
            this.lblCofirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCofirmPassword.ForeColor = System.Drawing.Color.Aqua;
            this.lblCofirmPassword.Location = new System.Drawing.Point(54, 199);
            this.lblCofirmPassword.Name = "lblCofirmPassword";
            this.lblCofirmPassword.Size = new System.Drawing.Size(148, 21);
            this.lblCofirmPassword.TabIndex = 3;
            this.lblCofirmPassword.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(223, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(223, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(223, 197);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(149, 22);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DimGray;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Aqua;
            this.btnRegister.Location = new System.Drawing.Point(165, 260);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(147, 53);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.Enter += new System.EventHandler(this.btnRegister_Enter);
            this.btnRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRegister_KeyDown);
            this.btnRegister.Leave += new System.EventHandler(this.btnRegister_Leave);
            this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Aqua;
            this.btnBack.Location = new System.Drawing.Point(194, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnBack_Enter);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBack_KeyDown);
            this.btnBack.Leave += new System.EventHandler(this.btnBack_Leave);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // pnlRegisterBAckground
            // 
            this.pnlRegisterBAckground.BackColor = System.Drawing.Color.Black;
            this.pnlRegisterBAckground.Controls.Add(this.btnViewPassword);
            this.pnlRegisterBAckground.Controls.Add(this.panel2);
            this.pnlRegisterBAckground.Controls.Add(this.panel1);
            this.pnlRegisterBAckground.Controls.Add(this.pnlUsernametxt);
            this.pnlRegisterBAckground.Controls.Add(this.lblRegister);
            this.pnlRegisterBAckground.Controls.Add(this.btnBack);
            this.pnlRegisterBAckground.Controls.Add(this.btnRegister);
            this.pnlRegisterBAckground.Controls.Add(this.txtConfirmPassword);
            this.pnlRegisterBAckground.Controls.Add(this.txtPassword);
            this.pnlRegisterBAckground.Controls.Add(this.txtUsername);
            this.pnlRegisterBAckground.Controls.Add(this.lblCofirmPassword);
            this.pnlRegisterBAckground.Controls.Add(this.lblPassword);
            this.pnlRegisterBAckground.Controls.Add(this.lblUsername);
            this.pnlRegisterBAckground.Location = new System.Drawing.Point(-19, -17);
            this.pnlRegisterBAckground.Name = "pnlRegisterBAckground";
            this.pnlRegisterBAckground.Size = new System.Drawing.Size(556, 454);
            this.pnlRegisterBAckground.TabIndex = 10;
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.Color.DimGray;
            this.btnViewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPassword.BackgroundImage")));
            this.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPassword.Location = new System.Drawing.Point(390, 155);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(27, 27);
            this.btnViewPassword.TabIndex = 13;
            this.btnViewPassword.UseVisualStyleBackColor = false;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(223, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(223, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 1);
            this.panel1.TabIndex = 12;
            // 
            // pnlUsernametxt
            // 
            this.pnlUsernametxt.BackColor = System.Drawing.Color.Aqua;
            this.pnlUsernametxt.Location = new System.Drawing.Point(223, 126);
            this.pnlUsernametxt.Name = "pnlUsernametxt";
            this.pnlUsernametxt.Size = new System.Drawing.Size(149, 1);
            this.pnlUsernametxt.TabIndex = 11;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.ForeColor = System.Drawing.Color.Aqua;
            this.lblRegister.Location = new System.Drawing.Point(176, 36);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(123, 37);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.Text = "Register";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 385);
            this.Controls.Add(this.pnlRegisterBAckground);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRegister";
            this.Text = "Register";
            this.pnlRegisterBAckground.ResumeLayout(false);
            this.pnlRegisterBAckground.PerformLayout();
            this.ResumeLayout(false);

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
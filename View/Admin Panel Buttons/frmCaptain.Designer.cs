namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmCaptain
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvCaptain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaptain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 243);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(91, 133);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 28);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(86, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 28);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(192, 131);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 27);
            this.txtAddress.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 27);
            this.txtName.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(85, 195);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(203, 195);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 40);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvCaptain
            // 
            this.dgvCaptain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaptain.Location = new System.Drawing.Point(434, 68);
            this.dgvCaptain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCaptain.Name = "dgvCaptain";
            this.dgvCaptain.RowHeadersWidth = 51;
            this.dgvCaptain.RowTemplate.Height = 25;
            this.dgvCaptain.Size = new System.Drawing.Size(323, 200);
            this.dgvCaptain.TabIndex = 33;
            this.dgvCaptain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaptain_CellClick);
            // 
            // frmCaptain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 329);
            this.Controls.Add(this.dgvCaptain);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCaptain";
            this.Text = "frmCaptain";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaptain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEdit;
        private Label lblAddress;
        private Label lblName;
        private TextBox txtAddress;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvCaptain;
    }
}
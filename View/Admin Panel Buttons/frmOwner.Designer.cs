namespace FisheriesAgency.View.Admin_Panel_Buttons
{
    partial class frmOwner
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
            this.lbIAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvOwner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(164, 236);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 40);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbIAddress
            // 
            this.lbIAddress.AutoSize = true;
            this.lbIAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbIAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIAddress.Location = new System.Drawing.Point(110, 124);
            this.lbIAddress.Name = "lbIAddress";
            this.lbIAddress.Size = new System.Drawing.Size(87, 28);
            this.lbIAddress.TabIndex = 64;
            this.lbIAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(104, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 28);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(210, 121);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 27);
            this.txtAddress.TabIndex = 62;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 64);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 27);
            this.txtName.TabIndex = 61;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(107, 191);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 37);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(222, 191);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 37);
            this.btnCreate.TabIndex = 59;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvOwner
            // 
            this.dgvOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwner.Location = new System.Drawing.Point(462, 64);
            this.dgvOwner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOwner.Name = "dgvOwner";
            this.dgvOwner.RowHeadersWidth = 51;
            this.dgvOwner.RowTemplate.Height = 25;
            this.dgvOwner.Size = new System.Drawing.Size(319, 200);
            this.dgvOwner.TabIndex = 66;
            this.dgvOwner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOwner_CellClick);
            // 
            // frmOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 344);
            this.Controls.Add(this.dgvOwner);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOwner";
            this.Text = "frmOwner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Label lbIAddress;
        private Label lblName;
        private TextBox txtAddress;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dgvOwner;
    }
}
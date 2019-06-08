namespace Example_Project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnApproveUsers = new System.Windows.Forms.Button();
            this.btnChangeUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.firstNameUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminApproved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnApproveUsers
            // 
            this.btnApproveUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnApproveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveUsers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveUsers.ForeColor = System.Drawing.Color.White;
            this.btnApproveUsers.Location = new System.Drawing.Point(16, 408);
            this.btnApproveUsers.Name = "btnApproveUsers";
            this.btnApproveUsers.Size = new System.Drawing.Size(130, 50);
            this.btnApproveUsers.TabIndex = 2;
            this.btnApproveUsers.Text = "Approve users";
            this.btnApproveUsers.UseVisualStyleBackColor = false;
            this.btnApproveUsers.Click += new System.EventHandler(this.ApproveUsers_Click);
            // 
            // btnChangeUsers
            // 
            this.btnChangeUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangeUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUsers.ForeColor = System.Drawing.Color.White;
            this.btnChangeUsers.Location = new System.Drawing.Point(308, 408);
            this.btnChangeUsers.Name = "btnChangeUsers";
            this.btnChangeUsers.Size = new System.Drawing.Size(130, 50);
            this.btnChangeUsers.TabIndex = 3;
            this.btnChangeUsers.Text = "Change user\r\n";
            this.btnChangeUsers.UseVisualStyleBackColor = false;
            this.btnChangeUsers.Click += new System.EventHandler(this.btnChangeUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUsers.Location = new System.Drawing.Point(454, 408);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(130, 50);
            this.btnDeleteUsers.TabIndex = 4;
            this.btnDeleteUsers.Text = "Delete user";
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCreateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdmin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCreateAdmin.Location = new System.Drawing.Point(162, 408);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(130, 50);
            this.btnCreateAdmin.TabIndex = 5;
            this.btnCreateAdmin.Text = "Create admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(600, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameUsers,
            this.lastNameUsers,
            this.adminPhone,
            this.adminEmail,
            this.adminApproved,
            this.adminCreated,
            this.columnUpdated,
            this.adminRole,
            this.adminPassword,
            this.idUsers});
            this.listView1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1121, 350);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // firstNameUsers
            // 
            this.firstNameUsers.Text = "First Name";
            this.firstNameUsers.Width = 110;
            // 
            // lastNameUsers
            // 
            this.lastNameUsers.Text = "Last Name";
            this.lastNameUsers.Width = 110;
            // 
            // adminPhone
            // 
            this.adminPhone.Text = "Phone";
            this.adminPhone.Width = 110;
            // 
            // adminEmail
            // 
            this.adminEmail.Text = "Email";
            this.adminEmail.Width = 180;
            // 
            // adminApproved
            // 
            this.adminApproved.Text = "Approved";
            this.adminApproved.Width = 80;
            // 
            // adminCreated
            // 
            this.adminCreated.Text = "Created";
            this.adminCreated.Width = 120;
            // 
            // columnUpdated
            // 
            this.columnUpdated.Text = "Updated";
            this.columnUpdated.Width = 120;
            // 
            // adminRole
            // 
            this.adminRole.Text = "Role";
            this.adminRole.Width = 100;
            // 
            // adminPassword
            // 
            this.adminPassword.Text = "Password";
            this.adminPassword.Width = 100;
            // 
            // idUsers
            // 
            this.idUsers.Text = "ID";
            this.idUsers.Width = 80;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 478);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApproveUsers);
            this.Controls.Add(this.btnChangeUsers);
            this.Controls.Add(this.btnCreateAdmin);
            this.Controls.Add(this.btnDeleteUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApproveUsers;
        private System.Windows.Forms.Button btnChangeUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader firstNameUsers;
        private System.Windows.Forms.ColumnHeader lastNameUsers;
        private System.Windows.Forms.ColumnHeader adminPhone;
        private System.Windows.Forms.ColumnHeader adminEmail;
        private System.Windows.Forms.ColumnHeader adminApproved;
        private System.Windows.Forms.ColumnHeader adminCreated;
        private System.Windows.Forms.ColumnHeader columnUpdated;
        private System.Windows.Forms.ColumnHeader adminRole;
        private System.Windows.Forms.ColumnHeader adminPassword;
        private System.Windows.Forms.ColumnHeader idUsers;
    }
}
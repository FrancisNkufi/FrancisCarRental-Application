namespace CarRentalApp
{
    partial class ManageUsers
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
            this.labelUsersRecordsTitle = new System.Windows.Forms.Label();
            this.dataGVViewUserLists = new System.Windows.Forms.DataGridView();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.btnAddUserManageUsers = new System.Windows.Forms.Button();
            this.btnRefreshUsersLists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVViewUserLists)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsersRecordsTitle
            // 
            this.labelUsersRecordsTitle.AutoSize = true;
            this.labelUsersRecordsTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsersRecordsTitle.Font = new System.Drawing.Font("Freestyle Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsersRecordsTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUsersRecordsTitle.Location = new System.Drawing.Point(221, 9);
            this.labelUsersRecordsTitle.Name = "labelUsersRecordsTitle";
            this.labelUsersRecordsTitle.Size = new System.Drawing.Size(164, 32);
            this.labelUsersRecordsTitle.TabIndex = 1;
            this.labelUsersRecordsTitle.Text = "MANAGE USERS";
            // 
            // dataGVViewUserLists
            // 
            this.dataGVViewUserLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVViewUserLists.Location = new System.Drawing.Point(135, 44);
            this.dataGVViewUserLists.Name = "dataGVViewUserLists";
            this.dataGVViewUserLists.Size = new System.Drawing.Size(358, 176);
            this.dataGVViewUserLists.TabIndex = 7;
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUser.Location = new System.Drawing.Point(294, 226);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(199, 40);
            this.btnDeactivateUser.TabIndex = 13;
            this.btnDeactivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetUserPassword
            // 
            this.btnResetUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetUserPassword.Location = new System.Drawing.Point(135, 225);
            this.btnResetUserPassword.Name = "btnResetUserPassword";
            this.btnResetUserPassword.Size = new System.Drawing.Size(139, 41);
            this.btnResetUserPassword.TabIndex = 12;
            this.btnResetUserPassword.Text = "Reset Password";
            this.btnResetUserPassword.UseVisualStyleBackColor = true;
            this.btnResetUserPassword.Click += new System.EventHandler(this.btnResetUserPassword_Click);
            // 
            // btnAddUserManageUsers
            // 
            this.btnAddUserManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserManageUsers.Location = new System.Drawing.Point(12, 227);
            this.btnAddUserManageUsers.Name = "btnAddUserManageUsers";
            this.btnAddUserManageUsers.Size = new System.Drawing.Size(117, 41);
            this.btnAddUserManageUsers.TabIndex = 11;
            this.btnAddUserManageUsers.Text = "Add a User";
            this.btnAddUserManageUsers.UseVisualStyleBackColor = true;
            this.btnAddUserManageUsers.Click += new System.EventHandler(this.btnAddUserManageUsers_Click);
            // 
            // btnRefreshUsersLists
            // 
            this.btnRefreshUsersLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUsersLists.Location = new System.Drawing.Point(500, 227);
            this.btnRefreshUsersLists.Name = "btnRefreshUsersLists";
            this.btnRefreshUsersLists.Size = new System.Drawing.Size(107, 38);
            this.btnRefreshUsersLists.TabIndex = 14;
            this.btnRefreshUsersLists.Text = "Refresh List";
            this.btnRefreshUsersLists.UseVisualStyleBackColor = true;
            this.btnRefreshUsersLists.Click += new System.EventHandler(this.btnRefreshUsersLists_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 278);
            this.Controls.Add(this.btnRefreshUsersLists);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetUserPassword);
            this.Controls.Add(this.btnAddUserManageUsers);
            this.Controls.Add(this.dataGVViewUserLists);
            this.Controls.Add(this.labelUsersRecordsTitle);
            this.Name = "ManageUsers";
            this.Text = "Francis Car Rental Application V1.0";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVViewUserLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsersRecordsTitle;
        private System.Windows.Forms.DataGridView dataGVViewUserLists;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetUserPassword;
        private System.Windows.Forms.Button btnAddUserManageUsers;
        private System.Windows.Forms.Button btnRefreshUsersLists;
    }
}
namespace CarRentalApp
{
    partial class AddUser
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
            this.labelAddUserTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserNameOnAddUser = new System.Windows.Forms.Label();
            this.tbxUserNameOnAddUser = new System.Windows.Forms.TextBox();
            this.comboxRoleOnAddUser = new System.Windows.Forms.ComboBox();
            this.btnAddUserOnAddUser = new System.Windows.Forms.Button();
            this.btnCancelOnAddUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAddUserTitle
            // 
            this.labelAddUserTitle.AutoSize = true;
            this.labelAddUserTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddUserTitle.Font = new System.Drawing.Font("Freestyle Script", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddUserTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddUserTitle.Location = new System.Drawing.Point(89, 9);
            this.labelAddUserTitle.Name = "labelAddUserTitle";
            this.labelAddUserTitle.Size = new System.Drawing.Size(190, 47);
            this.labelAddUserTitle.TabIndex = 1;
            this.labelAddUserTitle.Text = "ADD A USER";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUserNameOnAddUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxUserNameOnAddUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboxRoleOnAddUser, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // labelUserNameOnAddUser
            // 
            this.labelUserNameOnAddUser.AutoSize = true;
            this.labelUserNameOnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameOnAddUser.Location = new System.Drawing.Point(3, 0);
            this.labelUserNameOnAddUser.Name = "labelUserNameOnAddUser";
            this.labelUserNameOnAddUser.Size = new System.Drawing.Size(92, 22);
            this.labelUserNameOnAddUser.TabIndex = 0;
            this.labelUserNameOnAddUser.Text = "Username";
            // 
            // tbxUserNameOnAddUser
            // 
            this.tbxUserNameOnAddUser.Location = new System.Drawing.Point(153, 3);
            this.tbxUserNameOnAddUser.Name = "tbxUserNameOnAddUser";
            this.tbxUserNameOnAddUser.Size = new System.Drawing.Size(144, 20);
            this.tbxUserNameOnAddUser.TabIndex = 1;
            // 
            // comboxRoleOnAddUser
            // 
            this.comboxRoleOnAddUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxRoleOnAddUser.FormattingEnabled = true;
            this.comboxRoleOnAddUser.Location = new System.Drawing.Point(153, 53);
            this.comboxRoleOnAddUser.Name = "comboxRoleOnAddUser";
            this.comboxRoleOnAddUser.Size = new System.Drawing.Size(144, 21);
            this.comboxRoleOnAddUser.TabIndex = 3;
            // 
            // btnAddUserOnAddUser
            // 
            this.btnAddUserOnAddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddUserOnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserOnAddUser.Location = new System.Drawing.Point(30, 215);
            this.btnAddUserOnAddUser.Name = "btnAddUserOnAddUser";
            this.btnAddUserOnAddUser.Size = new System.Drawing.Size(128, 34);
            this.btnAddUserOnAddUser.TabIndex = 3;
            this.btnAddUserOnAddUser.Text = "Add User";
            this.btnAddUserOnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUserOnAddUser.Click += new System.EventHandler(this.btnAddUserOnAddUser_Click);
            // 
            // btnCancelOnAddUser
            // 
            this.btnCancelOnAddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelOnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOnAddUser.Location = new System.Drawing.Point(223, 215);
            this.btnCancelOnAddUser.Name = "btnCancelOnAddUser";
            this.btnCancelOnAddUser.Size = new System.Drawing.Size(104, 34);
            this.btnCancelOnAddUser.TabIndex = 4;
            this.btnCancelOnAddUser.Text = "Cancel";
            this.btnCancelOnAddUser.UseVisualStyleBackColor = false;
            this.btnCancelOnAddUser.Click += new System.EventHandler(this.btnCancelOnAddUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.btnCancelOnAddUser);
            this.Controls.Add(this.btnAddUserOnAddUser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelAddUserTitle);
            this.Name = "AddUser";
            this.Text = "Francis Car Rental Application V1.0";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddUserTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUserNameOnAddUser;
        private System.Windows.Forms.TextBox tbxUserNameOnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxRoleOnAddUser;
        private System.Windows.Forms.Button btnAddUserOnAddUser;
        private System.Windows.Forms.Button btnCancelOnAddUser;
    }
}
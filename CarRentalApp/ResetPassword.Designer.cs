namespace CarRentalApp
{
    partial class ResetPassword
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
            this.labelResetPasswordTitle = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.tbxNewPassWord = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelNewPssW = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResetPasswordTitle
            // 
            this.labelResetPasswordTitle.AutoSize = true;
            this.labelResetPasswordTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelResetPasswordTitle.Font = new System.Drawing.Font("Freestyle Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetPasswordTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResetPasswordTitle.Location = new System.Drawing.Point(135, 9);
            this.labelResetPasswordTitle.Name = "labelResetPasswordTitle";
            this.labelResetPasswordTitle.Size = new System.Drawing.Size(189, 32);
            this.labelResetPasswordTitle.TabIndex = 2;
            this.labelResetPasswordTitle.Text = "RESET PASSWORD";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.SystemColors.Info;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(150, 264);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(164, 40);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelConfirmPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxNewPassWord, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxConfirmPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNewPssW, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 188);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(3, 94);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(156, 22);
            this.labelConfirmPassword.TabIndex = 1;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // tbxNewPassWord
            // 
            this.tbxNewPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassWord.Location = new System.Drawing.Point(222, 3);
            this.tbxNewPassWord.Name = "tbxNewPassWord";
            this.tbxNewPassWord.PasswordChar = '*';
            this.tbxNewPassWord.Size = new System.Drawing.Size(214, 20);
            this.tbxNewPassWord.TabIndex = 2;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(222, 97);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '*';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(214, 20);
            this.tbxConfirmPassword.TabIndex = 3;
            // 
            // labelNewPssW
            // 
            this.labelNewPssW.AutoSize = true;
            this.labelNewPssW.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelNewPssW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPssW.Location = new System.Drawing.Point(3, 0);
            this.labelNewPssW.Name = "labelNewPssW";
            this.labelNewPssW.Size = new System.Drawing.Size(178, 22);
            this.labelNewPssW.TabIndex = 0;
            this.labelNewPssW.Text = "Enter New Password";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 316);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelResetPasswordTitle);
            this.Name = "ResetPassword";
            this.Text = "Francis Car Rental Application V1.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResetPasswordTitle;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox tbxNewPassWord;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label labelNewPssW;
    }
}
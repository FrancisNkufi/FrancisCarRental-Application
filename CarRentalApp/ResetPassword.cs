using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities _db;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _user = user;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
         var password = tbxNewPassWord.Text;
         var confirmPassword = tbxConfirmPassword.Text;
         var user = _db.Users.FirstOrDefault(q => q.id == _user.id);
            if (password != confirmPassword)
            {
                MessageBox.Show("Error: Passwords do not match.");
                return;
            }
            _user.password = Util.HashPassword(password);
            _db.SaveChanges();
            MessageBox.Show("Password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

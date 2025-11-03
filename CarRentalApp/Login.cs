using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {

        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var userName = tbxUsername.Text.Trim();
                var passWord = tbxPassword.Text;

               

                var hashed_password = Util.HashPassword(passWord);

                var user = _db.Users.FirstOrDefault(q => q.username == userName && q.password == hashed_password
                 && q.isActive == true);
                if (user != null)
                {
                    this.Hide();
                    var mainForm = new MainWindow(user);
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong please try again");
            }
        }
    }
}

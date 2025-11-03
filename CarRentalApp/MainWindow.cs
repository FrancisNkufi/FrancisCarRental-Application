using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        public string _RoleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(User user)
        {
            InitializeComponent();
            _RoleName = user.UserRoles.FirstOrDefault().Role.shortname;
            _user = user;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecords = new AddEditRentalRecords();
            addRentalRecords.ShowDialog();
            addRentalRecords.MdiParent = this;
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isFormOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");
            if (!isFormOpen)
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
           manageRentalRecords.MdiParent = this;
            manageRentalRecords.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUsers = new ManageUsers();
            manageUsers.MdiParent = this;
            manageUsers.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_user.password == Util.DefaultHashPassword())
            {
              //  MessageBox.Show("You are required to change your default password before proceeding.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var resetPasswordForm = new ResetPassword(_user);
                resetPasswordForm.ShowDialog();
            }

            var username = _user.username;
            loggedAsLabel.Text = $"Logged in as: {username} ({_RoleName})";

            if (_RoleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}

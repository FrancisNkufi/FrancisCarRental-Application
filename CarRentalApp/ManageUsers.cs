using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddUserManageUsers_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser(this);
            addUserForm.MdiParent = this.MdiParent;
            addUserForm.Show();

        }

        private void btnResetUserPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVViewUserLists.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to reset password.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the ID of the selected user
                var selectedUserID = (int)dataGVViewUserLists.SelectedRows[0].Cells["id"].Value;

                //query the database for the car details
                var selectedUserDetails = _db.Users.FirstOrDefault(q => q.id == selectedUserID);

                if (selectedUserDetails == null)
                {
                    MessageBox.Show("User details not found. It may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Reset the password by generating a known one.

                
                var hashed_password = Util.DefaultHashPassword(); // In a real application, consider generating a random password or sending a reset link.
                selectedUserDetails.password = hashed_password;
                _db.SaveChanges();
                MessageBox.Show($"Password has been reset to '{hashed_password}'. Please advise the user to change it upon next login.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to edit the car.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVViewUserLists.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to reset password.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the ID of the selected user
                var selectedUserID = (int)dataGVViewUserLists.SelectedRows[0].Cells["id"].Value;

                //query the database for the car details
                var selectedUserDetails = _db.Users.FirstOrDefault(q => q.id == selectedUserID);

                if (selectedUserDetails == null)
                {
                    MessageBox.Show("User details not found. It may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //change the isActive status of this user to false.

                selectedUserDetails.isActive = selectedUserDetails.isActive == true ? false : true;
                _db.SaveChanges();
                ManageUsers_Load(null, null);
                MessageBox.Show($"User '{selectedUserDetails.username}' status updated successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to edit the car.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                var users = _db.Users
                    .Select(q => new
                    {
                        q.id,
                        q.username,
                        q.UserRoles.FirstOrDefault().Role.name,
                        q.isActive
                    })
                    .ToList();

                dataGVViewUserLists.DataSource = users;
                dataGVViewUserLists.Columns["name"].HeaderText = "Role Name";
                dataGVViewUserLists.Columns["isActive"].HeaderText = "Active Status";
                dataGVViewUserLists.Columns["username"].HeaderText = "Username";
                dataGVViewUserLists.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading vehicle data.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnRefreshUsersLists_Click(object sender, EventArgs e)
        {
            ManageUsers_Load(sender, e);
        }
    }
}


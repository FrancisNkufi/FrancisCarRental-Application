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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            comboxRoleOnAddUser.DataSource = roles;
            comboxRoleOnAddUser.DisplayMember = "name";
            comboxRoleOnAddUser.ValueMember = "id";

        }

        private void btnAddUserOnAddUser_Click(object sender, EventArgs e)
        {
            var username = tbxUserNameOnAddUser.Text;
            var roleId = (int)comboxRoleOnAddUser.SelectedValue;

            var password = Util.DefaultHashPassword();
            var newUser = new User
            {
                username = username,
                password = password,
                isActive = true
            };
            _db.Users.Add(newUser);
            _db.SaveChanges();
           
              var userid = newUser.id;
            var userRole = new UserRole
            {
                userid = userid,
                roleid = roleId
            };
            _db.UserRoles.Add(userRole);
            _db.SaveChanges();

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _manageUsers.btnRefreshUsersLists_Click(null, null);
            this.Close();

        }

        private void btnCancelOnAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

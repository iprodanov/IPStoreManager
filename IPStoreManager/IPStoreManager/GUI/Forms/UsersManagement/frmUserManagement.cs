using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPStoreManager.GUI.Forms.UsersManagement
{
    public partial class frmUserManagement : Form
    {
        #region Members

        private BindingSource bsUsers;
        private List<User> allUsers;

        #endregion

        #region Constructors

        public frmUserManagement()
        {
            InitializeComponent();
            bsUsers = new BindingSource();
            dgvUsers.AutoGenerateColumns = false;
        }

        #endregion

        #region Methods

        private void LoadUsersData()
        {
            GetUsersData();
            BindUsersData();
        }

        private void GetUsersData()
        {
            using (var db = new StoreManagerContext())
            {
                allUsers = db.Users.Include("Role").ToList();
                bsUsers.DataSource = allUsers;
            }
        }

        private void BindUsersData()
        {   
            dgvUsers.DataSource = bsUsers;
        }

        private void NewUser()
        {
            User user = new User();
            frmEditUser frmNewUser = new frmEditUser(user);
            if (frmNewUser.ShowDialog() == DialogResult.OK)
            {
                using (var db = new StoreManagerContext())
                {  
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
        }

        private void EditUser()
        {
            User user = GetSelectedUser();
            frmEditUser frmEditUser = new frmEditUser(user);
            if (frmEditUser.ShowDialog() == DialogResult.OK)
            {   
                using (var db = new StoreManagerContext())
                {
                    var originalUser = (from u in db.Users
                                        where u.UserID == user.UserID
                                        select u).Single();
                    CloneUser(user, originalUser);
                    db.SaveChanges();
                }
            }
        }

        private void RemoveUser()
        {
            User user = GetSelectedUser();
            using (var db = new StoreManagerContext())
            {
                User userToRemove = (from u in db.Users
                                     where u.UserID == user.UserID
                                     select u).Single();
                db.Users.Remove(userToRemove);
                db.SaveChanges();
            }
        }

        private void CloneUser(User edited, User original)
        {
            original.UserName = edited.UserName;
            original.Password = edited.Password;
            original.FirstName = edited.FirstName;
            original.LastName = edited.LastName;
            original.RoleID = edited.RoleID;
            original.Address = edited.Address;
        }

        private User GetSelectedUser()
        {
            if (bsUsers.Current != null)
            {
                return (User)bsUsers.Current;
            }
            return null;
        }
        
        private void AdjustControlsAvailability()
        {
            bool userSelected = bsUsers.Current != null;
            this.tsbtnEditUser.Enabled = userSelected;
            this.tsbtnRemoveUser.Enabled = userSelected;
        }

        #endregion

        #region Event Handlers

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadUsersData();
            AdjustControlsAvailability();
        }

        private void tsbtnNewUser_Click(object sender, EventArgs e)
        {
            NewUser();
            LoadUsersData();
            AdjustControlsAvailability();
        }

        private void tsbtnEditUser_Click(object sender, EventArgs e)
        {
            EditUser();
            LoadUsersData();
            AdjustControlsAvailability();
        }

        private void tsbtnRemoveUser_Click(object sender, EventArgs e)
        {
            RemoveUser();
            LoadUsersData();
            AdjustControlsAvailability();
        }

        private void bsUsers_CurrentItemChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var user = (User)row.DataBoundItem;
                    var role = user.Role;
                    row.Cells[roleName.Index].Value = role.Name;
                }
            }
        }

        #endregion
    }
}

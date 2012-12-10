using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPStoreManager.Validation;

namespace IPStoreManager.GUI.Forms.UsersManagement
{
    public partial class frmEditUser : Form
    {
        #region Members

        private User user;
        private ErrorProvider err;

        #endregion

        #region Constructors

        public frmEditUser(User user)
        {
            InitializeComponent();
            this.user = user;
            err = new ErrorProvider();
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            err.SetIconAlignment(cbRoles, ErrorIconAlignment.MiddleRight);
            err.SetIconPadding(cbRoles, 2);
        }

        #endregion

        #region Methods

        private void SetFormTitle()
        {
            if ( user.UserID == 0)
            {
                this.Text = String.Format(this.Text, "New");
            }
            else
            {
                this.Text = String.Format(this.Text, "Edit");
            }
        }

        private void FillUserInfo()
        {
            tbUserName.Text = user.UserName;
            tbPassword.Text = user.Password;
            tbConfirmPassword.Text = user.Password;
            cbRoles.SelectedIndex = user.RoleID - 1;
            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            tbAddress.Text = user.Address;
        }

        private void GetUserInfo()
        {
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.RoleID = cbRoles.SelectedIndex + 1;
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Address = tbAddress.Text;
        }

        private bool ConfirmPassword()
        {
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                return true;
            }
            return false;
        }

        private bool UserRoleMissing()
        {
            if (cbRoles.SelectedIndex == -1)
            {
                err.SetError(cbRoles, "Choose user role!");
                return true;
            }
            else
            {
                err.SetError(cbRoles, null);
                return false;
            }
        }

        private void AdjustControlsAvailability()
        {
            bool usernameMissing = TextBoxInput.MissingText(tbUserName);
            bool passwordMissing = TextBoxInput.MissingText(tbPassword);
            bool roleMissing = UserRoleMissing();
            bool firstNameMissing = TextBoxInput.MissingText(tbFirstName);
            bool lastNameMissing = TextBoxInput.MissingText(tbLastName);
            bool addressMissing = TextBoxInput.MissingText(tbAddress);
            this.btnOK.Enabled = !(usernameMissing || passwordMissing ||
                                   roleMissing || firstNameMissing ||
                                   lastNameMissing || addressMissing);
        }

        #endregion

        #region Event Handlers

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            TextBoxInput.InitializeErrorProvider();
            SetFormTitle();
            if (user.UserID > 0)
            {
                FillUserInfo();
            }
            AdjustControlsAvailability();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ConfirmPassword())
            {
                GetUserInfo();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Confirmed password is wrong!");
                this.DialogResult = DialogResult.None; 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }
        
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPStoreManager.Security;

namespace IPStoreManager.GUI.Forms
{
    public partial class frmLogin : Form
    {
        #region Constructors

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SecurityManager.AuthenticateUser(tbUserName.Text, tbPassword.Text);

            if (SecurityManager.CurrentUser == null)
            {
                MessageBox.Show("Authentication Failed!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUserName.Clear();
                tbPassword.Clear();
                tbUserName.Focus();
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}

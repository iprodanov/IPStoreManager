using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IPStoreManager.GUI.Forms;
using IPStoreManager.GUI.Forms.SalesManagement;

namespace IPStoreManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form frmMain = null;

            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                if (Security.SecurityManager.CurrentUser.RoleID == 1)
                {
                    frmMain = new frmMain();
                }
                else if (Security.SecurityManager.CurrentUser.RoleID == 2)
                {
                    frmMain = new frmSalesTerminal();
                }
                Application.Run(frmMain);
            }
        }
    }
}

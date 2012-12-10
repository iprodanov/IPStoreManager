using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPStoreManager.Security
{
    public class UserInfo
    {
        #region Members

        private int id;
        private string username;
        private int roleID;

        #endregion

        #region Constructors

        public UserInfo(int userID, string userName, int userRoleID)
        {
            id = userID;
            username = userName;
            roleID = userRoleID;
        }

        #endregion

        #region Properties

        public int ID
        {
            get { return id; }
        }

        public string UserName
        {
            get { return username; }
        }

        public int RoleID
        {
            get { return roleID; }
        }

        #endregion
    }
}

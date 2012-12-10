using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPStoreManager.Security
{
    public static class SecurityManager
    {
        #region Members

        private static UserInfo userInfo;

        #endregion

        #region Constructos

        static SecurityManager()
        {
            userInfo = null;
        }

        #endregion

        #region Properties

        public static UserInfo CurrentUser
        {
            get { return userInfo; }
        }
        
        #endregion

        #region Methods

        public static void AuthenticateUser(string username, string password)
        {
            using (var db = new StoreManagerContext())
            {
                var user = (from u in db.Users
                            where u.UserName == username && u.Password == password
                            select u).SingleOrDefault();

                if (user != null)
                {
                    userInfo = new UserInfo(user.UserID, user.UserName, user.RoleID);
                }
            }
        }

        #endregion
    }
}

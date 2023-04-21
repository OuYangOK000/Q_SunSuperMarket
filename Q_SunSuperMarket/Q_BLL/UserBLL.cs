using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q_DAL;
using Q_Models;

namespace Q_BLL
{
    public class UserBLL
    {
        public static List<Users> GetUsersAll()
        {
            return UserDAL.UsersAll();
        }
        public static Users GetUserByUserName(string Name)
        {
            return UserDAL.GetUserByUserName(Name);
        }
    }
}

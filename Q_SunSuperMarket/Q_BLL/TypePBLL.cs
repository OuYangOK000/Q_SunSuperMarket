using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q_Models;
using Q_DAL;

namespace Q_BLL
{
    public class TypePBLL
    {
        public static List<TypeP> GetTypePsAll()
        {
            return TypePDAL.GetTypePsAll();
        }
    }
}

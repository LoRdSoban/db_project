using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_project
{
    static class LoginDetails
    {
        private static string salesmanID;
        private static string salesmanName;

        private static string adminID;
        private static string adminName;

        public static string SalesmanID
        {
            get { return salesmanID; }
            set {salesmanID = value; }
        }

        public static string SalesmanName
        {
            get { return salesmanName; }
            set
            {
                salesmanName = value;
            }
        }
        public static string AdminID
        { 
            get { return adminID; } 
            set { adminID = value; } 
        }

        public static string AdminName
        { 
            get { return adminName; }
            set { adminName = value; }  
        }
    }
}

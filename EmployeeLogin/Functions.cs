using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace EmployeeLogin
{
    public static class Functions
    {
        public static string pathToDB()
        {
            return @"data source=C:\Users\Mwa\Documents\GitHub\Group13ATM2\Databases\Employee.db";
        }
    }
}

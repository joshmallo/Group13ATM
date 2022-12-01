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
            return @"data source=C:\Users\USER\Desktop\Year2SHU\IntroToSoft\Project\Group13ATM\Databases\Employee.db";
        }
    }
}

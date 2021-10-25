using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Test1
{
    class Company1
    {
        public static string company;
        
       
        public string PCompany
        {
            get { return company; }
            set
            {
                company = value;
            }
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Account : Student
    {
        public string email { get; set; }
        public string password { get; set; }
        public int id { get; set; }

    }
}

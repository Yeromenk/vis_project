using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class ucet
    {
        private static List<Account> account = null;

        public static List<Account> GetFakeList
        {
            get
            {
                if (account == null)
                {
                    account = new List<Account>();
                    account.Add(new Account() { first_name = "Jan", last_name = "Kovar", age = 19, email = "jankovar@gmail.com" });
                    account.Add(new Account() { first_name = "Honza", last_name = "Jindrek", age = 20, email = "honzajindrek@gmail.com" });
                    account.Add(new Account() { first_name = "Mykyta", last_name = "Ivanov", age = 18, email = "mykytaivanov@gmail.com" });
                }
                return account;

            }
        }
    }
}

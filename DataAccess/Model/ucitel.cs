using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class ucitel
    {
        private static List<Teacher> teacher = null;

        public static List<Teacher> GetFakeList
        {
            get
            {
                if (teacher == null)
                {
                    teacher = new List<Teacher>();
                    teacher.Add(new Teacher() { subject_name = "English", first_name = "Mary", last_name = "jane", age = 33, email = "maryjane@gmail.com" });
                    teacher.Add(new Teacher() { first_name = "Kirill", last_name = "Vondrak", subject_name = "math", age = 34, email = "kirill@gmail.com" });
                    teacher.Add(new Teacher() { first_name = "Oleg", last_name = "Ivanov", subject_name = "LA", age = 23, email = "123@ga.com" });
                }
                return teacher;

            }
        }
    }
}

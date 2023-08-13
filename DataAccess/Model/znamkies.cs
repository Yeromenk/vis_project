using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq.ExpressionTransformers;

namespace DataAccess.Model
{
    public class znamkies
    {
        private static List<Znamky> znamky = null;
        private static int counter = 3;

        public static int Counter
        {
            get { return ++counter; }
        }

        public static List<Znamky> GetFakeList
        {
            get
            {
                if (znamky == null)
                {
                    znamky = new List<Znamky>();
                    znamky.Add(new Znamky() { grade = 1, subject_name = "Math", teacher = "Petr Bitek" });
                    znamky.Add(new Znamky() { grade = 4, subject_name = "Cestina", teacher = "Jan Kovar" });
                    znamky.Add(new Znamky() { grade = 10, subject_name = "English", teacher = "Mary Jane" });
                }
                return znamky;

            }

        }
        /*
        SQL!!!
        public static List<Znamky> GetZnamkyFromDb() // pracujeme z DB SQL!!!
        {
            List<Znamky> znamky = new List<Znamky>();
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-Q3UAPJR7;Initial Catalog=Skola;Integrated Security=True;");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * from Znamky join Teacher on Znamky.teacher_id = Teacher.id", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    Znamky z = new Znamky();

                    //z.grade = reader.GetInt32(1);
                    z.subject_name = reader.GetString(2);
                    z.teacher = reader.GetString(3);
                    //z.id = reader.GetInt32(4);
                    //z.teacher_id = reader.GetInt32(5);

                    Teacher t = new Teacher();

                    // t.id = reader.GetInt32(6);
                    t.first_name = reader.GetString(7);
                    t.last_name = reader.GetString(8);
                    //t.age = reader.GetInt32(9);
                    t.email = reader.GetString(10);
                    t.subject_name = reader.GetString(11);

                    znamky.Add(z);
                }
            }

            return null;

        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class timetable
    {
        private static List<Rozvrh> rozvrh = null;

        public static List<Rozvrh> GetFakeList
        {
            get
            {
                if (rozvrh == null)
                {
                    rozvrh = new List<Rozvrh>();
                    rozvrh.Add(new Rozvrh() { subject_name = "Math", subject_timetable = "11:25" });
                    rozvrh.Add(new Rozvrh() { subject_name = "English", subject_timetable = "09:00" });
                    rozvrh.Add(new Rozvrh() { subject_name = "Cestina", subject_timetable = "07:15" });
                }
                return rozvrh;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class ukoly
    {
        private static List<DomUkol> domUkol = null;

        public static List<DomUkol> GetFakeList
        {
            get
            {
                if (domUkol == null)
                {
                    domUkol = new List<DomUkol>();
                    domUkol.Add(new DomUkol() { subject_name = "Math", homework = "bude zkouska" });
                    domUkol.Add(new DomUkol() { subject_name = "Englis", homework = "dodelat neco" });
                    domUkol.Add(new DomUkol() { subject_name = "Cestina", homework = "ukoly 3,4,5" });
                }
                return domUkol;

            }
        }
    }
}

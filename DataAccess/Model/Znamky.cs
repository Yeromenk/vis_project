using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Model
{
    public class Znamky
    {
        [Required(ErrorMessage = "Znamka je vyzadovana")]
        [Range(1, 12, ErrorMessage = "Znamka muze byt od 1 do 12")]
        public int grade { get; set; }
        [Required(ErrorMessage = "Nazev predmetu je vyzadovan")]
        public string subject_name { get; set; }
        [Required(ErrorMessage = "Jmeno ucitele je vyzadovan")]
        public string teacher { get; set; }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11
{
    internal class Opiskelija
    {
        public string Enimi { get; set; }
        public string Snimi { get; set; }
        public string TiimiID { get; set; }
        public string OpiskelijaID { get; set; }

        public Opiskelija(string EtuNimi, string SukuNimi, string TiimiTunnus,  string OpiskelijaTunnus)
        {
            Enimi = EtuNimi;
            Snimi = SukuNimi;
            TiimiID = TiimiTunnus;
            OpiskelijaID = OpiskelijaTunnus;
        }
    }
}

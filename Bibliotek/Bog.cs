using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class Bog
    {
        public string Forlag { get; set; }
        public string Titel { get; set; }
        public string Forfatter { get; set; }
        public uint Udgivelsesår { get; set; }

        public Bog(string titel)
        {
            this.Titel = titel;
        }

    }

    public class Skønlitteratur : Bog
    {
        public Skønlitteratur(string titel) : base(titel)
        {
        }
        public string Eventyr { get; set; }
        public string Krimi { get; set; }
        public string Kærlighed { get; set; }
    }

    public class Faglitteratur : Bog
    {
        public Faglitteratur(string titel) : base(titel)
        {
        }

        public string Naturvidenskab { get; set; }
        public string Historie { get; set; }
        public string Dyr { get; set; }
        public string Computer { get; set; }
    }
}

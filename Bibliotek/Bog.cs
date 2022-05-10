using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class Bog //SUPERCLASS
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

    public class Skønlitteratur : Bog //1.SUBCLASS 
    {
        public Skønlitteratur(string titel) : base(titel)
        {
        }

        public enum Genre : int 
        { 
            Eventyr = 0,
            Krimi = 1,
            Kærlighed = 2 
        }
        public Genre genre { get; set; }
    }

    public class Faglitteratur : Bog //2. SUBCLASS
    {
        public Faglitteratur(string titel) : base(titel)
        {
        }

        public enum Genre : int 
        {
            Naturvidenskab = 0,
            Historie = 1,
            Dyr = 2,
            Computer = 3
        }
        public Genre genre { get; set; }
    }
}

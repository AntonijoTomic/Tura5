using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tura5
{
    public class Osoba : IEquatable<Osoba>, IComparable<Osoba>
    {
        public int Sifra { get; set; }

        public string Ime { get; set; }

        public string Adresa{ get; set; }
       
        public int Godine { get; set; }

        public int CompareTo(Osoba other)
        {
            if (this.Equals(other)) return 0;
            if (other == null) return 1;
            return (this.Godine > other.Godine) ? 1 : -1;
        }

        public bool Equals(Osoba other)
        {
            if (other == null) return false;

            return (this.Sifra == other.Sifra && this.Ime == other.Ime && this.Adresa == other.Adresa && this.Godine == other.Godine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class PromotorID
    {
        public PromotorID(int iD, string imie, string nazwisko)
        {
            ID = iD;
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public int ID { get; }
        public string Imie { get; }
        public string Nazwisko { get; }

        public override string ToString()
        {
            return $"{ID}";
        }
        public override bool Equals(object? obj)
        {
            return obj is PromotorID promotorID &&
                ID == promotorID.ID;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ID);
        }


    }
}

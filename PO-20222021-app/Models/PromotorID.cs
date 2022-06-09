using System;

namespace PO_20222021_app.Modele
{
    public class PromotorID
    {
        public int ID { get; }
        public string Imie { get; }
        public string Nazwisko { get; }

        public PromotorID(int iD, string imie, string nazwisko)
        {
            ID = iD;
            Imie = imie;
            Nazwisko = nazwisko;
        }

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

        public static bool operator ==(PromotorID ID1, PromotorID ID2)
        {
            if (ID1 is null && ID2 is null)
            {
                return true;
            }
            return !(ID1 is null) && ID1.Equals(ID2);
        }

        public static bool operator !=(PromotorID ID1, PromotorID ID2)
        {
            return !(ID1 == ID2);
        }
    }
}
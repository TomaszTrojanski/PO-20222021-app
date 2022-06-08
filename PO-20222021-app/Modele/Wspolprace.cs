using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class Wspolprace
    {
        private readonly Dictionary<PromotorID, List<Wspolprace>> _akcjePromocyjne;
        
        public Wspolprace()
        {
            _akcjePromocyjne = new Dictionary<PromotorID, List<Wspolprace>>();
        }
    }
}

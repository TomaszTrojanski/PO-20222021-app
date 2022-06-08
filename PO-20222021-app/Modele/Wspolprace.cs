using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class Wspolprace
    {
        private readonly List<Wspolprace> _promocje;
        
        public Wspolprace()
        {
            _promocje = new List<Wspolprace>();
        }
        public IEnumerable<Promocje> GetAkcjePromocyjneForUser(string username)
        {
            return _promocje.Where(r => r.Username == username);
        }
        public void AddAkcje(Promocje promocje)
        {
            foreach(Promocje existingPromocje in _promocje)
            {
                if(existingPromocje)
            }
            _promocje.Add(promocje);
        }
    }
}

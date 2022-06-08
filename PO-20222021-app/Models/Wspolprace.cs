using PO_20222021_app.Exeptions;
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
        public IEnumerable<Promocje> GetPromocjeForUser(string username)
        {
            return _promocje.Where(r => r.Username== username);
        }
        public void AddPromocje(Promocje promocje)
        {
            foreach (Promocje existingPromocje in _promocje) {
                if (existingPromocje.Conflicts(promocje))
                {
                    throw new PromocjeConflictException(existingPromocje, promocje);
                }
            }
            _promocje.Add(promocje);
        }
    }
}

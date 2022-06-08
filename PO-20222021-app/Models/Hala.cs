using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class Hala
    {
        private readonly Wspolprace _wspolprace;

        public string Name { get; set; }

        public Hala()
        {
            Name = Name;
            _wspolprace = new Wspolprace();
        }
        public IEnumerable<Promocje> GetPromocjeForUser(string username)
        {
            return _wspolprace.GetPromocjeForUser(username);
        }
        public void MakePromocje(Promocje promocje)
        {
            _wspolprace.AddPromocje(promocje);
        }
        
    }
}    

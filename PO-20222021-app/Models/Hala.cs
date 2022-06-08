using PO_20222021_app.Exeptions;
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

        public Hala(string name, Wspolprace wspolprace)
        {
            Name = name;
            _wspolprace = wspolprace;
        }
        public async Task<IEnumerable<Promocje>> GetAllPromocje()
        {
            return await _wspolprace.GetAllPromocje();
        }
        
        public async Task MakePromocje(Promocje promocje)
        {
            await _wspolprace.AddPromocje(promocje);
        }
        
    }
}    

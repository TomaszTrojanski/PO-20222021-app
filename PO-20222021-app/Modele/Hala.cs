using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class Hala
    {
        private readonly Wspolprace wspolprace;

        public string Name { get; set; }

        public Hala()
        {
            wspolprace = new Wspolprace();
        }
    }
}    

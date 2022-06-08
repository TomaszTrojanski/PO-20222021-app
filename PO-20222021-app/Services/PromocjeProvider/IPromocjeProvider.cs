using PO_20222021_app.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public interface IPromocjeProvider
    {
        Task<IEnumerable<Promocje>> GetAllPromocje();
    }
}
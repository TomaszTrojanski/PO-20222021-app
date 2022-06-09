using System.Collections.Generic;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public interface IPromocjeProvider
    {
        Task<IEnumerable<Promocje>> GetAllPromocje();
    }
}
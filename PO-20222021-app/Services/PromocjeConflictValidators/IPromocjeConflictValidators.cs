using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public interface IPromocjeConflictValidators
    {
        Task<Promocje> GetConflictingPromocje(Promocje promocje);
    }
}
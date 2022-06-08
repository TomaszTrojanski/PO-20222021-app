using PO_20222021_app.Exeptions;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public interface IPromocjeCreator
    {
        Task CreatePromocje(Promocje promocje);
    }
}
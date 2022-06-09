using PO_20222021_app.Exeptions;
using PO_20222021_app.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.ViewModels
{
    public class PromocjeViewModel : ViewModelBase
    {
        private readonly Promocje _promocje;
        public string ID => _promocje.PromotorID?.ToString();
        public string Username => _promocje.Username;
        public string StartTime => _promocje.StartTime.ToString("d");
        public string EndTime => _promocje.EndTime.ToString("d");
        public PromocjeViewModel(Promocje promocje)
        {
            _promocje = promocje;
        }
            
    }
}

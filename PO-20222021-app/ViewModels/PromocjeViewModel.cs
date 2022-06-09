using PO_20222021_app.Modele;

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
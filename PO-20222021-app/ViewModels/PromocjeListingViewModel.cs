using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PO_20222021_app.ViewModels
{
    public class PromocjeListingViewModel : ViewModelBase
    {
        private readonly HalaStore _halaStore;
        private readonly ObservableCollection<PromocjeViewModel> _promocje;
        public IEnumerable<PromocjeViewModel> Promocje => _promocje;
        //public bool HasPromocje => _promocjes;
        
    }
}

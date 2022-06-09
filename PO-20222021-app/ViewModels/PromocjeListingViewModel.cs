using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PO_20222021_app.ViewModels
{
    public class PromocjeListingViewModel : ViewModelBase
    {
        private readonly HalaStore _halaStore;
        private readonly ObservableCollection<PromocjeViewModel> _promocje;
        public IEnumerable<PromocjeViewModel> Promocje => _promocje;

        public static PromocjeListingViewModel LoadViewModel(HalaStore halaStore, NavigationService<MakePromocjeViewModel> navigationService)
        {
            throw new NotImplementedException();
        }

        public static PromocjeListingViewModel LoadViewModel(HalaStore halaStore)
        {
            throw new NotImplementedException();
        }

        //public bool HasPromocje => _promocjes;
    }
}
using PO_20222021_app.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Commands
{
    public class MakePromocjeCommand : CommandBase
    {
        private readonly MakePromocjeViewModel _makePromocjeViewModel;
        private readonly HalaStore _halaStore;
        private readonly NavigationService<PromocjeListingViewModel> _promocjeViewNavigationService;

        public MakePromocjeCommand(MakePromocjeViewModel makePromocjeViewModel, HalaStore halaStore, NavigationService<PromocjeListingViewModel> promocjeViewNavigationService)
        {
            _makePromocjeViewModel = makePromocjeViewModel;
            _halaStore = halaStore;
            _promocjeViewNavigationService = promocjeViewNavigationService;
            _makePromocjeViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangingEventArgs e)
        {
            //if (e.PropertyName == nameof(MakePromocjeViewModel.CanCreatePromocje))
            //{
            //    OnCanExecutedChanged();
            //}
        }

        public override void Execute(object parameter)
        {
            //throw 
        }
    }
    
    
}

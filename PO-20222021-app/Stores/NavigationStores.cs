using PO_20222021_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Stores
{
    public class NavigationStores
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewChanges();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewChanges()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}

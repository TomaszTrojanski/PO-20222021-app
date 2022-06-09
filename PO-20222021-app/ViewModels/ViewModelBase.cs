using System;
using System.ComponentModel;

namespace PO_20222021_app.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler PropertyChanged;

        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        public virtual void Dispose()
        { }
    }
}
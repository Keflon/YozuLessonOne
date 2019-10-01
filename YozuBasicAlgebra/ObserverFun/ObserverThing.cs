using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YozuBasicAlgebra.ObserverFun
{
    public class ObserverThing : INotifyPropertyChanged
    {
        private bool _isSelected;

        public ObserverThing(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        public string FriendlyName { get; }

        #region INotifyPropertyChanged

        public bool IsSelected { get => _isSelected;
            set
            {
                if(value != _isSelected)
                {
                    _isSelected = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual async void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SamuraiApp.Domain
{
    public class ClientChangeTracker : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetField<T>(ref T field, T value,
            [CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(propertyName);
            return true;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
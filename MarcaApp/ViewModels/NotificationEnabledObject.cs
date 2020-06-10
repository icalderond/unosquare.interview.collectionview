using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarcaApp.ViewModels
{
    public class NotificationEnabledObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

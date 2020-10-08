using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Maps;

namespace ProyectoUWP
{
    public abstract class MainViewModelBase : INotifyPropertyChanged
    {

        /*
         * INotifyPropertyChanged
         * 
         */
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName) {
            PropertyChangedEventHandler handler = this.PropertyChanged;            
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoUWP
{
    public class DelegateCommand : ICommand
    {
        private SimpleEventHandler handler;
        private bool isEnabled = true;
        public event EventHandler CanExecuteChanged;

        public delegate void SimpleEventHandler();

        //Constructor
        public DelegateCommand(SimpleEventHandler handler)
        {
            this.handler = handler;
        }

        //Propiedad
        public bool IsEnabled {
            get { return this.isEnabled;  }
        }

        /*
         * Interfaz ICommand
         */
        void ICommand.Execute(object parameter)
        {
            this.handler();
        }
        bool ICommand.CanExecute(object org)
        {
            return this.isEnabled;
        }


        //Metodo
        private void OnCanExecuteChanged() {
            if (this.CanExecuteChanged != null) 
            {
                this.CanExecuteChanged(this, EventArgs.Empty);    
            }
        }

    }
}

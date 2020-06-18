using System;
using System.Windows.Input;
 
namespace Contact.ViewModel.Comand
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;  // void NameMethod(0...16args)
     
        /*
         void Execute(object param){
            cw("hello world");
        }


        execute = Execute;
        execute?.Invoke("something");
        ==
        execute("something");
         */
        
        private Func<object, bool> canExecute;  // bool NameMethod(0..16args)
        /*
         bool CanDo(object param){
        return true;
        }

        canExecute = CanDo;
        canExecute = ()=>true;

        canExecute("any object");
         */

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}

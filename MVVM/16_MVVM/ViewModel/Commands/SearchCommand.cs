using System;
using System.Windows.Input;

namespace _16_MVVM.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {
        WeatherVM VM { get; set; }
        public SearchCommand(WeatherVM vm)
        {
            VM = vm;
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return !String.IsNullOrEmpty(parameter as string);
        }

        public void Execute(object parameter)
        {
            VM.MakeRequestCities();
        }
    }
}

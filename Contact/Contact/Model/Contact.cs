using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contact.Model
{
    public class Contacts : INotifyPropertyChanged
    {
        private string name;
        private string surname;
        private int number;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public int Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}


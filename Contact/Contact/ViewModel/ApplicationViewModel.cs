using Contact.Model;
using Contact.ViewModel.Comand;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contact.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Contacts selectedContacts;
        private Contacts contact; 
        public ObservableCollection<Contacts> Cnts { get; set; }
        public Contacts SelectedContacts
        {
            get { return selectedContacts; }
            set
            {
                selectedContacts = value;
                OnPropertyChanged("SelectedContacts");
            }
        }
        public Contacts Contact
        {
            get { return contact; }
            set
            {
                contact = value;
                OnPropertyChanged("Contact");
            }
        }
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Contacts phone = new Contacts();
                      Cnts.Add(contact);
                      SelectedContacts = phone;
                  }));
            }
        }
  
   

        public ApplicationViewModel()
        {
            Cnts = new ObservableCollection<Contacts>
            {
                new Contacts { Name="iPhone 7", Surname="Apple", Number=56000 },
                new Contacts {Name="Galaxy S7 Edge", Surname="Samsung", Number =60000 }

            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

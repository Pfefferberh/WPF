using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace RegistrForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new User();
        List<User> users = new List<User>();
        bool check1 = true;
        bool check2 = true;
        bool check_user = true;
        public MainWindow()
        {
            InitializeComponent();
            load();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            check_user = false;
            if (check1)
            {
                ok.Visibility = Visibility.Visible;
                lblogin.Visibility = Visibility.Visible;
                login.Visibility = Visibility.Visible;
                lbPassw.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Visible;
                check1 = false;
            }
            else
            {
                login.Text = "";
                Password.Password = "";

                ok.Visibility = Visibility.Hidden;
                lblogin.Visibility = Visibility.Hidden;
                login.Visibility = Visibility.Hidden;
                lbPassw.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Hidden;
                check1 = true;
            }
            lbConPasw.Visibility = Visibility.Hidden;
            CnPassword.Visibility = Visibility.Hidden;
            lbEmail.Visibility = Visibility.Hidden;
            Email.Visibility = Visibility.Hidden;
            check2 = true;
            CnPassword.Password = "";
            Email.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            check_user = true;
            if (check2)
            {
                ok.Visibility = Visibility.Visible;

                lblogin.Visibility = Visibility.Visible;
                login.Visibility = Visibility.Visible;
                lbPassw.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Visible;

                lbConPasw.Visibility = Visibility.Visible;
                CnPassword.Visibility = Visibility.Visible;
                lbEmail.Visibility = Visibility.Visible;
                Email.Visibility = Visibility.Visible;
                check2 = false;
            }
            else
            {
                login.Text = "";
                Password.Password = "";
                CnPassword.Password = "";
                Email.Text = "";

                ok.Visibility = Visibility.Hidden;
                lblogin.Visibility = Visibility.Hidden;
                login.Visibility = Visibility.Hidden;
                lbPassw.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Hidden;

                lbConPasw.Visibility = Visibility.Hidden;
                CnPassword.Visibility = Visibility.Hidden;
                lbEmail.Visibility = Visibility.Hidden;
                Email.Visibility = Visibility.Hidden;
                check2 = true;
            }
            check1 = true;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (check_user)
            {
                user.login = login.Text;
                if (Password.Password == CnPassword.Password)
                {
                    user.password = Password.Password;
                    user.email = Email.Text;
                    users.Add(user);

                    XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream("user.xml", FileMode.Create, FileAccess.Write))
                    {
                        formatter.Serialize(fs, users);

                        Skreen.Content = "user in the base";
                    }
                }
                else
                    Skreen.Content = "Password not corect";
            }
            else
            {
            //   if( users.Find(search) != null)
               if( users.Find((x) => x.login == login.Text && x.password == Password.Password) != null)

                    Skreen.Content = "Welcome User";
               else
                    Skreen.Content = "You have to registration";
            }
        }

        private bool search(User x)
        {
            if (x.login == login.Text && x.password == Password.Password)
                return true;
            return false;

         //   return (x.login == login.Text && x.password == Password.Password);
        }
        private void load()
        {
            if (!File.Exists("user.xml"))
                return;
            XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("user.xml", FileMode.Open, FileAccess.Read))
            {
                users = (List<User>)formatter.Deserialize(fs);
            }
        }
    }
}

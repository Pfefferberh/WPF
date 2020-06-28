using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace RegistrForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool check1 = true;
        bool check2 = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
                Password.Text = "";

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
            CnPassword.Text = "";
            Email.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
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
                Password.Text = "";
                CnPassword.Text = "";
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
            string writePath = @"C:\Users\Рома\Desktop\Step\WPF\RegistrForm\RegistrForm\txt.txt";

                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(login.Text);
                    sw.WriteLine(Password.Text);
                    sw.WriteLine(Email.Text);
                Skreen.Content = "DOne";
                }


        }
    }
}

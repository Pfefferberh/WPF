using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ExamWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonVS_Click(object sender, RoutedEventArgs e)
        {
            link.Inlines.Clear();
            lbScreen.Content =  (sender as Button).Tag;
            link.Inlines.Add(new Run("Downloads " + lbScreen.Content.ToString())) ;
        }

        private void Button_link_Click(object sender, RoutedEventArgs e)
        {
            if (lbScreen.Content.ToString()== "VISUAL STUDIO") 
            Process.Start(new ProcessStartInfo("https://visualstudio.microsoft.com/ru/downloads/"));
            if (lbScreen.Content.ToString() == "VISUAL STUDIO FOR MAC")
                Process.Start(new ProcessStartInfo("https://visualstudio.microsoft.com/ru/vs/mac/"));
            if (lbScreen.Content.ToString() == "VISUAL STUDIO CODE")
                Process.Start(new ProcessStartInfo("https://code.visualstudio.com/download"));
            if (lbScreen.Content.ToString() == "COMMAND LINE INTERFACE")
                Process.Start(new ProcessStartInfo("cmd.exe"));
        }
    }
}

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorPicer2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mixxx elemMix = new Mixxx();
        ObservableCollection<Mixxx> mixxxes = new ObservableCollection<Mixxx>();
        public MainWindow()
        {
            InitializeComponent();
            ListB.ItemsSource = mixxxes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isHere(ColBut.Background))
            {
                elemMix = new Mixxx
                {
                    brush = ColBut.Background,
                    nameCol = ColBut.Background.ToString(),
                    index = ColBut.Background.ToString()
                };
                mixxxes.Add(elemMix);
                ListB.ItemsSource = null;
                ListB.Items.Clear();

                foreach (var zminaSiz in mixxxes)
                    zminaSiz.widh = this.Width - 100;

                ListB.ItemsSource = mixxxes;
            }
        }
        private void Check()
        {
            byte memb1 = 0;
            byte memb2 = 0;
            byte memb3 = 0;
            byte memb4 = 0;
            if (CbAlpha.IsChecked == true) memb1 = (byte)SAlpha.Value;
            else memb1 = 0;
            if (CbRed.IsChecked == true) memb2 = (byte)SRed.Value;
            else memb2 = 0;
            if (CbGreen.IsChecked == true) memb3 = (byte)SGreen.Value;
            else memb3 = 0;
            if (CbBlue.IsChecked == true) memb4 = (byte)SBlue.Value;
            else memb4 = 0;
            ColBut.Background = new SolidColorBrush(Color.FromArgb(memb1, memb2, memb3, memb4));
        }
        private void S_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Check();
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Check();
        }
        private bool isHere(Brush brush)
        {
            for (int j = 0; j < mixxxes.Count; j++)
                if (mixxxes[j].brush == brush)
                    return false;
            return true;
        }
        private void Button_DELETE_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            foreach (var item in mixxxes)
            {
                if (btn.Tag.ToString() == item.index)
                {
                    mixxxes.Remove(item);
                    break;
                }
            }
        }
    }
}

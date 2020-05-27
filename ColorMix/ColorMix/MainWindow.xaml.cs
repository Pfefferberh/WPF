using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorMix
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Label> labelsNam = new List<Label>();
        List<Label> labels = new List<Label>();
        int memb = 0;
        public MainWindow()
        {
            InitializeComponent();
            labels.Add(Lb1);
            labels.Add(Lb2);
            labels.Add(Lb3);
            labels.Add(Lb4);
            labels.Add(Lb5);
            labelsNam.Add(LbNam1);
            labelsNam.Add(LbNam2);
            labelsNam.Add(LbNam3);
            labelsNam.Add(LbNam4);
            labelsNam.Add(LbNam5);
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int perevir = labelsNam.Count;
            if (memb == labelsNam.Count)
                memb = 0;
            for (int j = 0; j < labelsNam.Count; j++)
                if (ColBut.Background.ToString() != labelsNam[j].Content.ToString())
                    perevir--;
            if (perevir == 0)
            {
                for (int j = 0; j < labelsNam.Count; j++)
                    if (labelsNam[j].Content.ToString() == "Del")
                    {
                        labels[j].Background = ColBut.Background;
                        labelsNam[j].Content = ColBut.Background.ToString();
                        break;
                    }
                    else if(j == labelsNam.Count-1)
                    {
                        labels[memb].Background = ColBut.Background;
                        labelsNam[memb].Content = ColBut.Background.ToString();
                        memb++;
                    }
            }
        }
        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            Button button= sender as Button;
            button.Tag = "Del";
            button.Background = new SolidColorBrush(Colors.White);
        }
    }
}


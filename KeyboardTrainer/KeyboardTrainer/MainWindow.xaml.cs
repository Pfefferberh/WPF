using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            for(int i=0;i<15;i++)
            OutText.Text += Convert.ToChar(random.Next(97, 122));
            //PreviewKeyDown += MainWindow_PreviewKeyDown;
            // KeyDown += MainWindow_KeyDown;
            PreviewTextInput += TextBlock_PreviewTextInput;
        }

        private void MainWindow_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
          // (sender as Grid).Children[0].GotKeyboardFocus
            //InText.Text +=
            //Klava_row1.Children[0].;


        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //InText.Text += e.;
        }

        private void MainWindow_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
          //  InText.Text += e.;
        }

        private void TextBlock_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            InText.Text += e.Text;
           // InText.Text += ;
            //if ((sender as TextBlock).Text == e.Text)
            //    (sender as TextBlock).Background = new SolidColorBrush(Colors.White);
        }
    }
}
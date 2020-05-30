using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;

namespace pAint_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            ink.DefaultDrawingAttributes.Color = Colors.Red;
            ink.DefaultDrawingAttributes.Width = 10;
            saveFileDialog.Filter = "image (*.str)|*.str";
            openFileDialog.Filter = "image (*.str)|*.str";
            rbInk.IsChecked = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string color = (cbColor.SelectedItem as Label).Content.ToString();
            ink.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(color);
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == true)
                ink.Strokes.Save(new FileStream(saveFileDialog.FileName, FileMode.Create));
        }

        private void Button_Open(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                StrokeCollection strokes = new StrokeCollection(new FileStream(openFileDialog.FileName, FileMode.Open));
                ink.Strokes = strokes;
            }
        }

        private void cbWeight_SelectionChanged(object sender, SelectionChangedEventArgs e) =>
            ink.DefaultDrawingAttributes.Width = cbWeight.SelectedIndex * 5 + 1;

        private void Button_Clear(object sender, RoutedEventArgs e) =>
            ink.Strokes.Clear();

        private void rb_Checked(object sender, RoutedEventArgs e) =>
            ink.EditingMode = InkCanvasEditingMode.Ink;
        private void rbInkAndGesture_Checked(object sender, RoutedEventArgs e) =>
            ink.EditingMode = InkCanvasEditingMode.InkAndGesture;
        private void rbInkGestureOnly_Checked(object sender, RoutedEventArgs e) =>
            ink.EditingMode = InkCanvasEditingMode.GestureOnly;
        private void rbInkEraseByStroke_Checked(object sender, RoutedEventArgs e) =>
            ink.EditingMode = InkCanvasEditingMode.EraseByStroke;
        private void rbInkEraseByPoint_Checked(object sender, RoutedEventArgs e) =>
            ink.EditingMode = InkCanvasEditingMode.EraseByPoint;
        private void rbInkSelect_Checked(object sender, RoutedEventArgs e) =>
            ink.EditingMode = InkCanvasEditingMode.Select;
    }
}
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Media
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double tmpVolum = 0;
        bool ch_Volum = true;
        bool change_position = true;
        bool ch_pos_pause = true;
        public DispatcherTimer timer = new DispatcherTimer();
        ObservableCollection<MediaElement> listView = new ObservableCollection<MediaElement>();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            VolumScr.Maximum = 1;
            VolumScr.Minimum = 0;

            LamTex.ItemsSource = listView;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TextTime.Text = mediaFild1.Position.ToString(@"mm\:ss");

            video_value.Value = mediaFild1.Position.TotalSeconds;
        }

        private void Button_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                mediaFild1.Source = new Uri(openFile.FileName);
                VolumScr.Value = mediaFild1.Volume;
                mediaFild2.Volume = 0;
                mediaFild2.Source = mediaFild1.Source;

            }
        }
        private void MediaFild2_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaFild1.Close();
            mediaFild2.Close();
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            VolumScr.Visibility = Visibility.Visible;
        }

        private void StackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            VolumScr.Visibility = Visibility.Hidden;
        }

        private void Button_Go_Click(object sender, RoutedEventArgs e)
        {
            if (ch_pos_pause)
            {
                mediaFild2.Play();
                mediaFild1.Play();
                timer.Start();
                ch_pos_pause = false;
                imgButt.Source = BitmapFrame.Create(new Uri(@"C:\Users\Рома\Desktop\Step\WPF\Paint\Paint\img\pause.png"));
            }
            else
            {
                mediaFild2.Pause();
                mediaFild1.Pause();
                timer.Stop();
                ch_pos_pause = true;
                imgButt.Source = BitmapFrame.Create(new Uri(@"C:\Users\Рома\Desktop\Step\WPF\Paint\Paint\img\play.png"));
            }
        }

        private void Button_Play_list_Click(object sender, RoutedEventArgs e)
        {
            if (change_position)
            {
                podkast2.Visibility = Visibility.Visible;
                podkast1.Visibility = Visibility.Hidden;
                change_position = false;
            }
            else
            {
                podkast1.Visibility = Visibility.Visible;
                podkast2.Visibility = Visibility.Hidden;
                change_position = true;
            }
        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {
            mediaFild1.Stop();
            mediaFild2.Stop();
            ch_pos_pause = false;
            Button_Go_Click(null, null);
        }

        private void VolumScr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaFild1.Volume = VolumScr.Value;
        }

        private void Button_Mute_Click(object sender, RoutedEventArgs e)
        {
            if (ch_Volum)
            {
                tmpVolum = mediaFild1.Volume;
                mediaFild1.Volume = 0;
                VolumScr.Value = 0;
                ch_Volum = false;
            }
            else
            {
                mediaFild1.Volume = tmpVolum;
                VolumScr.Value = tmpVolum;
                ch_Volum = true;
            }
        }

        private void Button_left_Click(object sender, RoutedEventArgs e)
        {
            mediaFild1.Position -= TimeSpan.FromSeconds(5);
            mediaFild2.Position -= TimeSpan.FromSeconds(5);
        }
        private void Button_right_Click(object sender, RoutedEventArgs e)
        {
            mediaFild1.Position += TimeSpan.FromSeconds(5);
            mediaFild2.Position += TimeSpan.FromSeconds(5);
        }
        private void video_value_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaFild1.Position = TimeSpan.FromSeconds(video_value.Value);
            mediaFild2.Position = TimeSpan.FromSeconds(video_value.Value);
        }

        private void mediaFild1_MediaOpened(object sender, RoutedEventArgs e)
        {
            video_value.Maximum = mediaFild1.NaturalDuration.TimeSpan.TotalSeconds;
            video_value.Maximum = mediaFild2.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                MediaElement ss = new MediaElement();
                ss.Source = new Uri(openFile.FileName);
                ss.Height = 100;
                ss.IsMuted = true;
                ss.LoadedBehavior = MediaState.Play;
                listView.Add(ss);
            }
        }

        private void ListMed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mediaFild1.Source = listView[LamTex.SelectedIndex].Source;
            mediaFild2.Source = listView[LamTex.SelectedIndex].Source;
            mediaFild2.IsMuted = true;
        }
    }
}

using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace EpicQuest_0._1._2
{
    /// <summary>
    /// Interakční logika pro StoryTell1.xaml
    /// </summary>
    public partial class StoryTell1 : Page
    {
        private int increment;

        public StoryTell1()
        {
            InitializeComponent();

            TimeStart();
            

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            increment++;

            Timer.Content = increment;

            if (increment % 10 == 0)
            {
                First.Visibility = Visibility.Hidden;
                Second.Visibility = Visibility.Visible;
            }
        }

        public void TimeStart()
        {
            DispatcherTimer Time = new DispatcherTimer();
            Time.Interval = TimeSpan.FromSeconds(1);
            Time.Tick += Time_Tick;
            Time.Start();
        }
    }
}

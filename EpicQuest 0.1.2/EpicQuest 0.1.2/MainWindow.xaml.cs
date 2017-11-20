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

namespace EpicQuest_0._1._2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void New_Game_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new StoryTell1();

            StoryTell1 Times = new StoryTell1();
            Times.TimeStart();
        }

        private void Endless_Mode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Load_Game_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Game_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

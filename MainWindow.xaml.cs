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

namespace Bowling_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LeagueInfoBTN_Click(object sender, RoutedEventArgs e)
        {
            //This will show the following:
            //-league teams
            //-league bowlers
            //-bowlers averages
            //-league standings
            //-weekly standings
            //-lane pairings
        }

        private void LanesBTN_Click(object sender, RoutedEventArgs e)
        {
            //display what teams are bowling on what lanes for the week
            //select the week you want to view
            //manual edit option 
        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Net_Booking_System
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

        private void Exit_Click(object sender, RoutedEventArgs e) // exit button
        {
            Close(); // close the program
        }

        private void Login_Click(object sender, RoutedEventArgs e) // login button
        {

            // go to login

        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            RegPage Reg = new RegPage();
            this.Content = Reg;
        }

    }
}

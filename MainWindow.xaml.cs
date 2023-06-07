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
//using Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace BoatReservation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void frame1_Navigated(object sender, NavigationEventArgs e)
        {

        }


        private void SubmitLogin_Click(object sender, RoutedEventArgs e)
        {
            /*string username = UsernameField.Text.ToString();
            string password = PasswordField.Password.ToString();

            if (username != "" && password != "")
            {
                if (username.Length >= 6 && password.Length >= 6)
                {
                    connection.Open();
                    Console.WriteLine("Connected");

                    string query = "SELECT * FROM receptionnist";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    var reader = cmd.ExecuteReader();
                    string[] tab = { "", "" };
                    while (reader.Read())
                    {
                        tab[0] = reader.GetString(0);
                        tab[1] = reader.GetString(1);
                    }

                    if (username == tab[0] && password == tab[1])
                    {
                        Home MainTab = new Home();
                        MainTab.Show();
                        this.Close();
                    }else
                    {
                        ErrorLabel.Content = "Wrong username \n or password";
                        UsernameField.Text = "";
                        PasswordField.Password = "";
                    }

                } else {
                    ErrorLabel.Content = "Input's length should be\nover 6 characters.";
                }

            } else {
                ErrorLabel.Content = "Please fill out these fields.";
            }*/

            Home MainTab = new Home();
            MainTab.Show();
            this.Close();
        }

        private void CloseMW_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UsernameField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

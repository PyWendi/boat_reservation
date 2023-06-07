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
using System.Windows.Shapes;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace BoatReservation
{
    /// <summary>
    /// Logique d'interaction pour Boat.xaml
    /// </summary>
    public partial class Boat : Window
    {

        // Setting connection state
        MySqlConnection connection = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");
        public Boat()
        {
            InitializeComponent();
        }

        private void LogoutSection_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tab = new MainWindow();
            tab.Show();
            this.Close();
        }

        private void HomeSection_Click(object sender, RoutedEventArgs e)
        {
            Home tab = new Home();
            tab.Show();
            this.Close();
        }

        private void PassengerSection_Click(object sender, RoutedEventArgs e)
        {
            Enregistrement tab = new Enregistrement();
            tab.Show();
            this.Close();
        }

        private void ReservationSection_Click(object sender, RoutedEventArgs e)
        {
            Reservation tab = new Reservation();
            tab.Show();
            this.Close();
        }

        private void ValidFiltre_Click(object sender, RoutedEventArgs e)
        {
            string search = Search.Text.ToString();
            string filtre = FiltreBox.SelectedItem.ToString();

            string query = "SELECT * FROM receptionnist";

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                var reader = cmd.ExecuteReader();

                string[] tab = { "", "" };
                DataGrid grid = new DataGrid();

                while (reader.Read())
                {
                    tab[0] = reader.GetString(0);
                    tab[1] = reader.GetString(1);
                    //                    grid.Columns.Add("username", typeof(string));

                    // create four columns here with same names as the DataItem's properties
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }
        }


        private void FiltreBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            AddPassenger tab = new AddPassenger();
            tab.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            PassengerDeleteDialog tab = new PassengerDeleteDialog();
            tab.Show();
        }

        private void dataGrid_Initialized(object sender, EventArgs e)
        {

        }

        private void adddata(object sender, EventArgs e)
        {

        }

        /*private void Loaded(object sender, RoutedEventArgs e)
        {

        }*/
    }
}

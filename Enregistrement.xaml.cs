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
using System.Collections.ObjectModel;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace BoatReservation

{
    /// <summary>
    /// Logique d'interaction pour Enregistrement.xaml
    /// </summary>
    public partial class Enregistrement : Window
    {
        // Setting connection state
        MySqlConnection connection = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");
        private ObservableCollection<EnregistrementP> listEnregistrer;
        public Enregistrement()
        {
            InitializeComponent();
            Bindgrid();
        }
        public void Bindgrid()
        {
            MySqlConnection con = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");
            con.Open();
            listEnregistrer = new ObservableCollection<EnregistrementP>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM passager", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                string prenom = reader.GetString(2);
                string email = reader.GetString(3);
                string phone = reader.GetString(4);
                EnregistrementP register = new EnregistrementP { Id = id, Firstname = name, Lastname = prenom, Email = email, Phone = phone };
                listEnregistrer.Add(register);

            }
            reader.Close();
            dataGrid.ItemsSource = listEnregistrer;
            con.Close();


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
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }
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

        private void BoatSection_Click(object sender, RoutedEventArgs e)
        {
            Boat tab = new Boat();
            tab.Show();
            this.Close();
        }

        private void ReservationSection_Click(object sender, RoutedEventArgs e)
        {
            Reservation tab = new Reservation();
            tab.Show();
            this.Close();
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
        public void executeQuery(string query)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            if (dataGrid.SelectedItems != null)
            {
                var ligne = dataGrid.SelectedItems;
                foreach (EnregistrementP data in ligne)
                {
                    MessageBoxResult resutl = MessageBox.Show("Supprimer " + data.Id, "Confirmation", MessageBoxButton.YesNo);
                    if (resutl == MessageBoxResult.Yes)
                    {
                        int id;
                        int.TryParse(data.Id, out id);
                        string query = "DELETE FROM passager WHERE id_pass = " + id;
                        executeQuery(query);
                    }
                    else
                    {

                    }
                }
                Bindgrid();
            }
            //PassengerDeleteDialog tab = new PassengerDeleteDialog();
            //tab.Show();
        }

        private void dataGrid_Initialized(object sender, EventArgs e)
        {

        }

        private void adddata(object sender, EventArgs e)
        {

        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                EnregistrementP selectedRow = (EnregistrementP)dataGrid.SelectedItem;
                var id = selectedRow.Id;
                var firstname = selectedRow.Firstname;
                var lastname = selectedRow.Lastname;
                var email = selectedRow.Email;
                var phone = selectedRow.Phone;
                UpdatePassenger update = new UpdatePassenger();
                update.TextID.Text = id;
                update.FnameField.Text = firstname;
                update.LnameField.Text = lastname;
                update.EmailField.Text = email;
                update.TelField.Text = phone;
                update.Show();
            }
            else
            {
                MessageBox.Show("Veuillex selectionner une liste");
            }
        }
    }
}

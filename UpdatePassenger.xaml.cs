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
using System.Data;
using MySql.Data.MySqlClient;
using BoatReservation;

namespace BoatReservation
{
    /// <summary>
    /// Logique d'interaction pour UpdatePassenger.xaml
    /// </summary>
    public partial class UpdatePassenger : Window
    {
        public UpdatePassenger()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Enregistrement register = new Enregistrement();
            register.Bindgrid();
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");
            connection.Open();
            int id;
            int.TryParse(TextID.Text, out id);
            string query = "UPDATE passager SET nom = '" + FnameField.Text + "', prenom = '" + LnameField.Text + "', tel = '" + TelField.Text + "', email = '" + EmailField.Text + "' WHERE id_pass = " + id;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
                Enregistrement register = new Enregistrement();
                register.Bindgrid();
                this.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

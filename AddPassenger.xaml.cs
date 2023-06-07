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

namespace BoatReservation
{
    /// <summary>
    /// Logique d'interaction pour AddPassenger.xaml
    /// </summary>
    public partial class AddPassenger : Window
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            int num;
            int.TryParse(TelField.Text, out num);
            string query = "INSERT INTO passager(nom,prenom,email,tel) VALUES('" + FnameField.Text + "' , '" + LnameField.Text + "', '" + EmailField.Text + "', " + num + " )";
            Enregistrement register = new Enregistrement();
            register.executeQuery(query);
            register.Bindgrid();
            this.Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BoatReservation
{
    /// <summary>
    /// Logique d'interaction pour Reservation.xaml
    /// </summary>
    public partial class Reservation : Window
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; user=root; port=3306; database=boatreservation; password=");
        private ObservableCollection<ReservationModel> reservationModel;
        public Reservation()
        {
            InitializeComponent();
            BindGrid();            
        }

        //global variable to set tarif price
        string tarif="0";
        string voyage_id = "0";
        string query = "";
        int code_bat = 0;
        bool validate = true;

        public void BindGrid()
        {
            string query = "SELECT v.code_voyage as 'ID de voyage', v.itinéraire as 'Itinéraire', v.date_depart as 'Date de départ', v.durée as 'Durée', v.frais as 'Tarif de base', b.design as 'Bateaux', b.class_a as 'Class A', b.class_b as 'Class B', b.class_c as 'Class C' FROM VOYAGE v JOIN BATEAUX b ON v.code_bat = b.code_bat WHERE v.finitude=0;";

            reservationModel = new ObservableCollection<ReservationModel>();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                var reader = cmd.ExecuteReader();
                
                while(reader.Read())
                {
                    string id_voyage = reader.GetString(0);
                    string itineraire = reader.GetString(1);
                    string depart = reader.GetString(2);
                    string duree = reader.GetString(3);
                    string frais = reader.GetString(4);
                    string bateaux = reader.GetString(5);
                    string classA = reader.GetString(6);
                    string classB = reader.GetString(7);
                    string classC = reader.GetString(8);

                    ReservationModel data = new ReservationModel{ Voyage = id_voyage, Itineraire = itineraire, Depart = depart, Duree = duree, Tarif = frais, Bateaux = bateaux, ClassA = classA, ClassB = classB, ClassC = classC };
                    reservationModel.Add(data);

                }
                 
                reader.Close();
                dataGrid.ItemsSource = reservationModel;
                connection.Close();
            }
            catch (Exception ex)
            {
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

        private void PassengerSection_Click(object sender, RoutedEventArgs e)
        {
            Enregistrement tab = new Enregistrement();
            tab.Show();
            this.Close();
        }






        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tarif == "0" || voyage_id == "0")
            {
                MessageBox.Show("Veuiller selectionner un voyage avant de proceder à un enregistrement");
            } else
            {
                string prenom = PrenomField.Text.ToString();
                string tel = TelField.Text.ToString();

                string id_voyage = VoyageFied.Text.ToString();
                string ca = ClassAField.Text.ToString();
                string cb = ClassBField.Text.ToString();
                string cc = ClassCField.Text.ToString();

                string mode = PayementField.Text.ToString();
                string montant = MontantField.Text.ToString();
                int reste;
                string Reste;

                int ID_voyage, CA, CB, CC, Montant, Somme, frais;

                // verification about number of class taken
                if (ca=="0" && cb=="0" && cc=="0")
                {
                    MessageBox.Show("Veuiller selectionner au moin une place de classe !!");
                }
                else
                {
                    // Conversion
                    int.TryParse(id_voyage, out ID_voyage);
                    int.TryParse(ca, out CA);
                    int.TryParse(cb, out CB);
                    int.TryParse(cc, out CC);
                    int.TryParse(tarif, out frais);
                    int.TryParse(montant, out Montant);

                    // My int vars : ID_voyage, CA, CB, CC, Montant, frais de base

                    /* Setting the operations */

                    CA = (frais + 50000) * CA;
                    CB = (frais + 20000) * CB;
                    CC = frais * CC;

                    Somme = CA + CB + CC;
                    reste = Somme - Montant;

                    Reste = "" + reste;
                    RestField.Text = Reste;
                    DueField.Text = "" + Somme;


                    MessageBoxResult resutl = MessageBox.Show("Les informations concernant les montants sont-elles correctes ", "Confirmation", MessageBoxButton.YesNo);

                    if (resutl == MessageBoxResult.Yes)
                    {
                        //string query;
                        /* Setting query depenting on the payement mode */
                        if (mode == "TP")
                        {
                            if (Montant == Somme)
                            {
                                query = "INSERT INTO reservation (id_voyage,class_A,class_B,class_C,prenom,numero,payement,somme_paye,reste_paye, fini) VALUES("+id_voyage+","+ca+","+cb+","+cc+",'"+prenom+"','"+tel+"','"+mode+"',"+Somme+","+reste+",1)";
                            }
                            else
                            {
                                validate = false;
                                MessageBox.Show("Veuiller vérifier les valeurs insérer dans les différents champs de payement !");
                            }
                        }
                        else if (mode == "AA")
                        {
                            query = "INSERT INTO reservation (id_voyage,class_A,class_B,class_C,prenom,numero,payement,somme_paye,reste_paye, fini) VALUES(" + id_voyage + "," + ca + "," + cb + "," + cc + ",'" + prenom + "','" + tel + "','" + mode + "'," + Somme + "," + reste + ",0)";

                        }
                        else if (mode == "SA")
                        {
                            query = "INSERT INTO reservation (id_voyage,class_A,class_B,class_C,prenom,numero,payement,somme_paye,reste_paye, fini) VALUES(" + id_voyage + "," + ca + "," + cb + "," + cc + ",'" + prenom + "','" + tel + "','" + mode + "',0," + reste + ",0)";
                        }

                        if (validate)
                        {
                            //Inserting data into database
                            try
                            {
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

                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                                throw ex;
                            }

                            query = "SELECT code_bat FROM voyage WHERE code_voyage=" + voyage_id + ";";
                            try
                            {
                                connection.Open();
                                MySqlCommand cmd = new MySqlCommand(query, connection);
                                var reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    code_bat = reader.GetInt32(0);
                                }
                                reader.Close();
                                connection.Close();
                            }
                            catch (MySqlException ex)
                            {
                                Console.WriteLine(ex);
                                throw ex;
                            }

                            query = "UPDATE bateaux SET class_a=(class_a-" + ca + "), class_b=(class_b-" + cb + "), class_c=(class_c-" + cc + ") WHERE code_bat=" + code_bat + ";";

                            try
                            {
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
                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                                throw ex;
                            }


                            query = "";

                            MessageBox.Show("Réservation effectuer avec succès !!");
                            PrenomField.Text = "";
                            TelField.Text = "";
                            ClassAField.Text = "0";
                            ClassBField.Text = "0";
                            ClassCField.Text = "0";
                            MontantField.Text = "0";
                            RestField.Text = "0";
                            DueField.Text = "0";
                            BindGrid();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Corriger l'erreur correspondant");
                    }
                }
            }

            validate = true;
            
        }


        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReservationModel selectedRow = (ReservationModel)dataGrid.SelectedItem;
            int CA;
            tarif = selectedRow.Tarif;
            voyage_id = selectedRow.Voyage;

            int.TryParse(tarif, out CA);

            labelA.Content = "" + (CA + 50000);
            labelB.Content = "" + (CA + 20000);
            labelC.Content = "" + CA;
            VoyageFied.Text = voyage_id;
        }
    }
}

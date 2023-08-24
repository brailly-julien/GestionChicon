using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//utilisation de la librairie MY SQL
using MySql.Data.MySqlClient;


namespace GestionChicon
{

    public partial class Gestion_Chicon : Form
    {
       bool Connecté = false; //varaible connecté pour tester la connection
       MySqlConnection connection = null ;

        static public string LireConfig()
        {
            string s;
            //string path = @"C:\Users\jujub\OneDrive\Bureau\Travail\BTS snir 2\Projet\programme gestion chicon\configSql.txt";
            string path = Application.ExecutablePath; //renvoie le répertoire ou se trouve l'executable
            path = Directory.GetParent(path).ToString(); // Tu arrives dans le répertoire bin\debug
            path = Directory.GetParent(path).ToString(); // Tu arrives dans le répertoire de bin
            path = Directory.GetParent(path).ToString(); // Tu arrives dans le répertoire de l'application
            path = path + @"\Resources\configSql.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                s = sr.ReadLine();
            }
            return s; 
        }
        //MySqlConnection connection = new MySqlConnection("database=chicon; server=172.16.202.30; user id=chicon; pwd=BTSbts22;");
        //MySqlConnection connection = new MySqlConnection("database=chicon; server=localhost; user id=root; pwd=;");// entrer en connection avec le serveur
        public Gestion_Chicon()
        {
            InitializeComponent();
            string infosSql = LireConfig();
            connection = new MySqlConnection(infosSql);// entrer en connection avec le serveur
            try
            {
                connection.Open();// ouvrire la connection
                MessageBox.Show("Vous êtes connecté à la base de données");// pop up disant l'ouvertur de la connection si aucune erreur
                Connecté = true;// la variable connecté est valide
            }
            catch (MySqlException co) // en cas derreur 
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Vous n'êtes pas connecté à la base de données"); // envoyer un pop up diuant que la connection n'est pas etablie
            }

            if (Connecté) //teste de la connection si elle est valide
            {
                listView1.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM course", connection);//pour une entrer un commande sql 
                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string ID = Lire["idCourse"].ToString();
                        string Nom = Lire["nomCourse"].ToString();
                        string distance = Lire["distance"].ToString();
                        string date = Lire["dateCourse"].ToString();
                        string etat = Lire["etatCourse"].ToString();
                        listView1.Items.Add(new ListViewItem(new[] { ID, Nom, distance, date, etat }));
                    }
                }
            }
        }

        //----------------------------------passage sur un autre ecran------------------------------------------
        private void Btnewcourse_Click(object sender, EventArgs e)
        {
            new Creation_de_course().Show();
            this.Hide();
        }

        private void Bt_participants_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem element = listView1.SelectedItems[0];
                string course_ID;                
                new Gestion_Participants(course_ID = element.SubItems[0].Text).Show();
                //this.Close();
            }
            else { MessageBox.Show("Selectionner une course"); }
        }

        //--------------------------Menustript-------------------------------------
        private void SuprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem element = listView1.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM participant WHERE idCourse=@Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("DELETE FROM course WHERE idCourse=@Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    element.Remove();
                    MessageBox.Show("Supprimer");
                }
            }
        }
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Connecté)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem element = listView1.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    string Etat = element.SubItems[4].Text;

                    using (Etat_de_la_course modif = new Etat_de_la_course())
                    {
                        modif.Etat = Etat;
                        if (modif.ShowDialog() == DialogResult.Yes)
                        {
                            MySqlCommand cmd = new MySqlCommand("UPDATE course SET etatCourse=@Etat Where idCourse=@Id", connection);
                            cmd.Parameters.AddWithValue("@Etat", modif.Etat);
                            cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.ExecuteNonQuery();
                            element.SubItems[4].Text = modif.Etat;
                        }
                    }                      
                }
            }
        }
    }
}

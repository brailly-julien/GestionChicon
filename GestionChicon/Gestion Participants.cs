using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionChicon
{
    public partial class Gestion_Participants : Form
    {
        MySqlConnection connection;
        bool Connecté = false; //varaible connecté pour tester la connection

        public Gestion_Participants( string course_ID)
        {
            InitializeComponent();
            txt_IDCourse.Text = course_ID;
            string infosSql = Gestion_Chicon.LireConfig();
            connection = new MySqlConnection(infosSql);
        }
                
        //MySqlConnection connection = new MySqlConnection("database=chicon; server=localhost; user id=root; pwd=;");// entrer en connection avec le serveur
        private void Affichage_Des_Participant()
        {
            //----------------------------connection a la base de donnée--------------------------------------------
            try
            {
                connection.Open();// ouvrir la connection
                Connecté = true;// la variable connectée est valide
            }
            catch (MySqlException co) // en cas derreur 
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Vous n'êtes pas connecté à la base de données"); // envoyer un pop up diuant que la connection n'est pas etablie
            }
            //----------------------------------------------------------------------------------------

            int k = Convert.ToInt32(txt_IDCourse.Text);//recuiperation de la variable contenue dans le txt box elle va servire pour afficher les bon participant

            if (Connecté) //teste de la connection si elle est valide
            {
                listView1.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Participant WHERE  idCourse = " + k, connection);//pour une entrer un commande sql ici afficher les participant
                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string idParticipant = Lire["idParticipant"].ToString();
                        string idCourse = Lire["idCourse"].ToString();
                        string nom = Lire["nom"].ToString();
                        string prenom = Lire["prenom"].ToString();
                        string mail = Lire["mail"].ToString();
                        string mdp = Lire["mdp"].ToString();
                        string datenaissance = Lire["datenaissance"].ToString();
                        string adresse = Lire["adresse"].ToString();
                        string codepostal = Lire["codepostal"].ToString();
                        string ville = Lire["ville"].ToString();
                        string sexe = Lire["sexe"].ToString();
                        string club = Lire["club"].ToString();
                        string licence = Lire["licence"].ToString();
                        string RFID = Lire["RFID"].ToString();
                        string dossard = Lire["dossard"].ToString();
                        string temps = Lire["temps"].ToString();
                        string cheque = Lire["cheque"].ToString();
                        string CM = Lire["CM"].ToString();

                        listView1.Items.Add(new ListViewItem(new[] { idParticipant, nom, prenom, cheque, CM, mail, mdp, datenaissance, adresse, codepostal, ville, sexe, club, licence, RFID, dossard, temps, cheque, CM }));
                    }
                }
                connection.Close();     // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!      
            }
            else { MessageBox.Show("Vous n'êtes pas connecté à la base de données"); }//si on n'est pas connecter a la base de donnée

        }
        //--------------------------------------Appel methode de l'affichage---------------------------
        private void Bt_Affichage_Click(object sender, EventArgs e)
        {
            this.Affichage_Des_Participant();
        }
        private void Txt_IDCourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Affichage_Des_Participant();
            }
        }

        //----------------------------------supression d'un participant------------------------------------
        private void SuprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {connection.Open();
            if (Connecté)
            {
                if (listView1.SelectedItems.Count>0)
                {
                    ListViewItem element = listView1.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Participant WHERE idParticipant=@Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    element.Remove();
                    MessageBox.Show("Supprimer");
                }
            }
            connection.Close();
        }
        //------------------------------cheque et certificat ok pour le participant -------------------------
        private void ChequeOKToolStripMenuItem_Click(object sender, EventArgs e)
        {connection.Open();
            if (Connecté)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem element = listView1.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    string cheque = element.SubItems[3].Text;
                    MySqlCommand cmd = new MySqlCommand("UPDATE Participant SET cheque=@cheque WHERE idParticipant=@Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cheque = "1";
                    /*if (cheque == "1")
                    {
                        cheque = "0";
                    }
                    else
                    {
                        cheque = "1";
                    }*/
                    cmd.Parameters.AddWithValue("@cheque", int.Parse(cheque));
                    cmd.ExecuteNonQuery();
                    element.SubItems[3].Text = cheque;
                    //MessageBox.Show("bien envoyer");
                }
            }
            connection.Close();   
        }
        private void CertificatOKToolStripMenuItem_Click(object sender, EventArgs e)
        {connection.Open();
            if (Connecté)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem element = listView1.SelectedItems[0];
                    string Id = element.SubItems[0].Text;
                    string CM = element.SubItems[4].Text;
                    MySqlCommand cmd = new MySqlCommand("UPDATE Participant SET CM=@CM WHERE idParticipant=@Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    CM = "1";
                    /*if (CM == "0")
                    {
                        CM = "1";
                    }
                    else
                    {
                        CM = "0";
                    }*/
                    cmd.Parameters.AddWithValue("@CM", int.Parse(CM));
                    cmd.ExecuteNonQuery();
                    element.SubItems[4].Text = CM;
                    //MessageBox.Show("Supprimer");
                }
            }
            connection.Close();
        }
        //--------------------------------------------------------------------------------------------------
        private void ImprimerDossardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem element = listView1.SelectedItems[0];
            string recup_dossard = element.SubItems[15].Text;
            new impression(recup_dossard).Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Gestion_Chicon().Show();
            this.Hide();
        }
        private void Bt_dernieremin_Click(object sender, EventArgs e)
        {
            string course_ID;
            new Participants_de_dernière_minute(course_ID = txt_IDCourse.Text).Show();
            this.Hide();
        }
        //------------------------------txt box Clear--------------------------
        private void Txt_IDCourse_Click(object sender, EventArgs e)
        {
            txt_IDCourse.Clear();//effece mon txtbox des que je clique dessus
        }
    }
}

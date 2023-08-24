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
    public partial class Participants_de_dernière_minute : Form
    {
        bool Connecté = false; //varaible connecté pour tester la connection
        string infosSql = Gestion_Chicon.LireConfig();

        public Participants_de_dernière_minute( string course_ID)
        {
            InitializeComponent();
            txt_IDcourse.Text = course_ID;
        }

        private void Bt_creationparticipant_Click(object sender, EventArgs e)
        {                        
            MySqlConnection connection = new MySqlConnection(infosSql);
            try
            {
                connection.Open();// ouvrire la connection
                Connecté = true;// la variable connecté est valide
            }
            catch (MySqlException co) // en cas derreur 
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Vous n'êtes pas connecté à la base de données"); // envoyer un pop up diuant que la connection n'est pas etablie
            }

                                 
            if (txt_nom.Text == "" || txt_prenom.Text == "" || txt_adresse.Text == "" || txt_mail.Text == "" || txt_mdp.Text == "" || txt_codepostal.Text == "" || genre == "" ||txt_ville.Text == "")
            {
                MessageBox.Show("Inscription non complète, verifiez les champs");
            }else
            { 
                int k = Convert.ToInt32(txt_IDcourse.Text);//recuiperation de la variable contenue dans le txt box de la course   
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Participant (idcourse,nom,prenom,mail,mdp,datenaissance,adresse,codepostal,ville,sexe,club,licence,dossard,RFID,cheque,CM) VALUES("+ k +",@nom,@prenom,@mail,@mdp,@datenaissance,@adresse,@codepostal,@ville,@sexe,@club,@licence,@dossard,@RFID,@cheque,@CM);", connection);//ajout de comande base de donnee
                cmd.Parameters.AddWithValue("@idCourse",int.Parse(txt_IDcourse.Text));
                cmd.Parameters.AddWithValue("@nom", txt_nom.Text);//ajouter avec valeur
                cmd.Parameters.AddWithValue("@prenom", txt_prenom.Text);//ajouter avec valeur
                cmd.Parameters.AddWithValue("@mail", txt_mail.Text);//ajouter avec valeur         
                cmd.Parameters.AddWithValue("@mdp", txt_mdp.Text);
                cmd.Parameters.AddWithValue("@datenaissance", Calendar.SelectionRange.Start.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@adresse", txt_adresse.Text);
                cmd.Parameters.AddWithValue("@codepostal", int.Parse(txt_codepostal.Text));
                cmd.Parameters.AddWithValue("@ville", txt_ville.Text);
                cmd.Parameters.AddWithValue("@sexe", genre);//j'utilise des radio boutton pour connaitre le sexe.
                string club, licence;//avant de demander leur club je verifie qu'ils en ont bien un avec un check box
                if(box_club.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@club", txt_club.Text);
                    cmd.Parameters.AddWithValue("@licence", txt_licence.Text);
                 } else
                 {
                    club = "0";
                    licence = "0";
                    cmd.Parameters.AddWithValue("@club", club);
                    cmd.Parameters.AddWithValue("@licence", licence);
                }
                cmd.Parameters.AddWithValue("@dossard", int.Parse(txt_dossard.Text));
                cmd.Parameters.AddWithValue("@RFID", int.Parse(txt_rfid.Text));
                string cheque;
                if (CheckBox_cheque.Checked==true)
                {
                    cheque = "1";
                 }else
                 {
                    cheque = "0";
                }
                cmd.Parameters.AddWithValue("@cheque",int.Parse(cheque));
                string CM;
                if(CheckBox_CM.Checked==true)
                {
                    CM = "1";
                }
                else
                {
                    CM = "0";
                }
                cmd.Parameters.AddWithValue("@CM",int.Parse(CM));
                cmd.ExecuteNonQuery();//pour executer la comande
                cmd.Parameters.Clear();// pour vider les parametre
                MessageBox.Show("Le participant peut participer");

                new Gestion_Participants(txt_IDcourse.Text).Show();
                this.Close();
                connection.Close();
            }//envoyer tout les txtbox dans la base de donnee
        }

        //-----------------------CheckBox-----------------------------------------
        private void Box_club_CheckedChanged(object sender, EventArgs e)
        {
            if (box_club.Checked == true)
            {
                txt_club.Visible = true;
                txt_licence.Visible = true;
            }
            else
            {
                if (box_club.Checked == false)
                {
                    txt_club.Visible = false;
                    txt_licence.Visible = false;
                }
            }
        }
        //------------------------RadioButton---------------------------------------
        string genre;
        private void RadioHomme_CheckedChanged(object sender, EventArgs e)
        {
            genre = "Homme";
        }
        private void RadioFemme_CheckedChanged_1(object sender, EventArgs e)
        {
            genre = "Femme";
        }
        //---------------------textBox.clear------------------------------------------
        private void Txt_IDcourse_Click(object sender, EventArgs e)
        {
            txt_IDcourse.Clear();
        }
        private void Txt_nom_Click(object sender, EventArgs e)
        {
            txt_nom.Clear();
        }
        private void Txt_prenom_Click(object sender, EventArgs e)
        {
            txt_prenom.Clear();
        }
        private void Txt_mail_Click(object sender, EventArgs e)
        {
            txt_mail.Clear();
        }
        private void Txt_mdp_Click(object sender, EventArgs e)
        {
            txt_mdp.Clear();
        }
        private void Txt_adresse_Click(object sender, EventArgs e)
        {
            txt_adresse.Clear();
        }
        private void Txt_ville_Click(object sender, EventArgs e)
        {
            txt_ville.Clear();
        }
        private void Txt_codepostal_Click(object sender, EventArgs e)
        {
            txt_codepostal.Clear();
        }
        private void Txt_club_Click(object sender, EventArgs e)
        {
            txt_club.Clear();
        }
        private void Txt_licence_Click(object sender, EventArgs e)
        {
            txt_licence.Clear();
        }
        private void Txt_dossard_Click(object sender, EventArgs e)
        {
            txt_dossard.Clear();
        }
         private void Txt_rfid_Click(object sender, EventArgs e)
        {
            txt_rfid.Clear();
        }
        //------------------------------------------------------------------------------

        private void Participants_de_dernière_minute_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'chiconDataSet.participant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.participantTableAdapter.Fill(this.chiconDataSet.participant);
        }


        private void Bt_impression_Click(object sender, EventArgs e)
        {
            string recup_dossard;
            new impression( recup_dossard=txt_dossard.Text).Show();
            //this.Hide();
        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            string course_ID;
            new Gestion_Participants(course_ID = txt_IDcourse.Text).Show();
            this.Close();
        }
    }

}

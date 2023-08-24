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
    public partial class Creation_de_course : Form
    {
        //MySqlConnection connection;
        string infosSql = Gestion_Chicon.LireConfig(); 
        bool Connecté = false; //varaible connecté pour tester la connection
        public Creation_de_course()
        {
            InitializeComponent();
        }

 

        private void BtValidation_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(infosSql);// entrer en connection avec le serveur
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
            if (txt_nom_de_course.Text == ""|| calandrier.ToString() == "" )
            {
                MessageBox.Show("Completez correctement tous les champs");
            } else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO course (nomCourse,distance,dateCourse,etatCourse) VALUES(@nomCourse,@distance,@dateCourse,@etatCourse);", connection);//ajout de comande base de donnee
                cmd.Parameters.AddWithValue("@nomCourse", txt_nom_de_course.Text);//ajouter avec valeur
                if (radioButton500m.Checked) { cmd.Parameters.AddWithValue("@distance", radioButton500m.Text); } else if (radioButton1000m.Checked) { cmd.Parameters.AddWithValue("@distance", radioButton1000m.Text); } else { cmd.Parameters.AddWithValue("@distance", radioButton1500m.Text); }
                cmd.Parameters.AddWithValue("@dateCourse", calandrier.SelectionRange.Start.ToString("yyyy-MM-dd-") + dateTime.Value.ToString("HH-mm"));
                cmd.Parameters.AddWithValue("@etatCourse",lbl_etat.Text);
                cmd.ExecuteNonQuery();//pour executer la comande
                cmd.Parameters.Clear();// pour vider les parametre
                MessageBox.Show("La course est créée.");
            }
            /*course1 = new course(25, 200);
            this.Controls.Add(course1);*/
            new Gestion_Chicon().Show();
            this.Close();

        }

        private void Bt_Annuler_Click(object sender, EventArgs e)
        {
            new Gestion_Chicon().Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionChicon
{
    public partial class Etat_de_la_course : Form
    {
        public string Etat { get { return changement; } set { changement = value; } }
        string changement;
        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            changement = "En attente d'ouverture des inscriptions";
        }
        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            changement = "Ouverture des inscriptions";
        }
        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            changement = "Les inscriptions pour la course sont terminées";
        }
        private void Radio4_CheckedChanged(object sender, EventArgs e)
        {
            changement = "Course en cours";
        }
        private void Radio5_CheckedChanged(object sender, EventArgs e)
        {
            changement = "Course terminée";
        }

        public Etat_de_la_course()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
        private void Etat_de_la_course_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'etatCourse_chicon.course'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.courseTableAdapter.Fill(this.etatCourse_chicon.course);
        }     
    }
}

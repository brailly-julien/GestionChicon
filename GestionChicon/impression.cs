using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionChicon
{
    public partial class impression : Form
    {
        //private object printDocument;

        public impression(string recuperation_dossard)
        {
            InitializeComponent();
            richTextBox1.Text = recuperation_dossard;

            pageSetupDialog1.PageSettings.Landscape = true;//mettre le format de la page en paysage
            PaperSize A5 = new PaperSize("A5", 583,826);//creation de la taille du papier en pouce ( jai utiliser la dimanssion de l'image
            pageSetupDialog1.PageSettings.PaperSize = A5;// apelle de la taille creer 
            pageSetupDialog1.PageSettings.PaperSize.RawKind = 11;//mettre dans la pagesetup la taille en A5 automatiquement
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Image.FromFile("Dossard.png"), 0, 0);//le format de limage est mis en 21*14.8 soit le format A5
            e.Graphics.DrawString(richTextBox1.Text, new Font("Tahoma", 200), Brushes.Black, 130, 230);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            /*pageSetupDialog1.PageSettings.PaperSize.Height = 148;
            pageSetupDialog1.PageSettings.PaperSize.Width = 210;
            //pageSetupDialog1.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = 11;*/
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {   
            
            printPreviewDialog1.ShowDialog();
        }

        private void Bt_teste_impression_Click(object sender, EventArgs e)
        {
            
            printDialog1.ShowDialog();  
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {   
        }
    }
}

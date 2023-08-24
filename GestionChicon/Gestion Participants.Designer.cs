namespace GestionChicon
{
    partial class Gestion_Participants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Participants));
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bt_dernieremin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idParticipant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cheque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mdp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datenaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codepostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.club = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RFID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dossard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificatOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerDossardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_IDCourse = new System.Windows.Forms.TextBox();
            this.participantTableAdapter1 = new GestionChicon.chiconDataSet1TableAdapters.participantTableAdapter();
            this.bt_Affichage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gérer les participants de la course : ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(650, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Revenir à l\'accueil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // bt_dernieremin
            // 
            this.bt_dernieremin.Location = new System.Drawing.Point(439, 425);
            this.bt_dernieremin.Name = "bt_dernieremin";
            this.bt_dernieremin.Size = new System.Drawing.Size(177, 52);
            this.bt_dernieremin.TabIndex = 8;
            this.bt_dernieremin.Text = "Créer un participant de dernière minute";
            this.bt_dernieremin.UseVisualStyleBackColor = true;
            this.bt_dernieremin.Click += new System.EventHandler(this.Bt_dernieremin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 320);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tous les participants";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idParticipant,
            this.nom,
            this.prenom,
            this.cheque,
            this.CM,
            this.mail,
            this.mdp,
            this.datenaissance,
            this.adresse,
            this.codepostal,
            this.ville,
            this.sexe,
            this.club,
            this.licence,
            this.RFID,
            this.dossard,
            this.temps});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1313, 293);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idParticipant
            // 
            this.idParticipant.Text = "ID Participant";
            this.idParticipant.Width = 92;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nom.Width = 78;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prenom.Width = 87;
            // 
            // cheque
            // 
            this.cheque.Text = "Chèque";
            this.cheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cheque.Width = 114;
            // 
            // CM
            // 
            this.CM.Text = "Certificat";
            this.CM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CM.Width = 111;
            // 
            // mail
            // 
            this.mail.Text = " Mail";
            this.mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mail.Width = 130;
            // 
            // mdp
            // 
            this.mdp.Text = "Mot de passe";
            this.mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mdp.Width = 81;
            // 
            // datenaissance
            // 
            this.datenaissance.Text = "Date de naissance";
            this.datenaissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datenaissance.Width = 97;
            // 
            // adresse
            // 
            this.adresse.Text = "Adresse";
            this.adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adresse.Width = 103;
            // 
            // codepostal
            // 
            this.codepostal.Text = "Code postal";
            this.codepostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codepostal.Width = 64;
            // 
            // ville
            // 
            this.ville.Text = "Ville";
            this.ville.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ville.Width = 83;
            // 
            // sexe
            // 
            this.sexe.Text = "Sexe";
            this.sexe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // club
            // 
            this.club.Text = "Club";
            this.club.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // licence
            // 
            this.licence.Text = "Licence";
            this.licence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licence.Width = 81;
            // 
            // RFID
            // 
            this.RFID.Text = "RFID";
            this.RFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RFID.Width = 83;
            // 
            // dossard
            // 
            this.dossard.Text = "Dossard";
            this.dossard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temps
            // 
            this.temps.Text = "Temps";
            this.temps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temps.Width = 82;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suprimerToolStripMenuItem,
            this.chequeOKToolStripMenuItem,
            this.certificatOKToolStripMenuItem,
            this.imprimerDossardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 100);
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            this.suprimerToolStripMenuItem.Click += new System.EventHandler(this.SuprimerToolStripMenuItem_Click);
            // 
            // chequeOKToolStripMenuItem
            // 
            this.chequeOKToolStripMenuItem.Name = "chequeOKToolStripMenuItem";
            this.chequeOKToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.chequeOKToolStripMenuItem.Text = "cheque OK";
            this.chequeOKToolStripMenuItem.Click += new System.EventHandler(this.ChequeOKToolStripMenuItem_Click);
            // 
            // certificatOKToolStripMenuItem
            // 
            this.certificatOKToolStripMenuItem.Name = "certificatOKToolStripMenuItem";
            this.certificatOKToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.certificatOKToolStripMenuItem.Text = "certificat OK";
            this.certificatOKToolStripMenuItem.Click += new System.EventHandler(this.CertificatOKToolStripMenuItem_Click);
            // 
            // imprimerDossardToolStripMenuItem
            // 
            this.imprimerDossardToolStripMenuItem.Name = "imprimerDossardToolStripMenuItem";
            this.imprimerDossardToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.imprimerDossardToolStripMenuItem.Text = "Imprimer dossard";
            this.imprimerDossardToolStripMenuItem.Click += new System.EventHandler(this.ImprimerDossardToolStripMenuItem_Click);
            // 
            // txt_IDCourse
            // 
            this.txt_IDCourse.Location = new System.Drawing.Point(619, 12);
            this.txt_IDCourse.Name = "txt_IDCourse";
            this.txt_IDCourse.Size = new System.Drawing.Size(116, 22);
            this.txt_IDCourse.TabIndex = 0;
            this.txt_IDCourse.Text = "IDCourse";
            this.txt_IDCourse.Click += new System.EventHandler(this.Txt_IDCourse_Click);
            this.txt_IDCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_IDCourse_KeyDown);
            // 
            // participantTableAdapter1
            // 
            this.participantTableAdapter1.ClearBeforeFill = true;
            // 
            // bt_Affichage
            // 
            this.bt_Affichage.Location = new System.Drawing.Point(449, 51);
            this.bt_Affichage.Name = "bt_Affichage";
            this.bt_Affichage.Size = new System.Drawing.Size(185, 32);
            this.bt_Affichage.TabIndex = 1;
            this.bt_Affichage.Text = "Afficher les participants";
            this.bt_Affichage.UseVisualStyleBackColor = true;
            this.bt_Affichage.Click += new System.EventHandler(this.Bt_Affichage_Click);
            // 
            // Gestion_Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 503);
            this.Controls.Add(this.bt_Affichage);
            this.Controls.Add(this.txt_IDCourse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_dernieremin);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_Participants";
            this.Text = "Gestion_Participants";
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bt_dernieremin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idParticipant;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader cheque;
        private System.Windows.Forms.ColumnHeader CM;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader mdp;
        private System.Windows.Forms.ColumnHeader datenaissance;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader codepostal;
        private System.Windows.Forms.ColumnHeader ville;
        private System.Windows.Forms.ColumnHeader sexe;
        private System.Windows.Forms.ColumnHeader club;
        private System.Windows.Forms.ColumnHeader licence;
        private System.Windows.Forms.ColumnHeader RFID;
        private System.Windows.Forms.ColumnHeader dossard;
        private System.Windows.Forms.ColumnHeader temps;
        private System.Windows.Forms.TextBox txt_IDCourse;
        private chiconDataSet1TableAdapters.participantTableAdapter participantTableAdapter1;
        private System.Windows.Forms.Button bt_Affichage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificatOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerDossardToolStripMenuItem;
    }
}
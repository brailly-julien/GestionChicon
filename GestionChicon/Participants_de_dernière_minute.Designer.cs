namespace GestionChicon
{
    partial class Participants_de_dernière_minute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participants_de_dernière_minute));
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_codepostal = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_club = new System.Windows.Forms.TextBox();
            this.txt_licence = new System.Windows.Forms.TextBox();
            this.bt_creationparticipant = new System.Windows.Forms.Button();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiconDataSet = new GestionChicon.chiconDataSet();
            this.participantTableAdapter = new GestionChicon.chiconDataSetTableAdapters.participantTableAdapter();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.txt_IDcourse = new System.Windows.Forms.TextBox();
            this.txt_dossard = new System.Windows.Forms.TextBox();
            this.txt_rfid = new System.Windows.Forms.TextBox();
            this.CheckBox_cheque = new System.Windows.Forms.CheckBox();
            this.CheckBox_CM = new System.Windows.Forms.CheckBox();
            this.box_club = new System.Windows.Forms.CheckBox();
            this.radioHomme = new System.Windows.Forms.RadioButton();
            this.radioFemme = new System.Windows.Forms.RadioButton();
            this.bt_impression = new System.Windows.Forms.Button();
            this.bt_Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Club :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Date de naissance :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(367, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Création d\'un participant de dernière minute à la course :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(66, 91);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 22);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.Text = "Nom";
            this.txt_nom.Click += new System.EventHandler(this.Txt_nom_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(217, 89);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 22);
            this.txt_prenom.TabIndex = 2;
            this.txt_prenom.Text = "Prénom";
            this.txt_prenom.Click += new System.EventHandler(this.Txt_prenom_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(98, 158);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(177, 22);
            this.txt_mail.TabIndex = 3;
            this.txt_mail.Text = "Adresse e-mail";
            this.txt_mail.Click += new System.EventHandler(this.Txt_mail_Click);
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(98, 252);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(146, 22);
            this.txt_mdp.TabIndex = 5;
            this.txt_mdp.Text = "Mot de passe";
            this.txt_mdp.Click += new System.EventHandler(this.Txt_mdp_Click);
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(65, 320);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(177, 22);
            this.txt_adresse.TabIndex = 6;
            this.txt_adresse.Text = "Adresse";
            this.txt_adresse.Click += new System.EventHandler(this.Txt_adresse_Click);
            // 
            // txt_codepostal
            // 
            this.txt_codepostal.Location = new System.Drawing.Point(406, 320);
            this.txt_codepostal.Name = "txt_codepostal";
            this.txt_codepostal.Size = new System.Drawing.Size(117, 22);
            this.txt_codepostal.TabIndex = 8;
            this.txt_codepostal.Text = "Code postal";
            this.txt_codepostal.Click += new System.EventHandler(this.Txt_codepostal_Click);
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(268, 320);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(100, 22);
            this.txt_ville.TabIndex = 7;
            this.txt_ville.Text = "Ville";
            this.txt_ville.Click += new System.EventHandler(this.Txt_ville_Click);
            // 
            // txt_club
            // 
            this.txt_club.Location = new System.Drawing.Point(66, 379);
            this.txt_club.Name = "txt_club";
            this.txt_club.Size = new System.Drawing.Size(100, 22);
            this.txt_club.TabIndex = 14;
            this.txt_club.Text = "Nom du club";
            this.txt_club.Visible = false;
            this.txt_club.Click += new System.EventHandler(this.Txt_club_Click);
            // 
            // txt_licence
            // 
            this.txt_licence.Location = new System.Drawing.Point(207, 379);
            this.txt_licence.Name = "txt_licence";
            this.txt_licence.Size = new System.Drawing.Size(100, 22);
            this.txt_licence.TabIndex = 15;
            this.txt_licence.Text = "Licence";
            this.txt_licence.Visible = false;
            this.txt_licence.Click += new System.EventHandler(this.Txt_licence_Click);
            // 
            // bt_creationparticipant
            // 
            this.bt_creationparticipant.Location = new System.Drawing.Point(192, 429);
            this.bt_creationparticipant.Name = "bt_creationparticipant";
            this.bt_creationparticipant.Size = new System.Drawing.Size(138, 37);
            this.bt_creationparticipant.TabIndex = 17;
            this.bt_creationparticipant.Text = "Créer le participant";
            this.bt_creationparticipant.UseVisualStyleBackColor = true;
            this.bt_creationparticipant.Click += new System.EventHandler(this.Bt_creationparticipant_Click);
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataMember = "participant";
            this.participantBindingSource.DataSource = this.chiconDataSet;
            // 
            // chiconDataSet
            // 
            this.chiconDataSet.DataSetName = "chiconDataSet";
            this.chiconDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantTableAdapter
            // 
            this.participantTableAdapter.ClearBeforeFill = true;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(348, 85);
            this.Calendar.MaxDate = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 16;
            // 
            // txt_IDcourse
            // 
            this.txt_IDcourse.Location = new System.Drawing.Point(460, 18);
            this.txt_IDcourse.Name = "txt_IDcourse";
            this.txt_IDcourse.Size = new System.Drawing.Size(100, 22);
            this.txt_IDcourse.TabIndex = 0;
            this.txt_IDcourse.Text = "IDcourse";
            this.txt_IDcourse.Click += new System.EventHandler(this.Txt_IDcourse_Click);
            // 
            // txt_dossard
            // 
            this.txt_dossard.Location = new System.Drawing.Point(348, 378);
            this.txt_dossard.Name = "txt_dossard";
            this.txt_dossard.Size = new System.Drawing.Size(64, 22);
            this.txt_dossard.TabIndex = 9;
            this.txt_dossard.Text = "Dossard";
            this.txt_dossard.Click += new System.EventHandler(this.Txt_dossard_Click);
            // 
            // txt_rfid
            // 
            this.txt_rfid.Location = new System.Drawing.Point(443, 379);
            this.txt_rfid.Name = "txt_rfid";
            this.txt_rfid.Size = new System.Drawing.Size(100, 22);
            this.txt_rfid.TabIndex = 10;
            this.txt_rfid.Text = "RFID";
            this.txt_rfid.Click += new System.EventHandler(this.Txt_rfid_Click);
            // 
            // CheckBox_cheque
            // 
            this.CheckBox_cheque.AutoSize = true;
            this.CheckBox_cheque.Location = new System.Drawing.Point(589, 342);
            this.CheckBox_cheque.Name = "CheckBox_cheque";
            this.CheckBox_cheque.Size = new System.Drawing.Size(79, 21);
            this.CheckBox_cheque.TabIndex = 11;
            this.CheckBox_cheque.Text = "Chèque";
            this.CheckBox_cheque.UseVisualStyleBackColor = true;
            // 
            // CheckBox_CM
            // 
            this.CheckBox_CM.AutoSize = true;
            this.CheckBox_CM.Location = new System.Drawing.Point(589, 369);
            this.CheckBox_CM.Name = "CheckBox_CM";
            this.CheckBox_CM.Size = new System.Drawing.Size(137, 21);
            this.CheckBox_CM.TabIndex = 12;
            this.CheckBox_CM.Text = "Certificat médical";
            this.CheckBox_CM.UseVisualStyleBackColor = true;
            // 
            // box_club
            // 
            this.box_club.AutoSize = true;
            this.box_club.Location = new System.Drawing.Point(112, 350);
            this.box_club.Name = "box_club";
            this.box_club.Size = new System.Drawing.Size(18, 17);
            this.box_club.TabIndex = 13;
            this.box_club.UseVisualStyleBackColor = true;
            this.box_club.CheckedChanged += new System.EventHandler(this.Box_club_CheckedChanged);
            // 
            // radioHomme
            // 
            this.radioHomme.AutoSize = true;
            this.radioHomme.Location = new System.Drawing.Point(112, 189);
            this.radioHomme.Name = "radioHomme";
            this.radioHomme.Size = new System.Drawing.Size(77, 21);
            this.radioHomme.TabIndex = 31;
            this.radioHomme.TabStop = true;
            this.radioHomme.Text = "Homme";
            this.radioHomme.UseVisualStyleBackColor = true;
            this.radioHomme.CheckedChanged += new System.EventHandler(this.RadioHomme_CheckedChanged);
            // 
            // radioFemme
            // 
            this.radioFemme.AutoSize = true;
            this.radioFemme.Location = new System.Drawing.Point(112, 217);
            this.radioFemme.Name = "radioFemme";
            this.radioFemme.Size = new System.Drawing.Size(75, 21);
            this.radioFemme.TabIndex = 32;
            this.radioFemme.TabStop = true;
            this.radioFemme.Text = "Femme";
            this.radioFemme.UseVisualStyleBackColor = true;
            this.radioFemme.CheckedChanged += new System.EventHandler(this.RadioFemme_CheckedChanged_1);
            // 
            // bt_impression
            // 
            this.bt_impression.Location = new System.Drawing.Point(378, 422);
            this.bt_impression.Name = "bt_impression";
            this.bt_impression.Size = new System.Drawing.Size(135, 51);
            this.bt_impression.TabIndex = 33;
            this.bt_impression.Text = "Imprimer le dossard";
            this.bt_impression.UseVisualStyleBackColor = true;
            this.bt_impression.Click += new System.EventHandler(this.Bt_impression_Click);
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Location = new System.Drawing.Point(599, 429);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(107, 44);
            this.bt_Annuler.TabIndex = 34;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // Participants_de_dernière_minute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 489);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.bt_impression);
            this.Controls.Add(this.radioFemme);
            this.Controls.Add(this.radioHomme);
            this.Controls.Add(this.box_club);
            this.Controls.Add(this.CheckBox_CM);
            this.Controls.Add(this.CheckBox_cheque);
            this.Controls.Add(this.txt_rfid);
            this.Controls.Add(this.txt_dossard);
            this.Controls.Add(this.txt_IDcourse);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.bt_creationparticipant);
            this.Controls.Add(this.txt_licence);
            this.Controls.Add(this.txt_club);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_codepostal);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Participants_de_dernière_minute";
            this.Text = "Participants_de_dernière_minute";
            this.Load += new System.EventHandler(this.Participants_de_dernière_minute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_codepostal;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_club;
        private System.Windows.Forms.TextBox txt_licence;
        private System.Windows.Forms.Button bt_creationparticipant;
        private chiconDataSet chiconDataSet;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private chiconDataSetTableAdapters.participantTableAdapter participantTableAdapter;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TextBox txt_IDcourse;
        private System.Windows.Forms.TextBox txt_rfid;
        private System.Windows.Forms.CheckBox CheckBox_cheque;
        private System.Windows.Forms.CheckBox CheckBox_CM;
        private System.Windows.Forms.CheckBox box_club;
        private System.Windows.Forms.RadioButton radioHomme;
        private System.Windows.Forms.RadioButton radioFemme;
        private System.Windows.Forms.Button bt_impression;
        private System.Windows.Forms.TextBox txt_dossard;
        private System.Windows.Forms.Button bt_Annuler;
    }
}
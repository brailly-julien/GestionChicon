namespace GestionChicon
{
    partial class Creation_de_course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation_de_course));
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_nom_de_course = new System.Windows.Forms.TextBox();
            this.lbldistance = new System.Windows.Forms.Label();
            this.radioButton500m = new System.Windows.Forms.RadioButton();
            this.radioButton1000m = new System.Windows.Forms.RadioButton();
            this.radioButton1500m = new System.Windows.Forms.RadioButton();
            this.btValidation = new System.Windows.Forms.Button();
            this.calandrier = new System.Windows.Forms.MonthCalendar();
            this.lbl_k = new System.Windows.Forms.Label();
            this.lbl_etat = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(205, 28);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(148, 17);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom de votre course :";
            // 
            // txt_nom_de_course
            // 
            this.txt_nom_de_course.Location = new System.Drawing.Point(149, 61);
            this.txt_nom_de_course.Name = "txt_nom_de_course";
            this.txt_nom_de_course.Size = new System.Drawing.Size(262, 22);
            this.txt_nom_de_course.TabIndex = 1;
            // 
            // lbldistance
            // 
            this.lbldistance.AutoSize = true;
            this.lbldistance.Location = new System.Drawing.Point(182, 105);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(179, 17);
            this.lbldistance.TabIndex = 2;
            this.lbldistance.Text = "Quelle distance à parcourir";
            // 
            // radioButton500m
            // 
            this.radioButton500m.AutoSize = true;
            this.radioButton500m.Location = new System.Drawing.Point(149, 143);
            this.radioButton500m.Name = "radioButton500m";
            this.radioButton500m.Size = new System.Drawing.Size(64, 21);
            this.radioButton500m.TabIndex = 3;
            this.radioButton500m.TabStop = true;
            this.radioButton500m.Text = "500m";
            this.radioButton500m.UseVisualStyleBackColor = true;
            // 
            // radioButton1000m
            // 
            this.radioButton1000m.AutoSize = true;
            this.radioButton1000m.Location = new System.Drawing.Point(239, 143);
            this.radioButton1000m.Name = "radioButton1000m";
            this.radioButton1000m.Size = new System.Drawing.Size(72, 21);
            this.radioButton1000m.TabIndex = 4;
            this.radioButton1000m.TabStop = true;
            this.radioButton1000m.Text = "1000m";
            this.radioButton1000m.UseVisualStyleBackColor = true;
            // 
            // radioButton1500m
            // 
            this.radioButton1500m.AutoSize = true;
            this.radioButton1500m.Location = new System.Drawing.Point(339, 143);
            this.radioButton1500m.Name = "radioButton1500m";
            this.radioButton1500m.Size = new System.Drawing.Size(72, 21);
            this.radioButton1500m.TabIndex = 5;
            this.radioButton1500m.TabStop = true;
            this.radioButton1500m.Text = "1500m";
            this.radioButton1500m.UseVisualStyleBackColor = true;
            // 
            // btValidation
            // 
            this.btValidation.Location = new System.Drawing.Point(426, 399);
            this.btValidation.Name = "btValidation";
            this.btValidation.Size = new System.Drawing.Size(140, 29);
            this.btValidation.TabIndex = 7;
            this.btValidation.Text = "Créer la course";
            this.btValidation.UseVisualStyleBackColor = true;
            this.btValidation.Click += new System.EventHandler(this.BtValidation_Click);
            // 
            // calandrier
            // 
            this.calandrier.Location = new System.Drawing.Point(32, 176);
            this.calandrier.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.calandrier.MaxSelectionCount = 1;
            this.calandrier.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.calandrier.Name = "calandrier";
            this.calandrier.TabIndex = 11;
            // 
            // lbl_k
            // 
            this.lbl_k.AutoSize = true;
            this.lbl_k.Location = new System.Drawing.Point(29, 405);
            this.lbl_k.Name = "lbl_k";
            this.lbl_k.Size = new System.Drawing.Size(125, 17);
            this.lbl_k.TabIndex = 12;
            this.lbl_k.Text = "L\'etat actuel sera :";
            // 
            // lbl_etat
            // 
            this.lbl_etat.AutoSize = true;
            this.lbl_etat.Location = new System.Drawing.Point(160, 405);
            this.lbl_etat.Name = "lbl_etat";
            this.lbl_etat.Size = new System.Drawing.Size(251, 17);
            this.lbl_etat.TabIndex = 13;
            this.lbl_etat.Text = "En attente d\'ouverture des inscriptions";
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Location = new System.Drawing.Point(227, 429);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(84, 34);
            this.bt_Annuler.TabIndex = 14;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.Bt_Annuler_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime.Location = new System.Drawing.Point(381, 276);
            this.dateTime.MinDate = new System.DateTime(2020, 5, 17, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(122, 22);
            this.dateTime.TabIndex = 15;
            // 
            // Creation_de_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 475);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.lbl_etat);
            this.Controls.Add(this.lbl_k);
            this.Controls.Add(this.calandrier);
            this.Controls.Add(this.btValidation);
            this.Controls.Add(this.radioButton1500m);
            this.Controls.Add(this.radioButton1000m);
            this.Controls.Add(this.radioButton500m);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.txt_nom_de_course);
            this.Controls.Add(this.lbl_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Creation_de_course";
            this.Text = "Creation_de_course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_nom_de_course;
        private System.Windows.Forms.Label lbldistance;
        private System.Windows.Forms.RadioButton radioButton500m;
        private System.Windows.Forms.RadioButton radioButton1000m;
        private System.Windows.Forms.RadioButton radioButton1500m;
        private System.Windows.Forms.Button btValidation;
        private System.Windows.Forms.MonthCalendar calandrier;
        private System.Windows.Forms.Label lbl_k;
        private System.Windows.Forms.Label lbl_etat;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}
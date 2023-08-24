namespace GestionChicon
{
    partial class Gestion_Chicon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Chicon));
            this.lblacceuil = new System.Windows.Forms.Label();
            this.btnewcourse = new System.Windows.Forms.Button();
            this.bt_participants = new System.Windows.Forms.Button();
            this.groupBox_Course = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etatCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Course.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblacceuil
            // 
            this.lblacceuil.AutoSize = true;
            this.lblacceuil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacceuil.Location = new System.Drawing.Point(330, 9);
            this.lblacceuil.Name = "lblacceuil";
            this.lblacceuil.Size = new System.Drawing.Size(319, 27);
            this.lblacceuil.TabIndex = 0;
            this.lblacceuil.Text = "Gestion de la course du chicon";
            // 
            // btnewcourse
            // 
            this.btnewcourse.Location = new System.Drawing.Point(18, 40);
            this.btnewcourse.Name = "btnewcourse";
            this.btnewcourse.Size = new System.Drawing.Size(273, 44);
            this.btnewcourse.TabIndex = 1;
            this.btnewcourse.Text = "Créer une nouvelle Course";
            this.btnewcourse.UseVisualStyleBackColor = true;
            this.btnewcourse.Click += new System.EventHandler(this.Btnewcourse_Click);
            // 
            // bt_participants
            // 
            this.bt_participants.Location = new System.Drawing.Point(754, 25);
            this.bt_participants.Name = "bt_participants";
            this.bt_participants.Size = new System.Drawing.Size(206, 75);
            this.bt_participants.TabIndex = 7;
            this.bt_participants.Text = "Participants";
            this.bt_participants.UseVisualStyleBackColor = true;
            this.bt_participants.Click += new System.EventHandler(this.Bt_participants_Click);
            // 
            // groupBox_Course
            // 
            this.groupBox_Course.Controls.Add(this.listView1);
            this.groupBox_Course.Location = new System.Drawing.Point(12, 101);
            this.groupBox_Course.Name = "groupBox_Course";
            this.groupBox_Course.Size = new System.Drawing.Size(945, 340);
            this.groupBox_Course.TabIndex = 8;
            this.groupBox_Course.TabStop = false;
            this.groupBox_Course.Text = "Les Course";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCourse,
            this.nomCourse,
            this.distance,
            this.dateCourse,
            this.etatCourse});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(932, 313);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idCourse
            // 
            this.idCourse.Text = "ID";
            this.idCourse.Width = 34;
            // 
            // nomCourse
            // 
            this.nomCourse.Text = "Nom de la course";
            this.nomCourse.Width = 140;
            // 
            // distance
            // 
            this.distance.Text = "Distance de la course";
            this.distance.Width = 158;
            // 
            // dateCourse
            // 
            this.dateCourse.Text = "Date de la course";
            this.dateCourse.Width = 135;
            // 
            // etatCourse
            // 
            this.etatCourse.Text = "Etat de la course";
            this.etatCourse.Width = 226;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.suprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 52);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.modifierToolStripMenuItem.Text = "Modifier l\'etat";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.ModifierToolStripMenuItem_Click);
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.suprimerToolStripMenuItem.Text = "Suprimer";
            this.suprimerToolStripMenuItem.Click += new System.EventHandler(this.SuprimerToolStripMenuItem_Click);
            // 
            // Gestion_Chicon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 453);
            this.Controls.Add(this.groupBox_Course);
            this.Controls.Add(this.bt_participants);
            this.Controls.Add(this.btnewcourse);
            this.Controls.Add(this.lblacceuil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_Chicon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Chicon";
            this.groupBox_Course.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblacceuil;
        private System.Windows.Forms.Button btnewcourse;
        private System.Windows.Forms.Button bt_participants;
        private System.Windows.Forms.GroupBox groupBox_Course;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idCourse;
        private System.Windows.Forms.ColumnHeader nomCourse;
        private System.Windows.Forms.ColumnHeader distance;
        private System.Windows.Forms.ColumnHeader dateCourse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader etatCourse;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
    }
}


namespace GestionChicon
{
    partial class Etat_de_la_course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etat_de_la_course));
            this.chiconDataSet = new GestionChicon.chiconDataSet();
            this.chiconDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiconDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etatCourse_chicon = new GestionChicon.etatCourse_chicon();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new GestionChicon.etatCourse_chiconTableAdapters.courseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etatCourse_chicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chiconDataSet
            // 
            this.chiconDataSet.DataSetName = "chiconDataSet";
            this.chiconDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiconDataSetBindingSource
            // 
            this.chiconDataSetBindingSource.DataSource = this.chiconDataSet;
            this.chiconDataSetBindingSource.Position = 0;
            // 
            // chiconDataSetBindingSource1
            // 
            this.chiconDataSetBindingSource1.DataSource = this.chiconDataSet;
            this.chiconDataSetBindingSource1.Position = 0;
            // 
            // etatCourse_chicon
            // 
            this.etatCourse_chicon.DataSetName = "etatCourse_chicon";
            this.etatCourse_chicon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.etatCourse_chicon;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Changer l\'etat de la course !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(45, 39);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(272, 21);
            this.radio1.TabIndex = 2;
            this.radio1.TabStop = true;
            this.radio1.Text = "En attente d\'ouverture des inscriptions";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.Radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(45, 66);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(195, 21);
            this.radio2.TabIndex = 3;
            this.radio2.TabStop = true;
            this.radio2.Text = "Ouverture des inscriptions";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.Radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(45, 93);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(319, 21);
            this.radio3.TabIndex = 4;
            this.radio3.TabStop = true;
            this.radio3.Text = "Les inscriptions pour la course sont terminées";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.Radio3_CheckedChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(45, 120);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(133, 21);
            this.radio4.TabIndex = 5;
            this.radio4.TabStop = true;
            this.radio4.Text = "Course en cours";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.Radio4_CheckedChanged);
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(45, 147);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(133, 21);
            this.radio5.TabIndex = 6;
            this.radio5.TabStop = true;
            this.radio5.Text = "Course terminée";
            this.radio5.UseVisualStyleBackColor = true;
            this.radio5.CheckedChanged += new System.EventHandler(this.Radio5_CheckedChanged);
            // 
            // Etat_de_la_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 296);
            this.Controls.Add(this.radio5);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Etat_de_la_course";
            this.Text = "Etat_de_la_course";
            this.Load += new System.EventHandler(this.Etat_de_la_course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiconDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etatCourse_chicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource chiconDataSetBindingSource;
        private chiconDataSet chiconDataSet;
        private System.Windows.Forms.BindingSource chiconDataSetBindingSource1;
        private etatCourse_chicon etatCourse_chicon;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private etatCourse_chiconTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio5;
    }
}
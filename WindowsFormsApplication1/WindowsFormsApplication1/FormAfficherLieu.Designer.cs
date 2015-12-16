namespace WindowsFormsApplication1
{
    partial class FormAfficherLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfficherLieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCoordonneeY = new System.Windows.Forms.Label();
            this.labelCoordonneeX = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPeriode = new System.Windows.Forms.Button();
            this.comboBoxFin = new System.Windows.Forms.ComboBox();
            this.comboBoxDebut = new System.Windows.Forms.ComboBox();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelDebut = new System.Windows.Forms.Label();
            this.labelPeriode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelJourActivite = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.labelLabelActivite = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 526);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cliquer sur un lieu pour avoir ses informations");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // labelCoordonneeY
            // 
            this.labelCoordonneeY.AutoSize = true;
            this.labelCoordonneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordonneeY.Location = new System.Drawing.Point(14, 36);
            this.labelCoordonneeY.Name = "labelCoordonneeY";
            this.labelCoordonneeY.Size = new System.Drawing.Size(120, 18);
            this.labelCoordonneeY.TabIndex = 7;
            this.labelCoordonneeY.Text = "Coordonnées Y :";
            // 
            // labelCoordonneeX
            // 
            this.labelCoordonneeX.AutoSize = true;
            this.labelCoordonneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordonneeX.Location = new System.Drawing.Point(13, 9);
            this.labelCoordonneeX.Name = "labelCoordonneeX";
            this.labelCoordonneeX.Size = new System.Drawing.Size(121, 18);
            this.labelCoordonneeX.TabIndex = 6;
            this.labelCoordonneeX.Text = "Coordonnées X :";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonOk.Location = new System.Drawing.Point(947, 543);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(98, 33);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Retour";
            this.buttonOk.Text = "OK";
            this.toolTip1.SetToolTip(this.buttonOk, "Cliquer pour revenir à la fenêtre précédente");
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPeriode);
            this.panel2.Controls.Add(this.comboBoxFin);
            this.panel2.Controls.Add(this.comboBoxDebut);
            this.panel2.Controls.Add(this.labelFin);
            this.panel2.Controls.Add(this.labelDebut);
            this.panel2.Controls.Add(this.labelPeriode);
            this.panel2.Controls.Add(this.labelCoordonneeX);
            this.panel2.Controls.Add(this.labelCoordonneeY);
            this.panel2.Location = new System.Drawing.Point(776, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 243);
            this.panel2.TabIndex = 12;
            // 
            // buttonPeriode
            // 
            this.buttonPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeriode.Location = new System.Drawing.Point(171, 203);
            this.buttonPeriode.Name = "buttonPeriode";
            this.buttonPeriode.Size = new System.Drawing.Size(86, 27);
            this.buttonPeriode.TabIndex = 17;
            this.buttonPeriode.Text = "Appliquer";
            this.buttonPeriode.UseVisualStyleBackColor = true;
            this.buttonPeriode.Click += new System.EventHandler(this.buttonPeriode_Click);
            // 
            // comboBoxFin
            // 
            this.comboBoxFin.FormattingEnabled = true;
            this.comboBoxFin.Location = new System.Drawing.Point(74, 176);
            this.comboBoxFin.Name = "comboBoxFin";
            this.comboBoxFin.Size = new System.Drawing.Size(60, 21);
            this.comboBoxFin.TabIndex = 16;
            // 
            // comboBoxDebut
            // 
            this.comboBoxDebut.FormattingEnabled = true;
            this.comboBoxDebut.Location = new System.Drawing.Point(74, 147);
            this.comboBoxDebut.Name = "comboBoxDebut";
            this.comboBoxDebut.Size = new System.Drawing.Size(60, 21);
            this.comboBoxDebut.TabIndex = 15;
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFin.Location = new System.Drawing.Point(14, 175);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(36, 18);
            this.labelFin.TabIndex = 14;
            this.labelFin.Text = "Fin :";
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebut.Location = new System.Drawing.Point(13, 147);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(55, 18);
            this.labelDebut.TabIndex = 13;
            this.labelDebut.Text = "Début :";
            // 
            // labelPeriode
            // 
            this.labelPeriode.AutoSize = true;
            this.labelPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriode.Location = new System.Drawing.Point(14, 117);
            this.labelPeriode.Name = "labelPeriode";
            this.labelPeriode.Size = new System.Drawing.Size(67, 18);
            this.labelPeriode.TabIndex = 12;
            this.labelPeriode.Text = "Période :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelJourActivite);
            this.panel3.Controls.Add(this.richTextBoxDescription);
            this.panel3.Controls.Add(this.labelDescription);
            this.panel3.Controls.Add(this.labelNomActivite);
            this.panel3.Controls.Add(this.labelLabelActivite);
            this.panel3.Location = new System.Drawing.Point(776, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 236);
            this.panel3.TabIndex = 13;
            // 
            // labelJourActivite
            // 
            this.labelJourActivite.AutoSize = true;
            this.labelJourActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourActivite.Location = new System.Drawing.Point(3, 83);
            this.labelJourActivite.Name = "labelJourActivite";
            this.labelJourActivite.Size = new System.Drawing.Size(46, 18);
            this.labelJourActivite.TabIndex = 4;
            this.labelJourActivite.Text = "Jour :";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(6, 143);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(251, 90);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(3, 122);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(166, 18);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description de l\'activité :";
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomActivite.Location = new System.Drawing.Point(3, 42);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(124, 18);
            this.labelNomActivite.TabIndex = 1;
            this.labelNomActivite.Text = "Nom de l\'activité :";
            // 
            // labelLabelActivite
            // 
            this.labelLabelActivite.AutoSize = true;
            this.labelLabelActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabelActivite.Location = new System.Drawing.Point(3, 12);
            this.labelLabelActivite.Name = "labelLabelActivite";
            this.labelLabelActivite.Size = new System.Drawing.Size(147, 18);
            this.labelLabelActivite.TabIndex = 0;
            this.labelLabelActivite.Text = "Informations activité :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 534);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(283, 534);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(569, 534);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exploration Space Suit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "en noir si passé, en vert si à venir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "en noir si passé, en vert si à venir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Exploration en vehicule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "en noir si passé, en vert si à venir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Expérience en extérieur";
            // 
            // FormAfficherLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panel1);
            this.Name = "FormAfficherLieu";
            this.Text = "FormAfficherLieu";
            this.Load += new System.EventHandler(this.FormAfficherLieu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCoordonneeY;
        private System.Windows.Forms.Label labelCoordonneeX;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxFin;
        private System.Windows.Forms.ComboBox comboBoxDebut;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.Label labelPeriode;
        private System.Windows.Forms.Button buttonPeriode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.Label labelLabelActivite;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelJourActivite;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormAfficherLieu : Form
    {

        //Attributs
        private List<Lieu> listeLieux;
        private List<Jour> listeJours;
        private List<Jour> listeJoursPeriode;
        private List<int> listeJourParExploration;
        private List<Activités> listeActivite;
        private List<PictureBox> listePictureBox;
        private Planning planning;
        private Activités activiteSelectionne;
        PictureBox pBExploSpaceSuitPast, pBExploVehiclePast, pBExploExperiencePast, pBExploSpaceSuitFuture, pBExploVehicleFuture, pBExploExperienceFuture;
        private int jourDebut, jourFin;
        int positionX, positionY;

        //Constructeur
        public FormAfficherLieu(List<Lieu> tempListeLieux, List<Jour> templisteJours, Planning tempPlanning)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            listeLieux = tempListeLieux;
            listeJours = templisteJours;
            planning = tempPlanning;
            jourDebut = 0;
            jourFin = 499;
            listeJoursPeriode = new List<Jour>();
           

        }

        //Affiche les icônes des explorations contenus dans les jours
        public void afficherLieu()
        {
            listeJoursPeriode.Clear();
            for (int i = jourDebut; i <= jourFin; i++)
            {

                listeJoursPeriode.Add(listeJours[i]);

            }

            int coordonneeX, coordonneeY;
            int indexActivites = 0;
            int indexJour= 0;
            foreach (Jour j in listeJoursPeriode)
            {
                //Exploration passé
                if (j.GetidJour < planning.getJourActuel())
                {
                    foreach (Activités A in j.getlisteActivite)
                    {
                        if (A.GettypeActivite == "Exploration - Space Suit")
                        {
                            Image imageExploSpaceSuitPast = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\astronautPast.png");
                            Lieu lieuExploSpaceSuitPast = A.GetLieuActivite;
                            pBExploSpaceSuitPast = new PictureBox();
                            pBExploSpaceSuitPast.Image = imageExploSpaceSuitPast;

                            coordonneeX = Convert.ToInt32(lieuExploSpaceSuitPast.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploSpaceSuitPast.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploSpaceSuitPast.Location = p;
                            pBExploSpaceSuitPast.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploSpaceSuitPast);
                            pBExploSpaceSuitPast.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploSpaceSuitPast.BackColor = Color.Transparent;

                            pBExploSpaceSuitPast.Click += new EventHandler(icone_Click);
                            pBExploSpaceSuitPast.Tag = indexActivites.ToString();
                            listePictureBox.Add(pBExploSpaceSuitPast);
                            listeActivite.Add(A);
                            listeJourParExploration.Add(indexJour+1);
                            indexActivites++;

                        }
                        else if (A.GettypeActivite == "Exploration - Vehicle")
                        {
                            Image imageExploVehiclePast = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\vehiclePast.png");
                            Lieu lieuExploVehiclePast = A.GetLieuActivite;
                            pBExploVehiclePast = new PictureBox();
                            pBExploVehiclePast.Image = imageExploVehiclePast;

                            coordonneeX = Convert.ToInt32(lieuExploVehiclePast.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploVehiclePast.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploVehiclePast.Location = p;
                            pBExploVehiclePast.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploVehiclePast);
                            pBExploVehiclePast.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploVehiclePast.BackColor = Color.Transparent;

                            pBExploVehiclePast.Click += new EventHandler(icone_Click);
                            pBExploVehiclePast.Tag = indexActivites.ToString();
                            listePictureBox.Add(pBExploVehiclePast);
                            listeActivite.Add(A);
                            listeJourParExploration.Add(indexJour+1);
                            indexActivites++;

                        }
                        else if (A.GettypeActivite == "Science - Outside experiment")
                        {
                            Image imageExperiencePast = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\experiencePast.png");
                            Lieu lieuExploExperiencePast = A.GetLieuActivite;
                            pBExploExperiencePast = new PictureBox();
                            pBExploExperiencePast.Image = imageExperiencePast;

                            coordonneeX = Convert.ToInt32(lieuExploExperiencePast.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploExperiencePast.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploExperiencePast.Location = p;
                            pBExploExperiencePast.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploExperiencePast);
                            pBExploExperiencePast.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploExperiencePast.BackColor = Color.Transparent;

                            pBExploExperiencePast.Click += new EventHandler(icone_Click);
                            pBExploExperiencePast.Tag = indexActivites.ToString();
                            listePictureBox.Add(pBExploExperiencePast);
                            listeActivite.Add(A);
                            listeJourParExploration.Add(indexJour+1);
                            indexActivites++;
                        }
                    }

                }
                else
                {

                    foreach (Activités A in j.getlisteActivite)
                    {
                        if (A.GettypeActivite == "Exploration - Space Suit")
                        {
                            Image imageExploSpaceSuitFuture = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\astronautFuture.png");
                            Lieu lieuExploSpaceSuitFuture = A.GetLieuActivite;
                            pBExploSpaceSuitFuture = new PictureBox();
                            pBExploSpaceSuitFuture.Image = imageExploSpaceSuitFuture;

                            coordonneeX = Convert.ToInt32(lieuExploSpaceSuitFuture.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploSpaceSuitFuture.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploSpaceSuitFuture.Location = p;
                            pBExploSpaceSuitFuture.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploSpaceSuitFuture);
                            pBExploSpaceSuitFuture.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploSpaceSuitFuture.BackColor = Color.Transparent;

                            pBExploSpaceSuitFuture.Click += new EventHandler(icone_Click);
                            pBExploSpaceSuitFuture.Tag = indexActivites.ToString();
                            listePictureBox.Add(pBExploSpaceSuitFuture);
                            listeActivite.Add(A);
                            listeJourParExploration.Add(indexJour + 1);
                            indexActivites++;


                        }
                        else if (A.GettypeActivite == "Exploration - Vehicle")
                        {
                            Image imageExploVehicleFuture = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\vehicleFuture.png");
                            Lieu lieuExploVehicleFuture = A.GetLieuActivite;
                            pBExploVehicleFuture = new PictureBox();
                            pBExploVehicleFuture.Image = imageExploVehicleFuture;

                            coordonneeX = Convert.ToInt32(lieuExploVehicleFuture.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploVehicleFuture.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploVehicleFuture.Location = p;
                            pBExploVehicleFuture.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploVehicleFuture);
                            pBExploVehicleFuture.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploVehicleFuture.BackColor = Color.Transparent;

                            pBExploVehicleFuture.Click += new EventHandler(icone_Click);
                            pBExploVehicleFuture.Tag = indexActivites.ToString();
                            listePictureBox.Add(pBExploVehicleFuture);
                            listeActivite.Add(A);
                            listeJourParExploration.Add(indexJour + 1);
                            indexActivites++;

                        }
                        else if (A.GettypeActivite == "Science - Outside experiment")
                        {
                            Image imageExperienceFuture = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\experienceFuture.png");
                            Lieu lieuExploExperienceFuture = A.GetLieuActivite;
                            pBExploExperienceFuture = new PictureBox();
                            pBExploExperienceFuture.Image = imageExperienceFuture;

                            coordonneeX = Convert.ToInt32(lieuExploExperienceFuture.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploExperienceFuture.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploExperienceFuture.Location = p;
                            pBExploExperienceFuture.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploExperienceFuture);
                            pBExploExperienceFuture.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploExperienceFuture.BackColor = Color.Transparent;

                            pBExploExperienceFuture.Click += new EventHandler(icone_Click);
                            pBExploExperienceFuture.Tag = indexActivites.ToString();
                            listePictureBox.Add(pBExploExperienceFuture);
                            listeActivite.Add(A);
                            listeJourParExploration.Add(indexJour + 1);
                            indexActivites++;
                        }
                    }

                }

                indexJour++;

            }


        }

        //Charge les images et les contrôles sur le form
        private void FormAfficherLieu_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 500; i++)
            {
                comboBoxDebut.Items.Add(i);
                comboBoxFin.Items.Add(i);

            }
            listeJourParExploration = new List<int>();
            listePictureBox = new List<PictureBox>();
            listeActivite = new List<Activités>();
            afficherLieu();

            Image iconeAstro = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\astronautPast.png");
            pictureBox2.Image = iconeAstro;
            Image iconeVehicule = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\vehiclePast.png");
            pictureBox3.Image = iconeVehicule;
            Image iconeExperience = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\experiencePast.png");
            pictureBox4.Image = iconeExperience;
        }


        // Affiche les coordonnees à la position selectionnee
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            positionX = e.X - 700;
            positionY = pictureBox1.Height - e.Y - (pictureBox1.Height - 1000);
            labelCoordonneeX.Text = "Coordonnée X :  " + positionX.ToString();
            labelCoordonneeY.Text = "Coordonnée Y :  " + positionY.ToString();
        }


        //Au clique d'une icone recupere les infos de l'exploration et les affiches sur le côte
        private void icone_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((PictureBox)sender).Tag.ToString());
            activiteSelectionne = listeActivite[index];
            labelNomActivite.Text = "Nom de l'activité : " + activiteSelectionne.GetNomActivité;
            richTextBoxDescription.Text = activiteSelectionne.GettexteDescriptif;
            labelJourActivite.Text = "Numero du jour : " + listeJourParExploration[index].ToString();
        }

        //Filtre les donnees sur les explorations sur une periode
        private void buttonPeriode_Click(object sender, EventArgs e)
        {

            if (comboBoxFin.SelectedIndex > comboBoxDebut.SelectedIndex)
            {

                jourDebut = comboBoxDebut.SelectedIndex;
                jourFin = comboBoxFin.SelectedIndex;
                foreach (PictureBox P in listePictureBox)
                {
                    P.Dispose();
                }
                afficherLieu();

            }
            else
            {

                MessageBox.Show("Le jour de fin doit être supérieur au jour de début.", "Erreur" ,MessageBoxButtons.OK);

            }

        }

        //Ferme la form
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
}

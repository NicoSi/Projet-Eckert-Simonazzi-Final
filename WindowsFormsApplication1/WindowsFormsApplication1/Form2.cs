﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private List<Jour> listeJour;
        private int jourSelection;
        private Jour objetJourSelection;
        private List<Activités> listeActivitéTableau;
        private List<Astronautes> listeAstronautes;
        private int activiteSelectionne;
        private Planning planning;
        private List<Lieu> listeLieu;



        //Constructeur par défaut

        public Form2(List<Jour> tempListeJour, int tempJourSelection, Planning tempPlanning, List<Astronautes> tempListeAstronautes, List<Lieu> tempListeLieu)

        {
            listeJour = tempListeJour;
            jourSelection = tempJourSelection;
            InitializeComponent();
            planning = tempPlanning;
            listeAstronautes = tempListeAstronautes;
            listeLieu = tempListeLieu;
            
            
        }
        

        //Remplissage de la listbox
        public void remplissageListBox()
        {
            string contenuListBox;
            foreach (Activités A in listeActivitéTableau)
            {

                contenuListBox = A.getHoraireDebutMarsTexte() + " - " + A.getHoraireFinMarsTexte()  + "  : " + A.GetNomActivité;
                listBox1.Items.Add(contenuListBox);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            objetJourSelection = listeJour[jourSelection-1];
            listeActivitéTableau = objetJourSelection.getlisteActivite;

            remplissageListBox();

            DateTime dateDebutPlanning = new DateTime(2015, 11, 15, 0, 0, 0);

            richTextBoxCompteRendu.Text = objetJourSelection.GetcompteRendu;

            labelNumeroJour.Text = jourSelection.ToString();

            listBox1.SelectedIndex = 0;

            if (jourSelection < planning.getJourActuel())
            {
                boutonEffacerActivite.Enabled = false;
                buttonAjouterActivité.Enabled = false;
                buttonModifierActivité.Enabled = false;
                buttonSupprimerActivité.Enabled = false;
            }

                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Méthode qui affiche les caractéristiques d'une activité selectionnée
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            activiteSelectionne = listBox1.SelectedIndex;
            labelNomActivite.Text = listeActivitéTableau[activiteSelectionne].GetNomActivité;
            labelTypeActivité.Text = "Type : " + listeActivitéTableau[activiteSelectionne].GettypeActivite;

            labelJourActivité.Text = "Jour : "  + jourSelection.ToString();

            DateTime dateDebutPlanning = planning.GetDateDebut;
            string texteHoraire = listeActivitéTableau[activiteSelectionne].getHoraireDebutMarsTexte();
            texteHoraire = texteHoraire + " à " + listeActivitéTableau[activiteSelectionne].getHoraireFinMarsTexte();
            labelPlageHoraireActivité.Text = "Plage horaire : " + texteHoraire;

            // Recuperation du lieu
            Lieu lieuActivite = listeActivitéTableau[activiteSelectionne].GetLieuActivite;

            labelLieuActivite.Text = "Lieu : " + lieuActivite.GetnomLieu;

            // Recuperation de la liste d'astronautes
            List<Astronautes> listeAstronautesActivite = listeActivitéTableau[activiteSelectionne].GetlisteAstronautes;
            string contenuListBoxAstronautes;

            listBoxAstronautes.Items.Clear();

            foreach (Astronautes A in listeAstronautesActivite) 
            {

                contenuListBoxAstronautes = "" + A.GetprenomAstronaute + " " + A.GetnomAstronaute + "    age : " + A.GetageAstronaute.ToString() ;
                listBoxAstronautes.Items.Add(contenuListBoxAstronautes);

            }

            texteDescriptifActivite.Text = listeActivitéTableau[activiteSelectionne].GettexteDescriptif;



   
            
        }

        private void boutonJourSuivant_Click(object sender, EventArgs e)
        {
            if (jourSelection != 500)
            {

                Form2 fenetre = new Form2(listeJour, jourSelection + 1, planning, listeAstronautes, listeLieu);

                Form.ActiveForm.Close();
                fenetre.Show();
            }
        }

        private void boutonJourPrecedent_Click(object sender, EventArgs e)
        {
            if(jourSelection != 1)
            {


                Form2 fenetre = new Form2(listeJour, jourSelection - 1, planning, listeAstronautes, listeLieu);

                Form.ActiveForm.Close();
                fenetre.Show();
            }

        }

        private void boutonEffacerActivite_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer les activités ?", "Suppression activités", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                objetJourSelection.getlisteActivite.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void buttonAjouterActivité_Click(object sender, EventArgs e)
        {

            FormAjouterActivite formAjout = new FormAjouterActivite(objetJourSelection, listeAstronautes, listeLieu, planning);

            formAjout.ShowDialog();
            

            listBox1.Items.Clear();

            remplissageListBox();

        }

        private void buttonModifierActivité_Click(object sender, EventArgs e)
        {
            
            formModifierActivite formModifier = new formModifierActivite(objetJourSelection, listeAstronautes, listeActivitéTableau[activiteSelectionne],listeLieu,listeJour,planning);
            formModifier.ShowDialog();

        }

        private void buttonSupprimerActivité_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer l' activité ?", "Suppression de l'activité", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                activiteSelectionne = listBox1.SelectedIndex;
                objetJourSelection.supprimerActivite(activiteSelectionne);

                listBox1.Items.Clear();

                remplissageListBox();

                MessageBox.Show("L'activité a bien été supprimé", "Info", MessageBoxButtons.OK);

                activiteSelectionne = 1;
            }
         
        }

        private void buttonAfficherLieuActivité_Click(object sender, EventArgs e)
        {
            FormAfficherLieu form = new FormAfficherLieu(listeLieu, listeJour, planning);
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonEnregistrerCompteRendu_Click(object sender, EventArgs e)
        {
            objetJourSelection.GetcompteRendu = richTextBoxCompteRendu.Text;

            MessageBox.Show("Le compte rendu a bien été enregistré", "Info", MessageBoxButtons.OK);
        } 

    }
}

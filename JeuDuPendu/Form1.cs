using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// mot à rechercher
        /// </summary>
        private string mot;

        /// <summary>
        /// étape d'affichage du pendu
        /// </summary>
        private int etapePendu;

        /// <summary>
        /// maximum d'étapes du pendu
        /// </summary>
        private int maxPendu = 10;
        /// <summary>
        /// Vide le combo et le rempli avec les lettres de l'alphabet
        /// </summary>
        public void rempliCombo()
        {
            //vide le combo
            cmbLettres.Items.Clear();

            //rempli le combo avec lettre alphabet
            for (int i=0; i<26; i++)
            {
                cmbLettres.Items.Add((char)('A'+i));
            }
            cmbLettres.SelectedIndex = 0;
        }

        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Préparation de la phase 1
        /// Saisie du mot à chercher
        /// </summary>
        public void phase1()
        {
            //réinitialise l'étape du pendu et affiche l'image vide
            etapePendu = 0;
            AfficheImage(etapePendu);

            //désactive la zone de la phase 2 (proposition de lettres) et le bouton TEST
            cmbLettres.Enabled = false;
            btnTest.Enabled = false;

            //supprime le message et l'affichage des lettres testées
            lblReussite.Text = "";
            lblLettres.Text = "";

            //active, vide et se positionne sur la zone de saisie du mot
            txtMotAChercher.Enabled = true;
            txtMotAChercher.Text = "";
            txtMotAChercher.Focus();
        }

        /// <summary>
        /// Préparation de la phase 2 
        /// Recherche du mot
        /// </summary>
        public void phase2()
        {
            //Rend impossible l'accès à la case de saisie du mot à chercher
            txtMotAChercher.Enabled = false;
            //active la zone de la phase 2 (proposition de lettres)
            cmbLettres.Enabled = true;
            cmbLettres.SelectedIndex = 0;
            cmbLettres.Focus();

            btnTest.Enabled = true;
        }


        private void AfficheImage(int num)
        {
            imgPendu.ImageLocation = Application.StartupPath + "/../../Properties/ImagesJeuPendu/pendu" + num + ".png";
            imgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu" + num);
        }
        /// <summary>
        /// Contrôle si un mot est bien constitué uniquement de lettres
        /// </summary>
        /// <param name="unMot"></param>
        /// <returns></returns>
        public bool MotCorrect(string unMot)
        {
            bool correct = true;
            if (unMot!="" && unMot.Length<16)
            {
                unMot = unMot.ToUpper();
                for (int k = 0; k < unMot.Length; k++)
                {
                    if (unMot[k] < 'A' || unMot[k] > 'Z')
                    {
                        correct = false;
                    }
                }
            }
            else
            {
                correct = false;
            }
            return correct;
        }
        /// <summary>
        /// Evenement chargement de la fenêtre
        /// Création des boutons des lettres de l'alphabet
        /// et démarrage du jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            phase1();
            rempliCombo();
        }

        /// <summary>
        /// Evenement touche enfoncée dans la zone du mot
        /// si validation, enregistrement du mot et début du jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMotAChercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation donc fin de la saisie du mot
            if (e.KeyChar == (char)Keys.Enter)
            {
                //vérifie qu'un mot a été tapé et qu'il est correct (uniquement des lettres et taille inférieure à 16)
                if (MotCorrect(txtMotAChercher.Text))
                {
                    //met le mot en majuscule et le mémorise dans une propriété
                    mot = txtMotAChercher.Text.ToUpper();
                    //remplit la zone de tirets à la place des lettres
                    txtMotAChercher.Text = "";
                    for (int i=0; i<mot.Length; i++)
                    {
                        txtMotAChercher.Text += "-";
                    }
                    //Préparation des objets graphiques pour la phase 2 (recherche du mot)
                    phase2();
                }
                else
                {
                    MessageBox.Show("Le mot ne doit comporter que des lettres alphabétiques (pas d'espaces, pas d'accent)");
                    phase1();
                }
            }
        }

        /// <summary>
        /// Evenement clic sur le bouton TEST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (cmbLettres.SelectedIndex!= -1)
            {
                char lettre = char.Parse(cmbLettres.SelectedItem.ToString());
                lblLettres.Text += lettre;
                if (!RechercheLettreDansMot(lettre))
                {
                    //lettre non trouvée : affichage du pendu
                    if (AffichePendu())
                    {
                        //si totalement pendu, perdu et fin du jeu
                        FinJeu("PERDU");
                    }
                    else
                    {
                        //il n'y a plus de lettre à trouver
                        if (txtMotAChercher.Text.IndexOf("-")== -1)
                        {
                            //s'il n'y a plus de tiret (toutes les lettres sont trouvées) c'est gagné
                            FinJeu("GAGNE");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Affichage d'une étape du pendu
        /// </summary>
        /// <returns></returns>
        private bool AffichePendu()
        {
            etapePendu++;
            AfficheImage(etapePendu);
            return (etapePendu == maxPendu);
        }


        /// <summary>
        /// Recherche la lettre dans le mot et remplace le tiret par la lettre
        /// Retourne vrai si la lettre est trouvée au moins une fois
        /// </summary>
        /// <param name="lettre"> lettre à chercher </param>
        /// <returns></returns>
        private bool RechercheLettreDansMot(char lettre)
        {
            //position de la lettre dans le mot
            int position = -1;
            //booléen qui va dire si la lettre a été trouvée ou non
            bool trouve = false;

            //boucle sur la recherche de la lettre (qui peut être présente plusieurs fois)
            do
            {
                //récupère la position de la lettre (ou -1)
                position = mot.IndexOf(lettre, position + 1);
                if (position != -1)
                {
                    trouve = true;
                    //remplace le tiret par la lettre dans la zone de texte
                    txtMotAChercher.Text = txtMotAChercher.Text.Remove(position, 1);
                    txtMotAChercher.Text = txtMotAChercher.Text.Insert(position, lettre.ToString());
                }
            } while (position != -1);
            return trouve;

        }

        private void FinJeu(string message)
        {
            //affichage du message (gagné ou perdu)
            lblReussite.Text = message;
            //affiche le mot correct
            txtMotAChercher.Text = mot;
            //désactive la zone de proposition de lettre
            cmbLettres.Enabled = false;
            //se positionne sur le bouton recommencer (btnRejouer)
            btnRejouer.Focus();
        }
        /// <summary>
        /// Evenement clic sur le bouton rejouer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRejouer_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }
    }
}

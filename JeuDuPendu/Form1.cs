using System;
using System.Drawing;
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
        /// Permet de créer les boutons de l'alphabet
        /// </summary>
        private void CreeBoutons()
        {
            //variables locales
            char[] tAlpha = new char[26]; //tableau des lettres
            int sizeButton = 30; //taille du côté d'un bouton de lettre
            int posXButton = 6; //position du 1er bouton à partir de la gauche
            int posYButton = 18; //position du 1er bouton à partir du haut
            int nbLettreParLigne = 9; //détermine le nombre de boutons et donc de lettres par ligne
            //remplissage du tableau de lettres
            for (int k=0; k < tAlpha.Length; k++)
            {
                tAlpha[k] = (char)('A' + k);
            }
            //création et positionnement des boutons
            int line = -1, col = 0;
            for (int k=0; k< tAlpha.Length; k++)
            {
                //création du bouton
                Button btn = new Button();
                //ajout du bouton dans le groupe de boutons pour l'affichage
                grpTestLettres.Controls.Add(btn);
                //ajoute la lettre correspondante au bouton
                btn.Text = tAlpha[k].ToString();
                //fixe la taille du bouton
                btn.Size = new Size(sizeButton, sizeButton);
                //ajout d'une écoute sur le clic du bouton
                btn.Click += new EventHandler(btnAlpha_Click);
                //changement de ligne au bout d'un certain nombre de boutons affichés
                col++;
                if (k% nbLettreParLigne ==0)
                {
                    line++;
                    col = 0;
                }
                //positionne le bouton dans le groupe
                btn.Location = new Point(posXButton + sizeButton * col, posYButton + sizeButton * line);
            }
        }

        /// <summary>
        /// Active les boutons des lettres
        /// </summary>
        private void ActiveBoutons()
        {
            //active les boutons
            for (int k=0; k< grpTestLettres.Controls.Count; k++)
            {
                grpTestLettres.Controls[k].Enabled = true;
            }
            grpTestLettres.Controls[0].Focus();
        }

        /// <summary>
        /// Rend le focus au bouton de la première lettre non désactivée
        /// </summary>
        private void GestionFocusBoutonLettre()
        {
            int k = 0;
            while (!grpTestLettres.Controls[k].Enabled)
            {
                k++;
            }
            grpTestLettres.Controls[k].Focus();
        }


        private void btnAlpha_Click(object sender, EventArgs e)
        {
            //récupération du bouton concerné par l'évènement
            Button btnLettre = ((Button)sender);
            //désactive le bouton et donne le focus au premier bouton accessible
            btnLettre.Enabled = false;
            GestionFocusBoutonLettre();
            //recherche la lettre
            char lettre = char.Parse(btnLettre.Text);
            if (!RechercheLettreDansMot(lettre))
            {
                //lettre non trouvée : affichage du pendu
                if (AffichePendu())
                {
                    //si totalement pendu, perdu et fin du jeu
                    FinJeu("PERDU");
                }
            }
            else
            {
                //il n'y a plus de lettre à trouver
                if (txtMotAChercher.Text.IndexOf('-')== -1)
                {
                    //s'il n'y a plus de tiret (toutes les lettres trouvées) c'est gagné
                    FinJeu("GAGNE");
                }
            }
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
            grpTestLettres.Enabled = false;

            //supprime le message et l'affichage des lettres testées
            lblReussite.Text = "";

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
            //Active les boutons et la zone de la phase 2 (proposition de lettres)
            ActiveBoutons();
            grpTestLettres.Enabled = true;

            //positionne le focus sur le premier bouton (lettre A)
            grpTestLettres.Controls[0].Focus();

            //Rend impossible l'accès à la case de saisie du mot à chercher
            txtMotAChercher.Enabled = false;
        }

        /// <summary>
        /// Affiche une iimage d'un numéro précis
        /// </summary>
        /// <param name="num"></param>
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
            //création des boutons des lettres
            CreeBoutons();
            //Préparation des objets graphiques pour la phase 1 (saisie du mot)
            phase1();
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

        /// <summary>
        /// Fin du jeu (Gagné ou perdu)
        /// </summary>
        /// <param name="message"></param>
        private void FinJeu(string message)
        {
            //affichage du message (gagné ou perdu)
            lblReussite.Text = message;
            //affiche le mot correct
            txtMotAChercher.Text = mot;
            //désactive la zone de proposition de lettre
            grpTestLettres.Enabled = false;          
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

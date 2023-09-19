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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rempliCombo();
        }
    }
}

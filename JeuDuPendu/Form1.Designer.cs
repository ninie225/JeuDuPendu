namespace JeuDuPendu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMotAChercher = new System.Windows.Forms.TextBox();
            this.cmbLettres = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblLettres = new System.Windows.Forms.Label();
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblReussite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMotAChercher
            // 
            this.txtMotAChercher.Location = new System.Drawing.Point(24, 23);
            this.txtMotAChercher.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotAChercher.Name = "txtMotAChercher";
            this.txtMotAChercher.Size = new System.Drawing.Size(160, 22);
            this.txtMotAChercher.TabIndex = 0;
            this.txtMotAChercher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotAChercher_KeyPress);
            // 
            // cmbLettres
            // 
            this.cmbLettres.FormattingEnabled = true;
            this.cmbLettres.Location = new System.Drawing.Point(20, 23);
            this.cmbLettres.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLettres.Name = "cmbLettres";
            this.cmbLettres.Size = new System.Drawing.Size(52, 24);
            this.cmbLettres.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(95, 23);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(69, 26);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblLettres
            // 
            this.lblLettres.AutoSize = true;
            this.lblLettres.Enabled = false;
            this.lblLettres.Location = new System.Drawing.Point(16, 68);
            this.lblLettres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(0, 17);
            this.lblLettres.TabIndex = 3;
            // 
            // imgPendu
            // 
            this.imgPendu.Enabled = false;
            this.imgPendu.Location = new System.Drawing.Point(260, 15);
            this.imgPendu.Margin = new System.Windows.Forms.Padding(4);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(212, 213);
            this.imgPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPendu.TabIndex = 4;
            this.imgPendu.TabStop = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRejouer.Image = ((System.Drawing.Image)(resources.GetObject("btnRejouer.Image")));
            this.btnRejouer.Location = new System.Drawing.Point(200, 182);
            this.btnRejouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(52, 46);
            this.btnRejouer.TabIndex = 5;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // lblReussite
            // 
            this.lblReussite.AutoSize = true;
            this.lblReussite.Enabled = false;
            this.lblReussite.Location = new System.Drawing.Point(43, 212);
            this.lblReussite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReussite.Name = "lblReussite";
            this.lblReussite.Size = new System.Drawing.Size(0, 17);
            this.lblReussite.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotAChercher);
            this.groupBox1.Location = new System.Drawing.Point(27, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(225, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mot à chercher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLettres);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.lblLettres);
            this.groupBox2.Location = new System.Drawing.Point(27, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(225, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lettres testées";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblReussite);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.imgPendu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotAChercher;
        private System.Windows.Forms.ComboBox cmbLettres;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblLettres;
        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblReussite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


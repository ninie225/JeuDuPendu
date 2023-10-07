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
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblReussite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTestLettres = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMotAChercher
            // 
            this.txtMotAChercher.Location = new System.Drawing.Point(24, 23);
            this.txtMotAChercher.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotAChercher.Name = "txtMotAChercher";
            this.txtMotAChercher.Size = new System.Drawing.Size(332, 22);
            this.txtMotAChercher.TabIndex = 0;
            this.txtMotAChercher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotAChercher_KeyPress);
            // 
            // imgPendu
            // 
            this.imgPendu.Enabled = false;
            this.imgPendu.Location = new System.Drawing.Point(433, 15);
            this.imgPendu.Margin = new System.Windows.Forms.Padding(4);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(262, 268);
            this.imgPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPendu.TabIndex = 4;
            this.imgPendu.TabStop = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRejouer.Image = ((System.Drawing.Image)(resources.GetObject("btnRejouer.Image")));
            this.btnRejouer.Location = new System.Drawing.Point(353, 237);
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
            this.lblReussite.Location = new System.Drawing.Point(24, 252);
            this.lblReussite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReussite.Name = "lblReussite";
            this.lblReussite.Size = new System.Drawing.Size(44, 17);
            this.lblReussite.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotAChercher);
            this.groupBox1.Location = new System.Drawing.Point(27, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(378, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mot à chercher";
            // 
            // grpTestLettres
            // 
            this.grpTestLettres.Location = new System.Drawing.Point(27, 99);
            this.grpTestLettres.Margin = new System.Windows.Forms.Padding(4);
            this.grpTestLettres.Name = "grpTestLettres";
            this.grpTestLettres.Padding = new System.Windows.Forms.Padding(4);
            this.grpTestLettres.Size = new System.Drawing.Size(378, 130);
            this.grpTestLettres.TabIndex = 8;
            this.grpTestLettres.TabStop = false;
            this.grpTestLettres.Text = "Lettres testées";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 312);
            this.Controls.Add(this.grpTestLettres);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotAChercher;
        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblReussite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpTestLettres;
    }
}


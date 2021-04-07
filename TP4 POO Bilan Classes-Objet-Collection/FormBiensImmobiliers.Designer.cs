namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    partial class FormBiensImmobiliers
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
            this.gbTypeBien = new System.Windows.Forms.GroupBox();
            this.rbMaison = new System.Windows.Forms.RadioButton();
            this.rbAppart = new System.Windows.Forms.RadioButton();
            this.gbCaracteristiques = new System.Windows.Forms.GroupBox();
            this.numNbSalleEau = new System.Windows.Forms.NumericUpDown();
            this.numNbChambres = new System.Windows.Forms.NumericUpDown();
            this.numNbPieces = new System.Windows.Forms.NumericUpDown();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbSurface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPrix = new System.Windows.Forms.GroupBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cbListeBiens = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.gbConsultation = new System.Windows.Forms.GroupBox();
            this.btVente = new System.Windows.Forms.Button();
            this.lblEtatVente = new System.Windows.Forms.Label();
            this.tbPrixVente = new System.Windows.Forms.TextBox();
            this.lblPrixVente = new System.Windows.Forms.Label();
            this.gbTypeBien.SuspendLayout();
            this.gbCaracteristiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSalleEau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPieces)).BeginInit();
            this.gbPrix.SuspendLayout();
            this.gbConsultation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTypeBien
            // 
            this.gbTypeBien.Controls.Add(this.rbMaison);
            this.gbTypeBien.Controls.Add(this.rbAppart);
            this.gbTypeBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTypeBien.Location = new System.Drawing.Point(61, 12);
            this.gbTypeBien.Name = "gbTypeBien";
            this.gbTypeBien.Size = new System.Drawing.Size(370, 50);
            this.gbTypeBien.TabIndex = 0;
            this.gbTypeBien.TabStop = false;
            this.gbTypeBien.Text = "Type du bien";
            // 
            // rbMaison
            // 
            this.rbMaison.AutoSize = true;
            this.rbMaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaison.Location = new System.Drawing.Point(218, 20);
            this.rbMaison.Name = "rbMaison";
            this.rbMaison.Size = new System.Drawing.Size(70, 20);
            this.rbMaison.TabIndex = 1;
            this.rbMaison.TabStop = true;
            this.rbMaison.Text = "Maison";
            this.rbMaison.UseVisualStyleBackColor = true;
            // 
            // rbAppart
            // 
            this.rbAppart.AutoSize = true;
            this.rbAppart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAppart.Location = new System.Drawing.Point(66, 20);
            this.rbAppart.Name = "rbAppart";
            this.rbAppart.Size = new System.Drawing.Size(103, 20);
            this.rbAppart.TabIndex = 0;
            this.rbAppart.TabStop = true;
            this.rbAppart.Text = "Appartement";
            this.rbAppart.UseVisualStyleBackColor = true;
            // 
            // gbCaracteristiques
            // 
            this.gbCaracteristiques.Controls.Add(this.numNbSalleEau);
            this.gbCaracteristiques.Controls.Add(this.numNbChambres);
            this.gbCaracteristiques.Controls.Add(this.numNbPieces);
            this.gbCaracteristiques.Controls.Add(this.tbVille);
            this.gbCaracteristiques.Controls.Add(this.tbAdresse);
            this.gbCaracteristiques.Controls.Add(this.tbSurface);
            this.gbCaracteristiques.Controls.Add(this.label6);
            this.gbCaracteristiques.Controls.Add(this.label5);
            this.gbCaracteristiques.Controls.Add(this.label4);
            this.gbCaracteristiques.Controls.Add(this.label3);
            this.gbCaracteristiques.Controls.Add(this.label2);
            this.gbCaracteristiques.Controls.Add(this.label1);
            this.gbCaracteristiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaracteristiques.Location = new System.Drawing.Point(61, 68);
            this.gbCaracteristiques.Name = "gbCaracteristiques";
            this.gbCaracteristiques.Size = new System.Drawing.Size(370, 231);
            this.gbCaracteristiques.TabIndex = 1;
            this.gbCaracteristiques.TabStop = false;
            this.gbCaracteristiques.Text = "Caractéristiques";
            // 
            // numNbSalleEau
            // 
            this.numNbSalleEau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbSalleEau.Location = new System.Drawing.Point(149, 175);
            this.numNbSalleEau.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNbSalleEau.Name = "numNbSalleEau";
            this.numNbSalleEau.Size = new System.Drawing.Size(100, 22);
            this.numNbSalleEau.TabIndex = 11;
            // 
            // numNbChambres
            // 
            this.numNbChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbChambres.Location = new System.Drawing.Point(149, 147);
            this.numNbChambres.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNbChambres.Name = "numNbChambres";
            this.numNbChambres.Size = new System.Drawing.Size(100, 22);
            this.numNbChambres.TabIndex = 10;
            // 
            // numNbPieces
            // 
            this.numNbPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbPieces.Location = new System.Drawing.Point(149, 119);
            this.numNbPieces.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNbPieces.Name = "numNbPieces";
            this.numNbPieces.Size = new System.Drawing.Size(100, 22);
            this.numNbPieces.TabIndex = 9;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(95, 89);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(228, 22);
            this.tbVille.TabIndex = 8;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(95, 61);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(228, 22);
            this.tbAdresse.TabIndex = 7;
            // 
            // tbSurface
            // 
            this.tbSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurface.Location = new System.Drawing.Point(149, 32);
            this.tbSurface.Name = "tbSurface";
            this.tbSurface.Size = new System.Drawing.Size(100, 22);
            this.tbSurface.TabIndex = 6;
            this.tbSurface.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSurface_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nb de salles d\'eau : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nb de chambres : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nb de pièces :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ville : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surface habitable :";
            // 
            // gbPrix
            // 
            this.gbPrix.Controls.Add(this.tbPrix);
            this.gbPrix.Controls.Add(this.label7);
            this.gbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrix.Location = new System.Drawing.Point(61, 331);
            this.gbPrix.Name = "gbPrix";
            this.gbPrix.Size = new System.Drawing.Size(370, 64);
            this.gbPrix.TabIndex = 2;
            this.gbPrix.TabStop = false;
            this.gbPrix.Text = "Type du bien";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(100, 28);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 22);
            this.tbPrix.TabIndex = 1;
            this.tbPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrix_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prix voulu :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Red;
            this.btnAjouter.Location = new System.Drawing.Point(471, 359);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(96, 36);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(582, 359);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 36);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(698, 359);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(96, 36);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(122, 106);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(96, 36);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // cbListeBiens
            // 
            this.cbListeBiens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListeBiens.FormattingEnabled = true;
            this.cbListeBiens.Location = new System.Drawing.Point(20, 51);
            this.cbListeBiens.Name = "cbListeBiens";
            this.cbListeBiens.Size = new System.Drawing.Size(311, 21);
            this.cbListeBiens.TabIndex = 7;
            this.cbListeBiens.SelectedIndexChanged += new System.EventHandler(this.CbListeBiens_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Liste des biens ";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(224, 106);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(107, 36);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // gbConsultation
            // 
            this.gbConsultation.Controls.Add(this.btVente);
            this.gbConsultation.Controls.Add(this.label8);
            this.gbConsultation.Controls.Add(this.btnSupprimer);
            this.gbConsultation.Controls.Add(this.cbListeBiens);
            this.gbConsultation.Controls.Add(this.btnModifier);
            this.gbConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultation.Location = new System.Drawing.Point(451, 157);
            this.gbConsultation.Name = "gbConsultation";
            this.gbConsultation.Size = new System.Drawing.Size(358, 159);
            this.gbConsultation.TabIndex = 10;
            this.gbConsultation.TabStop = false;
            this.gbConsultation.Text = "Consultation des biens";
            // 
            // btVente
            // 
            this.btVente.Location = new System.Drawing.Point(20, 106);
            this.btVente.Name = "btVente";
            this.btVente.Size = new System.Drawing.Size(96, 36);
            this.btVente.TabIndex = 10;
            this.btVente.Text = "VENTE";
            this.btVente.UseVisualStyleBackColor = true;
            // 
            // lblEtatVente
            // 
            this.lblEtatVente.AutoSize = true;
            this.lblEtatVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtatVente.Location = new System.Drawing.Point(469, 46);
            this.lblEtatVente.Name = "lblEtatVente";
            this.lblEtatVente.Size = new System.Drawing.Size(98, 16);
            this.lblEtatVente.TabIndex = 11;
            this.lblEtatVente.Text = "État du bien :";
            // 
            // tbPrixVente
            // 
            this.tbPrixVente.Location = new System.Drawing.Point(618, 78);
            this.tbPrixVente.Name = "tbPrixVente";
            this.tbPrixVente.Size = new System.Drawing.Size(191, 20);
            this.tbPrixVente.TabIndex = 12;
            // 
            // lblPrixVente
            // 
            this.lblPrixVente.AutoSize = true;
            this.lblPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixVente.Location = new System.Drawing.Point(468, 78);
            this.lblPrixVente.Name = "lblPrixVente";
            this.lblPrixVente.Size = new System.Drawing.Size(139, 16);
            this.lblPrixVente.TabIndex = 13;
            this.lblPrixVente.Text = "Prix de vente final :";
            // 
            // FormBiensImmobiliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 415);
            this.Controls.Add(this.lblPrixVente);
            this.Controls.Add(this.tbPrixVente);
            this.Controls.Add(this.lblEtatVente);
            this.Controls.Add(this.gbConsultation);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbPrix);
            this.Controls.Add(this.gbCaracteristiques);
            this.Controls.Add(this.gbTypeBien);
            this.Name = "FormBiensImmobiliers";
            this.Text = "Gestion des biens immobiliers";
            this.Load += new System.EventHandler(this.FormBiensImmobiliers_Load);
            this.gbTypeBien.ResumeLayout(false);
            this.gbTypeBien.PerformLayout();
            this.gbCaracteristiques.ResumeLayout(false);
            this.gbCaracteristiques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSalleEau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPieces)).EndInit();
            this.gbPrix.ResumeLayout(false);
            this.gbPrix.PerformLayout();
            this.gbConsultation.ResumeLayout(false);
            this.gbConsultation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTypeBien;
        private System.Windows.Forms.RadioButton rbAppart;
        private System.Windows.Forms.RadioButton rbMaison;
        private System.Windows.Forms.GroupBox gbCaracteristiques;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numNbSalleEau;
        private System.Windows.Forms.NumericUpDown numNbChambres;
        private System.Windows.Forms.NumericUpDown numNbPieces;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbSurface;
        private System.Windows.Forms.GroupBox gbPrix;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cbListeBiens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox gbConsultation;
        private System.Windows.Forms.Button btVente;
        private System.Windows.Forms.Label lblEtatVente;
        private System.Windows.Forms.TextBox tbPrixVente;
        private System.Windows.Forms.Label lblPrixVente;
    }
}


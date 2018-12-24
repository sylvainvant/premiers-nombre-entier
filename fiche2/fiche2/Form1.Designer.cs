namespace fiche2
{
    partial class Fm_principal 
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
            this.lb_liste = new System.Windows.Forms.ListBox();
            this.tb_saisie = new System.Windows.Forms.TextBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_liste
            // 
            this.lb_liste.FormattingEnabled = true;
            this.lb_liste.Location = new System.Drawing.Point(12, 34);
            this.lb_liste.Name = "lb_liste";
            this.lb_liste.Size = new System.Drawing.Size(247, 134);
            this.lb_liste.Sorted = true;
            this.lb_liste.TabIndex = 0;
            // 
            // tb_saisie
            // 
            this.tb_saisie.Location = new System.Drawing.Point(12, 185);
            this.tb_saisie.Name = "tb_saisie";
            this.tb_saisie.Size = new System.Drawing.Size(247, 20);
            this.tb_saisie.TabIndex = 1;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(28, 221);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(75, 23);
            this.bt_ajouter.TabIndex = 2;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
       
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_supprimer.Location = new System.Drawing.Point(142, 221);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(75, 23);
            this.bt_supprimer.TabIndex = 3;
            this.bt_supprimer.Text = "supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Une liste déroulante";
            // 
            // Fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.tb_saisie);
            this.Controls.Add(this.lb_liste);
            this.Name = "Fm_principal";
            this.Text = "Premier programme ";
            this.Load += new System.EventHandler(this.Fm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_liste;
        private System.Windows.Forms.TextBox tb_saisie;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Label label1;
    }
}


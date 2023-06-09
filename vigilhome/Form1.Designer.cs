namespace vigilhome
{
    partial class frmHandicap
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
            this.lblConsigne = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnValidate = new vigilhome.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsigne
            // 
            this.lblConsigne.AutoSize = true;
            this.lblConsigne.ForeColor = System.Drawing.Color.White;
            this.lblConsigne.Location = new System.Drawing.Point(52, 226);
            this.lblConsigne.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConsigne.Name = "lblConsigne";
            this.lblConsigne.Size = new System.Drawing.Size(178, 26);
            this.lblConsigne.TabIndex = 0;
            this.lblConsigne.Text = "Identifiant tuteur";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(37, 279);
            this.txtEntry.Margin = new System.Windows.Forms.Padding(6);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(210, 33);
            this.txtEntry.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Silver;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(57, 436);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(173, 39);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "Votre tuteur doit vous donner\r\nson identifiant. Vous devrez le \r\nrentrer ci-desso" +
    "us.\r\n";
            // 
            // frmHandicap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(281, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblConsigne);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHandicap";
            this.Text = "VigilHome";
            this.Load += new System.EventHandler(this.frmHandicap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsigne;
        private System.Windows.Forms.TextBox txtEntry;
        private RJButton btnValidate;
        private System.Windows.Forms.Label label1;
    }
}


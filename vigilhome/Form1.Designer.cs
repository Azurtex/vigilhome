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
            this.lblError = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTracks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txtEntry.TextChanged += new System.EventHandler(this.txtEntry_TextChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Silver;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(48, 436);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(182, 39);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Visible = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Tomato;
            this.lblError.Location = new System.Drawing.Point(43, 35);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(200, 52);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Identifiant invalide.\r\nVeuillez rééssayer.";
            this.lblError.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(104, 35);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(67, 26);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Visible = false;
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.ForeColor = System.Drawing.Color.White;
            this.lblTracks.Location = new System.Drawing.Point(52, 109);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(180, 26);
            this.lblTracks.TabIndex = 6;
            this.lblTracks.Text = "Traceurs actifs : 3";
            this.lblTracks.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmHandicap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(281, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTracks);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblError);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsigne;
        private System.Windows.Forms.TextBox txtEntry;
        private RJButton btnValidate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


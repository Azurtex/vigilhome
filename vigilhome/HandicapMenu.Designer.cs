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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandicap));
            this.lblConsigne = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnValidate = new vigilhome.RJButton();
            this.lblError = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTracks = new System.Windows.Forms.Label();
            this.picLocation = new System.Windows.Forms.PictureBox();
            this.picHeartbeat = new System.Windows.Forms.PictureBox();
            this.picCameras = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnEdit = new vigilhome.RJButton();
            this.lblLocationStatus = new System.Windows.Forms.Label();
            this.lblStatusCam = new System.Windows.Forms.Label();
            this.lblStatusHB = new System.Windows.Forms.Label();
            this.btnRequest = new vigilhome.RJButton();
            this.btnEmergency = new vigilhome.RJButton();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnSave = new vigilhome.RJButton();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTracConsigne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartbeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.lblError.Location = new System.Drawing.Point(43, 148);
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
            this.lblTracks.Text = "Traceurs actifs : 2";
            this.lblTracks.Visible = false;
            // 
            // picLocation
            // 
            this.picLocation.BackColor = System.Drawing.Color.White;
            this.picLocation.Image = ((System.Drawing.Image)(resources.GetObject("picLocation.Image")));
            this.picLocation.Location = new System.Drawing.Point(12, 150);
            this.picLocation.Name = "picLocation";
            this.picLocation.Size = new System.Drawing.Size(70, 50);
            this.picLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLocation.TabIndex = 7;
            this.picLocation.TabStop = false;
            this.picLocation.Visible = false;
            this.picLocation.Click += new System.EventHandler(this.picLocation_Click);
            // 
            // picHeartbeat
            // 
            this.picHeartbeat.BackColor = System.Drawing.Color.White;
            this.picHeartbeat.Image = ((System.Drawing.Image)(resources.GetObject("picHeartbeat.Image")));
            this.picHeartbeat.Location = new System.Drawing.Point(199, 150);
            this.picHeartbeat.Name = "picHeartbeat";
            this.picHeartbeat.Size = new System.Drawing.Size(70, 50);
            this.picHeartbeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeartbeat.TabIndex = 8;
            this.picHeartbeat.TabStop = false;
            this.picHeartbeat.Visible = false;
            this.picHeartbeat.Click += new System.EventHandler(this.picHeartbeat_Click);
            // 
            // picCameras
            // 
            this.picCameras.BackColor = System.Drawing.Color.White;
            this.picCameras.Image = ((System.Drawing.Image)(resources.GetObject("picCameras.Image")));
            this.picCameras.Location = new System.Drawing.Point(109, 150);
            this.picCameras.Name = "picCameras";
            this.picCameras.Size = new System.Drawing.Size(70, 50);
            this.picCameras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCameras.TabIndex = 9;
            this.picCameras.TabStop = false;
            this.picCameras.Visible = false;
            this.picCameras.Click += new System.EventHandler(this.picCameras_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(88, -2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(110, 108);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(17, 510);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(249, 67);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Modifier profil";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblLocationStatus
            // 
            this.lblLocationStatus.AutoSize = true;
            this.lblLocationStatus.ForeColor = System.Drawing.Color.Cyan;
            this.lblLocationStatus.Location = new System.Drawing.Point(15, 203);
            this.lblLocationStatus.Name = "lblLocationStatus";
            this.lblLocationStatus.Size = new System.Drawing.Size(58, 26);
            this.lblLocationStatus.TabIndex = 13;
            this.lblLocationStatus.Text = "Actif";
            this.lblLocationStatus.Visible = false;
            // 
            // lblStatusCam
            // 
            this.lblStatusCam.AutoSize = true;
            this.lblStatusCam.ForeColor = System.Drawing.Color.Tomato;
            this.lblStatusCam.Location = new System.Drawing.Point(106, 203);
            this.lblStatusCam.Name = "lblStatusCam";
            this.lblStatusCam.Size = new System.Drawing.Size(73, 26);
            this.lblStatusCam.TabIndex = 14;
            this.lblStatusCam.Text = "Inactif";
            this.lblStatusCam.Visible = false;
            // 
            // lblStatusHB
            // 
            this.lblStatusHB.AutoSize = true;
            this.lblStatusHB.ForeColor = System.Drawing.Color.Cyan;
            this.lblStatusHB.Location = new System.Drawing.Point(208, 203);
            this.lblStatusHB.Name = "lblStatusHB";
            this.lblStatusHB.Size = new System.Drawing.Size(58, 26);
            this.lblStatusHB.TabIndex = 15;
            this.lblStatusHB.Text = "Actif";
            this.lblStatusHB.Visible = false;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.Silver;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(17, 422);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(249, 67);
            this.btnRequest.TabIndex = 16;
            this.btnRequest.Text = "Demande modification traceur";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Visible = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.Color.Red;
            this.btnEmergency.FlatAppearance.BorderSize = 0;
            this.btnEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergency.ForeColor = System.Drawing.Color.White;
            this.btnEmergency.Location = new System.Drawing.Point(57, 264);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(164, 113);
            this.btnEmergency.TabIndex = 17;
            this.btnEmergency.Text = "Urgence";
            this.btnEmergency.UseVisualStyleBackColor = false;
            this.btnEmergency.Visible = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(43, 9);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(211, 26);
            this.lblEdit.TabIndex = 18;
            this.lblEdit.Text = "Modifier votre profil";
            this.lblEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 67);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(15, 80);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(260, 26);
            this.lblTel.TabIndex = 20;
            this.lblTel.Text = "No de téléphone portable";
            this.lblTel.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(15, 203);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 26);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Adresse";
            this.lblAddress.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(20, 138);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(249, 33);
            this.txtTel.TabIndex = 22;
            this.txtTel.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(20, 232);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 33);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.Visible = false;
            // 
            // lblTracConsigne
            // 
            this.lblTracConsigne.AutoSize = true;
            this.lblTracConsigne.ForeColor = System.Drawing.Color.White;
            this.lblTracConsigne.Location = new System.Drawing.Point(32, 35);
            this.lblTracConsigne.Name = "lblTracConsigne";
            this.lblTracConsigne.Size = new System.Drawing.Size(230, 52);
            this.lblTracConsigne.TabIndex = 24;
            this.lblTracConsigne.Text = "Choisissez un traceur à\r\nactiver / désactiver";
            this.lblTracConsigne.Visible = false;
            // 
            // frmHandicap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(281, 589);
            this.Controls.Add(this.lblTracConsigne);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblStatusHB);
            this.Controls.Add(this.lblStatusCam);
            this.Controls.Add(this.lblLocationStatus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picCameras);
            this.Controls.Add(this.picHeartbeat);
            this.Controls.Add(this.picLocation);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartbeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCameras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox picLocation;
        private System.Windows.Forms.PictureBox picHeartbeat;
        private System.Windows.Forms.PictureBox picCameras;
        private System.Windows.Forms.PictureBox picLogo;
        private RJButton btnEdit;
        private System.Windows.Forms.Label lblLocationStatus;
        private System.Windows.Forms.Label lblStatusCam;
        private System.Windows.Forms.Label lblStatusHB;
        private RJButton btnRequest;
        private RJButton btnEmergency;
        private System.Windows.Forms.Label lblEdit;
        private RJButton btnSave;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTracConsigne;
    }
}


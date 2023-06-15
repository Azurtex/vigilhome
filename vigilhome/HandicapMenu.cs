using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vigilhome
{
    public partial class frmHandicap : Form
    {
        public frmHandicap()
        {
            InitializeComponent();
        }
        byte trackCount = 0;
        byte formNum = 0;
        /// <summary>
        /// Charge le programme et change la couleur de fond
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHandicap_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#433861");
        }
        /// <summary>
        /// Vérifie validité des identifiants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            //Création de listes

            List<Control> controllers = new List<Control>
            { lblMenu, lblTracks, picLocation, picCameras, picHeartbeat, btnEdit,btnRequest,
             lblLocationStatus,lblStatusHB,lblStatusCam,btnEmergency };

            // Cache tous les éléments
            if (txtEntry.Text.Contains("AS-"))
            {
                foreach (Control control in Controls)
                {
                    control.Hide();
                }
                foreach (Control control in controllers)
                {
                    control.Show();
                }
            }
            else
            {
                lblError.Show();
            }
        }
        /// <summary>
        /// vérifie que la personne entre un id correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEntry_TextChanged(object sender, EventArgs e)
        {
            if (txtEntry.Text.Length > 0)
            {
                btnValidate.Show();
            }
            if (txtEntry.Text.Length == 0)
            {
                btnValidate.Hide();
            }
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            string road = "Secours en route";

            if (btnEmergency.Text == road)
            {
                btnEmergency.Text = "Annulation de l'appel...";
                Timer timer = new Timer()
                { Interval = 3000, Enabled = true };
                timer.Tick += (s, events) =>
                {
                    btnEmergency.Text = "Urgence";
                    timer.Dispose();
                };
            }
            else
            {
                btnEmergency.Text = road;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<Control> showTrollers = new List<Control> { lblAddress, txtAddress, lblTel, txtTel,btnSave };
            foreach (Control ctrl in Controls)
            {
                ctrl.Hide();
            }
            foreach (Control ctrl in showTrollers)
            {
                ctrl.Show();
            }
        }

        /// <summary>
        /// Page de requête pour désactiver / activer un traceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRequest_Click(object sender, EventArgs e)
        {
            formNum = 1;
            foreach (Control controls in Controls)
            {
                controls.Hide();
            }
            List<Control> ctrl = new List<Control> { lblLocationStatus, lblStatusCam, lblStatusHB,picLocation,picCameras,picHeartbeat,lblTracConsigne };
            foreach (Control ctrlShow in ctrl)
            {
                ctrlShow.Show();               
            }
            
        }

        /// <summary>
        /// sauvegarde les changements de numéro de téléphone / adresse et retourne au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnValidate_Click(sender,e);
            List<Control> showTrollers = new List<Control> { lblAddress, txtAddress, lblTel, txtTel, btnSave };
            foreach (Control ctrl in Controls)
            {
                ctrl.Hide();
            }
        }

        private void picLocation_Click(object sender, EventArgs e)
        {
            if (formNum == 1)
            {
                TrackValidator();
            }
        }

        private void picCameras_Click(object sender, EventArgs e)
        {
            if (formNum == 1)
            {
                TrackValidator();
            }
        }

        private void picHeartbeat_Click(object sender, EventArgs e)
        {
            if (formNum == 1)
            {
                TrackValidator();
            }
            
        }

        private void TrackValidator()
        {
            if (formNum == 1)
            {
                MessageBox.Show("Une demande a été envoyée à votre tuteur");
                for (int i = 0; i < 3; i++)
                {
                    if (lblLocationStatus.Text == "Actif" || lblStatusHB.Text == "Actif" || lblStatusCam.Text == "Actif")
                    {
                        trackCount++;
                    }
                    else
                    {
                        trackCount--;
                    }
                }                
            }
            lblTracks.Text = "Traceurs actifs: " + trackCount;
            btnValidate.Show();
        }
    }
}

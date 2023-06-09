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
            // Cache tous les éléments
            if (txtEntry.Text.Contains("AS"))
            {
                lblError.Hide();
                lblConsigne.Hide();
                btnValidate.Hide();
                txtEntry.Hide();
                lblMenu.Show();
                lblTracks.Show();
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
    }
}

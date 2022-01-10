using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repte01_Francesc_Bague
{
    public partial class Formulari_Inici : System.Windows.Forms.Form
    {
        public Formulari_Inici()
        {
            InitializeComponent();
        }

        private void BarraAcces_Sortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraAcces_DadesDirectori_Click(object sender, EventArgs e)
        {
            Formulari_Directori f = new Formulari_Directori();

            f.ShowDialog();
        }

        private void BarraAcces_JSON_Llegir_Click(object sender, EventArgs e)
        {
            new Formulari_Llegir().ShowDialog();
        }

        private void BarraAcces_JSON_Escriure_Click(object sender, EventArgs e)
        {
            new Formulari_Escriure().ShowDialog();
        }
    }
}

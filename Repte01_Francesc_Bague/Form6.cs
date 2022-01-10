using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repte01_Francesc_Bague
{
    public partial class Formulari_Crear : Form
    {
        public static Data creat;
        public static bool Direcorio;
        public Formulari_Crear()
        {
            InitializeComponent();
            Crear_Ruta_CaixaText.Text = Formulari_Directori.rutaDirectorio.ToString();
        }
        private void Acceptar_Click(object sender, EventArgs e)
        {
            if (!Crear_Nom_CaixaText.Text.Equals(""))
            {
                String dir = Formulari_Directori.rutaDirectorio.ToString();
                String Tipus = "", Nom = "", Ruta = "";
                // Codi per a afegir directoris
                if (CrearTipus_Directori.Checked == true)
                {
                    Nom = Crear_Nom_CaixaText.Text.ToString();
                    Ruta = dir + Path.DirectorySeparatorChar + Nom;
                    if (!Path.HasExtension(Ruta))
                    {
                        Tipus = ".dir";

                        creat = new Data();
                        creat.Tipus = Tipus;
                        creat.Ruta = Ruta;
                        creat.Nom = Nom;
                        creat.Creacio = DateTime.Today;

                        Direcorio = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("¡¡ Un directorio no puede tener extensión !!", " ¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }// Codi per a afegir fitxers
                else if (CrearTipus_Fitxer.Checked == true)
                {
                    // Comprova si el nom introdüit te o no una extensió
                    if (Path.HasExtension(Crear_Nom_CaixaText.Text))
                    {
                        Nom = Crear_Nom_CaixaText.Text.ToString();
                        Ruta = dir + '\\' + Nom;
                        Tipus = Path.GetExtension(Ruta);

                        creat = new Data();
                        creat.Tipus = Tipus;
                        creat.Ruta = Ruta;
                        creat.Nom = Nom;
                        creat.Creacio = DateTime.Today;

                        Direcorio = false;
                        this.Close();
                    }// Si no te extensió llença un missatge d'error
                    else
                    {
                        MessageBox.Show("¡¡ Un fichero debe tener una extensión !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("¡¡ Primero has de dar-le un nombre !!", " ¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

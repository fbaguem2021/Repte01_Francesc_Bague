using Newtonsoft.Json.Linq;
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
    public partial class Formulari_Llegir : Form
    {
        List<Data> taula = new List<Data>();

        public Formulari_Llegir()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {  }

        private void Boto_Sortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Boto_Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                if (openfile.FileName.Contains(".json") == true)
                {
                    JSON_Ruta.Text = openfile.FileName;

                    JArray jarrayPeliculas = JArray.Parse(File.ReadAllText(JSON_Ruta.Text, Encoding.Default));
                    BindingList<Data> contenidoJSON = jarrayPeliculas.ToObject<BindingList<Data>>();

                    JSON_Taula.DataSource = null;
                    JSON_Taula.DataSource = contenidoJSON;
                }
                else
                {
                    MessageBox.Show("¡¡ El archivo seleccionado no es un JSON !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

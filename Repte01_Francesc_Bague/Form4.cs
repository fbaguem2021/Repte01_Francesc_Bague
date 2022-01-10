using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Repte01_Francesc_Bague
{
    public partial class Formulari_Escriure : Form
    {
        BindingList<Data> lista = new BindingList<Data>();
        protected static bool dadesCompletes;
        public Formulari_Escriure()
        {
            InitializeComponent();
            dadesCompletes = false;
        }

        private void BarraBotons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void Boto_Sortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Directori_Buscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscador = new FolderBrowserDialog();
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                Directori_Ruta.Text = buscador.SelectedPath;
                lista = getContenido(buscador.SelectedPath);

                BindingList<Data> listaAux = getDatosParaTabla();

                Taula_VistaPrevia.DataSource = listaAux.Select(o => new { Tipus = o.Tipus, Nom = o.Nom}).ToList();
                Taula_VistaPrevia.Columns[0].Width = 50;
                Taula_VistaPrevia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private BindingList<Data> getContenido(String rutaDirectori)
        {
            BindingList<Data> lista = new BindingList<Data>();
            DirectoryInfo directoriActual = new DirectoryInfo(rutaDirectori);

            foreach (DirectoryInfo dir in directoriActual.GetDirectories())
            {
                lista.Add(new Data(".dir", dir.Name, dir.FullName, dir.CreationTime));
            }
            foreach (FileInfo fichero in directoriActual.GetFiles())
            {
                lista.Add(new Data(fichero.Extension, fichero.Name, fichero.FullName, fichero.CreationTime));
            }
            return lista;
        }
        private BindingList<Data> getDatosParaTabla()
        {
            BindingList<Data> ListaAux = new BindingList<Data>();

            foreach (Data dato in lista)
            {
                Data aux = new Data(dato.Tipus, dato.Nom);
                ListaAux.Add(aux);
            }

            return ListaAux;
        }
        private void Boto_Desti_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscador = new FolderBrowserDialog();

            DialogResult dr = buscador.ShowDialog();
            if (dr == DialogResult.OK)
            {
                JSON_Ubicacio.Text = buscador.SelectedPath;
                JSON_RutaDef.Text = JSON_Ubicacio.Text + Path.DirectorySeparatorChar;
            }
            else if (dr != DialogResult.OK && dr != DialogResult.Cancel)
            {
                MessageBox.Show("El directorio no se ha seleccionado correctamente");
            }
        }
        private void JSON_Guardar_Click(object sender, EventArgs e)
        {
            bool ubiErr = JSON_Ubicacio.Text.Equals("") || JSON_Ubicacio.Text.Equals(null);
            bool namErr = JSON_Nom.Text.Equals("") || JSON_Nom.Text.Equals(null);
            bool ubiNamErr = ubiErr == true && namErr == true;
            if (Directori_Ruta.Text.Equals("") || Directori_Ruta.Text.Equals(null))
            {
                MessageBox.Show("¡¡ Primero debes selecciónar el directorio cuyo contenido vayas a guardar en el JSON !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// Si no se ha seleccionado un directorio
            else if (ubiErr == true)
            {
                MessageBox.Show("¡¡ Primero has de seleccionar una ubicación !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (namErr == true)
            {
                MessageBox.Show("¡¡ Primero debes dar un nombre al archivo JSON !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ubiNamErr == true)
            {
                MessageBox.Show("¡¡ Primero debes seleccionar la ubicación y darle un nombre !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("ara s'hauria de guardar");
                DialogResult dr;
                FileStream archivoJSON;
                if (File.Exists(JSON_RutaDef.Text))
                {
                    String text = "Ya hay un archivo con el nombre seleccionado.\n¿Desea sobreescribir el contenido de este?";

                    dr = MessageBox.Show(text, "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Sobreescribiendo archivo ...");
                        gravarJSON();
                    }
                }
                else
                {
                    archivoJSON = File.Create(JSON_RutaDef.Text);
                    archivoJSON.Close();
                    gravarJSON();
                }
            }
        }
        private void gravarJSON()
        {
            JArray arrayContenido = (JArray)JToken.FromObject(lista);
            File.WriteAllText(JSON_RutaDef.Text, arrayContenido.ToString());
        }
        private void JSON_Nom_Leave(object sender, EventArgs e)
        {
            // Si el textbox no está vacio
            if (!JSON_Nom.Text.Equals("") && !JSON_Nom.Text.Equals(null))
            {
                // Si el nombre no tiene extensión, o si esta noes '.json'
                if (!Path.HasExtension(JSON_Nom.Text) || Path.HasExtension(JSON_Nom.Text) && !Path.GetExtension(JSON_Nom.Text).Equals(".json"))
                {
                    MessageBox.Show("¡¡ El archivo JSON, debe tener una extensión '.json' !!\nAñadiendo extensión", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    JSON_Nom.Text = Path.ChangeExtension(JSON_Nom.Text, ".json");
                }
               JSON_RutaDef.Text = JSON_Ubicacio.Text + Path.DirectorySeparatorChar + JSON_Nom.Text;
            }
        }

        private void JSON_Nom_TextChanged(object sender, EventArgs e)
        {
            if (JSON_Ubicacio.Text.Equals("") || JSON_Ubicacio.Text.Equals(null))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Primero selecciona una ubucación para el archivo");
                JSON_Nom.Text = "";
            }
        }
    }
}

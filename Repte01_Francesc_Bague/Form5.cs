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
    public partial class Formulari_Renombrar : Form
    {
        public static Data data;
        /// <summary>
        /// Constructor del formulari que agafa per paràmetre un objecte de tipus Data
        /// Despres que inicialitzar el formulari, guarda el valor del parametre en la variable global.
        /// </summary>    
        public Formulari_Renombrar(Data a)
        {
            InitializeComponent();
            data = a;
            //Mostra en el primer cuadre de text el tipus del fitxer
            Renombrar_Tipus_CuadreText.Text = data.Tipus;
            //Mostra en el segon cuadre de texr el nom original del fitxer
            Renombrar_NomOriginal_CuadreText.Text = data.Nom;
        }
        private void Acceptar_Click(object sender, EventArgs e)
        {
            String tipusOriginal;
            String nomOriginal = data.Nom;
            
            DateTime d = data.Creacio;

            String ruta = Formulari_Directori.rutaDirectorio;
            String nomNou, rutaNova = ruta;

            if (data.Tipus.Equals(".dir"))
            {
                tipusOriginal = "Directori";
            }
            else
            {
                tipusOriginal = "Fitxer";
            }

            if (!Renombrar_NomNou_CuadreText.Text.Equals(""))
            {
                if (ruta.Contains("\\"))
                {
                    rutaNova += "\\";
                }
                else if (ruta.Contains("/"))
                {
                    rutaNova += "/";
                }
                // Si es un directori
                if (tipusOriginal.Equals("Directori"))
                {
                    nomNou = Renombrar_NomNou_CuadreText.Text;
                    if (!Path.HasExtension(nomNou))
                    {
                        if (nomOriginal.Equals(nomNou))
                        {
                            MessageBox.Show("¡¡ Deves introducir un nombre diferente al original !!", "¡¡ AVISO !!");
                        }
                        else
                        {
                            Directory.Move(data.Ruta, rutaNova + nomNou);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡¡ Un directorio no puede tener una extension en su nombre !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }// Si es un fitxer
                else if (tipusOriginal.Equals("Fitxer"))
                {
                    nomNou = Renombrar_NomNou_CuadreText.Text;
                    if (Path.HasExtension(nomNou))
                    {
                        if (nomOriginal.Equals(nomNou))
                        {
                            MessageBox.Show("¡¡ Deves introducir un nombre diferente al original !!", "¡¡ AVISO !!");
                        }
                        else
                        {
                            File.Move(data.Ruta, rutaNova + nomNou);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡¡ El fichero debe tener una extension en el nombre !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //Si no escrius res en el TextBox, salta el missatge i no es fa ningun canvi
                MessageBox.Show("¡¡ Necesitas escribir algo !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/* INFO
 * Diferents enllaços amb informació sobre diferents metodes
 * ===========================================================================================
 * Obtenir dades des de la ruta
 * https://docs.microsoft.com/es-es/dotnet/api/system.io.directory.getdirectories?view=net-5.0 
 * https://docs.microsoft.com/es-es/dotnet/api/system.io.directory.getfiles?view=net-5.0
 * https://docs.microsoft.com/es-es/dotnet/api/system.io.path.getextension?view=net-5.0
 * Filtrar DataGridView
 * https://stackoverflow.com/questions/45823314/c-sharp-windows-form-filtering-using-radiobutton 
 * https://www.youtube.com/watch?v=5-r-kKeit3M
 */

namespace Repte01_Francesc_Bague
{
    public partial class Formulari_Directori : Form
    {
        BindingList<Data> datosPrincipal = new BindingList<Data>();
        BindingList<Data> filtrado;
        public static String rutaDirectorio;
        DirectoryInfo directoriActual;
        public Formulari_Directori()
        {
            InitializeComponent();
        }
        /* ============================================================ FILTRADO DE DATOS ============================================================ */
        // Filtre TOTS (directoris + fitxers)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }
        private void DirectoriDadesFiltrar_Directoris_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }
        private void DirectoriDadesFiltrar_Fitxers_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltro();

        }
        /* ============================================================ BARRAS DE BOTONES ============================================================ */
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DirectoriDades_BarraEines_Afegir_Click(object sender, EventArgs e)
        {
            if (rutaDirectorio == null)
            {
                MessageBox.Show("¡¡ Primero debes seleccionar un directorio !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Formulari_Crear f = new Formulari_Crear();
                f.ShowDialog();
                Data objecteCreat = Formulari_Crear.creat;

                if (Formulari_Crear.creat != null)
                {
                    if (Formulari_Crear.Direcorio == true)
                    {
                        Directory.CreateDirectory(rutaDirectorio + Path.DirectorySeparatorChar + objecteCreat.Nom);
                    }// Si l'objecte que s'ha creat es un fitxer
                    else if (Formulari_Crear.Direcorio == false)
                    {
                        FileStream fitxer = File.Create(rutaDirectorio + Path.DirectorySeparatorChar + objecteCreat.Nom);
                        fitxer.Close();
                    }

                    CargarTaulaLlista();
                }
            }
        }
        private void DirectoriDades_BarraEines_Renombrar_Click(object sender, EventArgs e)
        {
            int posicion = DirectoriDades_TaulaContingut.SelectedRows[0].Index;

            if (DirectoriDades_TaulaContingut.SelectedRows.Count > 0)
            {
                Data data;
                data = datosPrincipal[posicion];
                Formulari_Renombrar f = new Formulari_Renombrar(data/*datosPrincipal*/);
                f.ShowDialog();

                CargarTaulaLlista();
            }
            else
            {
                MessageBox.Show("¡¡ Primero debes seleccionar una fila !!", "¡¡ ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DirectoriDades_BarraEines_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (rutaDirectorio == null)
            {
                MessageBox.Show("¡¡ Primero debes abrir un directorio !!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr = MessageBox.Show("¿ Estas seguro de querer borrarlo ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    int posicion = DirectoriDades_TaulaContingut.SelectedRows[0].Index;

                    Data data;
                    data = datosPrincipal[posicion];

                    // Si es un directori
                    if (data.Tipus.Equals(".dir"))
                    {
                        try
                        {
                            Directory.Delete(data.Ruta);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        CargarTaulaLlista();
                    }// Si es un fitxer
                    else if (data.Tipus.Equals(".dir") == false)
                    {
                        File.Delete(data.Ruta);
                        CargarTaulaLlista();
                    }
                }
                else if (dr == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Cancelando borrado");
                }
            }
        }
        private void DirectoriDades_BarraEines_Refrescar_Click(object sender, EventArgs e)
        {
            CargarTaulaLlista();
        }
        /* ============================================================ TRATADOS DE DATOS ============================================================ */
        private void DirectoriDireccio_Obrir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscador = new FolderBrowserDialog();
            DialogResult dr;

            dr = buscador.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (comprovar_MemoriaExterna(buscador.SelectedPath) )
                {
                    String mensage =
                        "El directorio seleccionado esta en una memoria externa.\n" +
                        "           ¿Està seguro de querer continuar?           ";
                    String titulo = "¡¡ AVISO !!";
                    dr = confirmar_MemoriaExterna(mensage, titulo);

                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        prepararMostrarDirectorio(buscador.SelectedPath);
                        CargarTaulaLlista();
                    }
                }
                else
                {
                    prepararMostrarDirectorio(buscador.SelectedPath);
                    CargarTaulaLlista();
                }
            }

        }
        private void prepararMostrarDirectorio(String ruta_buscador)
        {
            datosPrincipal.Clear();
            rutaDirectorio = ruta_buscador;
            DirectoriDireccio_Ruta.Text = ruta_buscador;
            directoriActual = new DirectoryInfo(rutaDirectorio);
        }
        /// <summary>
        /// Neteja i torna a omplir la taula i bindinglist
        /// </summary>        
        private void CargarTaulaLlista()
        {
            BindingList<Data> aux = datosPrincipal;
            DataGridView dg = DirectoriDades_TaulaContingut;
            datosPrincipal.Clear();

            obtenerDirectorios();
            obtenerFicheros();

            aplicarFiltro();

            dg.DataSource = filtrado;
            dg.Refresh();
        }
        /// <summary>
        /// Metode que afegeix a la BindingList un conjunt d'objectes que guarden l'informació dels directoris
        /// </summary>        
        private void obtenerDirectorios()
        {
            foreach (DirectoryInfo dir in directoriActual.GetDirectories())
            {
                Data data = new Data();
                data.Tipus = ".dir";
                data.Nom = dir.Name;
                data.Ruta = dir.FullName;
                data.Creacio = dir.CreationTime;
                datosPrincipal.Add(data);
            }

        }
        /// <summary>
        /// Metode que afegeix a la BindingList un conjunt d'objectes que guarden l'informació dels fitxers
        /// </summary>
        private void obtenerFicheros()
        {
            foreach (FileInfo fichero in directoriActual.GetFiles())
            {
                // Guarda tot el contingut exceptuant l'archiu desktop.ini per a evitar cualsevol problema que l'eliminació i/o modificació d'aquest pugui causar
                if (!fichero.FullName.Contains("desktop.ini"))
                {
                    Data data = new Data();
                    data.Tipus = fichero.Extension;
                    data.Nom = fichero.Name;
                    data.Ruta = fichero.FullName;
                    data.Creacio = fichero.CreationTime;
                    datosPrincipal.Add(data);
                }
            }
        }
        /// <summary>
        /// Comprova quins filtres estan aplicats a la taula
        /// despres canvia els valors de la llista depenent del filtrat sel·leccionat
        /// </summary>        
        private void aplicarFiltro()
        {

            DateTime dt = DirectoriDadesFiltrar_Creacio.Value.Date;

            if (DirectoriDadesFiltrar_Tots.Checked == true)
            {
                filtrado = new BindingList<Data>(datosPrincipal.Where(p => p.Tipus.Contains(".dir") || !p.Tipus.Contains(".dir")).ToList());
                filtrado = new BindingList<Data>(filtrado.Where(p => p.Creacio.Date <= dt.Date).ToList());
                DirectoriDades_TaulaContingut.DataSource = filtrado;
            }
            else if (DirectoriDadesFiltrar_Directoris.Checked == true)
            {
                filtrado = new BindingList<Data>(datosPrincipal.Where(p => p.Tipus.Contains(".dir")).ToList());
                filtrado = new BindingList<Data>(filtrado.Where(p => p.Creacio.Date <= dt.Date).ToList());
                DirectoriDades_TaulaContingut.DataSource = filtrado;
            }
            else if (DirectoriDadesFiltrar_Fitxers.Checked == true)
            {
                filtrado = new BindingList<Data>(datosPrincipal.Where(p => !p.Tipus.Contains(".dir")).ToList());
                filtrado = new BindingList<Data>(filtrado.Where(p => p.Creacio.Date <= dt.Date).ToList());
                DirectoriDades_TaulaContingut.DataSource = filtrado;
            }
        }
        /// <summary>
        /// Primera versió del metode per a obtenir l'informació del contingut del directori.
        /// Aquest mètode, mitgançant dos arrays d'String, guarda les dades en un array static d'objectes Data, i despres el retorna
        /// </summary>
        [ObsoleteAttribute("Mejor utiliza los metodos obtenerDirectorios y obtenerFicheros.", true)]
        private Data[] obtenerContenido(String[] archivos, String[] directorios)
        {
            Data[] data = new Data[archivos.Length - 1 + directorios.Length];
            String[] rutas = archivos.Concat(directorios).ToArray();
            int i = 0;
            DateTime aux;

            foreach (String path in rutas)
            {
                if (!Path.GetFullPath(path).Contains("desktop.ini"))
                {
                    data[i] = new Data();
                    if (Path.HasExtension(path))
                    {
                        data[i].Tipus = Path.GetExtension(path);
                    }
                    else
                    {
                        data[i].Tipus = "dir";
                    }
                    data[i].Nom = Path.GetFileName(path);
                    data[i].Ruta = Path.GetFullPath(path);
                    aux = File.GetCreationTime(path);
                    data[i].Creacio = new DateTime(aux.Year, aux.Month, aux.Day);
                    i++;
                }
            }
            return data;
        }
        /* ============================================================ ORDENAR LOS DATOS ============================================================ */
        private bool sortAscending = false;
        /// <summary>
        /// Aquest mètode, el qual s'activa al 'clicar' un dels capçals,ordena la columa de manera ascendent i/o descendent
        /// </summary>
        private void DirectoriDades_TaulaContingut_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.ColumnIndex;

            switch (e.ColumnIndex)
            {
                case 0:
                    if (sortAscending)
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderBy(p => p.Tipus).ToList();
                    }
                    else
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderByDescending(p => p.Tipus).ToList();
                    }
                    sortAscending = !sortAscending;
                    break;
                case 1:
                    if (sortAscending)
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderBy(p => p.Nom).ToList();
                    }
                    else
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderByDescending(p => p.Nom).ToList();
                    }
                    sortAscending = !sortAscending;
                    break;
                case 2:
                    if (sortAscending)
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderBy(p => p.Ruta).ToList();
                    }
                    else
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderByDescending(p => p.Ruta).ToList();
                    }
                    sortAscending = !sortAscending;
                    break;
                case 3:
                    if (sortAscending)
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderBy(p => p.Creacio).ToList();
                    }
                    else
                    {
                        DirectoriDades_TaulaContingut.DataSource = filtrado.OrderByDescending(p => p.Creacio).ToList();
                    }
                    sortAscending = !sortAscending;
                    break;
                default:
                    break;
            }
        }
        /* ========================================================= METODOS DE COMPROVACIÓN ========================================================= */
        /// <summary>
        /// Metode que obra un MessageÇBox i li demana a l'usuari que realitzi una confirmació
        /// </summary>
        /// <returns>
        /// Retorna un DialogResult amb l'opcio seleccionada per l'uisuari
        /// </returns>
        private DialogResult confirmar_MemoriaExterna(String text, String caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Mètode que comprova si la ruta sel·leccionada es o esta en una memoria externa (USB, disc dur, etc)
        /// </summary>
        /// <returns>Retorna un valor boleà indicant si coincideix o no amb el d'una memoria externa</returns>
        private bool comprovar_MemoriaExterna(String rutaSeleccionada)
        {
            return (!rutaSeleccionada.StartsWith("C:") || rutaSeleccionada.StartsWith("/media"));
        }
    }
}

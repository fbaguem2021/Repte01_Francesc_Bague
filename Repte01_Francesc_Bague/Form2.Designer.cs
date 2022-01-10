
namespace Repte01_Francesc_Bague
{
    partial class Formulari_Directori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulari_Directori));
            this.BarraBotons = new System.Windows.Forms.ToolStrip();
            this.Boto_Sortir = new System.Windows.Forms.ToolStripButton();
            this.Directori = new System.Windows.Forms.GroupBox();
            this.DirectoriDades = new System.Windows.Forms.GroupBox();
            this.DirectoriDades_BarraEines = new System.Windows.Forms.ToolStrip();
            this.DirectoriDades_BarraEines_Afegir = new System.Windows.Forms.ToolStripButton();
            this.DirectoriDades_BarraEines_Renombrar = new System.Windows.Forms.ToolStripButton();
            this.DirectoriDades_BarraEines_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.DirectoriDades_BarraEines_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.DirectoriDadesFiltrar = new System.Windows.Forms.GroupBox();
            this.DirectoriDadesFiltrar_Creacio = new System.Windows.Forms.DateTimePicker();
            this.DirectoriDadesFiltrar_Fitxers = new System.Windows.Forms.RadioButton();
            this.DirectoriDadesFiltrar_Directoris = new System.Windows.Forms.RadioButton();
            this.DirectoriDadesFiltrar_Tots = new System.Windows.Forms.RadioButton();
            this.DirectoriDades_TaulaContingut = new System.Windows.Forms.DataGridView();
            this.DirectoriDireccio = new System.Windows.Forms.GroupBox();
            this.DirectoriDireccio_Obrir = new System.Windows.Forms.Button();
            this.DirectoriDireccio_Ruta = new System.Windows.Forms.TextBox();
            this.DirectoriDireccio_directori = new System.Windows.Forms.Label();
            this.DirectoriDades_TaulaContingut_Columna_Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoriDades_TaulaContingut_Columna_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoriDades_TaulaContingut_Columna_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoriDades_TaulaContingut_Columna_Creacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraBotons.SuspendLayout();
            this.Directori.SuspendLayout();
            this.DirectoriDades.SuspendLayout();
            this.DirectoriDades_BarraEines.SuspendLayout();
            this.DirectoriDadesFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoriDades_TaulaContingut)).BeginInit();
            this.DirectoriDireccio.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraBotons
            // 
            this.BarraBotons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boto_Sortir});
            this.BarraBotons.Location = new System.Drawing.Point(0, 0);
            this.BarraBotons.Name = "BarraBotons";
            this.BarraBotons.Size = new System.Drawing.Size(800, 25);
            this.BarraBotons.TabIndex = 0;
            this.BarraBotons.Text = "toolStrip1";
            // 
            // Boto_Sortir
            // 
            this.Boto_Sortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Boto_Sortir.Image = ((System.Drawing.Image)(resources.GetObject("Boto_Sortir.Image")));
            this.Boto_Sortir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Boto_Sortir.Name = "Boto_Sortir";
            this.Boto_Sortir.Size = new System.Drawing.Size(23, 22);
            this.Boto_Sortir.Text = "Sortir";
            this.Boto_Sortir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Directori
            // 
            this.Directori.Controls.Add(this.DirectoriDades);
            this.Directori.Controls.Add(this.DirectoriDireccio);
            this.Directori.Location = new System.Drawing.Point(13, 29);
            this.Directori.Name = "Directori";
            this.Directori.Size = new System.Drawing.Size(775, 381);
            this.Directori.TabIndex = 1;
            this.Directori.TabStop = false;
            this.Directori.Text = "Directori";
            // 
            // DirectoriDades
            // 
            this.DirectoriDades.Controls.Add(this.DirectoriDades_BarraEines);
            this.DirectoriDades.Controls.Add(this.DirectoriDadesFiltrar);
            this.DirectoriDades.Controls.Add(this.DirectoriDades_TaulaContingut);
            this.DirectoriDades.Location = new System.Drawing.Point(6, 106);
            this.DirectoriDades.Name = "DirectoriDades";
            this.DirectoriDades.Size = new System.Drawing.Size(763, 267);
            this.DirectoriDades.TabIndex = 1;
            this.DirectoriDades.TabStop = false;
            this.DirectoriDades.Text = "Dades";
            // 
            // DirectoriDades_BarraEines
            // 
            this.DirectoriDades_BarraEines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DirectoriDades_BarraEines_Afegir,
            this.DirectoriDades_BarraEines_Renombrar,
            this.DirectoriDades_BarraEines_Eliminar,
            this.DirectoriDades_BarraEines_Refrescar});
            this.DirectoriDades_BarraEines.Location = new System.Drawing.Point(3, 16);
            this.DirectoriDades_BarraEines.Name = "DirectoriDades_BarraEines";
            this.DirectoriDades_BarraEines.Size = new System.Drawing.Size(757, 25);
            this.DirectoriDades_BarraEines.TabIndex = 13;
            this.DirectoriDades_BarraEines.Text = "Barra d\'eines";
            // 
            // DirectoriDades_BarraEines_Afegir
            // 
            this.DirectoriDades_BarraEines_Afegir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DirectoriDades_BarraEines_Afegir.Image = ((System.Drawing.Image)(resources.GetObject("DirectoriDades_BarraEines_Afegir.Image")));
            this.DirectoriDades_BarraEines_Afegir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DirectoriDades_BarraEines_Afegir.Name = "DirectoriDades_BarraEines_Afegir";
            this.DirectoriDades_BarraEines_Afegir.Size = new System.Drawing.Size(23, 22);
            this.DirectoriDades_BarraEines_Afegir.Text = "Afegir";
            this.DirectoriDades_BarraEines_Afegir.Click += new System.EventHandler(this.DirectoriDades_BarraEines_Afegir_Click);
            // 
            // DirectoriDades_BarraEines_Renombrar
            // 
            this.DirectoriDades_BarraEines_Renombrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DirectoriDades_BarraEines_Renombrar.Image = ((System.Drawing.Image)(resources.GetObject("DirectoriDades_BarraEines_Renombrar.Image")));
            this.DirectoriDades_BarraEines_Renombrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DirectoriDades_BarraEines_Renombrar.Name = "DirectoriDades_BarraEines_Renombrar";
            this.DirectoriDades_BarraEines_Renombrar.Size = new System.Drawing.Size(23, 22);
            this.DirectoriDades_BarraEines_Renombrar.Text = "Renombrar";
            this.DirectoriDades_BarraEines_Renombrar.Click += new System.EventHandler(this.DirectoriDades_BarraEines_Renombrar_Click);
            // 
            // DirectoriDades_BarraEines_Eliminar
            // 
            this.DirectoriDades_BarraEines_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DirectoriDades_BarraEines_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("DirectoriDades_BarraEines_Eliminar.Image")));
            this.DirectoriDades_BarraEines_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DirectoriDades_BarraEines_Eliminar.Name = "DirectoriDades_BarraEines_Eliminar";
            this.DirectoriDades_BarraEines_Eliminar.Size = new System.Drawing.Size(23, 22);
            this.DirectoriDades_BarraEines_Eliminar.Text = "Eliminar";
            this.DirectoriDades_BarraEines_Eliminar.Click += new System.EventHandler(this.DirectoriDades_BarraEines_Eliminar_Click);
            // 
            // DirectoriDades_BarraEines_Refrescar
            // 
            this.DirectoriDades_BarraEines_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DirectoriDades_BarraEines_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("DirectoriDades_BarraEines_Refrescar.Image")));
            this.DirectoriDades_BarraEines_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DirectoriDades_BarraEines_Refrescar.Name = "DirectoriDades_BarraEines_Refrescar";
            this.DirectoriDades_BarraEines_Refrescar.Size = new System.Drawing.Size(23, 22);
            this.DirectoriDades_BarraEines_Refrescar.Text = "Refrescar";
            this.DirectoriDades_BarraEines_Refrescar.Click += new System.EventHandler(this.DirectoriDades_BarraEines_Refrescar_Click);
            // 
            // DirectoriDadesFiltrar
            // 
            this.DirectoriDadesFiltrar.Controls.Add(this.DirectoriDadesFiltrar_Creacio);
            this.DirectoriDadesFiltrar.Controls.Add(this.DirectoriDadesFiltrar_Fitxers);
            this.DirectoriDadesFiltrar.Controls.Add(this.DirectoriDadesFiltrar_Directoris);
            this.DirectoriDadesFiltrar.Controls.Add(this.DirectoriDadesFiltrar_Tots);
            this.DirectoriDadesFiltrar.Location = new System.Drawing.Point(9, 210);
            this.DirectoriDadesFiltrar.Name = "DirectoriDadesFiltrar";
            this.DirectoriDadesFiltrar.Size = new System.Drawing.Size(748, 48);
            this.DirectoriDadesFiltrar.TabIndex = 12;
            this.DirectoriDadesFiltrar.TabStop = false;
            this.DirectoriDadesFiltrar.Text = "Filtrar";
            // 
            // DirectoriDadesFiltrar_Creacio
            // 
            this.DirectoriDadesFiltrar_Creacio.Location = new System.Drawing.Point(492, 15);
            this.DirectoriDadesFiltrar_Creacio.Name = "DirectoriDadesFiltrar_Creacio";
            this.DirectoriDadesFiltrar_Creacio.Size = new System.Drawing.Size(200, 20);
            this.DirectoriDadesFiltrar_Creacio.TabIndex = 3;
            this.DirectoriDadesFiltrar_Creacio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DirectoriDadesFiltrar_Fitxers
            // 
            this.DirectoriDadesFiltrar_Fitxers.AutoSize = true;
            this.DirectoriDadesFiltrar_Fitxers.Location = new System.Drawing.Point(374, 19);
            this.DirectoriDadesFiltrar_Fitxers.Name = "DirectoriDadesFiltrar_Fitxers";
            this.DirectoriDadesFiltrar_Fitxers.Size = new System.Drawing.Size(55, 17);
            this.DirectoriDadesFiltrar_Fitxers.TabIndex = 2;
            this.DirectoriDadesFiltrar_Fitxers.Text = "Fitxers";
            this.DirectoriDadesFiltrar_Fitxers.UseVisualStyleBackColor = true;
            this.DirectoriDadesFiltrar_Fitxers.CheckedChanged += new System.EventHandler(this.DirectoriDadesFiltrar_Fitxers_CheckedChanged);
            // 
            // DirectoriDadesFiltrar_Directoris
            // 
            this.DirectoriDadesFiltrar_Directoris.AutoSize = true;
            this.DirectoriDadesFiltrar_Directoris.Location = new System.Drawing.Point(224, 19);
            this.DirectoriDadesFiltrar_Directoris.Name = "DirectoriDadesFiltrar_Directoris";
            this.DirectoriDadesFiltrar_Directoris.Size = new System.Drawing.Size(69, 17);
            this.DirectoriDadesFiltrar_Directoris.TabIndex = 1;
            this.DirectoriDadesFiltrar_Directoris.Text = "Directoris";
            this.DirectoriDadesFiltrar_Directoris.UseVisualStyleBackColor = true;
            this.DirectoriDadesFiltrar_Directoris.CheckedChanged += new System.EventHandler(this.DirectoriDadesFiltrar_Directoris_CheckedChanged);
            // 
            // DirectoriDadesFiltrar_Tots
            // 
            this.DirectoriDadesFiltrar_Tots.AutoSize = true;
            this.DirectoriDadesFiltrar_Tots.Checked = true;
            this.DirectoriDadesFiltrar_Tots.Location = new System.Drawing.Point(108, 18);
            this.DirectoriDadesFiltrar_Tots.Name = "DirectoriDadesFiltrar_Tots";
            this.DirectoriDadesFiltrar_Tots.Size = new System.Drawing.Size(46, 17);
            this.DirectoriDadesFiltrar_Tots.TabIndex = 0;
            this.DirectoriDadesFiltrar_Tots.TabStop = true;
            this.DirectoriDadesFiltrar_Tots.Text = "Tots";
            this.DirectoriDadesFiltrar_Tots.UseVisualStyleBackColor = true;
            this.DirectoriDadesFiltrar_Tots.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DirectoriDades_TaulaContingut
            // 
            this.DirectoriDades_TaulaContingut.AllowUserToAddRows = false;
            this.DirectoriDades_TaulaContingut.AllowUserToDeleteRows = false;
            this.DirectoriDades_TaulaContingut.AllowUserToOrderColumns = true;
            this.DirectoriDades_TaulaContingut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DirectoriDades_TaulaContingut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirectoriDades_TaulaContingut_Columna_Tipus,
            this.DirectoriDades_TaulaContingut_Columna_Nom,
            this.DirectoriDades_TaulaContingut_Columna_Ruta,
            this.DirectoriDades_TaulaContingut_Columna_Creacio});
            this.DirectoriDades_TaulaContingut.Location = new System.Drawing.Point(9, 54);
            this.DirectoriDades_TaulaContingut.Name = "DirectoriDades_TaulaContingut";
            this.DirectoriDades_TaulaContingut.ReadOnly = true;
            this.DirectoriDades_TaulaContingut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DirectoriDades_TaulaContingut.Size = new System.Drawing.Size(748, 150);
            this.DirectoriDades_TaulaContingut.TabIndex = 8;
            this.DirectoriDades_TaulaContingut.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DirectoriDades_TaulaContingut_ColumnHeaderMouseClick);
            // 
            // DirectoriDireccio
            // 
            this.DirectoriDireccio.Controls.Add(this.DirectoriDireccio_Obrir);
            this.DirectoriDireccio.Controls.Add(this.DirectoriDireccio_Ruta);
            this.DirectoriDireccio.Controls.Add(this.DirectoriDireccio_directori);
            this.DirectoriDireccio.Location = new System.Drawing.Point(6, 29);
            this.DirectoriDireccio.Name = "DirectoriDireccio";
            this.DirectoriDireccio.Size = new System.Drawing.Size(763, 61);
            this.DirectoriDireccio.TabIndex = 0;
            this.DirectoriDireccio.TabStop = false;
            this.DirectoriDireccio.Text = "Directori a mostrar";
            // 
            // DirectoriDireccio_Obrir
            // 
            this.DirectoriDireccio_Obrir.Location = new System.Drawing.Point(682, 21);
            this.DirectoriDireccio_Obrir.Name = "DirectoriDireccio_Obrir";
            this.DirectoriDireccio_Obrir.Size = new System.Drawing.Size(75, 23);
            this.DirectoriDireccio_Obrir.TabIndex = 2;
            this.DirectoriDireccio_Obrir.Text = "Obrir";
            this.DirectoriDireccio_Obrir.UseVisualStyleBackColor = true;
            this.DirectoriDireccio_Obrir.Click += new System.EventHandler(this.DirectoriDireccio_Obrir_Click);
            // 
            // DirectoriDireccio_Ruta
            // 
            this.DirectoriDireccio_Ruta.Location = new System.Drawing.Point(85, 23);
            this.DirectoriDireccio_Ruta.Name = "DirectoriDireccio_Ruta";
            this.DirectoriDireccio_Ruta.ReadOnly = true;
            this.DirectoriDireccio_Ruta.Size = new System.Drawing.Size(591, 20);
            this.DirectoriDireccio_Ruta.TabIndex = 1;
            // 
            // DirectoriDireccio_directori
            // 
            this.DirectoriDireccio_directori.AutoSize = true;
            this.DirectoriDireccio_directori.Location = new System.Drawing.Point(6, 26);
            this.DirectoriDireccio_directori.Name = "DirectoriDireccio_directori";
            this.DirectoriDireccio_directori.Size = new System.Drawing.Size(73, 13);
            this.DirectoriDireccio_directori.TabIndex = 0;
            this.DirectoriDireccio_directori.Text = "Ruta absoluta";
            // 
            // DirectoriDades_TaulaContingut_Columna_Tipus
            // 
            this.DirectoriDades_TaulaContingut_Columna_Tipus.DataPropertyName = "Tipus";
            this.DirectoriDades_TaulaContingut_Columna_Tipus.HeaderText = "Tipus";
            this.DirectoriDades_TaulaContingut_Columna_Tipus.Name = "DirectoriDades_TaulaContingut_Columna_Tipus";
            this.DirectoriDades_TaulaContingut_Columna_Tipus.ReadOnly = true;
            this.DirectoriDades_TaulaContingut_Columna_Tipus.Width = 70;
            // 
            // DirectoriDades_TaulaContingut_Columna_Nom
            // 
            this.DirectoriDades_TaulaContingut_Columna_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectoriDades_TaulaContingut_Columna_Nom.DataPropertyName = "Nom";
            this.DirectoriDades_TaulaContingut_Columna_Nom.HeaderText = "Nom";
            this.DirectoriDades_TaulaContingut_Columna_Nom.Name = "DirectoriDades_TaulaContingut_Columna_Nom";
            this.DirectoriDades_TaulaContingut_Columna_Nom.ReadOnly = true;
            // 
            // DirectoriDades_TaulaContingut_Columna_Ruta
            // 
            this.DirectoriDades_TaulaContingut_Columna_Ruta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectoriDades_TaulaContingut_Columna_Ruta.DataPropertyName = "Ruta";
            this.DirectoriDades_TaulaContingut_Columna_Ruta.HeaderText = "Ruta";
            this.DirectoriDades_TaulaContingut_Columna_Ruta.Name = "DirectoriDades_TaulaContingut_Columna_Ruta";
            this.DirectoriDades_TaulaContingut_Columna_Ruta.ReadOnly = true;
            // 
            // DirectoriDades_TaulaContingut_Columna_Creacio
            // 
            this.DirectoriDades_TaulaContingut_Columna_Creacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectoriDades_TaulaContingut_Columna_Creacio.DataPropertyName = "Creacio";
            this.DirectoriDades_TaulaContingut_Columna_Creacio.HeaderText = "Data de Creació";
            this.DirectoriDades_TaulaContingut_Columna_Creacio.Name = "DirectoriDades_TaulaContingut_Columna_Creacio";
            this.DirectoriDades_TaulaContingut_Columna_Creacio.ReadOnly = true;
            // 
            // Formulari_Directori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.Directori);
            this.Controls.Add(this.BarraBotons);
            this.Name = "Formulari_Directori";
            this.Text = "Dades Directori";
            this.BarraBotons.ResumeLayout(false);
            this.BarraBotons.PerformLayout();
            this.Directori.ResumeLayout(false);
            this.DirectoriDades.ResumeLayout(false);
            this.DirectoriDades.PerformLayout();
            this.DirectoriDades_BarraEines.ResumeLayout(false);
            this.DirectoriDades_BarraEines.PerformLayout();
            this.DirectoriDadesFiltrar.ResumeLayout(false);
            this.DirectoriDadesFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoriDades_TaulaContingut)).EndInit();
            this.DirectoriDireccio.ResumeLayout(false);
            this.DirectoriDireccio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraBotons;
        private System.Windows.Forms.ToolStripButton Boto_Sortir;
        private System.Windows.Forms.GroupBox Directori;
        private System.Windows.Forms.GroupBox DirectoriDireccio;
        private System.Windows.Forms.Button DirectoriDireccio_Obrir;
        private System.Windows.Forms.TextBox DirectoriDireccio_Ruta;
        private System.Windows.Forms.Label DirectoriDireccio_directori;
        private System.Windows.Forms.GroupBox DirectoriDades;
        private System.Windows.Forms.DataGridView DirectoriDades_TaulaContingut;
        private System.Windows.Forms.GroupBox DirectoriDadesFiltrar;
        private System.Windows.Forms.RadioButton DirectoriDadesFiltrar_Tots;
        private System.Windows.Forms.RadioButton DirectoriDadesFiltrar_Fitxers;
        private System.Windows.Forms.RadioButton DirectoriDadesFiltrar_Directoris;
        private System.Windows.Forms.ToolStrip DirectoriDades_BarraEines;
        private System.Windows.Forms.ToolStripButton DirectoriDades_BarraEines_Renombrar;
        private System.Windows.Forms.ToolStripButton DirectoriDades_BarraEines_Afegir;
        private System.Windows.Forms.ToolStripButton DirectoriDades_BarraEines_Eliminar;
        private System.Windows.Forms.DateTimePicker DirectoriDadesFiltrar_Creacio;
        private System.Windows.Forms.ToolStripButton DirectoriDades_BarraEines_Refrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoriDades_TaulaContingut_Columna_Tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoriDades_TaulaContingut_Columna_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoriDades_TaulaContingut_Columna_Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoriDades_TaulaContingut_Columna_Creacio;
    }
}
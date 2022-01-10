
namespace Repte01_Francesc_Bague
{
    partial class Formulari_Escriure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulari_Escriure));
            this.BarraBotons = new System.Windows.Forms.ToolStrip();
            this.Boto_Sortir = new System.Windows.Forms.ToolStripButton();
            this.Directori_group = new System.Windows.Forms.GroupBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.Taula_VistaPrevia = new System.Windows.Forms.DataGridView();
            this.Directori_Ruta = new System.Windows.Forms.TextBox();
            this.Directori_Buscar = new System.Windows.Forms.Button();
            this.JSON_group = new System.Windows.Forms.GroupBox();
            this.JSON_RutaDef = new System.Windows.Forms.TextBox();
            this.JSON_Guardar = new System.Windows.Forms.Button();
            this.JSON_lblNom = new System.Windows.Forms.Label();
            this.JSON_Nom = new System.Windows.Forms.TextBox();
            this.JSON_lblUbicacio = new System.Windows.Forms.Label();
            this.Boto_Desti = new System.Windows.Forms.Button();
            this.JSON_Ubicacio = new System.Windows.Forms.TextBox();
            this.BarraBotons.SuspendLayout();
            this.Directori_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Taula_VistaPrevia)).BeginInit();
            this.JSON_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraBotons
            // 
            this.BarraBotons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boto_Sortir});
            this.BarraBotons.Location = new System.Drawing.Point(0, 0);
            this.BarraBotons.Name = "BarraBotons";
            this.BarraBotons.Size = new System.Drawing.Size(377, 25);
            this.BarraBotons.TabIndex = 2;
            this.BarraBotons.Text = "toolStrip1";
            this.BarraBotons.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BarraBotons_ItemClicked);
            // 
            // Boto_Sortir
            // 
            this.Boto_Sortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Boto_Sortir.Image = ((System.Drawing.Image)(resources.GetObject("Boto_Sortir.Image")));
            this.Boto_Sortir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Boto_Sortir.Name = "Boto_Sortir";
            this.Boto_Sortir.Size = new System.Drawing.Size(23, 22);
            this.Boto_Sortir.Text = "Sortir";
            this.Boto_Sortir.Click += new System.EventHandler(this.Boto_Sortir_Click);
            // 
            // Directori_group
            // 
            this.Directori_group.Controls.Add(this.lblVistaPrevia);
            this.Directori_group.Controls.Add(this.Taula_VistaPrevia);
            this.Directori_group.Controls.Add(this.Directori_Ruta);
            this.Directori_group.Controls.Add(this.Directori_Buscar);
            this.Directori_group.Location = new System.Drawing.Point(13, 29);
            this.Directori_group.Name = "Directori_group";
            this.Directori_group.Size = new System.Drawing.Size(353, 383);
            this.Directori_group.TabIndex = 4;
            this.Directori_group.TabStop = false;
            this.Directori_group.Text = "Directori";
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.Location = new System.Drawing.Point(8, 52);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(66, 13);
            this.lblVistaPrevia.TabIndex = 3;
            this.lblVistaPrevia.Text = "Vista Previa:";
            // 
            // Taula_VistaPrevia
            // 
            this.Taula_VistaPrevia.AllowUserToAddRows = false;
            this.Taula_VistaPrevia.AllowUserToDeleteRows = false;
            this.Taula_VistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Taula_VistaPrevia.Location = new System.Drawing.Point(6, 75);
            this.Taula_VistaPrevia.Name = "Taula_VistaPrevia";
            this.Taula_VistaPrevia.ReadOnly = true;
            this.Taula_VistaPrevia.Size = new System.Drawing.Size(341, 302);
            this.Taula_VistaPrevia.TabIndex = 2;
            // 
            // Directori_Ruta
            // 
            this.Directori_Ruta.Location = new System.Drawing.Point(6, 21);
            this.Directori_Ruta.Name = "Directori_Ruta";
            this.Directori_Ruta.ReadOnly = true;
            this.Directori_Ruta.Size = new System.Drawing.Size(260, 20);
            this.Directori_Ruta.TabIndex = 1;
            // 
            // Directori_Buscar
            // 
            this.Directori_Buscar.Location = new System.Drawing.Point(272, 19);
            this.Directori_Buscar.Name = "Directori_Buscar";
            this.Directori_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Directori_Buscar.TabIndex = 0;
            this.Directori_Buscar.Text = "Buscar";
            this.Directori_Buscar.UseVisualStyleBackColor = true;
            this.Directori_Buscar.Click += new System.EventHandler(this.Directori_Buscar_Click);
            // 
            // JSON_group
            // 
            this.JSON_group.Controls.Add(this.JSON_RutaDef);
            this.JSON_group.Controls.Add(this.JSON_Guardar);
            this.JSON_group.Controls.Add(this.JSON_lblNom);
            this.JSON_group.Controls.Add(this.JSON_Nom);
            this.JSON_group.Controls.Add(this.JSON_lblUbicacio);
            this.JSON_group.Controls.Add(this.Boto_Desti);
            this.JSON_group.Controls.Add(this.JSON_Ubicacio);
            this.JSON_group.Location = new System.Drawing.Point(12, 418);
            this.JSON_group.Name = "JSON_group";
            this.JSON_group.Size = new System.Drawing.Size(353, 126);
            this.JSON_group.TabIndex = 5;
            this.JSON_group.TabStop = false;
            this.JSON_group.Text = "JSON";
            // 
            // JSON_RutaDef
            // 
            this.JSON_RutaDef.Location = new System.Drawing.Point(6, 70);
            this.JSON_RutaDef.Name = "JSON_RutaDef";
            this.JSON_RutaDef.ReadOnly = true;
            this.JSON_RutaDef.Size = new System.Drawing.Size(341, 20);
            this.JSON_RutaDef.TabIndex = 8;
            // 
            // JSON_Guardar
            // 
            this.JSON_Guardar.Location = new System.Drawing.Point(272, 96);
            this.JSON_Guardar.Name = "JSON_Guardar";
            this.JSON_Guardar.Size = new System.Drawing.Size(75, 23);
            this.JSON_Guardar.TabIndex = 7;
            this.JSON_Guardar.Text = "Guardar";
            this.JSON_Guardar.UseVisualStyleBackColor = true;
            this.JSON_Guardar.Click += new System.EventHandler(this.JSON_Guardar_Click);
            // 
            // JSON_lblNom
            // 
            this.JSON_lblNom.AutoSize = true;
            this.JSON_lblNom.Location = new System.Drawing.Point(6, 47);
            this.JSON_lblNom.Name = "JSON_lblNom";
            this.JSON_lblNom.Size = new System.Drawing.Size(29, 13);
            this.JSON_lblNom.TabIndex = 4;
            this.JSON_lblNom.Text = "Nom";
            // 
            // JSON_Nom
            // 
            this.JSON_Nom.Location = new System.Drawing.Point(61, 44);
            this.JSON_Nom.Name = "JSON_Nom";
            this.JSON_Nom.Size = new System.Drawing.Size(286, 20);
            this.JSON_Nom.TabIndex = 3;
            this.JSON_Nom.TextChanged += new System.EventHandler(this.JSON_Nom_TextChanged);
            this.JSON_Nom.Leave += new System.EventHandler(this.JSON_Nom_Leave);
            // 
            // JSON_lblUbicacio
            // 
            this.JSON_lblUbicacio.AutoSize = true;
            this.JSON_lblUbicacio.Location = new System.Drawing.Point(6, 21);
            this.JSON_lblUbicacio.Name = "JSON_lblUbicacio";
            this.JSON_lblUbicacio.Size = new System.Drawing.Size(49, 13);
            this.JSON_lblUbicacio.TabIndex = 2;
            this.JSON_lblUbicacio.Text = "Ubicació";
            // 
            // Boto_Desti
            // 
            this.Boto_Desti.Location = new System.Drawing.Point(272, 16);
            this.Boto_Desti.Name = "Boto_Desti";
            this.Boto_Desti.Size = new System.Drawing.Size(75, 23);
            this.Boto_Desti.TabIndex = 1;
            this.Boto_Desti.Text = "Destí";
            this.Boto_Desti.UseVisualStyleBackColor = true;
            this.Boto_Desti.Click += new System.EventHandler(this.Boto_Desti_Click);
            // 
            // JSON_Ubicacio
            // 
            this.JSON_Ubicacio.Location = new System.Drawing.Point(61, 18);
            this.JSON_Ubicacio.Name = "JSON_Ubicacio";
            this.JSON_Ubicacio.ReadOnly = true;
            this.JSON_Ubicacio.Size = new System.Drawing.Size(205, 20);
            this.JSON_Ubicacio.TabIndex = 0;
            // 
            // Formulari_Escriure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 556);
            this.Controls.Add(this.JSON_group);
            this.Controls.Add(this.Directori_group);
            this.Controls.Add(this.BarraBotons);
            this.Name = "Formulari_Escriure";
            this.Text = "JSON (escriure)";
            this.BarraBotons.ResumeLayout(false);
            this.BarraBotons.PerformLayout();
            this.Directori_group.ResumeLayout(false);
            this.Directori_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Taula_VistaPrevia)).EndInit();
            this.JSON_group.ResumeLayout(false);
            this.JSON_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraBotons;
        private System.Windows.Forms.ToolStripButton Boto_Sortir;
        private System.Windows.Forms.GroupBox Directori_group;
        private System.Windows.Forms.TextBox Directori_Ruta;
        private System.Windows.Forms.Button Directori_Buscar;
        private System.Windows.Forms.GroupBox JSON_group;
        private System.Windows.Forms.Button JSON_Guardar;
        private System.Windows.Forms.Label JSON_lblNom;
        private System.Windows.Forms.TextBox JSON_Nom;
        private System.Windows.Forms.Label JSON_lblUbicacio;
        private System.Windows.Forms.Button Boto_Desti;
        private System.Windows.Forms.TextBox JSON_Ubicacio;
        private System.Windows.Forms.DataGridView Taula_VistaPrevia;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.TextBox JSON_RutaDef;
    }
}
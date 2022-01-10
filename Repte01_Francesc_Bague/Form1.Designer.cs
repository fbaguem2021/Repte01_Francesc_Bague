
namespace Repte01_Francesc_Bague
{
    partial class Formulari_Inici
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulari_Inici));
            this.BarraMenu = new System.Windows.Forms.MenuStrip();
            this.BarraAcces = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraAcces_DadesDirectori = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraAcces_JSON_Llegir = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraAcces_JSON_Escriure = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraAcces_Sortir = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarraAcces});
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(800, 24);
            this.BarraMenu.TabIndex = 0;
            this.BarraMenu.Text = "menuStrip1";
            // 
            // BarraAcces
            // 
            this.BarraAcces.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarraAcces_DadesDirectori,
            this.jSONToolStripMenuItem,
            this.BarraAcces_Sortir});
            this.BarraAcces.Name = "BarraAcces";
            this.BarraAcces.Size = new System.Drawing.Size(90, 20);
            this.BarraAcces.Text = "Barra d\'Accés";
            // 
            // BarraAcces_DadesDirectori
            // 
            this.BarraAcces_DadesDirectori.Image = ((System.Drawing.Image)(resources.GetObject("BarraAcces_DadesDirectori.Image")));
            this.BarraAcces_DadesDirectori.Name = "BarraAcces_DadesDirectori";
            this.BarraAcces_DadesDirectori.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.BarraAcces_DadesDirectori.Size = new System.Drawing.Size(192, 22);
            this.BarraAcces_DadesDirectori.Text = "Dades Directori";
            this.BarraAcces_DadesDirectori.Click += new System.EventHandler(this.BarraAcces_DadesDirectori_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarraAcces_JSON_Llegir,
            this.BarraAcces_JSON_Escriure});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // BarraAcces_JSON_Llegir
            // 
            this.BarraAcces_JSON_Llegir.Image = ((System.Drawing.Image)(resources.GetObject("BarraAcces_JSON_Llegir.Image")));
            this.BarraAcces_JSON_Llegir.Name = "BarraAcces_JSON_Llegir";
            this.BarraAcces_JSON_Llegir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.BarraAcces_JSON_Llegir.Size = new System.Drawing.Size(156, 22);
            this.BarraAcces_JSON_Llegir.Text = "Llegir";
            this.BarraAcces_JSON_Llegir.Click += new System.EventHandler(this.BarraAcces_JSON_Llegir_Click);
            // 
            // BarraAcces_JSON_Escriure
            // 
            this.BarraAcces_JSON_Escriure.Image = ((System.Drawing.Image)(resources.GetObject("BarraAcces_JSON_Escriure.Image")));
            this.BarraAcces_JSON_Escriure.Name = "BarraAcces_JSON_Escriure";
            this.BarraAcces_JSON_Escriure.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.BarraAcces_JSON_Escriure.Size = new System.Drawing.Size(156, 22);
            this.BarraAcces_JSON_Escriure.Text = "Escriure";
            this.BarraAcces_JSON_Escriure.Click += new System.EventHandler(this.BarraAcces_JSON_Escriure_Click);
            // 
            // BarraAcces_Sortir
            // 
            this.BarraAcces_Sortir.Image = global::Repte01_Francesc_Bague.Properties.Resources.salida;
            this.BarraAcces_Sortir.Name = "BarraAcces_Sortir";
            this.BarraAcces_Sortir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.BarraAcces_Sortir.Size = new System.Drawing.Size(192, 22);
            this.BarraAcces_Sortir.Text = "Sortir";
            this.BarraAcces_Sortir.Click += new System.EventHandler(this.BarraAcces_Sortir_Click);
            // 
            // Formulari_Inici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarraMenu);
            this.MainMenuStrip = this.BarraMenu;
            this.Name = "Formulari_Inici";
            this.Text = "Inici";
            this.BarraMenu.ResumeLayout(false);
            this.BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem BarraAcces;
        private System.Windows.Forms.ToolStripMenuItem BarraAcces_DadesDirectori;
        private System.Windows.Forms.ToolStripMenuItem BarraAcces_Sortir;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BarraAcces_JSON_Llegir;
        private System.Windows.Forms.ToolStripMenuItem BarraAcces_JSON_Escriure;
    }
}


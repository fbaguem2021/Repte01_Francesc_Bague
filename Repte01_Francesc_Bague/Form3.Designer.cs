
namespace Repte01_Francesc_Bague
{
    partial class Formulari_Llegir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulari_Llegir));
            this.BarraBotons = new System.Windows.Forms.ToolStrip();
            this.Boto_Sortir = new System.Windows.Forms.ToolStripButton();
            this.group_Arxiu = new System.Windows.Forms.GroupBox();
            this.JSON_Ruta = new System.Windows.Forms.TextBox();
            this.JSON_Taula = new System.Windows.Forms.DataGridView();
            this.Boto_Buscar = new System.Windows.Forms.Button();
            this.BarraBotons.SuspendLayout();
            this.group_Arxiu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JSON_Taula)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraBotons
            // 
            this.BarraBotons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Boto_Sortir});
            this.BarraBotons.Location = new System.Drawing.Point(0, 0);
            this.BarraBotons.Name = "BarraBotons";
            this.BarraBotons.Size = new System.Drawing.Size(377, 25);
            this.BarraBotons.TabIndex = 1;
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
            this.Boto_Sortir.Click += new System.EventHandler(this.Boto_Sortir_Click);
            // 
            // group_Arxiu
            // 
            this.group_Arxiu.Controls.Add(this.Boto_Buscar);
            this.group_Arxiu.Controls.Add(this.JSON_Ruta);
            this.group_Arxiu.Location = new System.Drawing.Point(12, 28);
            this.group_Arxiu.Name = "group_Arxiu";
            this.group_Arxiu.Size = new System.Drawing.Size(358, 49);
            this.group_Arxiu.TabIndex = 2;
            this.group_Arxiu.TabStop = false;
            this.group_Arxiu.Text = "Arxiu";
            // 
            // JSON_Ruta
            // 
            this.JSON_Ruta.Location = new System.Drawing.Point(6, 19);
            this.JSON_Ruta.Name = "JSON_Ruta";
            this.JSON_Ruta.ReadOnly = true;
            this.JSON_Ruta.Size = new System.Drawing.Size(265, 20);
            this.JSON_Ruta.TabIndex = 0;
            // 
            // JSON_Taula
            // 
            this.JSON_Taula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JSON_Taula.Location = new System.Drawing.Point(15, 83);
            this.JSON_Taula.Name = "JSON_Taula";
            this.JSON_Taula.Size = new System.Drawing.Size(350, 378);
            this.JSON_Taula.TabIndex = 3;
            // 
            // Boto_Buscar
            // 
            this.Boto_Buscar.Location = new System.Drawing.Point(277, 17);
            this.Boto_Buscar.Name = "Boto_Buscar";
            this.Boto_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Boto_Buscar.TabIndex = 1;
            this.Boto_Buscar.Text = "Buscar";
            this.Boto_Buscar.UseVisualStyleBackColor = true;
            this.Boto_Buscar.Click += new System.EventHandler(this.Boto_Buscar_Click);
            // 
            // Formulari_Llegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 473);
            this.Controls.Add(this.JSON_Taula);
            this.Controls.Add(this.group_Arxiu);
            this.Controls.Add(this.BarraBotons);
            this.Name = "Formulari_Llegir";
            this.Text = "JSON (llegir)";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.BarraBotons.ResumeLayout(false);
            this.BarraBotons.PerformLayout();
            this.group_Arxiu.ResumeLayout(false);
            this.group_Arxiu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JSON_Taula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraBotons;
        private System.Windows.Forms.ToolStripButton Boto_Sortir;
        private System.Windows.Forms.GroupBox group_Arxiu;
        private System.Windows.Forms.TextBox JSON_Ruta;
        private System.Windows.Forms.DataGridView JSON_Taula;
        private System.Windows.Forms.Button Boto_Buscar;
    }
}
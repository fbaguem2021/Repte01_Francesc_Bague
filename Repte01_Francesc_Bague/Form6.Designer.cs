
namespace Repte01_Francesc_Bague
{
    partial class Formulari_Crear
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
            this.Crear = new System.Windows.Forms.GroupBox();
            this.Crear_Ruta_Etiqueta = new System.Windows.Forms.Label();
            this.Crear_Ruta_CaixaText = new System.Windows.Forms.TextBox();
            this.Crear_Nom_CaixaText = new System.Windows.Forms.TextBox();
            this.Crear_Nom_Etiqueta = new System.Windows.Forms.Label();
            this.CrearTipus = new System.Windows.Forms.GroupBox();
            this.CrearTipus_Fitxer = new System.Windows.Forms.RadioButton();
            this.CrearTipus_Directori = new System.Windows.Forms.RadioButton();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Acceptar = new System.Windows.Forms.Button();
            this.Crear.SuspendLayout();
            this.CrearTipus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.Controls.Add(this.Crear_Ruta_Etiqueta);
            this.Crear.Controls.Add(this.Crear_Ruta_CaixaText);
            this.Crear.Controls.Add(this.Crear_Nom_CaixaText);
            this.Crear.Controls.Add(this.Crear_Nom_Etiqueta);
            this.Crear.Controls.Add(this.CrearTipus);
            this.Crear.Location = new System.Drawing.Point(13, 13);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(357, 151);
            this.Crear.TabIndex = 0;
            this.Crear.TabStop = false;
            this.Crear.Text = "Crear Fitxer";
            // 
            // Crear_Ruta_Etiqueta
            // 
            this.Crear_Ruta_Etiqueta.AutoSize = true;
            this.Crear_Ruta_Etiqueta.Location = new System.Drawing.Point(16, 98);
            this.Crear_Ruta_Etiqueta.Name = "Crear_Ruta_Etiqueta";
            this.Crear_Ruta_Etiqueta.Size = new System.Drawing.Size(49, 13);
            this.Crear_Ruta_Etiqueta.TabIndex = 6;
            this.Crear_Ruta_Etiqueta.Text = "Ubicació";
            // 
            // Crear_Ruta_CaixaText
            // 
            this.Crear_Ruta_CaixaText.Location = new System.Drawing.Point(103, 95);
            this.Crear_Ruta_CaixaText.Name = "Crear_Ruta_CaixaText";
            this.Crear_Ruta_CaixaText.ReadOnly = true;
            this.Crear_Ruta_CaixaText.Size = new System.Drawing.Size(242, 20);
            this.Crear_Ruta_CaixaText.TabIndex = 5;
            // 
            // Crear_Nom_CaixaText
            // 
            this.Crear_Nom_CaixaText.Location = new System.Drawing.Point(103, 121);
            this.Crear_Nom_CaixaText.Name = "Crear_Nom_CaixaText";
            this.Crear_Nom_CaixaText.Size = new System.Drawing.Size(242, 20);
            this.Crear_Nom_CaixaText.TabIndex = 4;
            // 
            // Crear_Nom_Etiqueta
            // 
            this.Crear_Nom_Etiqueta.AutoSize = true;
            this.Crear_Nom_Etiqueta.Location = new System.Drawing.Point(16, 124);
            this.Crear_Nom_Etiqueta.Name = "Crear_Nom_Etiqueta";
            this.Crear_Nom_Etiqueta.Size = new System.Drawing.Size(74, 13);
            this.Crear_Nom_Etiqueta.TabIndex = 3;
            this.Crear_Nom_Etiqueta.Text = "Nom del Fitxer";
            // 
            // CrearTipus
            // 
            this.CrearTipus.Controls.Add(this.CrearTipus_Fitxer);
            this.CrearTipus.Controls.Add(this.CrearTipus_Directori);
            this.CrearTipus.Location = new System.Drawing.Point(6, 19);
            this.CrearTipus.Name = "CrearTipus";
            this.CrearTipus.Size = new System.Drawing.Size(339, 67);
            this.CrearTipus.TabIndex = 1;
            this.CrearTipus.TabStop = false;
            this.CrearTipus.Text = "Tipus de fitxer";
            // 
            // CrearTipus_Fitxer
            // 
            this.CrearTipus_Fitxer.AutoSize = true;
            this.CrearTipus_Fitxer.Location = new System.Drawing.Point(224, 29);
            this.CrearTipus_Fitxer.Name = "CrearTipus_Fitxer";
            this.CrearTipus_Fitxer.Size = new System.Drawing.Size(50, 17);
            this.CrearTipus_Fitxer.TabIndex = 2;
            this.CrearTipus_Fitxer.Text = "Fitxer";
            this.CrearTipus_Fitxer.UseVisualStyleBackColor = true;
            // 
            // CrearTipus_Directori
            // 
            this.CrearTipus_Directori.AutoSize = true;
            this.CrearTipus_Directori.Checked = true;
            this.CrearTipus_Directori.Location = new System.Drawing.Point(97, 29);
            this.CrearTipus_Directori.Name = "CrearTipus_Directori";
            this.CrearTipus_Directori.Size = new System.Drawing.Size(64, 17);
            this.CrearTipus_Directori.TabIndex = 1;
            this.CrearTipus_Directori.TabStop = true;
            this.CrearTipus_Directori.Text = "Directori";
            this.CrearTipus_Directori.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(295, 170);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancel·lar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Acceptar
            // 
            this.Acceptar.Location = new System.Drawing.Point(179, 170);
            this.Acceptar.Name = "Acceptar";
            this.Acceptar.Size = new System.Drawing.Size(75, 23);
            this.Acceptar.TabIndex = 2;
            this.Acceptar.Text = "Acceptar";
            this.Acceptar.UseVisualStyleBackColor = true;
            this.Acceptar.Click += new System.EventHandler(this.Acceptar_Click);
            // 
            // Formulari_Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 205);
            this.Controls.Add(this.Acceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Crear);
            this.Name = "Formulari_Crear";
            this.Text = "Crear Fitxer";
            this.Crear.ResumeLayout(false);
            this.Crear.PerformLayout();
            this.CrearTipus.ResumeLayout(false);
            this.CrearTipus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Crear;
        private System.Windows.Forms.GroupBox CrearTipus;
        private System.Windows.Forms.RadioButton CrearTipus_Fitxer;
        private System.Windows.Forms.RadioButton CrearTipus_Directori;
        private System.Windows.Forms.TextBox Crear_Nom_CaixaText;
        private System.Windows.Forms.Label Crear_Nom_Etiqueta;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Acceptar;
        private System.Windows.Forms.Label Crear_Ruta_Etiqueta;
        private System.Windows.Forms.TextBox Crear_Ruta_CaixaText;
    }
}
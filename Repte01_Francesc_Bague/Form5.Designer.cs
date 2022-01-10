
namespace Repte01_Francesc_Bague
{
    partial class Formulari_Renombrar
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
            this.Renombrar = new System.Windows.Forms.GroupBox();
            this.Renombrar_NomNou_CuadreText = new System.Windows.Forms.TextBox();
            this.Renombrar_NomNou_Etiqueta = new System.Windows.Forms.Label();
            this.Renombrar_NomOriginal_CuadreText = new System.Windows.Forms.TextBox();
            this.Renombrar_NomOriginal_Etiqueta = new System.Windows.Forms.Label();
            this.Renombrar_Tipus_CuadreText = new System.Windows.Forms.TextBox();
            this.Renombrar_Tipus_Etiqueta = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Acceptar = new System.Windows.Forms.Button();
            this.Renombrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Renombrar
            // 
            this.Renombrar.Controls.Add(this.Renombrar_NomNou_CuadreText);
            this.Renombrar.Controls.Add(this.Renombrar_NomNou_Etiqueta);
            this.Renombrar.Controls.Add(this.Renombrar_NomOriginal_CuadreText);
            this.Renombrar.Controls.Add(this.Renombrar_NomOriginal_Etiqueta);
            this.Renombrar.Controls.Add(this.Renombrar_Tipus_CuadreText);
            this.Renombrar.Controls.Add(this.Renombrar_Tipus_Etiqueta);
            this.Renombrar.Location = new System.Drawing.Point(13, 12);
            this.Renombrar.Name = "Renombrar";
            this.Renombrar.Size = new System.Drawing.Size(278, 109);
            this.Renombrar.TabIndex = 1;
            this.Renombrar.TabStop = false;
            this.Renombrar.Text = "Renombrar";
            // 
            // Renombrar_NomNou_CuadreText
            // 
            this.Renombrar_NomNou_CuadreText.Location = new System.Drawing.Point(85, 80);
            this.Renombrar_NomNou_CuadreText.Name = "Renombrar_NomNou_CuadreText";
            this.Renombrar_NomNou_CuadreText.Size = new System.Drawing.Size(179, 20);
            this.Renombrar_NomNou_CuadreText.TabIndex = 5;
            // 
            // Renombrar_NomNou_Etiqueta
            // 
            this.Renombrar_NomNou_Etiqueta.AutoSize = true;
            this.Renombrar_NomNou_Etiqueta.Location = new System.Drawing.Point(9, 83);
            this.Renombrar_NomNou_Etiqueta.Name = "Renombrar_NomNou_Etiqueta";
            this.Renombrar_NomNou_Etiqueta.Size = new System.Drawing.Size(68, 13);
            this.Renombrar_NomNou_Etiqueta.TabIndex = 4;
            this.Renombrar_NomNou_Etiqueta.Text = "Nom definitiu";
            // 
            // Renombrar_NomOriginal_CuadreText
            // 
            this.Renombrar_NomOriginal_CuadreText.Location = new System.Drawing.Point(85, 46);
            this.Renombrar_NomOriginal_CuadreText.Name = "Renombrar_NomOriginal_CuadreText";
            this.Renombrar_NomOriginal_CuadreText.ReadOnly = true;
            this.Renombrar_NomOriginal_CuadreText.Size = new System.Drawing.Size(179, 20);
            this.Renombrar_NomOriginal_CuadreText.TabIndex = 3;
            // 
            // Renombrar_NomOriginal_Etiqueta
            // 
            this.Renombrar_NomOriginal_Etiqueta.AutoSize = true;
            this.Renombrar_NomOriginal_Etiqueta.Location = new System.Drawing.Point(9, 49);
            this.Renombrar_NomOriginal_Etiqueta.Name = "Renombrar_NomOriginal_Etiqueta";
            this.Renombrar_NomOriginal_Etiqueta.Size = new System.Drawing.Size(65, 13);
            this.Renombrar_NomOriginal_Etiqueta.TabIndex = 2;
            this.Renombrar_NomOriginal_Etiqueta.Text = "Nom original";
            // 
            // Renombrar_Tipus_CuadreText
            // 
            this.Renombrar_Tipus_CuadreText.Location = new System.Drawing.Point(85, 20);
            this.Renombrar_Tipus_CuadreText.Name = "Renombrar_Tipus_CuadreText";
            this.Renombrar_Tipus_CuadreText.ReadOnly = true;
            this.Renombrar_Tipus_CuadreText.Size = new System.Drawing.Size(179, 20);
            this.Renombrar_Tipus_CuadreText.TabIndex = 1;
            // 
            // Renombrar_Tipus_Etiqueta
            // 
            this.Renombrar_Tipus_Etiqueta.AutoSize = true;
            this.Renombrar_Tipus_Etiqueta.Location = new System.Drawing.Point(6, 23);
            this.Renombrar_Tipus_Etiqueta.Name = "Renombrar_Tipus_Etiqueta";
            this.Renombrar_Tipus_Etiqueta.Size = new System.Drawing.Size(73, 13);
            this.Renombrar_Tipus_Etiqueta.TabIndex = 0;
            this.Renombrar_Tipus_Etiqueta.Text = "Tipus de fitxer";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(216, 127);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancel·lar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Acceptar
            // 
            this.Acceptar.Location = new System.Drawing.Point(115, 127);
            this.Acceptar.Name = "Acceptar";
            this.Acceptar.Size = new System.Drawing.Size(75, 23);
            this.Acceptar.TabIndex = 7;
            this.Acceptar.Text = "Acceptar";
            this.Acceptar.UseVisualStyleBackColor = true;
            this.Acceptar.Click += new System.EventHandler(this.Acceptar_Click);
            // 
            // Formulari_Renombrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 158);
            this.Controls.Add(this.Acceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Renombrar);
            this.Name = "Formulari_Renombrar";
            this.Text = "Renombrar";
            this.Renombrar.ResumeLayout(false);
            this.Renombrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Renombrar;
        private System.Windows.Forms.TextBox Renombrar_NomNou_CuadreText;
        private System.Windows.Forms.Label Renombrar_NomNou_Etiqueta;
        private System.Windows.Forms.TextBox Renombrar_NomOriginal_CuadreText;
        private System.Windows.Forms.Label Renombrar_NomOriginal_Etiqueta;
        private System.Windows.Forms.TextBox Renombrar_Tipus_CuadreText;
        private System.Windows.Forms.Label Renombrar_Tipus_Etiqueta;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Acceptar;
    }
}
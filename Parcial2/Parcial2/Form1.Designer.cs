
namespace Parcial2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClasificar = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.textBoxParcial = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.buttonSumatoria = new System.Windows.Forms.Button();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonClasificar
            // 
            this.buttonClasificar.Location = new System.Drawing.Point(468, 242);
            this.buttonClasificar.Name = "buttonClasificar";
            this.buttonClasificar.Size = new System.Drawing.Size(75, 23);
            this.buttonClasificar.TabIndex = 0;
            this.buttonClasificar.Text = "Clasificar";
            this.buttonClasificar.UseVisualStyleBackColor = true;
            this.buttonClasificar.Click += new System.EventHandler(this.buttonClasificar_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Location = new System.Drawing.Point(597, 12);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(197, 199);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(12, 60);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(93, 12);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(237, 264);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(468, 82);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(75, 23);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // textBoxParcial
            // 
            this.textBoxParcial.Location = new System.Drawing.Point(468, 12);
            this.textBoxParcial.Multiline = true;
            this.textBoxParcial.Name = "textBoxParcial";
            this.textBoxParcial.Size = new System.Drawing.Size(123, 30);
            this.textBoxParcial.TabIndex = 5;
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(468, 49);
            this.textBoxSeccion.Multiline = true;
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(123, 27);
            this.textBoxSeccion.TabIndex = 6;
            // 
            // buttonSumatoria
            // 
            this.buttonSumatoria.Location = new System.Drawing.Point(468, 285);
            this.buttonSumatoria.Name = "buttonSumatoria";
            this.buttonSumatoria.Size = new System.Drawing.Size(75, 23);
            this.buttonSumatoria.TabIndex = 7;
            this.buttonSumatoria.Text = "Sumatoria";
            this.buttonSumatoria.UseVisualStyleBackColor = true;
            this.buttonSumatoria.Click += new System.EventHandler(this.buttonSumatoria_Click);
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.ItemHeight = 15;
            this.listBoxResultados.Location = new System.Drawing.Point(597, 242);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(191, 199);
            this.listBoxResultados.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.buttonSumatoria);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.textBoxParcial);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonClasificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClasificar;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.TextBox textBoxParcial;
        private System.Windows.Forms.TextBox textBoxSeccion;
        private System.Windows.Forms.Button buttonSumatoria;
        private System.Windows.Forms.ListBox listBoxResultados;
    }
}


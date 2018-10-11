namespace App_MongoDB_Lab
{
    partial class Principal
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
            this.btn_peliculas = new System.Windows.Forms.Button();
            this.btn_compania = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_peliculas
            // 
            this.btn_peliculas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_peliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peliculas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_peliculas.Location = new System.Drawing.Point(0, -2);
            this.btn_peliculas.Name = "btn_peliculas";
            this.btn_peliculas.Size = new System.Drawing.Size(404, 306);
            this.btn_peliculas.TabIndex = 0;
            this.btn_peliculas.Text = "Películas";
            this.btn_peliculas.UseVisualStyleBackColor = false;
            this.btn_peliculas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_compania
            // 
            this.btn_compania.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_compania.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compania.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_compania.Location = new System.Drawing.Point(400, -2);
            this.btn_compania.Name = "btn_compania";
            this.btn_compania.Size = new System.Drawing.Size(410, 306);
            this.btn_compania.TabIndex = 1;
            this.btn_compania.Text = "Compañias Productoras";
            this.btn_compania.UseVisualStyleBackColor = false;
            this.btn_compania.Click += new System.EventHandler(this.btn_compania_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_consultas.Location = new System.Drawing.Point(0, 303);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(796, 150);
            this.btn_consultas.TabIndex = 2;
            this.btn_consultas.Text = "Consultas del sistema";
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.button3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_compania);
            this.Controls.Add(this.btn_peliculas);
            this.Name = "Principal";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_peliculas;
        private System.Windows.Forms.Button btn_compania;
        private System.Windows.Forms.Button btn_consultas;
    }
}


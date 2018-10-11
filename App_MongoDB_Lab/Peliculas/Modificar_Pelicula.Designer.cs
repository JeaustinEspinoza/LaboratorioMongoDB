namespace App_MongoDB_Lab.Peliculas
{
    partial class Modificar_Pelicula
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.pelicula1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.actores1 = new System.Windows.Forms.TextBox();
            this.productora1 = new System.Windows.Forms.TextBox();
            this.duracion1 = new System.Windows.Forms.TextBox();
            this.año1 = new System.Windows.Forms.TextBox();
            this.pais1 = new System.Windows.Forms.TextBox();
            this.franquicia1 = new System.Windows.Forms.TextBox();
            this.director1 = new System.Windows.Forms.TextBox();
            this.genero1 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(393, 542);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 34);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pelicula1
            // 
            this.pelicula1.Location = new System.Drawing.Point(405, 172);
            this.pelicula1.Name = "pelicula1";
            this.pelicula1.Size = new System.Drawing.Size(245, 22);
            this.pelicula1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de película a modificar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Franquicia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Año de estreno";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duracion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Compañia productora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Actores (separar por coma)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "País";
            // 
            // actores1
            // 
            this.actores1.Location = new System.Drawing.Point(405, 502);
            this.actores1.Name = "actores1";
            this.actores1.Size = new System.Drawing.Size(245, 22);
            this.actores1.TabIndex = 11;
            // 
            // productora1
            // 
            this.productora1.Location = new System.Drawing.Point(405, 462);
            this.productora1.Name = "productora1";
            this.productora1.Size = new System.Drawing.Size(245, 22);
            this.productora1.TabIndex = 12;
            // 
            // duracion1
            // 
            this.duracion1.Location = new System.Drawing.Point(405, 422);
            this.duracion1.Name = "duracion1";
            this.duracion1.Size = new System.Drawing.Size(245, 22);
            this.duracion1.TabIndex = 13;
            // 
            // año1
            // 
            this.año1.Location = new System.Drawing.Point(405, 376);
            this.año1.Name = "año1";
            this.año1.Size = new System.Drawing.Size(245, 22);
            this.año1.TabIndex = 14;
            // 
            // pais1
            // 
            this.pais1.Location = new System.Drawing.Point(405, 334);
            this.pais1.Name = "pais1";
            this.pais1.Size = new System.Drawing.Size(245, 22);
            this.pais1.TabIndex = 15;
            // 
            // franquicia1
            // 
            this.franquicia1.Location = new System.Drawing.Point(405, 294);
            this.franquicia1.Name = "franquicia1";
            this.franquicia1.Size = new System.Drawing.Size(245, 22);
            this.franquicia1.TabIndex = 16;
            // 
            // director1
            // 
            this.director1.Location = new System.Drawing.Point(406, 252);
            this.director1.Name = "director1";
            this.director1.Size = new System.Drawing.Size(244, 22);
            this.director1.TabIndex = 17;
            // 
            // genero1
            // 
            this.genero1.Location = new System.Drawing.Point(406, 211);
            this.genero1.Name = "genero1";
            this.genero1.Size = new System.Drawing.Size(244, 22);
            this.genero1.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(533, 542);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 34);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // datos
            // 
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(13, 13);
            this.datos.Name = "datos";
            this.datos.RowTemplate.Height = 24;
            this.datos.Size = new System.Drawing.Size(1041, 135);
            this.datos.TabIndex = 20;
            // 
            // Modificar_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 589);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.genero1);
            this.Controls.Add(this.director1);
            this.Controls.Add(this.franquicia1);
            this.Controls.Add(this.pais1);
            this.Controls.Add(this.año1);
            this.Controls.Add(this.duracion1);
            this.Controls.Add(this.productora1);
            this.Controls.Add(this.actores1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pelicula1);
            this.Controls.Add(this.btnModificar);
            this.Name = "Modificar_Pelicula";
            this.Text = "Modificar_Pelicula";
            this.Load += new System.EventHandler(this.Modificar_Pelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox pelicula1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox actores1;
        private System.Windows.Forms.TextBox productora1;
        private System.Windows.Forms.TextBox duracion1;
        private System.Windows.Forms.TextBox año1;
        private System.Windows.Forms.TextBox pais1;
        private System.Windows.Forms.TextBox franquicia1;
        private System.Windows.Forms.TextBox director1;
        private System.Windows.Forms.TextBox genero1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView datos;
    }
}
namespace App_MongoDB_Lab
{
    partial class CRUD_Peliculas
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
            this.agregar = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.Green;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.agregar.Location = new System.Drawing.Point(-2, 0);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(413, 78);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ver
            // 
            this.ver.BackColor = System.Drawing.Color.Green;
            this.ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ver.Location = new System.Drawing.Point(-2, 75);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(413, 78);
            this.ver.TabIndex = 2;
            this.ver.Text = "Ver";
            this.ver.UseVisualStyleBackColor = false;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.Color.Green;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.modificar.Location = new System.Drawing.Point(-2, 149);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(413, 78);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Green;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.eliminar.Location = new System.Drawing.Point(-2, 223);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(413, 78);
            this.eliminar.TabIndex = 4;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.button5_Click);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volver.Location = new System.Drawing.Point(-2, 297);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(413, 78);
            this.volver.TabIndex = 5;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // CRUD_Peliculas
            // 
            this.ClientSize = new System.Drawing.Size(410, 371);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.agregar);
            this.Name = "CRUD_Peliculas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Ver;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button volver;
    }
}
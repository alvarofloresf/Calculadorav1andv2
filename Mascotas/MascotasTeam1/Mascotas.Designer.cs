
namespace MascotasTeam1
{
    partial class Mascotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mascotas));
            this.gbMascota = new System.Windows.Forms.GroupBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbHembra = new System.Windows.Forms.RadioButton();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMayor3an = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.lvCompleta = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Género = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EdadS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GéneroS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbMascota.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMascota
            // 
            this.gbMascota.Controls.Add(this.gbGenero);
            this.gbMascota.Controls.Add(this.tbEdad);
            this.gbMascota.Controls.Add(this.tbNombre);
            this.gbMascota.Controls.Add(this.label2);
            this.gbMascota.Controls.Add(this.label1);
            this.gbMascota.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMascota.Location = new System.Drawing.Point(31, 22);
            this.gbMascota.Name = "gbMascota";
            this.gbMascota.Size = new System.Drawing.Size(467, 98);
            this.gbMascota.TabIndex = 0;
            this.gbMascota.TabStop = false;
            this.gbMascota.Text = "Mascota";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbMacho);
            this.gbGenero.Controls.Add(this.rbHembra);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.Location = new System.Drawing.Point(265, 21);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(183, 61);
            this.gbGenero.TabIndex = 8;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(99, 23);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(71, 22);
            this.rbMacho.TabIndex = 1;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Location = new System.Drawing.Point(13, 24);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(78, 22);
            this.rbHembra.TabIndex = 0;
            this.rbHembra.TabStop = true;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(84, 57);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(42, 29);
            this.tbEdad.TabIndex = 3;
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(84, 27);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(131, 29);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // lvMayor3an
            // 
            this.lvMayor3an.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Edad,
            this.Género});
            this.lvMayor3an.HideSelection = false;
            this.lvMayor3an.Location = new System.Drawing.Point(43, 253);
            this.lvMayor3an.Name = "lvMayor3an";
            this.lvMayor3an.Size = new System.Drawing.Size(462, 216);
            this.lvMayor3an.TabIndex = 2;
            this.lvMayor3an.UseCompatibleStateImageBehavior = false;
            this.lvMayor3an.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mascotas Mayores a 3 años:";
            // 
            // lvCompleta
            // 
            this.lvCompleta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreS,
            this.EdadS,
            this.GéneroS});
            this.lvCompleta.HideSelection = false;
            this.lvCompleta.Location = new System.Drawing.Point(572, 79);
            this.lvCompleta.Name = "lvCompleta";
            this.lvCompleta.Size = new System.Drawing.Size(329, 372);
            this.lvCompleta.TabIndex = 4;
            this.lvCompleta.UseCompatibleStateImageBehavior = false;
            this.lvCompleta.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(566, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Todas las mascotas";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.Lavender;
            this.btnAñadir.Location = new System.Drawing.Point(188, 137);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(166, 45);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 192;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 98;
            // 
            // Género
            // 
            this.Género.Text = "Género";
            this.Género.Width = 150;
            // 
            // NombreS
            // 
            this.NombreS.Text = "Nombre";
            this.NombreS.Width = 128;
            // 
            // EdadS
            // 
            this.EdadS.Text = "Edad";
            this.EdadS.Width = 74;
            // 
            // GéneroS
            // 
            this.GéneroS.Text = "Género";
            this.GéneroS.Width = 117;
            // 
            // Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 505);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvCompleta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvMayor3an);
            this.Controls.Add(this.gbMascota);
            this.Name = "Mascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.Mascotas_Load);
            this.gbMascota.ResumeLayout(false);
            this.gbMascota.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMascota;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbHembra;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMayor3an;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvCompleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.ColumnHeader Género;
        private System.Windows.Forms.ColumnHeader NombreS;
        private System.Windows.Forms.ColumnHeader EdadS;
        private System.Windows.Forms.ColumnHeader GéneroS;
    }
}


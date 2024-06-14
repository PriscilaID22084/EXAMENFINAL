namespace Figuras
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.btndibujar = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtmedidas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbesfera = new System.Windows.Forms.RadioButton();
            this.rbprisma = new System.Windows.Forms.RadioButton();
            this.rbcubo = new System.Windows.Forms.RadioButton();
            this.rbcirculo = new System.Windows.Forms.RadioButton();
            this.rbpoligonoirregular = new System.Windows.Forms.RadioButton();
            this.rbpoligonoregular = new System.Windows.Forms.RadioButton();
            this.rbrectangulo = new System.Windows.Forms.RadioButton();
            this.rbtriangulo = new System.Windows.Forms.RadioButton();
            this.rbcuadrado = new System.Windows.Forms.RadioButton();
            this.txtInformacion = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btnexportar);
            this.groupBox1.Controls.Add(this.btndibujar);
            this.groupBox1.Controls.Add(this.btnInformacion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtmedidas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbesfera);
            this.groupBox1.Controls.Add(this.rbprisma);
            this.groupBox1.Controls.Add(this.rbcubo);
            this.groupBox1.Controls.Add(this.rbcirculo);
            this.groupBox1.Controls.Add(this.rbpoligonoirregular);
            this.groupBox1.Controls.Add(this.rbpoligonoregular);
            this.groupBox1.Controls.Add(this.rbrectangulo);
            this.groupBox1.Controls.Add(this.rbtriangulo);
            this.groupBox1.Controls.Add(this.rbcuadrado);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(401, 143);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(302, 143);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(213, 143);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(75, 23);
            this.btnexportar.TabIndex = 3;
            this.btnexportar.Text = "exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(111, 143);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(75, 23);
            this.btndibujar.TabIndex = 3;
            this.btndibujar.Text = "dibujar";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(6, 143);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(75, 23);
            this.btnInformacion.TabIndex = 3;
            this.btnInformacion.Text = "informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(378, 96);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtmedidas
            // 
            this.txtmedidas.Location = new System.Drawing.Point(253, 96);
            this.txtmedidas.Name = "txtmedidas";
            this.txtmedidas.Size = new System.Drawing.Size(100, 20);
            this.txtmedidas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO";
            // 
            // rbesfera
            // 
            this.rbesfera.AutoSize = true;
            this.rbesfera.Location = new System.Drawing.Point(322, 62);
            this.rbesfera.Name = "rbesfera";
            this.rbesfera.Size = new System.Drawing.Size(55, 17);
            this.rbesfera.TabIndex = 0;
            this.rbesfera.TabStop = true;
            this.rbesfera.Text = "Esfera";
            this.rbesfera.UseVisualStyleBackColor = true;
            // 
            // rbprisma
            // 
            this.rbprisma.AutoSize = true;
            this.rbprisma.Location = new System.Drawing.Point(213, 62);
            this.rbprisma.Name = "rbprisma";
            this.rbprisma.Size = new System.Drawing.Size(56, 17);
            this.rbprisma.TabIndex = 0;
            this.rbprisma.TabStop = true;
            this.rbprisma.Text = "Prisma";
            this.rbprisma.UseVisualStyleBackColor = true;
            // 
            // rbcubo
            // 
            this.rbcubo.AutoSize = true;
            this.rbcubo.Location = new System.Drawing.Point(111, 62);
            this.rbcubo.Name = "rbcubo";
            this.rbcubo.Size = new System.Drawing.Size(50, 17);
            this.rbcubo.TabIndex = 0;
            this.rbcubo.TabStop = true;
            this.rbcubo.Text = "Cubo";
            this.rbcubo.UseVisualStyleBackColor = true;
            // 
            // rbcirculo
            // 
            this.rbcirculo.AutoSize = true;
            this.rbcirculo.Location = new System.Drawing.Point(6, 62);
            this.rbcirculo.Name = "rbcirculo";
            this.rbcirculo.Size = new System.Drawing.Size(57, 17);
            this.rbcirculo.TabIndex = 0;
            this.rbcirculo.TabStop = true;
            this.rbcirculo.Text = "Circulo";
            this.rbcirculo.UseVisualStyleBackColor = true;
            // 
            // rbpoligonoirregular
            // 
            this.rbpoligonoirregular.AutoSize = true;
            this.rbpoligonoirregular.Location = new System.Drawing.Point(415, 19);
            this.rbpoligonoirregular.Name = "rbpoligonoirregular";
            this.rbpoligonoirregular.Size = new System.Drawing.Size(106, 17);
            this.rbpoligonoirregular.TabIndex = 0;
            this.rbpoligonoirregular.TabStop = true;
            this.rbpoligonoirregular.Text = "Poligono irregular";
            this.rbpoligonoirregular.UseVisualStyleBackColor = true;
            // 
            // rbpoligonoregular
            // 
            this.rbpoligonoregular.AutoSize = true;
            this.rbpoligonoregular.Location = new System.Drawing.Point(304, 19);
            this.rbpoligonoregular.Name = "rbpoligonoregular";
            this.rbpoligonoregular.Size = new System.Drawing.Size(101, 17);
            this.rbpoligonoregular.TabIndex = 0;
            this.rbpoligonoregular.TabStop = true;
            this.rbpoligonoregular.Text = "Poligono regular";
            this.rbpoligonoregular.UseVisualStyleBackColor = true;
            // 
            // rbrectangulo
            // 
            this.rbrectangulo.AutoSize = true;
            this.rbrectangulo.Location = new System.Drawing.Point(213, 19);
            this.rbrectangulo.Name = "rbrectangulo";
            this.rbrectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbrectangulo.TabIndex = 0;
            this.rbrectangulo.TabStop = true;
            this.rbrectangulo.Text = "Rectangulo";
            this.rbrectangulo.UseVisualStyleBackColor = true;
            // 
            // rbtriangulo
            // 
            this.rbtriangulo.AutoSize = true;
            this.rbtriangulo.Location = new System.Drawing.Point(111, 19);
            this.rbtriangulo.Name = "rbtriangulo";
            this.rbtriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbtriangulo.TabIndex = 0;
            this.rbtriangulo.TabStop = true;
            this.rbtriangulo.Text = "Triangulo";
            this.rbtriangulo.UseVisualStyleBackColor = true;
            // 
            // rbcuadrado
            // 
            this.rbcuadrado.AutoSize = true;
            this.rbcuadrado.Location = new System.Drawing.Point(6, 19);
            this.rbcuadrado.Name = "rbcuadrado";
            this.rbcuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbcuadrado.TabIndex = 0;
            this.rbcuadrado.TabStop = true;
            this.rbcuadrado.Text = "Cuadrado";
            this.rbcuadrado.UseVisualStyleBackColor = true;
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(302, 210);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(231, 203);
            this.txtInformacion.TabIndex = 2;
            this.txtInformacion.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Figuras.Properties.Resources.portada;
            this.pictureBox.Location = new System.Drawing.Point(21, 210);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(215, 194);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbesfera;
        private System.Windows.Forms.RadioButton rbprisma;
        private System.Windows.Forms.RadioButton rbcubo;
        private System.Windows.Forms.RadioButton rbcirculo;
        private System.Windows.Forms.RadioButton rbpoligonoirregular;
        private System.Windows.Forms.RadioButton rbpoligonoregular;
        private System.Windows.Forms.RadioButton rbrectangulo;
        private System.Windows.Forms.RadioButton rbtriangulo;
        private System.Windows.Forms.RadioButton rbcuadrado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtmedidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox txtInformacion;
    }
}


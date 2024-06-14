using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using FiguraGeometrica;
using Figuras_Geometricas;

namespace Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            if (rbcuadrado.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.cuadrado);
            }
            else if (rbtriangulo.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.triangulo);
            }
            else if (rbrectangulo.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.reactangulo);
            }
            else if (rbpoligonoregular.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.poligono_regular);
            }
            else if (rbpoligonoirregular.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.poligono_irregular);
            }
            else if (rbcirculo.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.circulo);
            }
            else if (rbcubo.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.cubo);
            }
            else if (rbprisma.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.prisma);
            }
            else if (rbesfera.Checked)
            {
                pictureBox.Image = (Figuras.Properties.Resources.esfera);
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (rbcuadrado.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Cuadrado, " + "\n" + "Sus lados son:" + "Logitud de lado: " + txtmedidas.Text;
            }
            else if (rbtriangulo.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Triángulo, " + "\n" + "Sus lados son:" + "Logitud de lado: " + txtmedidas.Text;
            }
            else if (rbrectangulo.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Rectángulo, " + "\n" + "Sus lados son:" + "Logitud de lado: " + txtmedidas.Text;
            }
            else if (rbpoligonoregular.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Polígono regular, " + "\n" + "Sus datos son:" + txtmedidas.Text;
            }
            else if (rbpoligonoirregular.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Polígono irregular, " + "\n" + "Sus datos son:" + txtmedidas.Text;
            }
            else if (rbcirculo.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Círculo, " + "\n" + "Sus datos son:" + txtmedidas.Text;
            }
            else if (rbcubo.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Cubo, " + "\n" + "Sus datos son:" + txtmedidas.Text;
            }
            else if (rbprisma.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Prisma, " + "\n" + "Sus datos son:" + txtmedidas.Text;
            }
            else if (rbesfera.Checked)
            {
                txtInformacion.Text = "Figura seleccionada: Esfera, " + "\n" + "Sus datos son:" + txtmedidas.Text;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtInformacion.Clear();
            pictureBox.Image = (Figuras.Properties.Resources.portada);
            txtmedidas.Clear();
            rbcuadrado.Checked = false;
            rbtriangulo.Checked = false;
            rbrectangulo.Checked = false;
            rbesfera.Checked = false;
            rbcirculo.Checked = false;
            rbcubo.Checked = false;
            rbprisma.Checked = false;
            rbpoligonoirregular.Checked = false;
            rbpoligonoregular.Checked = false;
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" DATOS  GUARDADOS" + txtmedidas.Text, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try //EXCEPCION
            {
                string filename = @"D:\Development\CSharp\Figuras\DATOS_EXPORTADOS";
                StreamWriter writer = File.AppendText(filename);
                writer.WriteLine("txtmedidas: " + txtInformacion.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}

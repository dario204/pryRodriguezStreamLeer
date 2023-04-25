using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezStreamLeer
{
    public partial class Stream : Form
    {
        public Stream()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter ManejoArchivo = new StreamWriter("ArchivoNuevo.txt", false);
            string texto = txtGrabar.Text;
            using (StreamWriter sw = ManejoArchivo)
            {
                sw.WriteLine(texto);
            }
            MessageBox.Show("Archivo guardado correctamente");



        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader ManejoArchivo = new StreamReader("ArchivoNuevo.txt");
            using (StreamReader sr= new StreamReader("ArchivoNuevo.txt"))
            {
                string Contenido = sr.ReadToEnd();
                rtbTexto.Text=Contenido;
            }
            MessageBox.Show("Leido correctamente");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            StreamReader ManejoArchivo = new StreamReader("ArchivoNuevo.txt");
            while (ManejoArchivo.EndOfStream==false)
            {
                string Auxiliar = ManejoArchivo.ReadLine();
                if (Auxiliar.Contains(txtDato.Text))
                {
                    MessageBox.Show("Encontrado");
                    break;
                }
                else
                {
                    MessageBox.Show("No encontrado");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

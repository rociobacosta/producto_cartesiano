using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace producto_cartesiano
{
    public partial class producto_cartesiano : Form
    {
        public producto_cartesiano()
        {
            InitializeComponent();
        }

        

        private List<string> GenerarProductoCartesiano(List<string> setA, List<string> setB)
        {
            // Crear una lista para almacenar el producto cartesiano
            List<string> producto = new List<string>();

            // Generar pares ordenados
            foreach (string elementoA in setA)
            {
                foreach (string elementoB in setB)
                {
                    // Agregar el par ordenado a la lista
                    producto.Add($"({elementoA}, {elementoB})");
                }
            }
           
            return producto; // Devolver el producto cartesiano
        }

        private void MostrarResultados(List<string> producto)
        {
            // Limpiar el ListBox antes de mostrar resultados
            listResultado.Items.Clear();

            // Mostrar cada par ordenado en el ListBox
            foreach (string par in producto)
            {
                listResultado.Items.Add(par);
            }
        }

        private void btnGenerarConjunto_Click_1(object sender, EventArgs e)
        {
            string primerConjunto = txtboxPrimerConjunto.Text;
            string segundoConjunto = txtboxSegundoConjunto.Text;

            if (string.IsNullOrWhiteSpace(primerConjunto) || string.IsNullOrWhiteSpace(segundoConjunto))
            {
                MessageBox.Show("Por favor, ingresa ambos conjuntos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> setA = primerConjunto.Split(',').Select(x => x.Trim()).ToList();
            List<string> setB = segundoConjunto.Split(',').Select(x => x.Trim()).ToList();

            // Generar el producto cartesiano
            List<string> producto = GenerarProductoCartesiano(setA, setB);
            panel1.Visible = true;
            // Mostrar los resultados en el ListBox
            MostrarResultados(producto);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }
    }

}


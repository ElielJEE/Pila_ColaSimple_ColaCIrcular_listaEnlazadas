using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_ColasSimples_ColasCirculares
{
    public partial class FormPila : Form
    {
        public FormPila()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        int tope = -1, maximo;

        public struct Clientes
        {
            public string nombre, marca;
            public double precio, total;
            public int horas;
        }

        Clientes[] cliente;

        public bool PilaLlena()
        {
            if (tope == maximo - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PilaVacia()
        {
            if (tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Agregar(string nombre, string marca, double precio, double total, int horas)
        {
            if (PilaLlena() == false)
            {
                tope++;
                cliente[tope].nombre = nombre;
                cliente[tope].marca = marca;
                cliente[tope].precio = precio;
                cliente[tope].horas = horas;
                cliente[tope].total = total;
                dataGridView1.Rows.Add(cliente[tope].nombre, cliente[tope].marca, cliente[tope].precio,
                    cliente[tope].horas, cliente[tope].total);
            }
            else
            {
                MessageBox.Show("La pila esta llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Eliminar()
        {
            if (PilaVacia() == false)
            {
                tope--;

                dataGridView1.Rows.Clear();
                for (int i = 0; i <= tope; i++)
                {
                    if (tope != -1)
                    {
                        dataGridView1.Rows.Add(cliente[i].nombre, cliente[i].marca, cliente[i].precio,
                            cliente[i].horas, cliente[i].total);
                    }
                }
            }
            else
            {
                MessageBox.Show("La pila esta vacia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitCantidad_Click(object sender, EventArgs e)
        {
            if (txtClienteCant.Text != "" && txtClienteCant.Text != "0")
            {
                maximo = Convert.ToInt32(txtClienteCant.Text);
                cliente = new Clientes[maximo];
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe de agregar un valor numerico, mayor que cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitDatos_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtHoras.Text != "")
            {
                Agregar(txtNombre.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text), 
                    Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtHoras.Text), Convert.ToInt32(txtHoras.Text));

                txtNombre.Clear();
                txtMarca.Clear();
                txtPrecio.Clear();
                txtHoras.Clear();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}

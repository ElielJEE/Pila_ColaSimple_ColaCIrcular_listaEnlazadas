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
    public partial class FormColaSimple : Form
    {
        public FormColaSimple()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        int frente = -1, final = -1, maximo;

        public struct Clientes
        {
            public string nombre, marca;
            public double precio, total;
            public int horas;
        }

        Clientes[] cliente;

        public void Agregar(string nombre, string marca, double precio, double total, int horas)
        {
            if (final < maximo - 1)
            {
                final++;

                cliente[final].nombre = nombre;
                cliente[final].marca = marca;
                cliente[final].precio = precio;
                cliente[final].total = total;
                cliente[final].horas = horas;

                dataGridView1.Rows.Add(cliente[final].nombre, cliente[final].marca, 
                    cliente[final].precio, cliente[final].horas, cliente[final].total);

                if (final == 0)
                {
                    frente = 0;
                }
            }
            else
            {
                MessageBox.Show("La cola esta llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Eliminar()
        {
            string datoNombre, datoMarca;
            double datoPrecio, datoTotal;
            int datoHoras;

            if (frente > -1)
            {
                datoNombre = cliente[frente].nombre;
                datoMarca = cliente[frente].marca;
                datoPrecio = cliente[frente].precio;
                datoHoras = cliente[frente].horas;
                datoTotal = cliente[frente].total;

                if (frente == final)
                {
                    frente = -1;
                    final = -1;
                }
                else
                {
                    frente++;
                }
            }
            else
            {
                MessageBox.Show("La cola esta vacia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView1.Rows.Clear();
            for (int i = frente; i < final + 1; i++)
            {
                if (frente != -1)
                {
                    dataGridView1.Rows.Add(cliente[i].nombre, cliente[i].marca,
                    cliente[i].precio, cliente[i].horas, cliente[i].total);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
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

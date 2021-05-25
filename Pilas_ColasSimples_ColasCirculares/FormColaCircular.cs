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
    public partial class FormColaCircular : Form
    {
        public FormColaCircular()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            btnEliminar.Enabled = false;
        }

        int final = -1, frente = -1, max;

        struct Clientes
        {
            public string nombre, marca;
            public double precio, total;
            public int horas;
        }
        Clientes[] cliente;


        public void Agregar(string nombre, string marca, double precio, double total, int horas)
        {
            if ((final == max - 1 && frente == 0) || (final + 1 == frente))
            {
                MessageBox.Show("Cola llena.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (final == max - 1)
                {
                    final = 0;
                }
                else
                {
                    final++;
                }

                cliente[final].nombre = nombre;
                cliente[final].marca = marca;
                cliente[final].precio = precio;
                cliente[final].total = total;
                cliente[final].horas = horas;
                dataGridView1.Rows.Add(cliente[final].nombre, cliente[final].marca,
                    cliente[final].precio, cliente[final].horas, cliente[final].total);

                if (frente == -1)
                {
                    frente = 0;
                }
            }
        }

        public void Eliminar()
        {
            string nombre, marca;
            double precio, total;
            int horas;

            if (frente == -1)
            {
                MessageBox.Show("Cola Vacia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nombre = cliente[frente].nombre;
                marca = cliente[frente].marca;
                precio = cliente[frente].precio;
                horas = cliente[frente].horas;
                total = cliente[frente].total;


                if (frente == final)
                {
                    frente = -1;
                    final = -1;
                }
                else
                {
                    if (frente == max - 1)
                    {
                        frente = 0;
                    }
                    else
                    {
                        frente++;
                    }
                }
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
            if (txtClienteCant.Text != " ")
            {
                max = Convert.ToInt32(txtClienteCant.Text);
                cliente = new Clientes[max];
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe de llenar el campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitDatos_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != " " || txtMarca.Text != " " || txtPrecio.Text != " " || txtHoras.Text != " ")
            {
                Agregar(txtNombre.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text),
                    Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtHoras.Text), Convert.ToInt32(txtHoras.Text));
            }
            else
            {
                MessageBox.Show("Debe de llenar los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}

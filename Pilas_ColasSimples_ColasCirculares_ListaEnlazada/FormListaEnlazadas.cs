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
    public partial class FormListaEnlazadas : Form
    {
        public FormListaEnlazadas()
        {
            InitializeComponent();

            btnInsertarDespuesX.Enabled = false;
            btnInsertarAntesX.Enabled = false;
            btnInsertarFinal.Enabled = false;
            gbDelete.Enabled = false;
            gbSearch.Enabled = false;
            gbTracing.Enabled = false;
            btnVaciarLista.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        ListaCliente listaCliente = new ListaCliente();
        string nombre, marca;
        double precio, total;
        int horas;
        FormX X = new FormX();

        public bool Validar()
        {
            if (txtNombre.Text == "" && txtMarca.Text == "" && txtPrecio.Text == "" && txtHoras.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CapturarDatos()
        {
            nombre = txtNombre.Text;
            marca = txtMarca.Text;
            precio = Convert.ToDouble(txtPrecio.Text);
            horas = Convert.ToInt32(txtHoras.Text);
            total = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtHoras.Text);
        }

        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                CapturarDatos();
                listaCliente.InsertarInicio(nombre, marca, precio, horas, total);
                listaCliente.Mostrar(dataGridView1);

                btnInsertarDespuesX.Enabled = true;
                btnInsertarAntesX.Enabled = true;
                btnInsertarFinal.Enabled = true;
                gbDelete.Enabled = true;
                gbSearch.Enabled = true;
                gbTracing.Enabled = true;
                btnVaciarLista.Enabled = true;
                btnEliminarCliente.Enabled = true;
                txtHoras.Clear();
                txtNombre.Clear();
                txtMarca.Clear();
                txtPrecio.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                CapturarDatos();
                listaCliente.InsertarFinal(nombre, marca, precio, horas, total);
                listaCliente.Mostrar(dataGridView1);

                txtHoras.Clear();
                txtNombre.Clear();
                txtMarca.Clear();
                txtPrecio.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnInsertarDespuesX_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                X.ShowDialog();
                CapturarDatos();
                listaCliente.InsertarDespuesX(nombre, marca, precio, horas, total, X.nombre);
                listaCliente.Mostrar(dataGridView1);
                txtHoras.Clear();
                txtNombre.Clear();
                txtMarca.Clear();
                txtPrecio.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnInsertarAntesX_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
            {
                X.ShowDialog();
                CapturarDatos();
                listaCliente.InsertarAntesX(nombre, marca, precio, horas, total, X.nombre);
                listaCliente.Mostrar(dataGridView1);
                txtHoras.Clear();
                txtNombre.Clear();
                txtMarca.Clear();
                txtPrecio.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            listaCliente.VaciarPila(dataGridView1);
            btnInsertarDespuesX.Enabled = false;
            btnInsertarAntesX.Enabled = false;
            btnInsertarFinal.Enabled = false;
            gbDelete.Enabled = false;
            gbSearch.Enabled = false;
            gbTracing.Enabled = false;
            btnVaciarLista.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            listaCliente.EliminarInicio();
            listaCliente.Mostrar(dataGridView1);

            if (listaCliente.ListaVacia() == true)
            {
                btnInsertarDespuesX.Enabled = false;
                btnInsertarAntesX.Enabled = false;
                btnInsertarFinal.Enabled = false;
                gbDelete.Enabled = false;
                gbSearch.Enabled = false;
                gbTracing.Enabled = false;
                btnVaciarLista.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            listaCliente.EliminarFinal();
            listaCliente.Mostrar(dataGridView1);

            if (listaCliente.ListaVacia() == true)
            {
                btnInsertarDespuesX.Enabled = false;
                btnInsertarAntesX.Enabled = false;
                btnInsertarFinal.Enabled = false;
                gbDelete.Enabled = false;
                gbSearch.Enabled = false;
                gbTracing.Enabled = false;
                btnVaciarLista.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }

        private void btnEliminarDespuesX_Click(object sender, EventArgs e)
        {
            X.ShowDialog();
            listaCliente.EliminarDespuesX(X.nombre);
            listaCliente.Mostrar(dataGridView1);
        }

        private void btnEliminarAntesX_Click(object sender, EventArgs e)
        {
            X.ShowDialog();
            listaCliente.EliminarAntesX(X.nombre);
            listaCliente.Mostrar(dataGridView1);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            X.ShowDialog();
            listaCliente.EliminarX(X.nombre);
            listaCliente.Mostrar(dataGridView1);

            if (listaCliente.ListaVacia() == true)
            {
                btnInsertarDespuesX.Enabled = false;
                btnInsertarAntesX.Enabled = false;
                btnInsertarFinal.Enabled = false;
                gbDelete.Enabled = false;
                gbSearch.Enabled = false;
                gbTracing.Enabled = false;
                btnVaciarLista.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }

        private void btnBusquedaOrdenada_Click(object sender, EventArgs e)
        {
            X.ShowDialog();
            listaCliente.BusquedaOrdenada(X.nombre);
        }

        private void btnBusquedaDesordenada_Click(object sender, EventArgs e)
        {
            X.ShowDialog();
            listaCliente.BusquedaDesordenada(X.nombre);
        }

        private void btnBusquedaRecursiva_Click(object sender, EventArgs e)
        {
            X.ShowDialog();
            listaCliente.BusquedaRecursiva(listaCliente.primero, X.nombre);
        }

        private void btnRecorridoIterativo_Click(object sender, EventArgs e)
        {
            listaCliente.RecorridoIterativo();
        }

        private void btnRecorridoRecursivo_Click(object sender, EventArgs e)
        {
            listaCliente.RecorridoRecursivo(listaCliente.primero.Siguiente);
        }
    }
}

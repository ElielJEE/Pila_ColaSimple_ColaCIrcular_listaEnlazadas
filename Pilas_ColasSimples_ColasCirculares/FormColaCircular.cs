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
        int cantidadMax = 0;
        ColaCirular registro;
        private void btnSubmitCantidad_Click_1(object sender, EventArgs e)
        {
            if (txtClienteCant.Text != " ")
            {
                cantidadMax = Convert.ToInt32(txtClienteCant.Text);
                registro = new ColaCirular(cantidadMax);
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
                btnEliminar.Enabled = true;
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe de llenar el campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_reiniciar_cola_Click(object sender, EventArgs e)
        {
            cantidadMax = 0;
            txtClienteCant.Clear();
            txtNombre.Clear();
            txtHoras.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            dataGridView1.Rows.Clear();
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            txtClienteCant.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            registro.Eliminar(dataGridView1);
        }

        private void btnSubmitDatos_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || 
                    string.IsNullOrEmpty(txtMarca.Text)  || 
                    string.IsNullOrEmpty(txtPrecio.Text) ||
                    string.IsNullOrEmpty(txtHoras.Text))
                {
                     
                }

                registro.Agregar(txtNombre.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text),
                        Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtHoras.Text), 
                        Convert.ToInt32(txtHoras.Text), dataGridView1);


                    txtNombre.Clear();
                    txtHoras.Clear();
                    txtMarca.Clear();
                    txtPrecio.Clear();
              
            }
            catch (Exception)
            {

                 MessageBox.Show("Debe de Llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
}
    }
}

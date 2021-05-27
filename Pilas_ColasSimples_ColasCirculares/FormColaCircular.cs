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

        //Instancia de la clase ColaCirular.
        ColaCirular registro;
        private void btnSubmitCantidad_Click_1(object sender, EventArgs e)
        {
            if (txtClienteCant.Text != " ")
            {
                cantidadMax = Convert.ToInt32(txtClienteCant.Text);
                /*
                 * Pasandole la cantidad maxima de clientes 
                 * al constructor de la clase ColaCirular.
                 */
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

        /*
         * Metodo nos permite reiniciar la Cola
         * Para poder volver a ingresar datos 
         * haciendo que la cola vuelva a 0 
         * sin que haya conflictos al volver insertar.
         */
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
            //permite cerrar la ventana al presionar el boton X.
            Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            /*
             * Metodo eliminar de la clase ColaCirular 
             * se le debe pasar el nombre del 
             * DataGridView que le dieron en el diseño
             * para poder trabajar con el en la clase.
             */
            registro.Eliminar(dataGridView1);
        }

        private void btnSubmitDatos_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validacion de campos vacios y manejo de errores 
                if (string.IsNullOrEmpty(txtNombre.Text) || 
                    string.IsNullOrEmpty(txtMarca.Text)  || 
                    string.IsNullOrEmpty(txtPrecio.Text) ||
                    string.IsNullOrEmpty(txtHoras.Text)){}

                /*
                 * Al igual que el Meotod eliminar
                 * a este metodo tambien se le debe pasar
                 * el nombre del DatagridView que le hayan puesto anteriormente.
                 */
                registro.Agregar(txtNombre.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text),
                        Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtHoras.Text), 
                        Convert.ToInt32(txtHoras.Text), dataGridView1);


                    txtNombre.Clear();
                    txtHoras.Clear();
                    txtMarca.Clear();
                    txtPrecio.Clear();
                    txtNombre.Focus();
              
            }
            catch (Exception)
            {
                 MessageBox.Show("Debe de Llenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
        /*
         * Al presionar la Tecla ""Enter"" de nuestro teclado,
         * por cada campo, iran pasando en orden 
         * haciendo que se rellenen los campos mas rapidos, 
         * para esto se usaron los eventos de los textbox
         * el cual es el Keypress para obtener la tecla presionada.
         */
        #region Focus de Textbox para Pasar de uno a otro

       
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMarca.Focus();
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecio.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtHoras.Focus();
            }
        }

     

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSubmitDatos.Focus();
            }
        }

        private void txtClienteCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                 btnSubmitCantidad.Focus();
            }
        }

        #endregion
    }
}

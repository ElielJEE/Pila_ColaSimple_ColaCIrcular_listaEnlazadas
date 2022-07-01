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
    public partial class FormX : Form
    {
        public FormX()
        {
            InitializeComponent();
        }

        public string nombre;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtRefX.Text == "")
            {
                MessageBox.Show("El campo esta vacio, por favor ingrese un valor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nombre = txtRefX.Text;
                Close();
            }
        }
    }
}

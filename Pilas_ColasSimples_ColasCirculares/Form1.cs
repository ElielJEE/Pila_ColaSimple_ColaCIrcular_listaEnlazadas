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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PilasForm_Click(object sender, EventArgs e)
        {
            FormPila pila = new FormPila();
            pila.Show();
        }

        private void ColasSimpleForm_Click(object sender, EventArgs e)
        {
            FormColaSimple colaSimple = new FormColaSimple();
            colaSimple.Show();
        }

        private void ColasCircularesForm_Click(object sender, EventArgs e)
        {
            FormColaCircular colaCircular = new FormColaCircular();
            colaCircular.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colaCircularConEstructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

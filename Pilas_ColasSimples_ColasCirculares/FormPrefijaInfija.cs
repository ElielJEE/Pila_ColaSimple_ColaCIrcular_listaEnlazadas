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
    public partial class FormPrefijaInfija : Form
    {
        public FormPrefijaInfija()
        {
            InitializeComponent();
        }

        int tope, maximo;
        string notacionInfija = "", notacionPrefija, aux1, aux2, invertida;
        char dato;
        string[] pila;

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

        public void Agregar(string dato)
        {
            if (PilaLlena() == false)
            {
                tope++;
                pila[tope] = dato;
            }
            else
            {
                MessageBox.Show("la pila  se encuentra llena");
            }
        }

        public string Eliminar()
        {
            string dato = "";

            if (PilaVacia() == false)
            {
                dato = pila[tope];
                tope--;
            }
            else
            {
                MessageBox.Show("la pila se encuentra vacia");
            }

            return dato;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPrefija.Text != "")
            {
                notacionPrefija = txtPrefija.Text;
                maximo = notacionPrefija.Length;
                pila = new string[notacionPrefija.Length];

                for (int i = notacionPrefija.Length - 1; i >= 0; i--)
                {
                    dato = notacionPrefija[i];

                    if (dato != '^' && dato != '*' && dato != '/' && dato != '+' && dato != '-')
                    {
                        Agregar(dato.ToString());
                    }
                    else
                    {
                        aux1 = Eliminar();
                        aux2 = Eliminar();
                        aux2 = "(" + aux2 + dato + aux1 + ")";
                        Agregar(aux2);
                    }
                }

                while (PilaVacia() != true)
                {
                    notacionInfija += Eliminar();
                }

                for (int i = notacionInfija.Length - 1; i >= 0; i--)
                {
                    if (notacionInfija[i] == '(')
                    {
                        invertida += ')';
                    }
                    else if (notacionInfija[i] == ')')
                    {
                        invertida += '(';
                    }
                    else
                    {
                        invertida += notacionInfija[i];
                    }
                }
                dataGridView1.Rows.Add(notacionPrefija, notacionInfija, invertida);
                txtPrefija.Clear();
                invertida = ""; 
                notacionInfija = "";
                notacionPrefija = "";
            }
            else
            {
                MessageBox.Show("Es necesario ingresar un valor en el campo para continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

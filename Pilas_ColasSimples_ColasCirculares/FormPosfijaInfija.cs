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
    public partial class FormPosfijaInfija : Form
    {
        public FormPosfijaInfija()
        {
            InitializeComponent();
        }

        int tope, maximo;
        string notacionInfija = "", notacionPosfija, aux1, aux2;
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
            if (txtPosfija.Text != "")
            {
                notacionPosfija = txtPosfija.Text;
                maximo = notacionPosfija.Length;
                pila = new string[notacionPosfija.Length];

                while (notacionPosfija != "")
                {
                    dato = notacionPosfija[0];
                    notacionPosfija = notacionPosfija.Substring(1);

                    if (dato >= '0' && dato <= '9')
                    {
                        Agregar(dato.ToString());
                    }
                    else
                    {

                        aux1 = Eliminar();
                        aux2 = Eliminar();
                        aux1 = "(" + aux2 + dato + aux1 + ")";
                        Agregar(aux1);

                    }
                }

                while (PilaVacia() != true)
                {
                    notacionInfija += Eliminar();
                }

                dataGridView1.Rows.Add(txtPosfija.Text, notacionInfija);
                txtPosfija.Clear();
                notacionPosfija = "";
                notacionInfija = "";
            }
            else
            {
                MessageBox.Show("Es necesario ingresar un valor en el campo para continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int precedencia(string dato)
        {
            int precedencia = 0;

            switch (dato)
            {
                case "^":
                    precedencia = 4;
                    break;

                case "/":
                case "*":
                    precedencia = 3;
                    break;

                case "+":
                case "-":
                    precedencia = 2;
                    break;

                case "=":
                    precedencia = 1;
                    break;

                default:
                    precedencia = 0;
                    break;
            }
            return precedencia;
        }
    }
}

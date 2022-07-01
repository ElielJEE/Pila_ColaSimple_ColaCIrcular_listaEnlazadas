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
    public partial class FormInfijaPrefija : Form
    {
        public FormInfijaPrefija()
        {
            InitializeComponent();
        }

        int tope, maximo;
        string notacionPrefija = "", notacionInfija, invertida;
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
            if (txtInfija.Text != "")
            {
                notacionInfija = txtInfija.Text;
                maximo = notacionInfija.Length;
                pila = new string[notacionInfija.Length];

                for (int i = notacionInfija.Length - 1; i >= 0; i--)
                {
                    dato = notacionInfija[i];

                    if (dato.Equals(')'))
                    {
                        Agregar(dato.ToString());
                    }
                    else if (dato.Equals('('))
                    {
                        while (pila[tope] != ")")
                        {
                            notacionPrefija += Eliminar();
                        }
                        Eliminar();
                    }
                    else
                    {
                        if (dato >= '0' && dato <= '9')
                        {
                            notacionPrefija += dato;
                        }
                        else
                        {
                            while (PilaVacia() == false && precedencia(dato.ToString()) < precedencia(pila[tope]))
                            {
                                notacionPrefija += Eliminar();
                            }
                            Agregar(dato.ToString());
                        }
                    }
                }

                while (PilaVacia() == false)
                {
                    notacionPrefija += Eliminar();
                }

                for (int i = notacionPrefija.Length - 1; i >= 0; i--)
                {
                    invertida += notacionPrefija[i];
                }

                dataGridView1.Rows.Add(notacionInfija, notacionPrefija, invertida);
                txtInfija.Clear();
                notacionPrefija = "";
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

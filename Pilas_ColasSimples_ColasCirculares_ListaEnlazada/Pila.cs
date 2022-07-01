using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_ColasSimples_ColasCirculares
{
    class Pila
    {
        int tope = -1, maximo;

        public struct Clientes
        {
            public string nombre, marca;
            public double precio, total;
            public int horas;
        }
        Clientes[] cliente;

        public Pila(int max)
        {
            maximo = max;
            cliente = new Clientes[maximo];
        }

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

        public void Agregar(string nombre, string marca, double precio, double total, int horas, DataGridView dgv)
        {
            if (PilaLlena() == false)
            {
                tope++;

                cliente[tope].nombre = nombre;
                cliente[tope].marca = marca;
                cliente[tope].precio = precio;
                cliente[tope].horas = horas;
                cliente[tope].total = total;

                dgv.Rows.Add(cliente[tope].nombre, cliente[tope].marca, cliente[tope].precio,
                    cliente[tope].horas, cliente[tope].total);
            }
            else
            {
                MessageBox.Show("La pila esta llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Eliminar(DataGridView dgv)
        {
            if (PilaVacia() == false)
            {
                tope--;

                dgv.Rows.Clear();
                for (int i = 0; i <= tope; i++)
                {
                    if (tope != -1)
                    {
                        dgv.Rows.Add(cliente[i].nombre, cliente[i].marca, cliente[i].precio,
                            cliente[i].horas, cliente[i].total);
                    }
                }
            }
            else
            {
                MessageBox.Show("La pila esta vacia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

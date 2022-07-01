using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_ColasSimples_ColasCirculares
{
    class ColaSimple
    {
        int frente, final, maximo;

        public struct Clientes
        {
            public string nombre, marca;
            public double precio, total;
            public int horas;
        }
        Clientes[] cliente;

        public ColaSimple(int max)
        {
            frente = -1;
            final = -1;
            maximo = max;
            cliente = new Clientes[maximo];
        }

        public void Agregar(string nombre, string marca, double precio, double total, int horas, DataGridView dgv)
        {
            if (final < maximo - 1)
            {
                final++;

                cliente[final].nombre = nombre;
                cliente[final].marca = marca;
                cliente[final].precio = precio;
                cliente[final].total = total;
                cliente[final].horas = horas;

                dgv.Rows.Add(cliente[final].nombre, cliente[final].marca,
                    cliente[final].precio, cliente[final].horas, cliente[final].total);

                if (final == 0)
                {
                    frente = 0;
                }
            }
            else
            {
                MessageBox.Show("La cola esta llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Eliminar(DataGridView dgv)
        {
            if (frente > -1)
            {
                dgv.Rows.RemoveAt(0);
                
                if (frente == final)
                {
                    frente = -1;
                    final = -1;
                }
                else
                {
                    frente++;
                }
            }
            else
            {
                MessageBox.Show("La cola esta vacia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

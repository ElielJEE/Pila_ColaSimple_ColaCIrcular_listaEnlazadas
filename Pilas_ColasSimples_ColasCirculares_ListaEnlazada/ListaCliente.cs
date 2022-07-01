using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_ColasSimples_ColasCirculares
{
    class ListaCliente
    {
        public CNodo primero, T, puntero, anterior;

        public ListaCliente()
        {
            primero = new CNodo();

            primero.Siguiente = null;
        }

        public void Mostrar(DataGridView dgv)
        {
            T = primero;

            dgv.Rows.Clear();
            while (T.Siguiente != null)
            {
                T = T.Siguiente;

                string nombre = T.Nombre;
                string marca = T.Marca;
                double precio = T.Precio;
                double total = T.Total;
                int horas = T.Horas;

                dgv.Rows.Add(nombre, marca, precio, horas, total);
            }
        }

        public bool ListaVacia()
        {
            if (primero.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public CNodo BuscarRefX(string pNombre)
        {
            if (ListaVacia() == true)
            {
                return null;
            }

            puntero = primero;

            while (puntero.Siguiente != null)
            {
                puntero = puntero.Siguiente;

                if (puntero.Nombre == pNombre)
                {
                    return puntero;
                }
            }

            return null;
        }

        public void InsertarInicio(string pNombre, string pMarca, double pPrecio, int pHoras, double pTotal)
        {
            CNodo q = new CNodo();

            q.Nombre = pNombre;
            q.Marca = pMarca;
            q.Precio = pPrecio;
            q.Horas = pHoras;
            q.Total = pTotal;

            q.Siguiente = primero.Siguiente;

            primero.Siguiente = q;
        }

        public void InsertarFinal(string pNombre, string pMarca, double pPrecio, int pHoras, double pTotal)
        {
            CNodo q = new CNodo();

            T = primero;

            while (T.Siguiente != null)
            {
                T = T.Siguiente;
            }

            q.Nombre = pNombre;
            q.Marca = pMarca;
            q.Precio = pPrecio;
            q.Total = pTotal;
            q.Horas = pHoras;

            q.Siguiente = null;

            T.Siguiente = q;
        }

        public void InsertarDespuesX(string pNombre, string pMarca, double pPrecio, int pHoras, double pTotal, string x)
        {
            T = BuscarRefX(x);

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CNodo q = new CNodo();

            q.Nombre = pNombre;
            q.Marca = pMarca;
            q.Precio = pPrecio;
            q.Total = pTotal;
            q.Horas = pHoras;

            q.Siguiente = T.Siguiente;

            T.Siguiente = q;
        }

        public void InsertarAntesX(string pNombre, string pMarca, double pPrecio, int pHoras, double pTotal, string x)
        {
            T = BuscarRefX(x);
            CNodo p = primero;

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CNodo q = new CNodo();

            q.Nombre = pNombre;
            q.Marca = pMarca;
            q.Precio = pPrecio;
            q.Total = pTotal;
            q.Horas = pHoras;

            while (p.Siguiente != T)
            {
                p = p.Siguiente;
            }

            q.Siguiente = T;

            p.Siguiente = q;
        }

        public void EliminarInicio()
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("La lista esta vacia.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CNodo p = primero.Siguiente;
                primero.Siguiente = p.Siguiente;
            }
        }

        public void EliminarFinal()
        {
            if (ListaVacia() == true)
            {
                MessageBox.Show("La lista esta vacia.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CNodo p = primero;

                while (p.Siguiente != null)
                {
                    T = p;
                    p = p.Siguiente;
                }

                T.Siguiente = null;
            }
        }

        public void EliminarDespuesX(string x)
        {
            T = BuscarRefX(x);

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CNodo s = T.Siguiente;

            if (T.Siguiente == null)
            {
                MessageBox.Show($"No existe ningun cliente despues {x}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                T.Siguiente = s.Siguiente;
            }
        }

        public void EliminarAntesX(string x)
        {
            T = BuscarRefX(x);

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CNodo p = primero;

            while (p.Siguiente != T)
            {
                anterior = p;
                p = p.Siguiente;
            }

            if (primero.Siguiente == T)
            {
                MessageBox.Show($"No existe ningun cliente antes {x}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                anterior.Siguiente = T;
            }
        }

        public void EliminarX(string x)
        {
            T = BuscarRefX(x);

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CNodo p = primero;

            while (p.Siguiente != T.Siguiente)
            {
                anterior = p;
                p = p.Siguiente;
            }

            anterior.Siguiente = T.Siguiente;
        }

        public void BusquedaOrdenada(string x)
        {
            T = BuscarRefX(x);

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show($"Informacion del cliente: \nNombre: {T.Nombre} \nMarca del vehiculo: {T.Marca} " +
                    $"\nPrecio: {T.Precio} \nHoras: {T.Horas} \nTotal: {T.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BusquedaDesordenada(string x)
        {
            T = BuscarRefX(x);

            if (T == null)
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show($"Informacion del cliente: \nNombre:{T.Nombre} \nMarca del vehiculo: {T.Marca} " +
                    $"\nPrecio: {T.Precio} \nHoras: {T.Horas} \nTotal: {T.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BusquedaRecursiva(CNodo q, string x)
        {
            if (q != null)
            {
                if (q.Nombre == x)
                {
                    MessageBox.Show($"Informacion del cliente: \nNombre: {q.Nombre} \nMarca del vehiculo: {q.Marca} " +
                    $"\nPrecio: {q.Precio} \nHoras: {q.Horas} \nTotal: {q.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BusquedaRecursiva(q.Siguiente, x);
                }
            }
            else
            {
                MessageBox.Show("No se encontro el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RecorridoIterativo()
        {
            CNodo p = primero;

            if (p.Siguiente != null)
            {
                while (p.Siguiente != null)
                {
                    p = p.Siguiente;
                    MessageBox.Show($"Informacion del cliente: \nNombre: {p.Nombre} \nMarca del vehiculo: {p.Marca} " +
                    $"\nPrecio: {p.Precio} \nHoras: {p.Horas} \nTotal: {p.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista Vacia.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RecorridoRecursivo(CNodo q)
        {
            if (q == null)
            {
                MessageBox.Show("Fin.", "Aviso",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (q != null)
            {
                MessageBox.Show($"Informacion del cliente: \nNombre: {q.Nombre} \nMarca del vehiculo: {q.Marca} " +
                    $"\nPrecio: {q.Precio} \nHoras: {q.Horas} \nTotal: {q.Total}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecorridoRecursivo(q.Siguiente);
            }
        }

        public void VaciarPila(DataGridView dgv)
        {
            primero.Siguiente = null;
            dgv.Rows.Clear();
        }
    }
}

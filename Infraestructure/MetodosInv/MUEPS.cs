using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.MetodosInv
{
    public class MUEPS
    {
        Producto[] Productos;
        //Producto variable;
        decimal costo = 0;
        decimal CostoCompraa = 0;

        public void Compras(int i, float a)
        {
            throw new NotImplementedException();
        }

        public decimal Costo()
        {
            return costo;

        }

        public decimal CostoCompra()
        {
            for (int i = 0; i < Productos.Length; i++)
            {
                CostoCompraa += Productos[i].Existencia * Productos[i].Precio;
            }
            return CostoCompraa;
        }

        public void Create(Producto t)
        {
            if (Productos == null)
            {
                Productos = new Producto[1];
                Productos[0] = t;
                return;
            }

            Producto[] temp = new Producto[Productos.Length + 1];
            Array.Copy(Productos, temp, Productos.Length);
            temp[temp.Length - 1] = t;

            Productos = temp;
        }

        public void Eliminando()
        {
            Producto[] temp = new Producto[Productos.Length - 1];




            Array.Copy(Productos, temp, Productos.Length - 1);
            Productos = temp;

        }

        public int Largo()
        {
            return Productos.Length;
        }

        public void Ordenar()
        {
            Array.Sort(Productos);
        }
        //for(int i=0; i<leght;i++)
        public void Ventas(int i)
        {

            for (int a = (i - 1); a >= 0; a--)
            {
                if (a < 0)
                {
                    break;
                }
                if (Productos[a].Existencia != 0)
                {

                    costo += Productos[a].Existencia * Productos[a].Precio;

                    Eliminando();

                }

            }
        }
    }
}

using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.MetodosInv
{
    public class MPEPS : IMetodosModel
    {
        Producto[] Productos;
        //Producto variable;
        decimal costo = 0;
        decimal CostoCom = 0;
        

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

            CostoCom = 0;
            for (int i = 0; i < Productos.Length; i++)
            {
                CostoCom += Productos[i].Existencia * Productos[i].Precio;
            }
            return CostoCom;
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
            Array.Copy(Productos, 1, temp, 0, Productos.Length - 1);
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
        public void Ventas(int i)
        {
            for (int a = 0; a < i; a++)
            {
                if (Productos[a].Existencia != 0)
                {
                    costo += Productos[a].Existencia * Productos[a].Precio;
                }

            }
            for (int a = 0; a < i; a++)
            {
                Eliminando();
            }
        }
    }
}

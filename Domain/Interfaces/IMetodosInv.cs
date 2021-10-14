using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IMetodosInv<T>
    {
        void Create(T t);
        void Ventas(int i);

        void Compras(int i, float a);

        void Eliminando();
    }
}

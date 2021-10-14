using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IMetodosModel : IMetodosInv<Producto>
    {
        void Ordenar();
        decimal Costo();
        decimal CostoCompra();
        int Largo();
    }

}

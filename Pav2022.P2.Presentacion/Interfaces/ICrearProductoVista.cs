using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav2022.P2.Dominio.Entidades;

namespace Pav2022.P2.Presentacion.Interfaces
{
    public interface ICrearProductoVista: IVista
    {
        void CargarProductoSource();
    }
}

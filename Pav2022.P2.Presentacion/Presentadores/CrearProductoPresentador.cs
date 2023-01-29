using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Tareas;
using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Entidades;
using System;

namespace Pav2022.P2.Presentacion.Presentadores
{
    public class CrearProductoPresentador: PresentadorBase<ProductoTarea, ICrearProductoVista>
    {
        private readonly IRepositorio<Producto> _repositorio;
        public Producto ProductoSource { get; set; }

        public CrearProductoPresentador(ICrearProductoVista vista, 
            IRepositorio<Producto> repositorio): base(vista)
        {
            _repositorio = repositorio;
            ConfigurarProductoSource();
        }
        
        private void ConfigurarProductoSource()
        {
            ProductoSource = new Producto();
            Vista.CargarProductoSource();
        }

        public void CargarProducto()
        {
            try
            {
                if (!CodigoDisponible(ProductoSource.Codigo))
                    throw new Exception("Ya existe un producto con el mismo codigo.");

                if(!ProductoSource.DatosValidos())
                    throw new Exception("Datos invalidos.");

                _repositorio.Agregar(ProductoSource);
                _repositorio.UnidadDeTrabajo.Confirmar();
                Vista.MostrarMensaje("Producto cargado con exito.", "Operacion Exitosa");
                ConfigurarProductoSource();
            }
            catch(Exception e)
            {
                Vista.MostrarMensaje(e.Message, "Atencion");
            }
        }

        private bool CodigoDisponible(int codigo)
        {
            return _repositorio.GetUnico(p => p.Codigo == codigo) == null;
        }
    }
}

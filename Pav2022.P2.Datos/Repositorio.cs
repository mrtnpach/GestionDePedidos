using Microsoft.EntityFrameworkCore;
using Pav2022.P2.Dominio.Contratos;
using Pav2022.P2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Pav2022.P2.Datos
{
    /// <summary>
    /// Implementación del patrón Repository de forma genérica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repositorio<T> : IRepositorio<T>
        where T : EntidadBase
    {
        #region Members
        private readonly IUnidadDeTrabajoMarco _unidadDeTrabajo;
        #endregion

        #region Constructor
        /// <summary>
        /// Crea una nueva instancia del repositorio
        /// </summary>
        /// <param name="unidadDeTrabajo">Unit of Work asociada</param>
        public Repositorio(IUnidadDeTrabajoMarco unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo ?? throw new ArgumentNullException("unitOfWork");
        }
        #endregion

        public IUnidadDeTrabajo UnidadDeTrabajo => _unidadDeTrabajo;

        public void Agregar(T item)
        {
            if (item != null)
            {
                GetSet().Add(item);
            }
        }

        public void Quitar(T item)
        {
            if (item != null)
            {
                GetSet().Remove(item);
            }
        }

        public void Modificar(T item)
        {
            if (item != null)
            {
                _unidadDeTrabajo.SetModificado(item);
            }
        }

        public T Get(int id)
        {
            return id != 0 ? GetSet().Find(id) : null;
        }

        public IEnumerable<T> GetTodos()
        {
            return GetSet();
        }

        public IEnumerable<T> GetConFiltro(Expression<Func<T, bool>> filtro)
        {
            return GetSet().Where(filtro);
        }

        public void DescartarCambios()
        {
            _unidadDeTrabajo.RevertirCambios();
        }

        public void Refrescar(T item)
        {
            if (item != null)
            {
                _unidadDeTrabajo.Refrescar(item);
            }
        }

        public void Refrescar(EntidadBase item)
        {
            if (item != null)
            {
                _unidadDeTrabajo.Refrescar(item);
            }
        }

        public T GetUnico(Expression<Func<T, bool>> filtro)
        {
            return GetSet().FirstOrDefault(filtro);
        }

        #region IDisposable Miembros
        private bool _disposed = false;

        protected void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    UnidadDeTrabajo?.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region Métodos Privados
        DbSet<T> GetSet()
        {
            return _unidadDeTrabajo.CrearSet<T>();
        }
        #endregion
    }
}

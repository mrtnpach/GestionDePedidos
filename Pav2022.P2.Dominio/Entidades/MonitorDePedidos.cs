using Pav2022.P2.Dominio.Delegados;

namespace Pav2022.P2.Dominio.Entidades
{
    public class MonitorDePedidos
    {
        //public EventHandler<int> PedidoListo;
        public event PedidoListoDelegate PedidoListo;
        #region Singleton
        private static volatile MonitorDePedidos _instancia;
        private static readonly object _lock = new object();

        private MonitorDePedidos()
        {

        
        
        }

        public static MonitorDePedidos Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    lock (_lock)
                    {
                        _instancia = new MonitorDePedidos();
                    }
                }
                return _instancia;
            }
        }
        #endregion Singleton

        public PedidoListoDelegate Delegado { get => OnPedidoListo; }
        private void OnPedidoListo(PedidoListoEventArgs e)
        {
            PedidoListo?.Invoke(e);
        }
    }
}

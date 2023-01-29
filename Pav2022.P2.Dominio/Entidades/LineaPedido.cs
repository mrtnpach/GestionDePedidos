namespace Pav2022.P2.Dominio.Entidades
{
    public class LineaPedido : EntidadBase
    {
        public int Cantidad { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public LineaPedido()
        {

        }

        public LineaPedido(Producto producto, int cantidad)
        {
            Producto = producto;
            ProductoId = producto.Id;
            Cantidad = cantidad;
        }

        public int TiempoDePreparacion { get => Producto.TiempoDePreparacion * Cantidad; }
        public decimal SubTotal { get => Producto.Precio * Cantidad; }
    }
}

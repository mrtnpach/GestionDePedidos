namespace Pav2022.P2.Dominio.Entidades
{
    public class Producto: EntidadBase
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int TiempoDePreparacion { get; set; }

        public bool DatosValidos()
        {
            return Codigo > 0 && !string.IsNullOrEmpty(Descripcion) &&
                   Precio > 0 && TiempoDePreparacion > 0;
        }
    }
}

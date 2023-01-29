using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;

namespace Pav2022.P2.Presentacion.Tareas
{
    public class ProductoTarea: TareaBase
    {
        public ProductoTarea()
        {
            
        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<CrearProductoPresentador>(esMdiHijo: false, esDialogo: true);
        }
    }
}

# Gestión de Pedidos

Se requiere construir una pequeña aplicación que permita gestionar los pedidos en
un delivery de comida.

En esta etapa se considerarán sólo las siguientes funcionalidades:

* __Cargar producto__
* __Tomar pedido__

La aplicación contará con un menú principal con las dos opciones anteriores.

La opción __Cargar Producto__ desplegará el formulario para agregar un nuevo
producto. Se deberá informar al usuario que la carga se realizó correctamente.

Para los productos se tendrán en cuenta los siguientes datos: __código, descripción,
precio y tiempo de preparación__. Todos los datos son requeridos.

La opción __Tomar Pedido__ es la más importante y compleja. Desde ella se registrará
lo solicitado por el cliente y se visualizará el estado de los pedidos. Al elegirla se desplegará
un formulario con __dos listas una de pedidos pendientes y otra de pedidos listos para
enviar__.

El mismo formulario contará con una __opción para la registración del pedido__, esa
opción iniciará un formulario modal con todo lo necesario para tomar el pedido.

Para la toma del pedido se ingresará el código del producto; se visualizará la
descripción y precio; y se indicará la cantidad. Tener en cuenta que un cliente puede
solicitar varios productos en un mismo pedido. Se debe reflejar también el monto total a
pagar. Los datos de entrega del pedido se indican con un texto.

Los datos del pedido se completan con: __fecha, número y estado__.

Los estados posibles son: __Pendiente, Listo, Finalizado__.

Se considera: __Pendiente__, al pedido recién registrado. __Listo__, al pedido que cumplió
con el tiempo de preparación y está listo para enviarse. __Finalizado__, al pedido que fue
entregado.

Cuando se confirma el pedido se cierra el formulario modal y se refleja el nuevo
pedido en la lista de pedidos Pendientes. En la lista se deberá __mostrar el número de
pedido, el monto total y el tiempo de preparación__. Cuando se cumpla el tiempo de
preparación __el pedido pasará automáticamente a la lista de pedidos Listos__. Lo qué
significa qué el cadete lo está llevando. Cuando el cadete confirma la entrega, con un click
se confirmará y el pedido desaparecerá de la lista.

Para determinar el tiempo de preparación de un pedido se utiliza la siguiente lógica:

| Suma del tiempo de preparación de todos los productos en el pedido | Regla |
| --- | --- |
| <= 15 min | Se toma el mayor tiempo de preparación de los productos |
| > 15 y <= 20 min | Se toma el mayor tiempo de preparación de los productos y se suman 7 min |
| > 20 min  | Se toma el mayor tiempo de preparación de los productos, se suman 5 min y 5 min más por cada decena. Ej: si la suma da entre 20 y 30 (incluido) se suma 5, entre 30 y 40 (incluido) se suma 10 y así sucesivamente. |

__Consideraciones:__
* Si la aplicación se reinicia con datos cargados deberá recuperar el estado en el que
se encontraba.
* El tiempo de preparación se considera en valores discretos, expresados en minutos.
* El número del pedido puede ser de cualquier forma, solo se debe garantizar que sea
único.
* Datos de entrega del pedido como texto significa NO considerar una entidad cliente.
* __Se valorarán soluciones qué automaticen mejor el cambio de estado de los
pedidos.__


## Implementación
* .NET Core 3.1
* Windows Forms
* Unity Container (DI)
* Entity Framework Core (Code First)
* Eventos para la preparación de pedidos:

```C#
public class MonitorDePedidos
{
      public event PedidoListoDelegate PedidoListo;
      public PedidoListoDelegate Delegado { get => OnPedidoListo; }
      [...]
      private void OnPedidoListo(PedidoListoEventArgs e)
      {
          PedidoListo?.Invoke(e);
      }
}
  
public class Pedido : EntidadBase
{
      [...]
      // Preparacion del pedido
      public int TiempoTotal { get; private set; }
      private Timer _preparacion;
      private event PedidoListoDelegate PedidoListo;
      public bool Iniciado { get; private set; } = false;
      [...]
}
```
_Nota: Al reiniciar la aplicación, los temporizadores de los pedidos pendientes no resumen. Esto causa que nunca se finalicen y pasen a la lista de pedidos listos_

## GUI
### Lista de Pedidos
![Captura de lista de pedidos](https://i.imgur.com/TaXp85F.png)

### Nuevo Pedido
![Captura de menu de nuevo pedido](https://i.imgur.com/XrEazPM.png)

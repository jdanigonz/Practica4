namespace Practica4.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        public required Venta Venta { get; set; }
        public required Producto Producto { get; set; }
    }
}

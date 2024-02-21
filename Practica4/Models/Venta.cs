namespace Practica4.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int PersonaId { get; set; }
        public decimal TotalVenta { get; set; }

        public required Usuario Cliente { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ListaDeCompras.Models

{
    public class Mascota
    {

        public int Id { get; set; }
        [Required]
        public string name { get; set; } = string.Empty;

        public DateTime FechaCompraAlimento { get; set; } = DateTime.Now;

        public string? notas { get; set; } = string.Empty;

        public bool disponible { get; set; } = true;


    }
}

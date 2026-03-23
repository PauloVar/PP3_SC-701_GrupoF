using System.ComponentModel.DataAnnotations;

namespace PP3_SC_701_GrupoFDAL.Entidades
{
    public record Vehiculo
    {
        [Required(ErrorMessage = "El id es requerido")]
        public int Id { get; init; }

        [Required(ErrorMessage = "La marca es requerida")]
        public string Marca { get; init; }

        [Required(ErrorMessage = "El modelo es requerido")]
        public string Modelo { get; init; }

        [Range(1900, 2100, ErrorMessage = "El año debe estar entre 1900 y 2100")]
        public int Anio { get; init; }

        [Required(ErrorMessage = "El color es requerido")]
        public string Color { get; init; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; init; }

        public Vehiculo(int id, string marca, string modelo, int anio, string color, decimal precio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Color = color;
            Precio = precio;
        }
    }
}
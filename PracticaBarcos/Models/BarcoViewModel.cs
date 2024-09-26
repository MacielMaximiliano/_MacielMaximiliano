using PracticaBarcosEntidades;

using System.ComponentModel.DataAnnotations;


namespace PracticaBarcos.Models
{
    public class BarcoViewModel
    {

        [Required(ErrorMessage = "El nombre del barco es obligatorio.")]
        [StringLength(40, ErrorMessage = "El nombre del barco no puede tener más de 40 caracteres.")]
        [Display(Name = "Nombre del Barco")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "La antigüedad es obligatoria.")]
        [Range(1, 49, ErrorMessage = "La antigüedad debe ser mayor a 0 y menor a 50 años.")]
        [Display(Name = "Antigüedad (en años)")]
        public int Antiguedad { get; set; }

        [Required(ErrorMessage = "La tripulación es obligatoria.")]
        [Range(10, 999, ErrorMessage = "La tripulación debe ser mayor o igual a 10 y menor a 1000 personas.")]
        [Display(Name = "Número de Tripulación Máxima")]
        public int Tripulacion { get; set; }



        public decimal Tasa { get; private set; }
        public int Id { get; private set; }

        public static Barco aBarco(BarcoViewModel barcoViewModel)
        {
            return new Barco
            {
                Nombre = barcoViewModel.Nombre,
                Antiguedad = barcoViewModel.Antiguedad,
                Tripulacion = barcoViewModel.Tripulacion,
                tasa = (barcoViewModel.Antiguedad * 0.25M) + (barcoViewModel.Tripulacion / 3M)
            };
        }

        public static BarcoViewModel aModel(Barco barco)
        {
            return new BarcoViewModel
            {
                Id=barco.IdBarco,
                Nombre = barco.Nombre, 
                Antiguedad = barco.Antiguedad, 
                Tripulacion = barco.Tripulacion, 
                Tasa = barco.tasa,
            };
        }
        public static List<BarcoViewModel> AListaModel(List<Barco> ventas)
        {

            return ventas
          .Select(v => aModel(v))
          .ToList();
        }

    }
}

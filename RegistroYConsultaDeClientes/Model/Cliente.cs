using System.ComponentModel.DataAnnotations;

namespace RegistroYConsultaDeClientes.Model
{
    public class Cliente
    {
        [Required(ErrorMessage = "El campo ClienteId es obligatorio.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Celular es obligatorio.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El campo RNC es obligatorio.")]
        public string RNC { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Direccion es obligatorio.")]
        public string Direccion { get; set; }

    }
}

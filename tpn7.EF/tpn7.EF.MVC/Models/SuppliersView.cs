using System.ComponentModel.DataAnnotations;


namespace tpn7.EF.MVC.Models
{
    public class SuppliersView
    {
        public int? Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "El campo {0} debe tener al menos {1} caracteres"), MaxLength(40)]
        public string Description { get; set; }

        [MaxLength(40)]
        public string Contacto { get; set; }

        [MaxLength(30)]
        public string ContactoTitle { get; set; }

        [MaxLength(60)]
        public string Direccion { get; set; }

        [MaxLength(60)]
        public string Ciudad { get; set; }
    }
}
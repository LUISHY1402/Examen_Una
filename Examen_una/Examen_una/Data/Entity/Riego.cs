using System.ComponentModel.DataAnnotations;

namespace Examen_una.Data.Entity
{
    public class Riego
    {
        public int id { get; set; }

        [Display(Name = "Tipo de Riego")]
        [MaxLength(10, ErrorMessage = "en el campo {0} el maximo permitido son {1} caracteres")]
        public string Type { get; set; } = null!;

        [Display(Name = "Tiempo")]
        [MaxLength(18, ErrorMessage = "en el campo {0} el maximo permitido son {1} caracteres")]
        public string Time { get; set; } = null!;

        [Display(Name = "Costo de riego")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Cantidad de riego")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        [Display(Name = "fecha de Empiezo de Riego")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "fecha de Termino de riego")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; } = null!;

    }
}

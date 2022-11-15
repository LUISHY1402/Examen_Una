using System.ComponentModel.DataAnnotations;

namespace Examen_una.Data.Entity
{
    public class Plantas
    { 
    public int id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(200, ErrorMessage = "en el campo {0} el maximo permitido son {1} caracteres")]
    public string Name { get; set; } = null!;

    [Display(Name = "Tipo")]
    [MaxLength(20, ErrorMessage = "en el campo {0} el maximo permitido son {1} caracteres")]
    public string Type { get; set; } = null!;

    [Display(Name = "Años")]
    [MaxLength(8, ErrorMessage = "en el campo {0} el maximo permitido son {1} caracteres")]
    public string Years { get; set; } = null!;

    [Display(Name = "Costo")]
    [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
    public decimal Price { get; set; }

    [Display(Name = "Cantidad")]
    [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
    public double Stock { get; set; }

    [Display(Name = "fecha de Plantacion")]
    public DateTime? LastSale { get; set; }

    [Display(Name = "fecha de Vendido")]
    public DateTime? LastPurchase { get; set; }

    [Display(Name = "Activo")]
    public bool IsActive { get; set; }

    [Display(Name = "Image")]
    public string ImageUrl { get; set; } = null!;

    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Product
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProduct {get; set;}

    [Display(Name = "Enter Product Code")]
    [StringLength(20)]
    [Required(ErrorMessage = "{0} is required")]
    public string ProductCode {get; set;}
}
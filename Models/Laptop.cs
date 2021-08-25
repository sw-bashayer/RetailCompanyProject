using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCompanyProject.Models
{
  public class Laptop
  {
    public Laptop()
    {
    }
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Screen { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string ImageURL { get; set; }

  }
}

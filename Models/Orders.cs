using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetailCompanyProject.Models
{
  public class Orders
  {
    public Orders()
    {
    }

    public int OrderId { get; set; }
    [Key]
    [ForeignKey("Laptop")]
    public int LaptopId { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Payment_type { get; set; }

  }
}

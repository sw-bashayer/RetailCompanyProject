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
    [Key]
    public int OrderId { get; set; }
    [ForeignKey("Laptop")]
    public int LaptopId { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    [StringLength(30)]
    public string Name { get; set; }
    public string Address { get; set; }
    public string Payment_type { get; set; }

  }
}

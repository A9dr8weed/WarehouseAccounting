using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseAccounting.Model
{
    [Table("TableCategory")]
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
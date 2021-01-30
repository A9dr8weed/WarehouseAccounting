using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseAccounting.Model
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int Course { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
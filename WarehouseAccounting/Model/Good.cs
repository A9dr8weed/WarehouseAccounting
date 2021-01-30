using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseAccounting.Model
{
    /// <summary>
    /// Goods.
    /// </summary>
    [Table("TableGood")]
    public class Good
    {
        /// <summary>.
        /// Id entity
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of goods.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Base Currency Price.
        /// </summary>
        public decimal BaseCurrencyPrice { get; set; }

        /// <summary>
        /// Price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Product Category.
        /// </summary>
        public string ProductCategory { get; set; }

        /// <summary>
        /// Currency.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Barcode Number.
        /// </summary>
        public int BarcodeNumber { get; set; }
    }
}
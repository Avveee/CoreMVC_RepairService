using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Products")]
    public class Product
    {
        [Required]
        [StringLength(6)]
        [Key]
        public string id { get; set; }

        [Required]
        [StringLength(6)]
        [ForeignKey("category_id")]
        public string category_id { get; set; }

        [StringLength(30)]
        [Required]
        public string serial_number { get; set; }

        [Required]
        [Column("price", TypeName = "money")]
        public decimal price { get; set; }

        [Required]
        [Column("year", TypeName = "datetime")]
        public DateTime year { get; set; }

        [Required]
        [StringLength(20)]
        public string brand { get; set; }

        [Required]
        [StringLength(20)]
        public string model { get; set; }
    }
}

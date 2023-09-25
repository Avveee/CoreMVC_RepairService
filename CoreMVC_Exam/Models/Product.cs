using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Products")]
    public class Product
    {
        [Required(ErrorMessage = "Field is required")]
        [StringLength(6)]
        [Key]
        public string id { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(6, ErrorMessage = "Length limit exceeded")]
        [ForeignKey("category_id")]
        public string category_id { get; set; }

        [StringLength(30, ErrorMessage = "Length limit exceeded")]
        [Required(ErrorMessage = "Field is required")]
        public string serial_number { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Column("price", TypeName = "money")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Column("year", TypeName = "datetime")]
        public DateTime year { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Length limit exceeded")]
        public string brand { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Length limit exceeded")]
        public string model { get; set; }
    }
}

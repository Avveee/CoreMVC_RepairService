using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [StringLength(6)]
        [Required]
        public string id { get; set; }

        [ForeignKey("product_id")]
        [Required]
        public string product_id { get; set; }

        [ForeignKey("client_id")]
        [Required]
        public string client_id { get; set;}

        [Column("start_date", TypeName = "datetime")]
        [Required]
        public DateTime start_date { get; set; }

        [Column("end_date", TypeName = "datetime")]
        public DateTime? end_date { get; set; }

        [Column("price", TypeName = "money")]
        public decimal? price { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        [StringLength(6)]
        [Column("passport_id")]
        [Required]
        public string passport_id { get; set; }

        [StringLength(100)]
        [Column("full_name")]
        [Required]
        public string full_name { get; set; }

        [Column("address")]
        [Required]
        public string address { get; set; }

        [Column("phone_number")]
        public string phone_number { get; set; }

        [Column("birthday", TypeName = "datetime")]
        [Required]
        public DateTime birthday { get; set; }

    }
}

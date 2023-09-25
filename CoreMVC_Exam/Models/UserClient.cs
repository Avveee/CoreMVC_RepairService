using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    public class UserClient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [ForeignKey("passport_id")]
        [StringLength(6)]
        [Column("passport_id")]
        [Required]
        public string passport_id { get; set; }

        [ForeignKey("user_id")]
        [StringLength(450)]
        [Column("user_id")]
        [Required]
        public string user_id { get; set; }
    }
}

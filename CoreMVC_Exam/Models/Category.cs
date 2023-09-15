using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [StringLength(6)]
        [Required]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }
    }
}

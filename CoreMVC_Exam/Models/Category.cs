using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [StringLength(6, ErrorMessage = "Length limit exceeded")]
        [Required(ErrorMessage = "Field is required")]
        public string id { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Length limit exceeded")]
        public string name { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC_Exam.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        [StringLength(6, ErrorMessage = "Length limit exceeded")]
        [Column("passport_id")]
        [Required(ErrorMessage = "Field is required")]
        public string passport_id { get; set; }

        [StringLength(100, ErrorMessage = "Length limit exceeded")]
        [Column("full_name")]
        [RegularExpression("^[A-Za-zа-яА-Я]+(?:[-\\s][A-Za-zа-яА-Я]+)*$", ErrorMessage = "Invalid name")]
        [Required(ErrorMessage = "Field is required")]
        public string full_name { get; set; }

        [Column("address")]
        [Required(ErrorMessage = "Field is required")]
        public string address { get; set; }

        [Column("phone_number")]
        [RegularExpression("^\\+?\\d{1,3}(\\(\\d{1,3}\\))?[-\\d]+$", ErrorMessage = "Invalid phone number")]
        [Required(ErrorMessage = "Field is required")]
        public string phone_number { get; set; }

        [Column("birthday", TypeName = "datetime")]
        [Required(ErrorMessage = "Field is required")]
        public DateTime birthday { get; set; }

    }
}

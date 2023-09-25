using CoreMVC_Exam.Data;
using Microsoft.AspNetCore.Identity;

namespace CoreMVC_Exam.ViewModels
{
    public class AdministrationFormViewModel
    {
        public List<IdentityRole> Roles { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}

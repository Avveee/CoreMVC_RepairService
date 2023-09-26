using CoreMVC_Exam.Data;
using CoreMVC_Exam.Models;
using Microsoft.AspNetCore.Identity;

namespace CoreMVC_Exam.ViewModels
{
    public class AdministrationFormViewModel
    {
        public List<IdentityRole> Roles { get; set; }

        public List<ApplicationUser> Users { get; set; }

        public List<Client> Clients { get; set; }

        public List<UserClient> UsersClients { get; set; }
    }
}

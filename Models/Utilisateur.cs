using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EMGBACAR.Models
{
    public class Utilisateur : IdentityUser
    {
        public bool EstAdmin { get; set; }  
    }
}

using System.ComponentModel.DataAnnotations;

namespace OfficeLoginWebApp.Models
{
    public class UserSigninLog
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Email")]
        public string LoggerEmail { get; set; }

        public DateTime LoginTime { get; set; } = DateTime.UtcNow;

        public string IPAddress { get; set; }

        public string IPAddressLocal { get; set; }

        public DateTime? LogoutTime { get; set; }
    }
}

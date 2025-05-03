using System.ComponentModel.DataAnnotations;

namespace CTUClassroomReservation.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; }

        public string CTUID { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

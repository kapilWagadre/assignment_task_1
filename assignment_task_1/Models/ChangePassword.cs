using System.ComponentModel.DataAnnotations;

namespace assignment_task_1.Models
{
    public class ChangePassword
    {
        public string Email { get; set; }
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword", ErrorMessage = "Confirm new password does not match")]
        public string ConfirmPassword { get; set; }
    }
}

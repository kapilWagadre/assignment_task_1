using Microsoft.Build.Framework;

namespace assignment_task_1.Models
{
    public class Forgetpass
    {
        [Required]
        public string email { get; set; }
        public bool emailsent { get; set; }
    }
}

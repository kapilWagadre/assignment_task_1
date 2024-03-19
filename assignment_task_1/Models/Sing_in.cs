using System.ComponentModel.DataAnnotations;

namespace assignment_task_1.Models
{
    public class Sing_in
    {
        [Key]
        public int id { get; set; } 
        public string username { get; set; }
        public string contact { get; set; }
        public string Address { get; set; }

        [EmailAddress]
        [UniqueEmail]
        public string email { get; set; }
        public string password { get; set; }
    }
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dbContext = (DataBaseConnect)validationContext.GetService(typeof(DataBaseConnect));

            var existingUser = dbContext.Singin.FirstOrDefault(u => u.email == (string)value);

            if (existingUser != null)
            {
                return new ValidationResult("The email address is already in use.");
            }

            return ValidationResult.Success;
        }
    }
}

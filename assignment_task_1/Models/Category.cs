using System.ComponentModel.DataAnnotations;

namespace assignment_task_1.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
       
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment_task_1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Detail { get; set; }
        public string Product_Price { get; set; }
        public string Product_warranty { get; set; }
        public byte[] Product_Image { get; set; }

        public int cid { get; set; }
        [ForeignKey("cid")]
        public Category Category { get; set; }
    }
}

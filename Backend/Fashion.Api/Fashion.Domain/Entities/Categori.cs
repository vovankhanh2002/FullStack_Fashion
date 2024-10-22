using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Domain.Entities
{
    public class Categori
    {
        public int CategoryID { get; set; }
        public required string CategoryName { get; set; }
        public string? Description { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public DateTime DateTimeClose {  get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

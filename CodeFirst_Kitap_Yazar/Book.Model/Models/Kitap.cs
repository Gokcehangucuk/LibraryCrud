using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model.Models
{
    public class Kitap
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<YazarKitap> Books { get; } = new List<YazarKitap>();
    }
}

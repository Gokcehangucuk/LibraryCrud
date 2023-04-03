using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model.Models
{
    public class Yazar
    {
        [Key]
        public int WriterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<YazarKitap> Books { get;} = new List<YazarKitap>();
    }
}

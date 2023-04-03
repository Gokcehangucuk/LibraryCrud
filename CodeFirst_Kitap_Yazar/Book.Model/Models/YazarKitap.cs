using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model.Models
{
    public class YazarKitap
    {
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Kitap Book { get; set; }
        public int WriterId { get; set; }
        [ForeignKey("WriterId")]
        public virtual Yazar Writer { get; set; }
    }
}

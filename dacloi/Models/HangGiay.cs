using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksShopOnline.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int HangID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string TenHang { get; set; }
        public virtual ICollection<Giay> Giays { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace dacloi.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int GiayID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string TenGiay { get; set; }
        [Required, StringLength(1000), Display(Name = "Book Description"),
        DataType(DataType.MultilineText)]
        public string MieuTa { get; set; }
        public string HinhAnh { get; set; }
        [Display(Name = "Price")]
        public float? GiaBan { get; set; }
        public int? HangID { get; set; }
        public virtual HangGiay HangGiay { get; set; }
    }
}
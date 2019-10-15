using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace dacloi.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BooksShopOnline")
        { }
        public DbSet<HangGiay> HangGiays { get; set; }
        public DbSet<Giay> Giays { get; set; }        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
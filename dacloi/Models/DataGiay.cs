using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;

namespace dacloi.Models
{
    public class DataGiay : DropCreateDatabaseAlways<GiayContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.HangGiays.Add(c));
            GetGiays().ForEach(p => context.Giays.Add(p));
        }
        private static List<HangGiay> GetCategories()
        {
            var Hangs = new List<HangGiay>
            {
                new HangGiay
                {
                    CategoryID = 1,
                    CategoryName = "Fiction"
                },
                new HangGiay
                {
                    CategoryID = 2,
                    CategoryName = "Biographies and Memoirs"
                },
                new HangGiay
                {
                    CategoryID = 3,
                    CategoryName = "Biological Sciences"
                },
                new HangGiay
                {
                    CategoryID = 4,
                    CategoryName = "Self-Help"
                }
            };
            return Hangs;
        }
        private static List<Giay> GetBooks()
        {
            var Giays = new List<Giay> {
                new Giay
                {
                    GiayID = 1,
                    TenGiay = "Fire & Blood",
                    MieuTa = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",
                    HinhAnh ="Pic1.png",
                    GiaBan = 16.04f,
                    HangID = 1
                    },
                new Giay
                {
                    GiayID = 2,
                    TenGiay = "Benjamin Franklin: An American Life",
                    MieuTa = "In this authoritative and engrossing full-scale biography, Walter Isaacson, " + "bestselling author of Einstein and Steve Jobs, shows how the most fascinating of " + "America's founders helped define our national character.",
                    HinhAnh ="Pic2.png",
                    GiaBan = 19.60f,
                    HangID = 2
                },
                new Giay
                {
                    GiayID = 3,
                    TenGiay = "Obama: An Intimate Portrait",
                    MieuTa = "During Barack Obama's two terms, Pete Souza was with the President " + "during more crucial moments than anyone else--and he photographed them all",
                    HinhAnh ="Pic3.png",
                    GiaBan = 26.73f,
                    HangID = 2
                },
                new Giay
                {
                    GiayID = 4,
                    TenGiay = "Sapiens: A Brief History of Humankind",
                    MieuTa = "One hundred thousand years ago, at least six different species of " + "humans inhabited Earth. Yet today there is only one—homo sapiens. " + "What happened to the others? And what may happen to us?",
                    HinhAnh ="Pic4.png",
                    GiaBan = 23.79f,
                    HangID = 3
                },
                new Book
                {
                    GiayID = 5,
                    TenGiay = "The 7 Habits of Highly Effective People",
                    MieuTa = "Stephen Covey’s cherished classic commemorates the timeless wisdom and " + "power of the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    HinhAnh ="Pic5.png",
                    GiaBan = 16.04f,
                    HangID = 4
                },


            };
            return Giays;
        }
    }
}
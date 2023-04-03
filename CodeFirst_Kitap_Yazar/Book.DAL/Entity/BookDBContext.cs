using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Book.DAL.Entity
{
    public class BookDBContext : DbContext
    {
        public BookDBContext()
        {
            
        }
        public BookDBContext(DbContextOptions<BookDBContext> options): base(options) 
        {
            
        }

        public virtual DbSet<Kitap> Kitaps { get; set; }
        public virtual DbSet<Yazar> Yazars { get; set; }
        public virtual DbSet<YazarKitap> YazarKitaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=YazarKitapDB;Trusted_Connection=True;TrustServerCertificate=True;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YazarKitap>().HasKey(nameof(YazarKitap.BookId), nameof(YazarKitap.WriterId));
            AddDummyData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yazar>().HasData(
                new Yazar() { WriterId = 1 , FirstName = "Stephen" , LastName = "Hawking"},
                new Yazar() { WriterId = 2 , FirstName = "Leonard" , LastName = "Mlodinow" },
                new Yazar() { WriterId = 3 , FirstName = "Margaret" , LastName = "Atwood" },
                new Yazar() { WriterId = 4 , FirstName = "Graeme" , LastName = "Gibson" },
                new Yazar() { WriterId = 5 , FirstName = "Stephen" , LastName = "King" },
                new Yazar() { WriterId = 6 , FirstName = "Peter" , LastName = "Straub" },
                new Yazar() { WriterId = 7 , FirstName = "Sun" , LastName = "Tzu" },
                new Yazar() { WriterId = 8 , FirstName = "Lionel " , LastName = "Giles" }
                );
            modelBuilder.Entity<Kitap>().HasData(
                new Kitap() { BookId = 1 , Name = "Zamanın Kısa Tarihi" , NumberOfPages = 255 ,Price =89 },
                new Kitap() { BookId = 2 , Name = "Sürüngen İle Yılan ", NumberOfPages = 452 ,Price =30 },
                new Kitap() { BookId = 3 , Name = "The Talisman", NumberOfPages = 290 ,Price =73.60m },
                new Kitap() { BookId = 4 , Name = "Savaş Sanatı", NumberOfPages = 350 ,Price =69.99m },
                new Kitap() { BookId = 5 , Name = "Evrenin Kısa Tarihi" , NumberOfPages = 400 ,Price =25 },
                new Kitap() { BookId = 6 , Name = "Zihin Uzayı", NumberOfPages = 420 ,Price =50 }
                );
            modelBuilder.Entity<YazarKitap>().HasData(
                
                new YazarKitap() { WriterId = 1 , BookId = 1},
                new YazarKitap() { WriterId = 1 , BookId = 5},
                new YazarKitap() { WriterId = 1 , BookId = 6},
                new YazarKitap() { WriterId = 2 , BookId = 1},
                new YazarKitap() { WriterId = 3 , BookId = 2},
                new YazarKitap() { WriterId = 4 , BookId = 2},
                new YazarKitap() { WriterId = 5 , BookId = 3},
                new YazarKitap() { WriterId = 6 , BookId = 3},
                new YazarKitap() { WriterId = 7 , BookId = 4},
                new YazarKitap() { WriterId = 8 , BookId = 4}
                
                );
        }
    }
}

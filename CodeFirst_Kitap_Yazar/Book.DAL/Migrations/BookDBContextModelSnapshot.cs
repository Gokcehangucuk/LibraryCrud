﻿// <auto-generated />
using Book.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book.DAL.Migrations
{
    [DbContext(typeof(BookDBContext))]
    partial class BookDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Book.Model.Models.Kitap", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BookId");

                    b.ToTable("Kitaps");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Name = "Zamanın Kısa Tarihi",
                            NumberOfPages = 255,
                            Price = 89m
                        },
                        new
                        {
                            BookId = 2,
                            Name = "Sürüngen İle Yılan ",
                            NumberOfPages = 452,
                            Price = 30m
                        },
                        new
                        {
                            BookId = 3,
                            Name = "The Talisman",
                            NumberOfPages = 290,
                            Price = 73.60m
                        },
                        new
                        {
                            BookId = 4,
                            Name = "Savaş Sanatı",
                            NumberOfPages = 350,
                            Price = 69.99m
                        },
                        new
                        {
                            BookId = 5,
                            Name = "Evrenin Kısa Tarihi",
                            NumberOfPages = 400,
                            Price = 25m
                        },
                        new
                        {
                            BookId = 6,
                            Name = "Zihin Uzayı",
                            NumberOfPages = 420,
                            Price = 50m
                        });
                });

            modelBuilder.Entity("Book.Model.Models.Yazar", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriterId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WriterId");

                    b.ToTable("Yazars");

                    b.HasData(
                        new
                        {
                            WriterId = 1,
                            FirstName = "Stephen",
                            LastName = "Hawking"
                        },
                        new
                        {
                            WriterId = 2,
                            FirstName = "Leonard",
                            LastName = "Mlodinow"
                        },
                        new
                        {
                            WriterId = 3,
                            FirstName = "Margaret",
                            LastName = "Atwood"
                        },
                        new
                        {
                            WriterId = 4,
                            FirstName = "Graeme",
                            LastName = "Gibson"
                        },
                        new
                        {
                            WriterId = 5,
                            FirstName = "Stephen",
                            LastName = "King"
                        },
                        new
                        {
                            WriterId = 6,
                            FirstName = "Peter",
                            LastName = "Straub"
                        },
                        new
                        {
                            WriterId = 7,
                            FirstName = "Sun",
                            LastName = "Tzu"
                        },
                        new
                        {
                            WriterId = 8,
                            FirstName = "Lionel ",
                            LastName = "Giles"
                        });
                });

            modelBuilder.Entity("Book.Model.Models.YazarKitap", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "WriterId");

                    b.HasIndex("WriterId");

                    b.ToTable("YazarKitaps");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            WriterId = 1
                        },
                        new
                        {
                            BookId = 5,
                            WriterId = 1
                        },
                        new
                        {
                            BookId = 6,
                            WriterId = 1
                        },
                        new
                        {
                            BookId = 1,
                            WriterId = 2
                        },
                        new
                        {
                            BookId = 2,
                            WriterId = 3
                        },
                        new
                        {
                            BookId = 2,
                            WriterId = 4
                        },
                        new
                        {
                            BookId = 3,
                            WriterId = 5
                        },
                        new
                        {
                            BookId = 3,
                            WriterId = 6
                        },
                        new
                        {
                            BookId = 4,
                            WriterId = 7
                        },
                        new
                        {
                            BookId = 4,
                            WriterId = 8
                        });
                });

            modelBuilder.Entity("Book.Model.Models.YazarKitap", b =>
                {
                    b.HasOne("Book.Model.Models.Kitap", "Book")
                        .WithMany("Books")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book.Model.Models.Yazar", "Writer")
                        .WithMany("Books")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Book.Model.Models.Kitap", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Book.Model.Models.Yazar", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
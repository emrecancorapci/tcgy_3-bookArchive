using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tcgy_3_bookArchive.Models;

namespace tcgy_3_bookArchive.Data
{
    internal class BookshopDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Language> Languages { get; set; }

        private const string DataSource = "(localdb)\\emre";
        private const string DatabaseName = "bookshopDB";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $@"Data Source={DataSource}; 
                   Database={DatabaseName};
                   Integrated Security=yes;");
            Console.WriteLine(optionsBuilder.IsConfigured);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var book = BookBuilder(modelBuilder);
            var author = AuthorBuilder(modelBuilder);
            var publisher = PublisherBuilder(modelBuilder);
            var language = LanguageBuilder(modelBuilder);
            var format = FormatBuilder(modelBuilder);

            var entities = new List<EntityTypeBuilder>{book, author, publisher, language, format};
            DataEntries(entities);
            RelationsBuilder(modelBuilder);
        }

        private static void RelationsBuilder(ModelBuilder modelBuilder)
        {
            var booksAuthors = modelBuilder.Entity<BooksAuthors>();
            var booksPublishers = modelBuilder.Entity<BooksPublishers>();

            booksAuthors.HasKey("BookID", "AuthorID");
            booksPublishers.HasKey("BookID", "PublisherID");

            booksAuthors.HasData(new BooksAuthors()
            {
                BookID = 1,
                AuthorID = 1,
                Order = 1
            });
            booksPublishers.HasData(new BooksPublishers()
            {
                BookID = 1,
                PublisherID = 1
            });
        }

        private static EntityTypeBuilder BookBuilder(ModelBuilder modelBuilder)
        {
            var book = modelBuilder.Entity<Book>();

            book
                .HasKey(b => b.ID)
                .HasName("PrimaryKey_BookID");


            book
                .Property(b => b.ID)
                .IsRequired()
                .ValueGeneratedOnAdd();

            book
                .Property(b => b.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

            book
                .Property(b => b.Edition)
                .IsUnicode()
                .HasMaxLength(250);

            book
                .Property(b => b.Condition)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

            book
                .Property(b => b.Summary)
                .IsUnicode()
                .HasMaxLength(2000);

            book
                .Property(b => b.Rating);

            book
                .HasMany(b => b.Authors)
                .WithOne(ba => ba.Book)
                .HasForeignKey(ba => ba.BookID)
                .OnDelete(DeleteBehavior.NoAction);

            book
                .HasMany(b => b.Publishers)
                .WithOne(bp => bp.Book)
                .HasForeignKey(bp => bp.BookID)
                .OnDelete(DeleteBehavior.NoAction);

            return book;
        }
        private static EntityTypeBuilder AuthorBuilder(ModelBuilder modelBuilder)
        {
            var author = modelBuilder.Entity<Author>();


            author
                .HasKey(a => a.ID)
                .HasName("PrimaryKey_AuthorID");

            author
                .Property(a => a.ID)
                .ValueGeneratedOnAdd();

            author
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode();

            author
                .Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode();

            author
                .Property(b => b.Info)
                .IsUnicode()
                .HasMaxLength(2000);

            author
                .HasMany(a => a.Books)
                .WithOne(ba => ba.Author)
                .HasForeignKey(bp => bp.AuthorID)
                .OnDelete(DeleteBehavior.NoAction);

            return author;
        }
        private static EntityTypeBuilder PublisherBuilder(ModelBuilder modelBuilder)
        {
            var publisher = modelBuilder.Entity<Publisher>();

            publisher
                .HasKey(p => p.ID)
                .HasName("PrimaryKey_PublisherID");

            publisher
                .Property(p => p.ID)
                .ValueGeneratedOnAdd();

            publisher
                .Property(p => p.Name)
                .IsUnicode()
                .HasMaxLength(200);

            publisher
                .Property(p => p.Info)
                .IsUnicode()
                .HasMaxLength(2000);

            publisher
                .HasMany(p => p.Books)
                .WithOne(bp => bp.Publisher)
                .HasForeignKey(bp => bp.PublisherID)
                .OnDelete(DeleteBehavior.NoAction);

            return publisher;
        }
        private static EntityTypeBuilder LanguageBuilder(ModelBuilder modelBuilder)
        {
            var language = modelBuilder.Entity<Language>();

            language
                .HasKey(l => l.ID)
                .HasName("PrimaryKey_LanguageID");

            language
                .Property(l => l.ID)
                .ValueGeneratedOnAdd();

            language
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            language
                .Property(l => l.ShortName)
                .IsRequired()
                .HasMaxLength(5);

            language
                .HasMany(l => l.Books)
                .WithOne(b => b.Language)
                .HasForeignKey(b => b.LanguageID);


            return language;
        }
        private static EntityTypeBuilder FormatBuilder(ModelBuilder modelBuilder)
        {
            var format = modelBuilder.Entity<Format>();

            format
                .HasKey(f => f.ID)
                .HasName("PrimaryKey_FormatID");

            format
                .Property(f => f.ID)
                .ValueGeneratedOnAdd();

            format
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(200);

            format
                .HasMany(f => f.Books)
                .WithOne(b => b.Format)
                .HasForeignKey(b => b.FormatID);

            return format;
        }

        private static void DataEntries(IReadOnlyList<EntityTypeBuilder> entities)
        {
            var alfredAdler = new Author
            {
                ID = 1,
                Name = "Alfred",
                LastName = "Adler",
                BirthDate = new DateTime(1870, 02, 07),
                Info = "Alfred Adler was an Austrian medical doctor, " +
                       "psychotherapist, and founder of the school " +
                       "of individual psychology."
            };

            var understandingHumanNature = new Book
            {
                ID = 1,
                Name = "Understanding Human Nature",
                Condition = "Brand new",
                Edition = "42nd Edition",
                ISBN = 9781578989843,
                PublishDate = new DateTime(2010, 07, 04),
                Pages = 302
            };

            var martinoFineBooks = new Publisher
            {
                ID = 1,
                Name = "Martino Fine Books",
                Info = "MARTINO FINE BOOKS. P.O. Box 913," +
                       "Eastford, CT 06242, USA." +
                       "email: martinofinebooks@hotmail.com." +
                       "Tel: (860) 974-2277."
            };

            var englishUS = new Language
            {
                ID = 1,
                Name = "English",
                ShortName = "en_US"
            };

            entities[0].HasData(understandingHumanNature);
            entities[1].HasData(alfredAdler);
            entities[2].HasData(martinoFineBooks);
            entities[3].HasData(englishUS);
            
        }
    }
}

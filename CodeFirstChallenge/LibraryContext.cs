namespace CodeFirstChallenge
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Borrower> Borrowers { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<BookCopy> BookCopies { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.BookTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookPublisher)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.BorrowerName)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.BorrowerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.BorrowerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorName)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.BookPublisher)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.PublisherAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.PublisherPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.CardNo)
                .IsUnicode(false);
        }
    }
}

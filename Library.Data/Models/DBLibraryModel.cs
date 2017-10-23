using System.Data.Entity;

namespace Library.Data.Models
{
    public partial class DBLibraryModel : DbContext
    {
        public DBLibraryModel()
            : base("name=DBLibraryEntity")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AUTHOR> AUTHOR { get; set; }
        public virtual DbSet<BOOK> BOOK { get; set; }
        public virtual DbSet<BORROW> BORROW { get; set; }
        public virtual DbSet<BORROWER> BORROWER { get; set; }
        public virtual DbSet<CATEGORY> CATEGORY { get; set; }
        public virtual DbSet<CLASSIFICATION> CLASSIFICATION { get; set; }
        public virtual DbSet<COPY> COPY { get; set; }
        public virtual DbSet<STATUS> STATUS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AUTHOR>()
                .HasMany(e => e.BOOK)
                .WithMany(e => e.AUTHOR)
                .Map(m => m.ToTable("BOOK_AUTHOR").MapLeftKey("Aid").MapRightKey("ISBN"));

            modelBuilder.Entity<BORROWER>()
                .HasMany(e => e.BORROW)
                .WithRequired(e => e.BORROWER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATEGORY>()
                .HasMany(e => e.BORROWER)
                .WithOptional(e => e.CATEGORY)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<COPY>()
                .HasMany(e => e.BORROW)
                .WithRequired(e => e.COPY)
                .WillCascadeOnDelete(false);
        }
    }
}

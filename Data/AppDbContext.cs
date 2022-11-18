using GoogleKeepClone_DotNetAPI.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoogleKeepClone_DotNetAPI.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<Note>()
            //        .Property(n => n.Tags)
            //        .IsRequired(false);

            //    modelBuilder.Entity<Tag>()
            //       .Property(t => t.Notes)
            //       .IsRequired(false);

            modelBuilder.Entity<NoteTag>()
                .HasKey(nt => new { nt.NoteId, nt.TagId });

            modelBuilder.Entity<NoteTag>()
                .HasOne(nt => nt.Note) 
                .WithMany(t => t.NoteTags)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(nt => nt.NoteId);

            modelBuilder.Entity<NoteTag>()
                .HasOne(nt => nt.Tag)
                .WithMany(n => n.NoteTags)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(nt => nt.TagId);

            base.OnModelCreating(modelBuilder);
        }

    public DbSet<Note> Notes { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<NoteTag> NoteTags { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using BlogApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasData(
            new Category(1, "Oyun"),
            new Category(2, "Sinema"),
            new Category(3, "Spor")
            );

        builder.HasMany(c => c.Contents);
    }
}

public class RepositoryContext : DbContext
{
    public DbSet<Content> Contents { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Content>().HasKey(e => e.Id);
        modelBuilder.Entity<Content>().HasData(
            new Content { Id = 1, Title = "İlk Paylaşım", Text = "merhaba bu ilk gönderinin metnidir.", CategoryId = 1 },
            new Content { Id = 2, Title = "İkinci Paylaşım", Text = "merhaba bu ikinci gönderinin metnidir.", CategoryId = 2 },
            new Content { Id = 3, Title = "Üçüncü Paylaşım", Text = "merhaba bu üçüncü gönderinin metnidir.", CategoryId = 3 },
            new Content(4, "Deneme Başlık", "adfnkdajfj kkjdanf kjdaaakj kjda jnqje  nkjndskjf kjsdkjnqw nkqnwkas") { CategoryId = 2 });
    }
}
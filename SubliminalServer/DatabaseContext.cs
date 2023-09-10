using Microsoft.EntityFrameworkCore;
using SubliminalServer.DataModel.Account;
using SubliminalServer.DataModel.Configurations;
using SubliminalServer.DataModel.Purgatory;

namespace SubliminalServer;

public class DatabaseContext : DbContext
{
    public DbSet<AccountData> Accounts { get; set; }
    public DbSet<AccountBadge> AccountBadges { get; set; }
    public DbSet<AccountIp> AccountIps { get; set; }

    public DbSet<PurgatoryDraft> PurgatoryDrafts { get; set; }
    public DbSet<PurgatoryEntry> PurgatoryEntries { get; set; }
    public DbSet<PurgatoryTag> PurgatoryTags { get; set; }
    public DbSet<PurgatoryAnnotation> PurgatoryAnnotations { get; set; }
    
    private string DatabasePath { get; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DatabaseContext(string dbPath)
    {
        DatabasePath = dbPath;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountDataConfiguration());
        modelBuilder.ApplyConfiguration(new PurgatoryEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurgatoryTagConfiguration());
        modelBuilder.ApplyConfiguration(new PurgatoryDraftConfiguration());
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DatabasePath}");
    }
}

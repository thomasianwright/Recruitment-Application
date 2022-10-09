using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Recruitment.Api.Core.Entities;

namespace Recruitment.Api.EntityFramework.MSSQL.Data;

public class ApiContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<JobPost?> JobPosts { get; set; }
    public DbSet<Tag?> Tags { get; set; }
    public DbSet<Agent> Agents { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserApplication> UserApplications { get; set; }

    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        base.OnModelCreating(mb);
        var jsonOptions = new JsonSerializerOptions();
        mb.Entity<Company>()
            .HasMany<JobPost>()
            .WithOne(x => x.Company);

        // mb.Entity<JobPost>()
        //     .HasMany<Tag>()
        //     .WithMany(x => x.JobPosts);

        mb.Entity<JobPost>()
            .HasOne(x => x.Company)
            .WithOne()
            .HasForeignKey<JobPost>(x => x.CompanyId);

        mb.Entity<Agent>()
            .HasMany(x => x.AccountManagerOf)
            .WithOne(x => x.AccountManager)
            .HasForeignKey(x => x.AccountManagerId);

        mb.Entity<Agent>()
            .HasMany(x => x.AgentOf)
            .WithMany(x => x.Agents);

        mb.Entity<UserApplication>()
            .HasOne(x => x.User)
            .WithOne()
            .HasForeignKey<UserApplication>(x => x.UserId);

        mb.Entity<Agent>()
            .HasOne(x => x.User)
            .WithOne()
            .HasForeignKey<Agent>(x => x.UserId);

        mb.Entity<JobPost>()
            .Property(x => x.Files)
            .HasConversion(o => JsonSerializer.Serialize(o, jsonOptions),
                c => JsonSerializer.Deserialize<List<Guid>>(c, jsonOptions) ?? new List<Guid>());
    }
}
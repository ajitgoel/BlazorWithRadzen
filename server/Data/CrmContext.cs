using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using RadzenCrm3.Models.Crm;

namespace RadzenCrm3.Data
{
  public partial class CrmContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public CrmContext(DbContextOptions<CrmContext> options):base(options)
    {
    }

    public CrmContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<RadzenCrm3.Models.Crm.Opportunity>()
              .HasOne(i => i.Contact)
              .WithMany(i => i.Opportunities)
              .HasForeignKey(i => i.ContactId)
              .HasPrincipalKey(i => i.Id);
        builder.Entity<RadzenCrm3.Models.Crm.Opportunity>()
              .HasOne(i => i.OpportunityStatus)
              .WithMany(i => i.Opportunities)
              .HasForeignKey(i => i.StatusId)
              .HasPrincipalKey(i => i.Id);
        builder.Entity<RadzenCrm3.Models.Crm.Task>()
              .HasOne(i => i.Opportunity)
              .WithMany(i => i.Tasks)
              .HasForeignKey(i => i.OpportunityId)
              .HasPrincipalKey(i => i.Id);
        builder.Entity<RadzenCrm3.Models.Crm.Task>()
              .HasOne(i => i.TaskType)
              .WithMany(i => i.Tasks)
              .HasForeignKey(i => i.TypeId)
              .HasPrincipalKey(i => i.Id);
        builder.Entity<RadzenCrm3.Models.Crm.Task>()
              .HasOne(i => i.TaskStatus)
              .WithMany(i => i.Tasks)
              .HasForeignKey(i => i.StatusId)
              .HasPrincipalKey(i => i.Id);


        builder.Entity<RadzenCrm3.Models.Crm.Opportunity>()
              .Property(p => p.CloseDate)
              .HasColumnType("datetime");

        builder.Entity<RadzenCrm3.Models.Crm.Task>()
              .Property(p => p.DueDate)
              .HasColumnType("datetime");

        this.OnModelBuilding(builder);
    }


    public DbSet<RadzenCrm3.Models.Crm.Contact> Contacts
    {
      get;
      set;
    }

    public DbSet<RadzenCrm3.Models.Crm.Opportunity> Opportunities
    {
      get;
      set;
    }

    public DbSet<RadzenCrm3.Models.Crm.OpportunityStatus> OpportunityStatuses
    {
      get;
      set;
    }

    public DbSet<RadzenCrm3.Models.Crm.Task> Tasks
    {
      get;
      set;
    }

    public DbSet<RadzenCrm3.Models.Crm.TaskStatus> TaskStatuses
    {
      get;
      set;
    }

    public DbSet<RadzenCrm3.Models.Crm.TaskType> TaskTypes
    {
      get;
      set;
    }
  }
}

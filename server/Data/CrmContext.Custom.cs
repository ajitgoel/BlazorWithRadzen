using Microsoft.EntityFrameworkCore;

using RadzenCrm3.Models;

namespace RadzenCrm3.Data
{
  public partial class CrmContext
  {
    partial void OnModelBuilding(ModelBuilder builder)
    {
      builder.Entity<ApplicationUser>().ToTable("AspNetUsers");
    }
  }
}

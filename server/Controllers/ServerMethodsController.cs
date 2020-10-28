using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RadzenCrm3.Data;

namespace RadzenCrm3.Controllers
{
  [Route("api/[controller]/[action]")]
  public class ServerMethodsController : Controller
  {
    private readonly CrmContext crmContext;

    public ServerMethodsController(CrmContext crmContext)
    {
      this.crmContext = crmContext;
    }
    public IActionResult MonthlyStats()
    {
      double wonOpportunities = crmContext.Opportunities
                           .Include(opportunity => opportunity.OpportunityStatus)
                           .Where(opportunity => opportunity.OpportunityStatus.Name == "Won")
                           .Count();
      var totalOpportunities = crmContext.Opportunities.Count();
      var ratio = wonOpportunities / totalOpportunities;
      var stats = crmContext.Opportunities
                           .Include(opportunity => opportunity.OpportunityStatus)
                           .Where(opportunity => opportunity.OpportunityStatus.Name == "Won")
                           .ToList()
                           .GroupBy(opportunity => new DateTime(opportunity.CloseDate.Year, opportunity.CloseDate.Month, 1))
                           .Select(group => new
                           {
                             Month = group.Key,
                             Revenue = group.Sum(opportunity => opportunity.Amount),
                             Opportunities = group.Count(),
                             AverageDealSize = group.Average(opportunity => opportunity.Amount),
                             Ratio = ratio
                           })
                           .OrderBy(deals => deals.Month)
                           .Last();
      return Ok(System.Text.Json.JsonSerializer.Serialize(stats, new JsonSerializerOptions { PropertyNamingPolicy = null }));
    }
  }
}

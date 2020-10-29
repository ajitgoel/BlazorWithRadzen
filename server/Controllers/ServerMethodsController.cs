using System;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RadzenCrm3.Data;

namespace RadzenCrm3
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
    public IActionResult RevenueByCompany()
    {
      var result = crmContext.Opportunities
                           .Include(opportunity => opportunity.Contact)
                           .GroupBy(opportunity => opportunity.Contact.Company)
                           .Select(group => new {
                             Company = group.Key,
                             Revenue = group.Sum(opportunity => opportunity.Amount)
                           });
      return Ok(System.Text.Json.JsonSerializer.Serialize(result, new JsonSerializerOptions
      {
        PropertyNamingPolicy = null
      }));
    }
    public IActionResult RevenueByEmployee()
    {
      var result = crmContext.Opportunities
                           .Include(opportunity => opportunity.User).AsEnumerable()
                           .GroupBy(opportunity => $"{opportunity.User.FirstName} {opportunity.User.LastName}")
                           .Select(group => new {
                             Employee = group.Key,
                             Revenue = group.Sum(opportunity => opportunity.Amount)
                           });
      return Ok(System.Text.Json.JsonSerializer.Serialize(result, new JsonSerializerOptions
      {
        PropertyNamingPolicy = null
      }));
    }
    public IActionResult RevenueByMonth()
    {
      var result = crmContext.Opportunities
                           .Include(opportunity => opportunity.OpportunityStatus)
                           .Where(opportunity => opportunity.OpportunityStatus.Name == "Won").AsEnumerable()
                           .GroupBy(opportunity => new DateTime(opportunity.CloseDate.Year, opportunity.CloseDate.Month, 1))
                           .Select(group => new {
                             Revenue = group.Sum(opportunity => opportunity.Amount),
                             Month = group.Key
                           })
                           .OrderBy(deals => deals.Month);
      return Ok(System.Text.Json.JsonSerializer.Serialize(result, new JsonSerializerOptions
      {
        PropertyNamingPolicy = null
      }));
    }
  }
}

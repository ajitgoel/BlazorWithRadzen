using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Data;
using Microsoft.AspNetCore.Identity;
using RadzenCrm3.Models;
using Microsoft.AspNetCore.Http;

namespace RadzenCrm3.Controllers.Crm
{
  [Authorize]
  public partial class OpportunitiesController
  {
    partial void OnOpportunitiesRead(ref IQueryable<Models.Crm.Opportunity> items)
    {
      var userManager = (UserManager<ApplicationUser>)HttpContext.RequestServices.GetService(typeof(UserManager<ApplicationUser>));
      var user = userManager.GetUserAsync(HttpContext.User).Result;
      if (user != null)
      {
        var roles = userManager.GetRolesAsync(user).Result;

        if (roles.Contains("Sales Manager"))
        {
          // Filter the opportunities by the current user's id
          items = items.Where(item => item.UserId == user.Id);
        }
      }
    }

    partial void OnOpportunityCreated(Models.Crm.Opportunity item)
    {
      var userManager = (UserManager<ApplicationUser>)HttpContext.RequestServices.GetService(typeof(UserManager<ApplicationUser>));
      var userId = userManager.GetUserId(HttpContext.User);
      // Set the UserId property of the opportunity to the current user's id
      item.UserId = userId;
    }
  }
}

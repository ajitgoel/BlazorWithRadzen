using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace RadzenCrm3.Controllers.Crm
{
  using Models;
  using Data;
  using Models.Crm;

  [ODataRoutePrefix("odata/CRM/OpportunityStatuses")]
  [Route("mvc/odata/CRM/OpportunityStatuses")]
  public partial class OpportunityStatusesController : ODataController
  {
    private Data.CrmContext context;

    public OpportunityStatusesController(Data.CrmContext context)
    {
      this.context = context;
    }
    // GET /odata/Crm/OpportunityStatuses
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Crm.OpportunityStatus> GetOpportunityStatuses()
    {
      var items = this.context.OpportunityStatuses.AsQueryable<Models.Crm.OpportunityStatus>();
      this.OnOpportunityStatusesRead(ref items);

      return items;
    }

    partial void OnOpportunityStatusesRead(ref IQueryable<Models.Crm.OpportunityStatus> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<OpportunityStatus> GetOpportunityStatus(int key)
    {
        var items = this.context.OpportunityStatuses.Where(i=>i.Id == key);
        return SingleResult.Create(items);
    }
    partial void OnOpportunityStatusDeleted(Models.Crm.OpportunityStatus item);
    partial void OnAfterOpportunityStatusDeleted(Models.Crm.OpportunityStatus item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteOpportunityStatus(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.OpportunityStatuses
                .Where(i => i.Id == key)
                .Include(i => i.Opportunities)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnOpportunityStatusDeleted(item);
            this.context.OpportunityStatuses.Remove(item);
            this.context.SaveChanges();
            this.OnAfterOpportunityStatusDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnOpportunityStatusUpdated(Models.Crm.OpportunityStatus item);
    partial void OnAfterOpportunityStatusUpdated(Models.Crm.OpportunityStatus item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutOpportunityStatus(int key, [FromBody]Models.Crm.OpportunityStatus newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.Id != key))
            {
                return BadRequest();
            }

            this.OnOpportunityStatusUpdated(newItem);
            this.context.OpportunityStatuses.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.OpportunityStatuses.Where(i => i.Id == key);
            this.OnAfterOpportunityStatusUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchOpportunityStatus(int key, [FromBody]Delta<Models.Crm.OpportunityStatus> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.OpportunityStatuses.Where(i => i.Id == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnOpportunityStatusUpdated(item);
            this.context.OpportunityStatuses.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.OpportunityStatuses.Where(i => i.Id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnOpportunityStatusCreated(Models.Crm.OpportunityStatus item);
    partial void OnAfterOpportunityStatusCreated(Models.Crm.OpportunityStatus item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Crm.OpportunityStatus item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnOpportunityStatusCreated(item);
            this.context.OpportunityStatuses.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Crm/OpportunityStatuses/{item.Id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}

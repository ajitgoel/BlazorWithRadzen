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

  [ODataRoutePrefix("odata/CRM/Contacts")]
  [Route("mvc/odata/CRM/Contacts")]
  public partial class ContactsController : ODataController
  {
    private Data.CrmContext context;

    public ContactsController(Data.CrmContext context)
    {
      this.context = context;
    }
    // GET /odata/Crm/Contacts
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Crm.Contact> GetContacts()
    {
      var items = this.context.Contacts.AsQueryable<Models.Crm.Contact>();
      this.OnContactsRead(ref items);

      return items;
    }

    partial void OnContactsRead(ref IQueryable<Models.Crm.Contact> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<Contact> GetContact(int key)
    {
        var items = this.context.Contacts.Where(i=>i.Id == key);
        return SingleResult.Create(items);
    }
    partial void OnContactDeleted(Models.Crm.Contact item);
    partial void OnAfterContactDeleted(Models.Crm.Contact item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteContact(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Contacts
                .Where(i => i.Id == key)
                .Include(i => i.Opportunities)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnContactDeleted(item);
            this.context.Contacts.Remove(item);
            this.context.SaveChanges();
            this.OnAfterContactDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnContactUpdated(Models.Crm.Contact item);
    partial void OnAfterContactUpdated(Models.Crm.Contact item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutContact(int key, [FromBody]Models.Crm.Contact newItem)
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

            this.OnContactUpdated(newItem);
            this.context.Contacts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Contacts.Where(i => i.Id == key);
            this.OnAfterContactUpdated(newItem);
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
    public IActionResult PatchContact(int key, [FromBody]Delta<Models.Crm.Contact> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Contacts.Where(i => i.Id == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnContactUpdated(item);
            this.context.Contacts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Contacts.Where(i => i.Id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnContactCreated(Models.Crm.Contact item);
    partial void OnAfterContactCreated(Models.Crm.Contact item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Crm.Contact item)
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

            this.OnContactCreated(item);
            this.context.Contacts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Crm/Contacts/{item.Id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}

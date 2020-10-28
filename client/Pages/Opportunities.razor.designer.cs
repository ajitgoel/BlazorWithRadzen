using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using RadzenCrm3.Models.Crm;
using Microsoft.AspNetCore.Identity;
using RadzenCrm3.Models;
using RadzenCrm3.Client.Pages;

namespace RadzenCrm3.Pages
{
    public partial class OpportunitiesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }


        [Inject]
        protected CrmService Crm { get; set; }
        protected RadzenGrid<RadzenCrm3.Models.Crm.Opportunity> grid0;

        IEnumerable<RadzenCrm3.Models.Crm.Opportunity> _getOpportunitiesResult;
        protected IEnumerable<RadzenCrm3.Models.Crm.Opportunity> getOpportunitiesResult
        {
            get
            {
                return _getOpportunitiesResult;
            }
            set
            {
                if (!object.Equals(_getOpportunitiesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOpportunitiesResult", NewValue = value, OldValue = _getOpportunitiesResult };
                    _getOpportunitiesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getOpportunitiesCount;
        protected int getOpportunitiesCount
        {
            get
            {
                return _getOpportunitiesCount;
            }
            set
            {
                if (!object.Equals(_getOpportunitiesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOpportunitiesCount", NewValue = value, OldValue = _getOpportunitiesCount };
                    _getOpportunitiesCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            if (!await Security.IsAuthenticatedAsync())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }

        }
        protected async System.Threading.Tasks.Task Load()
        {

        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddOpportunity>("Add Opportunity", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var crmGetOpportunitiesResult = await Crm.GetOpportunities(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", expand:$"Contact,OpportunityStatus,User", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getOpportunitiesResult = crmGetOpportunitiesResult.Value.AsODataEnumerable();

                getOpportunitiesCount = crmGetOpportunitiesResult.Count;
            }
            catch (System.Exception crmGetOpportunitiesException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load Opportunities");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenCrm3.Models.Crm.Opportunity args)
        {
            var dialogResult = await DialogService.OpenAsync<EditOpportunity>("Edit Opportunity", new Dictionary<string, object>() { {"Id", args.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var crmDeleteOpportunityResult = await Crm.DeleteOpportunity(id:data.Id);
                    if (crmDeleteOpportunityResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception crmDeleteOpportunityException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Opportunity");
            }
        }
    }
}

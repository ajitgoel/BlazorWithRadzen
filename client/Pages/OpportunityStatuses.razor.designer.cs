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
    public partial class OpportunityStatusesComponent : ComponentBase
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
        protected RadzenGrid<RadzenCrm3.Models.Crm.OpportunityStatus> grid0;

        IEnumerable<RadzenCrm3.Models.Crm.OpportunityStatus> _getOpportunityStatusesResult;
        protected IEnumerable<RadzenCrm3.Models.Crm.OpportunityStatus> getOpportunityStatusesResult
        {
            get
            {
                return _getOpportunityStatusesResult;
            }
            set
            {
                if (!object.Equals(_getOpportunityStatusesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOpportunityStatusesResult", NewValue = value, OldValue = _getOpportunityStatusesResult };
                    _getOpportunityStatusesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getOpportunityStatusesCount;
        protected int getOpportunityStatusesCount
        {
            get
            {
                return _getOpportunityStatusesCount;
            }
            set
            {
                if (!object.Equals(_getOpportunityStatusesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOpportunityStatusesCount", NewValue = value, OldValue = _getOpportunityStatusesCount };
                    _getOpportunityStatusesCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddOpportunityStatus>("Add Opportunity Status", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var crmGetOpportunityStatusesResult = await Crm.GetOpportunityStatuses(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getOpportunityStatusesResult = crmGetOpportunityStatusesResult.Value.AsODataEnumerable();

                getOpportunityStatusesCount = crmGetOpportunityStatusesResult.Count;
            }
            catch (System.Exception crmGetOpportunityStatusesException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load OpportunityStatuses");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenCrm3.Models.Crm.OpportunityStatus args)
        {
            var dialogResult = await DialogService.OpenAsync<EditOpportunityStatus>("Edit Opportunity Status", new Dictionary<string, object>() { {"Id", args.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var crmDeleteOpportunityStatusResult = await Crm.DeleteOpportunityStatus(id:data.Id);
                    if (crmDeleteOpportunityStatusResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception crmDeleteOpportunityStatusException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete OpportunityStatus");
            }
        }
    }
}

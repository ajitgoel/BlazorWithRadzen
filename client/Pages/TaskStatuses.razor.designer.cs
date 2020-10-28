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
    public partial class TaskStatusesComponent : ComponentBase
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
        protected RadzenGrid<RadzenCrm3.Models.Crm.TaskStatus> grid0;

        IEnumerable<RadzenCrm3.Models.Crm.TaskStatus> _getTaskStatusesResult;
        protected IEnumerable<RadzenCrm3.Models.Crm.TaskStatus> getTaskStatusesResult
        {
            get
            {
                return _getTaskStatusesResult;
            }
            set
            {
                if (!object.Equals(_getTaskStatusesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTaskStatusesResult", NewValue = value, OldValue = _getTaskStatusesResult };
                    _getTaskStatusesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getTaskStatusesCount;
        protected int getTaskStatusesCount
        {
            get
            {
                return _getTaskStatusesCount;
            }
            set
            {
                if (!object.Equals(_getTaskStatusesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTaskStatusesCount", NewValue = value, OldValue = _getTaskStatusesCount };
                    _getTaskStatusesCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddTaskStatus>("Add Task Status", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var crmGetTaskStatusesResult = await Crm.GetTaskStatuses(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getTaskStatusesResult = crmGetTaskStatusesResult.Value.AsODataEnumerable();

                getTaskStatusesCount = crmGetTaskStatusesResult.Count;
            }
            catch (System.Exception crmGetTaskStatusesException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load TaskStatuses");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenCrm3.Models.Crm.TaskStatus args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTaskStatus>("Edit Task Status", new Dictionary<string, object>() { {"Id", args.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var crmDeleteTaskStatusResult = await Crm.DeleteTaskStatus(id:data.Id);
                    if (crmDeleteTaskStatusResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception crmDeleteTaskStatusException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TaskStatus");
            }
        }
    }
}

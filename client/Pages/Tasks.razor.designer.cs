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
    public partial class TasksComponent : ComponentBase
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
        protected RadzenGrid<RadzenCrm3.Models.Crm.Task> grid0;

        IEnumerable<RadzenCrm3.Models.Crm.Task> _getTasksResult;
        protected IEnumerable<RadzenCrm3.Models.Crm.Task> getTasksResult
        {
            get
            {
                return _getTasksResult;
            }
            set
            {
                if (!object.Equals(_getTasksResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTasksResult", NewValue = value, OldValue = _getTasksResult };
                    _getTasksResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getTasksCount;
        protected int getTasksCount
        {
            get
            {
                return _getTasksCount;
            }
            set
            {
                if (!object.Equals(_getTasksCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTasksCount", NewValue = value, OldValue = _getTasksCount };
                    _getTasksCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddTask>("Add Task", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var crmGetTasksResult = await Crm.GetTasks(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", expand:$"Opportunity,TaskType,TaskStatus", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getTasksResult = crmGetTasksResult.Value.AsODataEnumerable();

                getTasksCount = crmGetTasksResult.Count;
            }
            catch (System.Exception crmGetTasksException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load Tasks");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenCrm3.Models.Crm.Task args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTask>("Edit Task", new Dictionary<string, object>() { {"Id", args.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var crmDeleteTaskResult = await Crm.DeleteTask(id:data.Id);
                    if (crmDeleteTaskResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception crmDeleteTaskException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Task");
            }
        }
    }
}

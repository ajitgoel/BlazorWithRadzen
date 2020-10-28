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
    public partial class TaskTypesComponent : ComponentBase
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
        protected RadzenGrid<RadzenCrm3.Models.Crm.TaskType> grid0;

        IEnumerable<RadzenCrm3.Models.Crm.TaskType> _getTaskTypesResult;
        protected IEnumerable<RadzenCrm3.Models.Crm.TaskType> getTaskTypesResult
        {
            get
            {
                return _getTaskTypesResult;
            }
            set
            {
                if (!object.Equals(_getTaskTypesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTaskTypesResult", NewValue = value, OldValue = _getTaskTypesResult };
                    _getTaskTypesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getTaskTypesCount;
        protected int getTaskTypesCount
        {
            get
            {
                return _getTaskTypesCount;
            }
            set
            {
                if (!object.Equals(_getTaskTypesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getTaskTypesCount", NewValue = value, OldValue = _getTaskTypesCount };
                    _getTaskTypesCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddTaskType>("Add Task Type", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var crmGetTaskTypesResult = await Crm.GetTaskTypes(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getTaskTypesResult = crmGetTaskTypesResult.Value.AsODataEnumerable();

                getTaskTypesCount = crmGetTaskTypesResult.Count;
            }
            catch (System.Exception crmGetTaskTypesException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load TaskTypes");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenCrm3.Models.Crm.TaskType args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTaskType>("Edit Task Type", new Dictionary<string, object>() { {"Id", args.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var crmDeleteTaskTypeResult = await Crm.DeleteTaskType(id:data.Id);
                    if (crmDeleteTaskTypeResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception crmDeleteTaskTypeException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TaskType");
            }
        }
    }
}

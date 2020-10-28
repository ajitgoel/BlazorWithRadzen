﻿using System;
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
    public partial class AddTaskStatusComponent : ComponentBase
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

        RadzenCrm3.Models.Crm.TaskStatus _taskstatus;
        protected RadzenCrm3.Models.Crm.TaskStatus taskstatus
        {
            get
            {
                return _taskstatus;
            }
            set
            {
                if (!object.Equals(_taskstatus, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "taskstatus", NewValue = value, OldValue = _taskstatus };
                    _taskstatus = value;
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
            taskstatus = new RadzenCrm3.Models.Crm.TaskStatus(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(RadzenCrm3.Models.Crm.TaskStatus args)
        {
            try
            {
                var crmCreateTaskStatusResult = await Crm.CreateTaskStatus(taskStatus:taskstatus);
                DialogService.Close(taskstatus);
            }
            catch (System.Exception crmCreateTaskStatusException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TaskStatus!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
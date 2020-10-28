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
    public partial class EditContactComponent : ComponentBase
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

        [Parameter]
        public dynamic Id { get; set; }

        RadzenCrm3.Models.Crm.Contact _contact;
        protected RadzenCrm3.Models.Crm.Contact contact
        {
            get
            {
                return _contact;
            }
            set
            {
                if (!object.Equals(_contact, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "contact", NewValue = value, OldValue = _contact };
                    _contact = value;
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
            var crmGetContactByIdResult = await Crm.GetContactById(id:Id);
            contact = crmGetContactByIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(RadzenCrm3.Models.Crm.Contact args)
        {
            try
            {
                var crmUpdateContactResult = await Crm.UpdateContact(id:Id, contact:contact);
                DialogService.Close(contact);
            }
            catch (System.Exception crmUpdateContactException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Contact");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}

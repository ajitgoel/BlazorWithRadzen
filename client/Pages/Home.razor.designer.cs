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
    public partial class HomeComponent : ComponentBase
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

        RadzenCrm3.Pages.Stats _monthlyStats;
        protected RadzenCrm3.Pages.Stats monthlyStats
        {
            get
            {
                return _monthlyStats;
            }
            set
            {
                if (!object.Equals(_monthlyStats, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "monthlyStats", NewValue = value, OldValue = _monthlyStats };
                    _monthlyStats = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        dynamic _revenueByCompany;
        protected dynamic revenueByCompany
        {
            get
            {
                return _revenueByCompany;
            }
            set
            {
                if (!object.Equals(_revenueByCompany, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "revenueByCompany", NewValue = value, OldValue = _revenueByCompany };
                    _revenueByCompany = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<RadzenCrm3.Pages.RevenueByEmployee> _revenueByEmployee;
        protected IEnumerable<RadzenCrm3.Pages.RevenueByEmployee> revenueByEmployee
        {
            get
            {
                return _revenueByEmployee;
            }
            set
            {
                if (!object.Equals(_revenueByEmployee, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "revenueByEmployee", NewValue = value, OldValue = _revenueByEmployee };
                    _revenueByEmployee = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<RadzenCrm3.Pages.RevenueByMonth> _revenueByMonth;
        protected IEnumerable<RadzenCrm3.Pages.RevenueByMonth> revenueByMonth
        {
            get
            {
                return _revenueByMonth;
            }
            set
            {
                if (!object.Equals(_revenueByMonth, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "revenueByMonth", NewValue = value, OldValue = _revenueByMonth };
                    _revenueByMonth = value;
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
            var monthlyStatsResult = await MonthlyStats();
            monthlyStats = monthlyStatsResult;

            var revenueByCompanyResult = await RevenueByCompany();
            revenueByCompany = revenueByCompanyResult;

            var revenueByEmployeeResult = await RevenueByEmployee();
            revenueByEmployee = revenueByEmployeeResult;

            var revenueByMonthResult = await RevenueByMonth();
            revenueByMonth = revenueByMonthResult;
        }
    }
}

#pragma checksum "c:\temp\RadzenCRM3\client\Pages\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a01f8c9bb5033c653f4ebcca2f01e444006246bf"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenCrm3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\temp\RadzenCRM3\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\temp\RadzenCRM3\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\temp\RadzenCRM3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\temp\RadzenCRM3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\temp\RadzenCRM3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\_Imports.razor"
using RadzenCrm3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\_Imports.razor"
using RadzenCrm3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
using RadzenCrm3.Models.Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
using RadzenCrm3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tasks")]
    public partial class Tasks : RadzenCrm3.Pages.TasksComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Tasks");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<RadzenCrm3.Models.Crm.Task>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                      getTasksCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenCrm3.Models.Crm.Task>>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                                            getTasksResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                                                                        FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                                                                                                                                           Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenCrm3.Models.Crm.Task>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenCrm3.Models.Crm.Task>(this, 
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                                                                                                                                                                      Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(31);
                    __builder3.AddAttribute(32, "Property", "Id");
                    __builder3.AddAttribute(33, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(35);
                    __builder3.AddAttribute(36, "Property", "Title");
                    __builder3.AddAttribute(37, "Title", "Title");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(39);
                    __builder3.AddAttribute(40, "FilterProperty", "Opportunity.Name");
                    __builder3.AddAttribute(41, "Property", "OpportunityId");
                    __builder3.AddAttribute(42, "SortProperty", "Opportunity.Name");
                    __builder3.AddAttribute(43, "Title", "Opportunity");
                    __builder3.AddAttribute(44, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Task>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(45, "\n              ");
                        __builder4.AddContent(46, 
#nullable restore
#line 30 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                data.Opportunity?.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(47, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(49);
                    __builder3.AddAttribute(50, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(51, "Property", "DueDate");
                    __builder3.AddAttribute(52, "Title", "Due Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(54);
                    __builder3.AddAttribute(55, "FilterProperty", "TaskType.Name");
                    __builder3.AddAttribute(56, "Property", "TypeId");
                    __builder3.AddAttribute(57, "SortProperty", "TaskType.Name");
                    __builder3.AddAttribute(58, "Title", "Task Type");
                    __builder3.AddAttribute(59, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Task>)((radzenCrm3ModelsCrmTask) => (__builder4) => {
                        __builder4.AddMarkupContent(60, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenIcon>(61);
                        __builder4.AddAttribute(62, "Icon", "settings_phone");
                        __builder4.AddAttribute(63, "style", "vertical-align: middle");
                        __builder4.AddAttribute(64, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                            radzenCrm3ModelsCrmTask.TaskType.Name == "Call"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenIcon>(66);
                        __builder4.AddAttribute(67, "Icon", "video_call");
                        __builder4.AddAttribute(68, "style", "vertical-align: middle");
                        __builder4.AddAttribute(69, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                        radzenCrm3ModelsCrmTask.TaskType.Name == "Online Meeting"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenIcon>(71);
                        __builder4.AddAttribute(72, "Icon", "email");
                        __builder4.AddAttribute(73, "style", "vertical-align: middle");
                        __builder4.AddAttribute(74, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                   radzenCrm3ModelsCrmTask.TaskType.Name == "Email"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(75, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(76);
                        __builder4.AddAttribute(77, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                     $"{(radzenCrm3ModelsCrmTask.TaskType.Name)}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(80);
                    __builder3.AddAttribute(81, "FilterProperty", "TaskStatus.Name");
                    __builder3.AddAttribute(82, "Property", "StatusId");
                    __builder3.AddAttribute(83, "SortProperty", "TaskStatus.Name");
                    __builder3.AddAttribute(84, "Title", "Task Status");
                    __builder3.AddAttribute(85, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Task>)((radzenCrm3ModelsCrmTask) => (__builder4) => {
                        __builder4.AddMarkupContent(86, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenIcon>(87);
                        __builder4.AddAttribute(88, "Icon", "check_circle");
                        __builder4.AddAttribute(89, "style", "vertical-align: middle");
                        __builder4.AddAttribute(90, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                          radzenCrm3ModelsCrmTask.TaskStatus.Name == "Complete"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(91, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenIcon>(92);
                        __builder4.AddAttribute(93, "Icon", "cancel");
                        __builder4.AddAttribute(94, "style", "vertical-align: middle");
                        __builder4.AddAttribute(95, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                    radzenCrm3ModelsCrmTask.TaskStatus.Name == "Not Started"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(96, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenIcon>(97);
                        __builder4.AddAttribute(98, "Icon", "autorenew");
                        __builder4.AddAttribute(99, "style", "vertical-align: middle");
                        __builder4.AddAttribute(100, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                       radzenCrm3ModelsCrmTask.TaskStatus.Name == "In Progress"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(101, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(102);
                        __builder4.AddAttribute(103, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                     $"{(radzenCrm3ModelsCrmTask.TaskStatus.Name)}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Task>>(106);
                    __builder3.AddAttribute(107, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                             false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 59 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                                TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "Width", "70px");
                    __builder3.AddAttribute(111, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Task>)((radzenCrm3ModelsCrmTask) => (__builder4) => {
                        __builder4.AddMarkupContent(112, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(113);
                        __builder4.AddAttribute(114, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 61 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(115, "Icon", "close");
                        __builder4.AddAttribute(116, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 61 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(117, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, radzenCrm3ModelsCrmTask)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(118, "onclick", 
#nullable restore
#line 61 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                                                                                                                                                                                                       true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(119, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(121, (__value) => {
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Tasks.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<RadzenCrm3.Models.Crm.Task>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
#pragma checksum "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be62357fedde2e3a9f6e8355b22707a67aaa5e5a"
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
#line 5 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
using RadzenCrm3.Models.Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
using RadzenCrm3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/opportunities")]
    public partial class Opportunities : RadzenCrm3.Pages.OpportunitiesComponent
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
                __builder2.AddAttribute(6, "Text", "Opportunities");
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
#line 20 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<RadzenCrm3.Models.Crm.Opportunity>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                      getOpportunitiesCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenCrm3.Models.Crm.Opportunity>>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                                                    getOpportunitiesResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                                                                                        FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                                                                                                                                                                  Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenCrm3.Models.Crm.Opportunity>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenCrm3.Models.Crm.Opportunity>(this, 
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                                                                                                                                                                                             Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(31);
                    __builder3.AddAttribute(32, "Property", "Id");
                    __builder3.AddAttribute(33, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(35);
                    __builder3.AddAttribute(36, "Property", "Amount");
                    __builder3.AddAttribute(37, "Title", "Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(39);
                    __builder3.AddAttribute(40, "Property", "Name");
                    __builder3.AddAttribute(41, "Title", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(43);
                    __builder3.AddAttribute(44, "FilterProperty", "User.FirstName");
                    __builder3.AddAttribute(45, "Property", "UserId");
                    __builder3.AddAttribute(46, "SortProperty", "User.FirstName");
                    __builder3.AddAttribute(47, "Title", "User");
                    __builder3.AddAttribute(48, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Opportunity>)((radzenCrm3ModelsCrmOpportunity) => (__builder4) => {
                        __builder4.AddMarkupContent(49, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(50);
                        __builder4.AddAttribute(51, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                     $"{(radzenCrm3ModelsCrmOpportunity.User.FirstName)}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(52, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                        __builder4.AddAttribute(54, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                     $"{(radzenCrm3ModelsCrmOpportunity.User.LastName)}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(55, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(57);
                    __builder3.AddAttribute(58, "FilterProperty", "Contact.Email");
                    __builder3.AddAttribute(59, "Property", "ContactId");
                    __builder3.AddAttribute(60, "SortProperty", "Contact.Email");
                    __builder3.AddAttribute(61, "Title", "Contact");
                    __builder3.AddAttribute(62, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Opportunity>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(63, "\n              ");
                        __builder4.AddContent(64, 
#nullable restore
#line 40 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                data.Contact?.Email

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(65, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(67);
                    __builder3.AddAttribute(68, "FilterProperty", "OpportunityStatus.Name");
                    __builder3.AddAttribute(69, "Property", "StatusId");
                    __builder3.AddAttribute(70, "SortProperty", "OpportunityStatus.Name");
                    __builder3.AddAttribute(71, "Title", "Opportunity Status");
                    __builder3.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Opportunity>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(73, "\n              ");
                        __builder4.AddContent(74, 
#nullable restore
#line 45 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                data.OpportunityStatus?.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(75, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(77);
                    __builder3.AddAttribute(78, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(79, "Property", "CloseDate");
                    __builder3.AddAttribute(80, "Title", "Close Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenCrm3.Models.Crm.Opportunity>>(82);
                    __builder3.AddAttribute(83, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 50 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "Width", "70px");
                    __builder3.AddAttribute(87, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm3.Models.Crm.Opportunity>)((radzenCrm3ModelsCrmOpportunity) => (__builder4) => {
                        __builder4.AddMarkupContent(88, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(89);
                        __builder4.AddAttribute(90, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 52 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "Icon", "close");
                        __builder4.AddAttribute(92, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 52 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, radzenCrm3ModelsCrmOpportunity)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(94, "onclick", 
#nullable restore
#line 52 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                                                                                                                                                                                                              true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(97, (__value) => {
#nullable restore
#line 22 "c:\temp\RadzenCRM3\client\Pages\Opportunities.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<RadzenCrm3.Models.Crm.Opportunity>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

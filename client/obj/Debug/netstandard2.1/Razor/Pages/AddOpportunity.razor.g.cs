#pragma checksum "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756300218e5a2333a4ceaad15bc95fa5cbecbc5f"
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
#line 5 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
using RadzenCrm3.Models.Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
using RadzenCrm3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-opportunity")]
    public partial class AddOpportunity : RadzenCrm3.Pages.AddOpportunityComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<RadzenCrm3.Models.Crm.Opportunity>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RadzenCrm3.Models.Crm.Opportunity>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                   opportunity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                     opportunity != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenCrm3.Models.Crm.Opportunity>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenCrm3.Models.Crm.Opportunity>(this, 
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                                                    Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Component", "Amount");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Amount");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.AddOpportunity.TypeInference.CreateRadzenNumeric_0(__builder3, 32, 33, "display: block; width: 100%", 34, "Amount", 35, 
#nullable restore
#line 26 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                  opportunity.Amount

#line default
#line hidden
#nullable disable
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => opportunity.Amount = __value, opportunity.Amount)), 37, () => opportunity.Amount);
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "Amount");
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "Text", "Amount is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-md-3");
                    __builder3.AddMarkupContent(52, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                    __builder3.AddAttribute(54, "Component", "Name");
                    __builder3.AddAttribute(55, "style", "width: 100%");
                    __builder3.AddAttribute(56, "Text", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                    __builder3.AddAttribute(63, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 38 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                          256

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(65, "Name", "Name");
                    __builder3.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                  opportunity.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => opportunity.Name = __value, opportunity.Name))));
                    __builder3.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => opportunity.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(70);
                    __builder3.AddAttribute(71, "Component", "Name");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.AddAttribute(73, "Text", "Name is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(79, "class", "row");
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-md-3");
                    __builder3.AddMarkupContent(83, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(84);
                    __builder3.AddAttribute(85, "Component", "ContactId");
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.AddAttribute(87, "Text", "Contact");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "col-md-9");
                    __builder3.AddMarkupContent(92, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.AddOpportunity.TypeInference.CreateRadzenDropDown_1(__builder3, 93, 94, 
#nullable restore
#line 50 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                       getContactsResult

#line default
#line hidden
#nullable disable
                    , 95, "Choose Contact", 96, "display: block; width: 100%", 97, "Email", 98, "Id", 99, "ContactId", 100, 
#nullable restore
#line 50 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                                                                               opportunity.ContactId

#line default
#line hidden
#nullable disable
                    , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => opportunity.ContactId = __value, opportunity.ContactId)), 102, () => opportunity.ContactId);
                    __builder3.AddMarkupContent(103, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(104);
                    __builder3.AddAttribute(105, "Component", "ContactId");
                    __builder3.AddAttribute(106, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                             0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(107, "style", "position: absolute");
                    __builder3.AddAttribute(108, "Text", "ContactId is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(114, "class", "row");
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "col-md-3");
                    __builder3.AddMarkupContent(118, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(119);
                    __builder3.AddAttribute(120, "Component", "StatusId");
                    __builder3.AddAttribute(121, "style", "width: 100%");
                    __builder3.AddAttribute(122, "Text", "Opportunity Status");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\n              ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "class", "col-md-9");
                    __builder3.AddMarkupContent(127, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.AddOpportunity.TypeInference.CreateRadzenDropDown_2(__builder3, 128, 129, 
#nullable restore
#line 62 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                       getOpportunityStatusesResult

#line default
#line hidden
#nullable disable
                    , 130, "Choose OpportunityStatus", 131, "display: block; width: 100%", 132, "Name", 133, "Id", 134, "StatusId", 135, 
#nullable restore
#line 62 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                                                                                                   opportunity.StatusId

#line default
#line hidden
#nullable disable
                    , 136, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => opportunity.StatusId = __value, opportunity.StatusId)), 137, () => opportunity.StatusId);
                    __builder3.AddMarkupContent(138, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(139);
                    __builder3.AddAttribute(140, "Component", "StatusId");
                    __builder3.AddAttribute(141, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 64 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                            0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(142, "style", "position: absolute");
                    __builder3.AddAttribute(143, "Text", "StatusId is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\n            ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(149, "class", "row");
                    __builder3.AddMarkupContent(150, "\n              ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "class", "col-md-3");
                    __builder3.AddMarkupContent(153, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(154);
                    __builder3.AddAttribute(155, "Component", "CloseDate");
                    __builder3.AddAttribute(156, "style", "width: 100%");
                    __builder3.AddAttribute(157, "Text", "Close Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(158, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(159, "\n              ");
                    __builder3.OpenElement(160, "div");
                    __builder3.AddAttribute(161, "class", "col-md-9");
                    __builder3.AddMarkupContent(162, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.AddOpportunity.TypeInference.CreateRadzenDatePicker_3(__builder3, 163, 164, "MM/dd/yyyy", 165, "display: block; width: 100%", 166, "CloseDate", 167, 
#nullable restore
#line 74 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                             opportunity.CloseDate

#line default
#line hidden
#nullable disable
                    , 168, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => opportunity.CloseDate = __value, opportunity.CloseDate)), 169, () => opportunity.CloseDate);
                    __builder3.AddMarkupContent(170, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(171);
                    __builder3.AddAttribute(172, "Component", "CloseDate");
                    __builder3.AddAttribute(173, "style", "position: absolute");
                    __builder3.AddAttribute(174, "Text", "CloseDate is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(175, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(176, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(177, "\n            ");
                    __builder3.OpenElement(178, "div");
                    __builder3.AddAttribute(179, "class", "row");
                    __builder3.AddMarkupContent(180, "\n              ");
                    __builder3.OpenElement(181, "div");
                    __builder3.AddAttribute(182, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(183, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(184);
                    __builder3.AddAttribute(185, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 82 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(186, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 82 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(187, "Icon", "save");
                    __builder3.AddAttribute(188, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(190);
                    __builder3.AddAttribute(191, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 84 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(192, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(193, "Text", "Cancel");
                    __builder3.AddAttribute(194, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "c:\temp\RadzenCRM3\client\Pages\AddOpportunity.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(195, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(196, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(197, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(198, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(200, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RadzenCrm3.Client.Pages.AddOpportunity
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
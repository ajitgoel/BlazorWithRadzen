#pragma checksum "c:\temp\RadzenCRM3\client\Pages\EditTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d5076ad7fde00baf29a0a22586e34a6ca47e6c8"
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
#line 5 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
using RadzenCrm3.Models.Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
using RadzenCrm3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-task/{Id}")]
    public partial class EditTask : RadzenCrm3.Pages.EditTaskComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<RadzenCrm3.Models.Crm.Task>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RadzenCrm3.Models.Crm.Task>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                      task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                       task != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenCrm3.Models.Crm.Task>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenCrm3.Models.Crm.Task>(this, 
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
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
                    __builder3.AddAttribute(24, "Text", "Title");
                    __builder3.AddAttribute(25, "Component", "Title");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 26 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                          256

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "style", "width: 100%");
                    __builder3.AddAttribute(35, "Name", "Title");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                  task.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.Title = __value, task.Title))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => task.Title));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(44, "class", "row");
                    __builder3.AddMarkupContent(45, "\n              ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-3");
                    __builder3.AddMarkupContent(48, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                    __builder3.AddAttribute(50, "Text", "Opportunity");
                    __builder3.AddAttribute(51, "Component", "OpportunityId");
                    __builder3.AddAttribute(52, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-9");
                    __builder3.AddMarkupContent(57, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.EditTask.TypeInference.CreateRadzenDropDown_0(__builder3, 58, 59, 
#nullable restore
#line 36 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                       getOpportunitiesResult

#line default
#line hidden
#nullable disable
                    , 60, "Name", 61, "Id", 62, "Choose Opportunity", 63, "display: block; width: 100%", 64, "OpportunityId", 65, 
#nullable restore
#line 36 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                                                                                                          task.OpportunityId

#line default
#line hidden
#nullable disable
                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.OpportunityId = __value, task.OpportunityId)), 67, () => task.OpportunityId);
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "OpportunityId");
                    __builder3.AddAttribute(71, "Text", "OpportunityId is required");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.AddAttribute(73, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 38 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                                                             0

#line default
#line hidden
#nullable disable
                    ));
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
                    __builder3.AddAttribute(85, "Text", "Due Date");
                    __builder3.AddAttribute(86, "Component", "DueDate");
                    __builder3.AddAttribute(87, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "col-md-9");
                    __builder3.AddMarkupContent(92, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.EditTask.TypeInference.CreateRadzenDatePicker_1(__builder3, 93, 94, "MM/dd/yyyy", 95, "display: block; width: 100%", 96, "DueDate", 97, 
#nullable restore
#line 48 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                             task.DueDate

#line default
#line hidden
#nullable disable
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.DueDate = __value, task.DueDate)), 99, () => task.DueDate);
                    __builder3.AddMarkupContent(100, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(101);
                    __builder3.AddAttribute(102, "Component", "DueDate");
                    __builder3.AddAttribute(103, "Text", "DueDate is required");
                    __builder3.AddAttribute(104, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(110, "class", "row");
                    __builder3.AddMarkupContent(111, "\n              ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "col-md-3");
                    __builder3.AddMarkupContent(114, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(115);
                    __builder3.AddAttribute(116, "Text", "Task Type");
                    __builder3.AddAttribute(117, "Component", "TypeId");
                    __builder3.AddAttribute(118, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "col-md-9");
                    __builder3.AddMarkupContent(123, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.EditTask.TypeInference.CreateRadzenDropDown_2(__builder3, 124, 125, 
#nullable restore
#line 60 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                       getTaskTypesResult

#line default
#line hidden
#nullable disable
                    , 126, "Name", 127, "Id", 128, "Choose TaskType", 129, "display: block; width: 100%", 130, "TypeId", 131, 
#nullable restore
#line 60 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                                                                                                   task.TypeId

#line default
#line hidden
#nullable disable
                    , 132, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.TypeId = __value, task.TypeId)), 133, () => task.TypeId);
                    __builder3.AddMarkupContent(134, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(135);
                    __builder3.AddAttribute(136, "Component", "TypeId");
                    __builder3.AddAttribute(137, "Text", "TypeId is required");
                    __builder3.AddAttribute(138, "style", "position: absolute");
                    __builder3.AddAttribute(139, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 62 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                                               0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(140, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\n            ");
                    __builder3.OpenElement(143, "div");
                    __builder3.AddAttribute(144, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(145, "class", "row");
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "col-md-3");
                    __builder3.AddMarkupContent(149, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(150);
                    __builder3.AddAttribute(151, "Text", "Task Status");
                    __builder3.AddAttribute(152, "Component", "StatusId");
                    __builder3.AddAttribute(153, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(154, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(155, "\n              ");
                    __builder3.OpenElement(156, "div");
                    __builder3.AddAttribute(157, "class", "col-md-9");
                    __builder3.AddMarkupContent(158, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.EditTask.TypeInference.CreateRadzenDropDown_3(__builder3, 159, 160, 
#nullable restore
#line 72 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                       getTaskStatusesResult

#line default
#line hidden
#nullable disable
                    , 161, "Name", 162, "Id", 163, "Choose TaskStatus", 164, "width: 100%", 165, "StatusId", 166, 
#nullable restore
#line 72 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                                                                                        task.StatusId

#line default
#line hidden
#nullable disable
                    , 167, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.StatusId = __value, task.StatusId)), 168, () => task.StatusId);
                    __builder3.AddMarkupContent(169, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(170, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(171, "\n            ");
                    __builder3.OpenElement(172, "div");
                    __builder3.AddAttribute(173, "class", "row");
                    __builder3.AddMarkupContent(174, "\n              ");
                    __builder3.OpenElement(175, "div");
                    __builder3.AddAttribute(176, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(177, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(178);
                    __builder3.AddAttribute(179, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 78 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(180, "Icon", "save");
                    __builder3.AddAttribute(181, "Text", "Save");
                    __builder3.AddAttribute(182, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 78 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(183, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(184);
                    __builder3.AddAttribute(185, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 80 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(186, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(187, "Text", "Cancel");
                    __builder3.AddAttribute(188, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "c:\temp\RadzenCRM3\client\Pages\EditTask.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(189, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(190, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(191, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(192, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(193, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RadzenCrm3.Client.Pages.EditTask
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

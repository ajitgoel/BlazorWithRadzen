#pragma checksum "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2264a565ef2190f992909afa05b28d670f3ba804"
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
#line 5 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
using RadzenCrm3.Models.Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
using RadzenCrm3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-application-user/{Id}")]
    public partial class EditApplicationUser : RadzenCrm3.Pages.EditApplicationUserComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                           user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                            user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
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
                    __builder3.AddAttribute(24, "Component", "UserName");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "User Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "style", "width: 100%");
                    __builder3.AddAttribute(35, "Name", "UserName");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                                  user.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.UserName = __value, user.UserName))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.UserName));
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
                    __builder3.AddAttribute(50, "Component", "Email");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.AddAttribute(52, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-9");
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(58);
                    __builder3.AddAttribute(59, "style", "width: 100%");
                    __builder3.AddAttribute(60, "Name", "Email");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                  user.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                    __builder3.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(69, "class", "row");
                    __builder3.AddMarkupContent(70, "\n              ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "col-md-3");
                    __builder3.AddMarkupContent(73, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(74);
                    __builder3.AddAttribute(75, "Component", "RoleNames");
                    __builder3.AddAttribute(76, "style", "width: 100%");
                    __builder3.AddAttribute(77, "Text", "Roles");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-md-9");
                    __builder3.AddMarkupContent(82, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.EditApplicationUser.TypeInference.CreateRadzenDropDown_0(__builder3, 83, 84, 
#nullable restore
#line 46 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                       roles

#line default
#line hidden
#nullable disable
                    , 85, 
#nullable restore
#line 46 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    , 86, "width: 100%", 87, "Name", 88, "Name", 89, "RoleNames", 90, 
#nullable restore
#line 46 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                                                                     user.RoleNames

#line default
#line hidden
#nullable disable
                    , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.RoleNames = __value, user.RoleNames)), 92, () => user.RoleNames);
                    __builder3.AddMarkupContent(93, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(98, "class", "row");
                    __builder3.AddMarkupContent(99, "\n              ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "col-md-3");
                    __builder3.AddMarkupContent(102, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(103);
                    __builder3.AddAttribute(104, "Component", "Password");
                    __builder3.AddAttribute(105, "style", "width: 100%");
                    __builder3.AddAttribute(106, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n              ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-md-9");
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(112);
                    __builder3.AddAttribute(113, "style", "width: 100%");
                    __builder3.AddAttribute(114, "Name", "Password");
                    __builder3.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                   user.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n            ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(123, "class", "row");
                    __builder3.AddMarkupContent(124, "\n              ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "class", "col-md-3");
                    __builder3.AddMarkupContent(127, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(128);
                    __builder3.AddAttribute(129, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(130, "style", "width: 100%");
                    __builder3.AddAttribute(131, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n              ");
                    __builder3.OpenElement(134, "div");
                    __builder3.AddAttribute(135, "class", "col-md-9");
                    __builder3.AddMarkupContent(136, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(137);
                    __builder3.AddAttribute(138, "style", "width: 100%");
                    __builder3.AddAttribute(139, "Name", "ConfirmPassword");
                    __builder3.AddAttribute(140, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                   user.ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                    __builder3.AddAttribute(142, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\n            ");
                    __builder3.OpenElement(146, "div");
                    __builder3.AddAttribute(147, "class", "row");
                    __builder3.AddMarkupContent(148, "\n              ");
                    __builder3.OpenElement(149, "div");
                    __builder3.AddAttribute(150, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(151, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(152);
                    __builder3.AddAttribute(153, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 72 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(154, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 72 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(155, "Icon", "save");
                    __builder3.AddAttribute(156, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(158);
                    __builder3.AddAttribute(159, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 74 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(160, "Text", "Cancel");
                    __builder3.AddAttribute(161, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "c:\temp\RadzenCRM3\client\Pages\EditApplicationUser.razor"
                                                                                    Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(162, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(163, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(164, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(165, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RadzenCrm3.Client.Pages.EditApplicationUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Multiple", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

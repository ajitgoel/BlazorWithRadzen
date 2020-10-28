#pragma checksum "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bffbfbe48e3aecbc812d2e969aae3f336e8ff70"
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
#line 5 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
using RadzenCrm3.Models.Crm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
using RadzenCrm3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
           [Authorize(Roles="Sales Manager")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-application-user")]
    public partial class AddApplicationUser : RadzenCrm3.Pages.AddApplicationUserComponent
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
#line 18 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                   user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                            user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#nullable restore
#line 18 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
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
                    __builder3.AddAttribute(24, "Component", "Email");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(34, "Name", "Email");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                  user.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "Email");
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "Text", "Email is required");
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
                    __builder3.AddAttribute(54, "Component", "FirstName");
                    __builder3.AddAttribute(55, "style", "width: 100%");
                    __builder3.AddAttribute(56, "Text", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                    __builder3.AddAttribute(63, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(64, "Name", "FirstName");
                    __builder3.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                  user.FirstName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.FirstName = __value, user.FirstName))));
                    __builder3.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.FirstName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "FirstName");
                    __builder3.AddAttribute(71, "style", "position: absolute");
                    __builder3.AddAttribute(72, "Text", "First Name is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(78, "class", "row");
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-md-3");
                    __builder3.AddMarkupContent(82, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(83);
                    __builder3.AddAttribute(84, "Component", "LastName");
                    __builder3.AddAttribute(85, "style", "width: 100%");
                    __builder3.AddAttribute(86, "Text", "Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-9");
                    __builder3.AddMarkupContent(91, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(92);
                    __builder3.AddAttribute(93, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(94, "Name", "LastName");
                    __builder3.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                  user.LastName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.LastName = __value, user.LastName))));
                    __builder3.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.LastName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(99);
                    __builder3.AddAttribute(100, "Component", "LastName");
                    __builder3.AddAttribute(101, "style", "position: absolute");
                    __builder3.AddAttribute(102, "Text", "Last Name is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.AddMarkupContent(109, "\n              ");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "col-md-3");
                    __builder3.AddMarkupContent(112, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(113);
                    __builder3.AddAttribute(114, "Component", "Picture");
                    __builder3.AddAttribute(115, "style", "width: 100%");
                    __builder3.AddAttribute(116, "Text", "Picture");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-md-9");
                    __builder3.AddMarkupContent(121, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.AddApplicationUser.TypeInference.CreateRadzenFileInput_0(__builder3, 122, 123, "Picture", 124, 
#nullable restore
#line 62 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                user.Picture

#line default
#line hidden
#nullable disable
                    , 125, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Picture = __value, user.Picture)), 126, () => user.Picture);
                    __builder3.AddMarkupContent(127, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(128);
                    __builder3.AddAttribute(129, "Component", "Picture");
                    __builder3.AddAttribute(130, "style", "position: absolute");
                    __builder3.AddAttribute(131, "Text", "Picture is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n            ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(137, "class", "row");
                    __builder3.AddMarkupContent(138, "\n              ");
                    __builder3.OpenElement(139, "div");
                    __builder3.AddAttribute(140, "class", "col-md-3");
                    __builder3.AddMarkupContent(141, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(142);
                    __builder3.AddAttribute(143, "Component", "RoleNames");
                    __builder3.AddAttribute(144, "style", "width: 100%");
                    __builder3.AddAttribute(145, "Text", "Roles");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n              ");
                    __builder3.OpenElement(148, "div");
                    __builder3.AddAttribute(149, "class", "col-md-9");
                    __builder3.AddMarkupContent(150, "\n                ");
                    __Blazor.RadzenCrm3.Client.Pages.AddApplicationUser.TypeInference.CreateRadzenDropDown_1(__builder3, 151, 152, 
#nullable restore
#line 74 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                       roles

#line default
#line hidden
#nullable disable
                    , 153, 
#nullable restore
#line 74 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    , 154, "width: 100%", 155, "Name", 156, "Name", 157, "RoleNames", 158, 
#nullable restore
#line 74 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                                                     user.RoleNames

#line default
#line hidden
#nullable disable
                    , 159, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.RoleNames = __value, user.RoleNames)), 160, () => user.RoleNames);
                    __builder3.AddMarkupContent(161, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(162, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(163, "\n            ");
                    __builder3.OpenElement(164, "div");
                    __builder3.AddAttribute(165, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(166, "class", "row");
                    __builder3.AddMarkupContent(167, "\n              ");
                    __builder3.OpenElement(168, "div");
                    __builder3.AddAttribute(169, "class", "col-md-3");
                    __builder3.AddMarkupContent(170, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(171);
                    __builder3.AddAttribute(172, "Component", "Password");
                    __builder3.AddAttribute(173, "style", "width: 100%");
                    __builder3.AddAttribute(174, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(175, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(176, "\n              ");
                    __builder3.OpenElement(177, "div");
                    __builder3.AddAttribute(178, "class", "col-md-9");
                    __builder3.AddMarkupContent(179, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(180);
                    __builder3.AddAttribute(181, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(182, "Name", "Password");
                    __builder3.AddAttribute(183, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 84 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                   user.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(184, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(185, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(186, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(187);
                    __builder3.AddAttribute(188, "Component", "Password");
                    __builder3.AddAttribute(189, "style", "position: absolute");
                    __builder3.AddAttribute(190, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(191, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(192, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(193, "\n            ");
                    __builder3.OpenElement(194, "div");
                    __builder3.AddAttribute(195, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(196, "class", "row");
                    __builder3.AddMarkupContent(197, "\n              ");
                    __builder3.OpenElement(198, "div");
                    __builder3.AddAttribute(199, "class", "col-md-3");
                    __builder3.AddMarkupContent(200, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(201);
                    __builder3.AddAttribute(202, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(203, "style", "width: 100%");
                    __builder3.AddAttribute(204, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(205, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(206, "\n              ");
                    __builder3.OpenElement(207, "div");
                    __builder3.AddAttribute(208, "class", "col-md-9");
                    __builder3.AddMarkupContent(209, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(210);
                    __builder3.AddAttribute(211, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(212, "Name", "ConfirmPassword");
                    __builder3.AddAttribute(213, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                   user.ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(214, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                    __builder3.AddAttribute(215, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(216, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(217);
                    __builder3.AddAttribute(218, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(219, "style", "position: absolute");
                    __builder3.AddAttribute(220, "Text", "ConfirmPassword is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(221, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(222, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(223, "\n            ");
                    __builder3.OpenElement(224, "div");
                    __builder3.AddAttribute(225, "class", "row");
                    __builder3.AddMarkupContent(226, "\n              ");
                    __builder3.OpenElement(227, "div");
                    __builder3.AddAttribute(228, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(229, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(230);
                    __builder3.AddAttribute(231, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 104 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(232, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 104 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(233, "Icon", "save");
                    __builder3.AddAttribute(234, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(235, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(236);
                    __builder3.AddAttribute(237, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 106 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(238, "Text", "Cancel");
                    __builder3.AddAttribute(239, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "c:\temp\RadzenCRM3\client\Pages\AddApplicationUser.razor"
                                                                                    Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(240, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(241, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(242, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(243, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(244, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(245, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RadzenCrm3.Client.Pages.AddApplicationUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenFileInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenFileInput<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
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

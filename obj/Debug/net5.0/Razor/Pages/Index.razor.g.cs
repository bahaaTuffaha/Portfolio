#pragma checksum "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50537d032e4813415b2e70386003a68c4993f05e"
// <auto-generated/>
#pragma warning disable 1591
namespace app_port.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using app_port;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using app_port.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
using BlazorTypewriter;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"_content/BlazorTypewriter/styles.css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, @"<section class=""module parallax parallax-1""><div class=""container""><p class=""l1"">About Me</p>
        <div class=""l2"">
            Whenever I start working on a project, I always tend to be passionate, dedicated and diligent.
            Looking to use my coding and programming skills as efficiently as possible. I consistently look
            for an opportunity to hone my skills.
        </div></div></section>

");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "module parallax parallax-2");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", "l1");
            __builder.OpenComponent<BlazorTypewriter.Typewriter>(8);
            __builder.AddAttribute(9, "Builder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTypewriter.TypewriterBuilder>(
#nullable restore
#line 21 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                            typewriter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "commmands");
            __builder.AddMarkupContent(13, "<p style=\"font-family:FiraMono; color: green\">BAHAA@my-os:<span style=\"color:blue\">~</span><span style=\"color:white\">$<per> cd MyProjects</per></span></p>\r\n            ");
            __builder.AddMarkupContent(14, "<p style=\"font-family:FiraMono; color: green\">BAHAA@my-os:<span style=\"color:blue\">~</span><span style=\"color:white\">$<per> ls</per></span></p>\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "OS");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                             args => Info1(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<p>&quot;Floppy-Cloud&quot;</p>");
            __builder.CloseElement();
            __builder.AddContent(20, " ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                args => Info1(3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<p>&quot;Blazor WebAssembly&quot;</p>");
            __builder.CloseElement();
            __builder.AddContent(24, " ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                                                                                         args => Info1(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<p>&quot;DATABASE&quot;</p>");
            __builder.CloseElement();
            __builder.AddContent(28, "    ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                                                                                                                                                           args => Info1(4)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<p>&quot;Cryptography-project&quot;</p>");
            __builder.CloseElement();
            __builder.AddContent(32, "  ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                                                                                                                                                                                                                                       args => Info1(5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<p>&quot;Machine learning project&quot;</p>");
            __builder.CloseElement();
            __builder.AddContent(36, " ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                                                                                                                                                                                                                                                                                                                      args => Info1(6)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "<p>&quot;Management System&quot;</p>");
            __builder.CloseElement();
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                             args => Info1(7)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<p>&quot;Selenium&quot;</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n            ");
            __builder.OpenElement(44, "p");
            __builder.AddAttribute(45, "style", "font-family:FiraMono; color: green");
            __builder.AddContent(46, "BAHAA@my-os:");
            __builder.AddMarkupContent(47, "<span style=\"color:blue\">~</span>");
            __builder.AddMarkupContent(48, "<span style=\"color:white\">$</span>");
            __builder.OpenComponent<BlazorTypewriter.Typewriter>(49);
            __builder.AddAttribute(50, "Builder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTypewriter.TypewriterBuilder>(
#nullable restore
#line 33 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                                                                               typewriter2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
          RenderFragment footer = 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenComponent<AntDesign.Template>(51);
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(53);
                    __builder3.AddAttribute(54, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                            HandleCancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(56, "Return");
                    }
                    ));
                    __builder3.SetKey(
#nullable restore
#line 37 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                   "back" 

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
#nullable restore
#line 38 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                       ;

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Modal>(57);
            __builder.AddAttribute(58, "Style", "color:snow");
            __builder.AddAttribute(59, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                 title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                               _visible1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                           (e)=>{_visible1 = false;}

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(62, "Draggable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                               (e)=>{_visible1 = false;}

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(64, "Footer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>?>(
#nullable restore
#line 44 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                              footer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "CloseIcon", new Microsoft.AspNetCore.Components.RenderFragment(
#nullable restore
#line 45 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                closeimg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 46 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
         if (title == "Floppy-Cloud")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(67, "<div style=\"float:left\"><img class=\"card-image\" src=\"/images/floppy.png\"></div>\r\n            ");
                __builder2.AddMarkupContent(68, "<p class=\"cards-content\">\r\n                Graduation project :\r\n                A backup with file prioritization for cloud backup with limited upload connections.\r\n            </p>");
                __builder2.AddMarkupContent(69, "<p>\r\n                Used: Python,Apache CouchDB.\r\n            </p>");
#nullable restore
#line 57 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
        }
        else if (title == "Database project")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(70, "<div style=\"float:left\"><img class=\"card-image\" src=\"/images/lib.png\"></div>\r\n            ");
                __builder2.AddMarkupContent(71, "<p class=\"cards-content\">\r\n                Database project for Nablus Public Library.\r\n            </p>");
                __builder2.AddMarkupContent(72, "<p>\r\n                Used: MYSQL\r\n            </p>");
#nullable restore
#line 68 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
        }
        else if (title == "Blazor WebAssembly")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(73, "<div style=\"float:left\"><img class=\"card-image\" src=\"/images/programing_mid.gif\"></div>");
                __builder2.AddMarkupContent(74, "<p class=\"cards-content\">\r\n                This website made with love and passionate using .net-blazor.\r\n            </p>");
                __builder2.AddMarkupContent(75, "<p>\r\n                Used: BLAZOR/C#  /HTML/CSS\r\n            </p>");
#nullable restore
#line 80 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
        }
        else if (title == "Machine learning project")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(76, "<div style=\"float:left\"><img class=\"card-image\" src=\"/images/machine.jpg\"></div>\r\n            ");
                __builder2.AddMarkupContent(77, "<p class=\"cards-content\">\r\n                Predicting the Attrition of an employee worked in a company.\r\n            </p>");
                __builder2.AddMarkupContent(78, "<p>\r\n                Used: Python\r\n            </p>");
#nullable restore
#line 91 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
        }
        else if (title == "Cryptography project")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(79, "<div style=\"float: left;\"><img class=\"card-image\" src=\"/images/crypto.jpg\">\r\n            <img class=\"card-image\" src=\"/images/lock.gif\" style=\"position:absolute;left:10px;top:1px; pointer-events:none;\"></div>\r\n            ");
                __builder2.AddMarkupContent(80, "<p class=\"cards-content\">\r\n                A full encryption and decryption python program with Multithreaded\r\n                Ciphers and brute force the encrypted data.\r\n            </p>");
                __builder2.AddMarkupContent(81, "<p>\r\n                Used: Python\r\n            </p>");
#nullable restore
#line 106 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
            }
        else if (title == "Restaurant management system")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(82, "<div style=\"float: left\"><img class=\"card-image\" src=\"/images/90s.png\"></div>\r\n            ");
                __builder2.AddMarkupContent(83, "<p class=\"cards-content\">\r\n                Designed a web application for restaurant management system.\r\n            </p>");
                __builder2.AddMarkupContent(84, "<p>\r\n                Used: PHP/ HTML/CSS/JAVASCRIPT\r\n            </p>");
#nullable restore
#line 117 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
        }
        else if (title == "Selenium")
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(85, "<div style=\"float: left\"><img class=\"card-image\" src=\"/images/crypto.jpg\"></div>\r\n            ");
                __builder2.AddMarkupContent(86, "<p class=\"cards-content\">\r\n                I used selenium framework in web automation and scraping data from websites.\r\n            </p>");
                __builder2.AddMarkupContent(87, "<p>\r\n                Used: Python\r\n            </p>");
#nullable restore
#line 128 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n");
            __builder.OpenElement(89, "section");
            __builder.AddAttribute(90, "class", "module parallax parallax-3");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "container");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "id", "card");
            __builder.AddAttribute(95, "class", "flip-card");
            __builder.AddAttribute(96, "tabIndex", "0");
            __builder.AddAttribute(97, "style", "margin-top:20px");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "flip-card-inner");
            __builder.AddMarkupContent(100, "<div class=\"flip-card-front\"></div>\r\n\r\n                ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "flip-card-back");
            __builder.AddMarkupContent(103, "<div style=\"width:100%; margin:50px\"><h4 style=\"color: snow; user-select: none;\">BAHAA TUFFAHA</h4></div>\r\n                    ");
            __builder.AddMarkupContent(104, "<div style=\"width:100%\"><span class=\"infos\">EMAIL: bahaa.tuffaha@yahoo.com</span></div>\r\n                    ");
            __builder.OpenElement(105, "a");
            __builder.AddAttribute(106, "href", "mailto:bahaa.tuffaha@yahoo.com");
            __builder.OpenComponent<AntDesign.Button>(107);
            __builder.AddAttribute(108, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 151 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                 AntDesign.ButtonType.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "Loading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 152 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                         _noIconLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.Color>(
#nullable restore
#line 153 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                       AntDesign.Color.Gold3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "Icon", "Send");
            __builder.AddAttribute(112, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 155 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                         EnterNoIconLoading

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(114, "\r\n                            Contact Me\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n");
            __builder.AddMarkupContent(116, "<style>@import url(\'https://fonts.googleapis.com/css2?family=Ubuntu:wght@300&display=swap\');\r\n    section.module.parallax {\r\n        height: 600px;\r\n        background-position: 50% 50%;\r\n        background-repeat: no-repeat;\r\n        background-attachment: fixed;\r\n        background-size: cover;\r\n    }\r\n\r\n    section.module.parallax-1 {\r\n        background-image: url(\"/images/me3.png\");\r\n        /*background-position: top;*/\r\n        /*background-position-x: -60px;*/\r\n        background-size: cover;\r\n        background-position: center;\r\n        overflow: hidden;\r\n    }\r\n\r\n    section.module.parallax-2 {\r\n        background-image: url(\"/images/me.gif\");\r\n        background-size: cover;\r\n        background-position: center;\r\n        overflow: hidden;\r\n    }\r\n\r\n    section.module.parallax-3 {\r\n        background-image: url(\"/images/me4_22.png\");\r\n        background-size: cover;\r\n        background-position: center;\r\n        overflow: hidden;\r\n    }\r\n    .container {\r\n        overflow-wrap: break-word;\r\n    }\r\n    .OS {\r\n        font-family: FiraMono;\r\n        color: #3464A2;\r\n        display: flex;\r\n        flex-direction: row;\r\n        justify-content: space-around;\r\n        width: 100%;\r\n        user-select: none;\r\n    }\r\n        .OS p {\r\n           font-size:13px;\r\n        }\r\n\r\n    .l1 {\r\n        font-size: 70px;\r\n        font-family: jd_code;\r\n        color: #2673dc;\r\n        user-select: none;\r\n    }\r\n\r\n    .l2 {\r\n        width: 80%;\r\n        font-size: 5vmin;\r\n        text-justify: auto;\r\n        font-family: TitilliumWeb;\r\n        color: whitesmoke;\r\n        text-align: justify;\r\n        user-select: none;\r\n    }\r\n\r\n    html {\r\n        scroll-behavior: smooth;\r\n    }\r\n\r\n    .card-image {\r\n       width: 30%;\r\n       border-radius: 15px 50px;\r\n       padding-bottom:20px;\r\n\r\n    }\r\n\r\n    .card-image:hover {\r\n        filter: saturate(150%);\r\n    }\r\n    .card-image:active {\r\n        pointer-events: none;\r\n    }\r\n    .ant-modal-body {\r\n        background-color: #333333;\r\n        font-family: TitilliumWeb;\r\n    }\r\n    .ant-modal-header {\r\n        background-color: #363636;\r\n        border-bottom: 1px solid hsla(0, 0%, 0%, 0.5);\r\n    }\r\n    .ant-modal-title {\r\n        font-weight:800;\r\n        font-family: TitilliumWeb;\r\n        color: snow;\r\n        text-align:center;\r\n    }\r\n    .ant-modal-footer {\r\n        font-family: TitilliumWeb;\r\n        background-color: #333333;\r\n    }\r\n    .ant-btn ant-btn-default {\r\n        background-color: #95EBEC;\r\n    }\r\n    .ant-modal-content {\r\n        border-radius: 10px !important;\r\n    }\r\n    .cards-content {\r\n    }\r\n    .flip-card {\r\n        background-color: transparent;\r\n        width: 560px;\r\n        height: 400px;\r\n        perspective: 1000px;\r\n    }\r\n\r\n    .flip-card-inner {\r\n        position: relative;\r\n        width: 100%;\r\n        height: 100%;\r\n        text-align: center;\r\n        transition: transform 0.6s;\r\n        transform-style: preserve-3d;\r\n        -webkit-border-radius: 20px;\r\n        -moz-border-radius: 20px;\r\n        border-radius: 20px;\r\n        -webkit-box-shadow: rgba(0,0,0,0.8) 0px 0 10px;\r\n        -moz-box-shadow: rgba(0,0,0,0.8) 0 0 10px;\r\n        box-shadow: rgba(0,0,0,0.8) 0 0 10px;\r\n    }\r\n\r\n    .flip-card:focus {\r\n        outline: 0;\r\n    }\r\n\r\n    .flip-card:hover .flip-card-inner,\r\n    .flip-card:active .flip-card-inner {\r\n        transform: rotateY(180deg);\r\n    }\r\n\r\n    .flip-card-front,\r\n    .flip-card-back {\r\n        position: absolute;\r\n        width: 100%;\r\n        height: 100%;\r\n        backface-visibility: hidden;\r\n    }\r\n\r\n    .flip-card-front {\r\n        background-image: url(\"/images/Card-Out.png\");\r\n        background-repeat:no-repeat;\r\n        background-size:contain;\r\n        color: black;\r\n        z-index: 2;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n    }\r\n\r\n    .flip-card-back {\r\n        background-image: url(\"/images/Card-In.png\");\r\n        color: white;\r\n        background-size: contain;\r\n        background-repeat: no-repeat;\r\n        transform: rotateY(180deg);\r\n        z-index: 1;\r\n        display: flex;\r\n        align-items: center;\r\n        flex-direction: column;\r\n        font-family: \'Ubuntu\', sans-serif;\r\n    }\r\n\r\n    .infos {\r\n        font-size: 15px;\r\n        font-weight: bold;\r\n        color: #fff;\r\n    }\r\n    img:active{\r\n        pointer-events: none;\r\n    }\r\n    @media (max-width: 1028px) {\r\n        .OS {\r\n            flex-direction: column;\r\n        }\r\n    }\r\n    @media (max-width: 1180px) {\r\n        section .module.parallax-1 {\r\n            background-image: url(\"/images/programing_mid.png\");\r\n        }\r\n\r\n        section.module.parallax-2 {\r\n            background-image: url(\"/images/programing_mid.gif\");\r\n        }\r\n\r\n        section.module.parallax-3 {\r\n            background-image: url(\"/images/programing_mid2.png\");\r\n        }\r\n\r\n        .l1 {\r\n            font-size: 50px;\r\n        }\r\n        .l2 {\r\n            background-color: hsla(0, 0%, 0%, 0.5);\r\n            text-align: center;\r\n        }\r\n\r\n        .flip-card {\r\n            background-color: transparent;\r\n            width: 280px;\r\n            height: 200px;\r\n            perspective: 1000px;\r\n        }\r\n\r\n        .OS {\r\n            flex-direction: column;\r\n        }\r\n    }\r\n    @media (max-width:500px) {\r\n        .l1 {\r\n            font-size: 35px;\r\n            text-align:center;\r\n\r\n        }\r\n        .l2 {\r\n            text-align: center;\r\n            width: auto;\r\n            background-color: hsla(0, 0%, 0%, 0.5);\r\n            text-align: center;\r\n        }\r\n        .container {\r\n        justify-content:center;\r\n        }\r\n        .section.module.parallax-3.container {\r\n        display:flex;\r\n        justify-content:center;\r\n        }\r\n        .flip-card {\r\n            background-color: transparent;\r\n            width: 280px;\r\n            height: 200px;\r\n            perspective: 1000px;\r\n        }\r\n        .OS {\r\n            flex-direction:column;\r\n        }\r\n    @media (max-width:406px) {\r\n        .flip-card {\r\n            transform: scale(0.9);\r\n        }\r\n        .module parallax parallax-3.container {\r\n            padding-left: 0px;\r\n        }\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 429 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
      
    //here cards windows
    string title = "404 error";
    bool _visible1 = false;
    private void Info1(int card_num)
    {
        if (card_num == 1)
        {
            title = "Floppy-Cloud";
        }
        else if (card_num == 2)
        {
            title = "Database project";
        }
        else if (card_num == 3)
        {
            title = "Blazor WebAssembly";
        }
        else if (card_num == 4)
        {
            title = "Cryptography project";
        }
        else if (card_num == 5)
        {
            title = "Machine learning project";
        }
        else if (card_num == 6)
        {
            title = "Restaurant management system";
        }
        else if (card_num == 7)
        {
            title = "Selenium";
        }

        _visible1 = true;
    }

    private void HandleCancel(MouseEventArgs e)
    {
        _visible1 = false;
    }
    RenderFragment closeimg =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(117, "<img style=\"width: 20px;height:20px\" src=\"/images/close.png\" alt=\"close\">");
        }
#nullable restore
#line 471 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Index.razor"
                                                                                                         ;
    TypewriterBuilder typewriter = new TypewriterBuilder(defaultCharacterPause: 100)
    .TypeString("BAHAA TUFFAHA")
    .Pause(2000)
    .DeleteAll()
    .TypeString("DEVELOPER", 100)
    .Pause(500)
    .DeleteAll(30)
    .TypeString("DESIGNER", 100)
    .Pause(500)
    .DeleteAll(20)
    .Pause(500)
    .Loop();

    TypewriterBuilder typewriter2 = new TypewriterBuilder(defaultCharacterPause: 100);

    //contact me button
    private bool _noIconLoading;
    private bool _withIconLoading;
    private bool _onlyIconLoading;

    private async Task EnterNoIconLoading()
    {
        _noIconLoading = true;
        await Task.Delay(8000);
        _noIconLoading = false;
    }

    private async Task EnterWithIconLoading()
    {
        _withIconLoading = true;
        await Task.Delay(8000);
        _withIconLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModalService _modalService { get; set; }
    }
}
#pragma warning restore 1591

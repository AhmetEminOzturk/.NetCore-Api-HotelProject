#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_NavbarPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "750a487ac71f83534b1d6218e7713f8485e0468f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__NavbarPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto.Responses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750a487ac71f83534b1d6218e7713f8485e0468f", @"/Views/Shared/Components/_NavbarPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09498897724d1f8f80a7f385e5c05e5869491dac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__NavbarPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid bg-dark px-0"">
    <div class=""row gx-0"">
        <div class=""col-lg-3 bg-dark d-none d-lg-block"">
            <a href=""/Default/Index"" class=""navbar-brand w-100 h-100 m-0 p-0 d-flex align-items-center justify-content-center"">
                <h1 class=""m-0 text-primary text-uppercase"">Hotelier</h1>
            </a>
        </div>
        <div class=""col-lg-9"">
            <div class=""row gx-0 bg-white d-none d-lg-flex"">
                <div class=""col-lg-7 px-5 text-start"">
                    <div class=""h-100 d-inline-flex align-items-center py-2 me-4"">
                        <i class=""fa fa-envelope text-primary me-2""></i>
                        <p class=""mb-0"">hotelapi@example.com</p>
                    </div>
                    <div class=""h-100 d-inline-flex align-items-center py-2"">
                        <i class=""fa fa-phone-alt text-primary me-2""></i>
                        <p class=""mb-0"">+012 345 6789</p>
                    </div>
           ");
            WriteLiteral("     </div>\r\n                <div class=\"col-lg-5 px-5 text-end\">\r\n                    <div class=\"d-inline-flex align-items-center py-2\">\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1210, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1290, "\"", 1297, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1374, "\"", 1381, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a>\r\n                        <a class=\"me-3\"");
            BeginWriteAttribute("href", " href=\"", 1462, "\"", 1469, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        <a");
            BeginWriteAttribute("class", " class=\"", 1535, "\"", 1543, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1544, "\"", 1551, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-youtube""></i></a>
                    </div>
                </div>
            </div>
            <nav class=""navbar navbar-expand-lg bg-dark navbar-dark p-3 p-lg-0"">
                <a href=""index.html"" class=""navbar-brand d-block d-lg-none"">
                    <h1 class=""m-0 text-primary text-uppercase"">Hotelier</h1>
                </a>
                <button type=""button"" class=""navbar-toggler"" data-bs-toggle=""collapse"" data-bs-target=""#navbarCollapse"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                    <div class=""navbar-nav mr-auto py-0"">
                        <a href=""index.html"" class=""nav-item nav-link active"">Ana Sayfa</a>
                        <a href=""about.html"" class=""nav-item nav-link"">Hakkımızda</a>
                        <a href=""service.html"" class=""nav-item nav-link"">Servisler</a>
               ");
            WriteLiteral(@"         <a href=""room.html"" class=""nav-item nav-link"">Odalar</a>
                        <div class=""nav-item dropdown"">
                            <a href=""#"" class=""nav-link dropdown-toggle"" data-bs-toggle=""dropdown"">Sayfalar</a>
                            <div class=""dropdown-menu rounded-0 m-0"">
                                <a href=""booking.html"" class=""dropdown-item"">Rezarvasyon</a>
                                <a href=""team.html"" class=""dropdown-item"">Ekibimiz</a>
                                <a href=""testimonial.html"" class=""dropdown-item"">Yorumlar</a>
                            </div>
                        </div>
                        <a href=""contact.html"" class=""nav-item nav-link"">İletişim</a>
                        <a href=""contact.html"" class=""nav-item nav-link"">Yardım</a>
                    </div>
                </div>
            </nav>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

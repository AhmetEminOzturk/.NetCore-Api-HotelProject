#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_FooterPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5dcaa9555969ab8d8222b7e99825be6b787c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__FooterPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_FooterPartial/Default.cshtml")]
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
using HotelProject.WebUI.Dtos.AboutDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto.Requests;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5dcaa9555969ab8d8222b7e99825be6b787c6a", @"/Views/Shared/Components/_FooterPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4f446b2aa6baa51274ad4c98853784c27e0943", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__FooterPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid bg-dark text-light footer wow fadeIn"" data-wow-delay=""0.1s"">
    <div class=""container pb-5"">
        <div class=""row g-5"">
            <div class=""col-md-6 col-lg-4"">
                <div class=""bg-primary rounded p-4"">
                    <a href=""index.html""><h1 class=""text-white text-uppercase mb-3"">Hotelier</h1></a>
                    <p class=""text-white mb-0"">
                        Asp .Net Core Api ile Hazırladığımız  Web Tabanlı Online Rezervasyon Uygulamasıdır. Geliştirici: Ahmet Emin Öztürk
                    </p>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <h6 class=""section-title text-start text-primary text-uppercase mb-4"">İletişim</h6>
                <p class=""mb-2""><i class=""fa fa-map-marker-alt me-3""></i>Dolmabahçe Caddesi</p>
                <p class=""mb-2""><i class=""fa fa-phone-alt me-3""></i>+90 530 7313091</p>
                <p class=""mb-2""><i class=""fa fa-envelope me-3""></i>eminahm");
            WriteLiteral("etozturk@gmail.com</p>\r\n                <div class=\"d-flex pt-2\">\r\n                    <a class=\"btn btn-outline-light btn-social\"");
            BeginWriteAttribute("href", " href=\"", 1154, "\"", 1161, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                    <a class=\"btn btn-outline-light btn-social\"");
            BeginWriteAttribute("href", " href=\"", 1262, "\"", 1269, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                    <a class=\"btn btn-outline-light btn-social\"");
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1380, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-youtube\"></i></a>\r\n                    <a class=\"btn btn-outline-light btn-social\"");
            BeginWriteAttribute("href", " href=\"", 1481, "\"", 1488, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-linkedin-in""></i></a>
                </div>
            </div>
            <div class=""col-lg-5 col-md-12"">
                <div class=""row gy-5 g-4"">
                    <div class=""col-md-6"">
                        <h6 class=""section-title text-start text-primary text-uppercase mb-4"">Company</h6>
                        <a class=""btn btn-link""");
            BeginWriteAttribute("href", " href=\"", 1863, "\"", 1870, 0);
            EndWriteAttribute();
            WriteLiteral(">Hakkımızda</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 1935, "\"", 1942, 0);
            EndWriteAttribute();
            WriteLiteral(">Bize Yazın</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2007, "\"", 2014, 0);
            EndWriteAttribute();
            WriteLiteral(">Gizlilik Politikası</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2088, "\"", 2095, 0);
            EndWriteAttribute();
            WriteLiteral(">Kurallar & Şartlar</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2168, "\"", 2175, 0);
            EndWriteAttribute();
            WriteLiteral(">Destek</a>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <h6 class=\"section-title text-start text-primary text-uppercase mb-4\">Services</h6>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2417, "\"", 2424, 0);
            EndWriteAttribute();
            WriteLiteral(">Yemek & Restoran</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2495, "\"", 2502, 0);
            EndWriteAttribute();
            WriteLiteral(">Spa & Fitness</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2570, "\"", 2577, 0);
            EndWriteAttribute();
            WriteLiteral(">Spor & Oyun</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2643, "\"", 2650, 0);
            EndWriteAttribute();
            WriteLiteral(">Kutlama & Eğlence</a>\r\n                        <a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2722, "\"", 2729, 0);
            EndWriteAttribute();
            WriteLiteral(@">Yoga & Meditasyon</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""copyright"">
            <div class=""row"">
                <div class=""col-md-6 text-center text-md-start mb-3 mb-md-0"">
                    &copy; Tüm Hakları Saklıdır ");
#nullable restore
#line 51 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_FooterPartial\Default.cshtml"
                                           Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    
                    Designed By <a class=""border-bottom"" href=""https://htmlcodex.com"">aEo</a>
                </div>
                <div class=""col-md-6 text-center text-md-end"">
                    <div class=""footer-menu"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 3374, "\"", 3381, 0);
            EndWriteAttribute();
            WriteLiteral(">Ana Sayfa</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3424, "\"", 3431, 0);
            EndWriteAttribute();
            WriteLiteral(">Çerezler</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3473, "\"", 3480, 0);
            EndWriteAttribute();
            WriteLiteral(">Yardım</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3520, "\"", 3527, 0);
            EndWriteAttribute();
            WriteLiteral(">FQAs</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TrailerPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ed59f653ec34ddde008fbbdc3242961e4239d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TrailerPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TrailerPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ed59f653ec34ddde008fbbdc3242961e4239d0", @"/Views/Shared/Components/_TrailerPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09498897724d1f8f80a7f385e5c05e5869491dac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TrailerPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-xxl py-5 px-0 wow zoomIn"" data-wow-delay=""0.1s"">
    <div class=""row g-0"">
        <div class=""col-md-6 bg-dark d-flex align-items-center"">
            <div class=""p-5"">
                <h6 class=""section-title text-start text-white text-uppercase mb-3"">Huzur Dolu Bir Tatil</h6>
                <h1 class=""text-white mb-4"">Otelimizi Daha Yakından Tanıyın</h1>
                <p class=""text-white mb-4"">Sizler için hazırladığımız otel tanıtım videomuzu izleyip hakkımızda daha fazla bilgi sahibi olabilirsiniz.Sorularınız olursa iletişim kısmından bize ulaşabilirsiniz.</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 624, "\"", 631, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-md-3 px-md-5 me-3\">Odalarımız</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 712, "\"", 719, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-light py-md-3 px-md-5"">Rezervasyon Yap</a>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""video"">
                <button type=""button"" class=""btn-play"" data-bs-toggle=""modal"" data-src=""https://www.youtube.com/embed/A-yYTkfrHR0?si=YSuC8eR44TUszoKd"" data-bs-target=""#videoModal"">
                    <span></span>
                </button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""videoModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content rounded-0"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Youtube Video</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <!-- 16:9 aspect ratio -->
                <div class=""ratio ra");
            WriteLiteral("tio-16x9\">\r\n                    <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 1813, "\"", 1819, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"video\" allowfullscreen allowscriptaccess=\"always\"\r\n                            allow=\"autoplay\"></iframe>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8860752b29f7381a7015a99bdda411e6c02266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__OurRoomsPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8860752b29f7381a7015a99bdda411e6c02266", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4f446b2aa6baa51274ad4c98853784c27e0943", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__OurRoomsPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DisplayRoomResponse>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Odalarımız</h6>
            <h1 class=""mb-5"">Odalarımızı <span class=""text-primary text-uppercase"">Keşfedin</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 11 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-lg-4 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n                <div class=\"room-item shadow rounded overflow-hidden\">\r\n                    <div class=\"position-relative\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 727, "\"", 753, 1);
#nullable restore
#line 16 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
WriteAttributeValue("", 733, item.RoomCoverImage, 733, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 754, "\"", 760, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">");
#nullable restore
#line 17 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺/Gece</small>\r\n                    </div>\r\n                    <div class=\"p-4 mt-2\">\r\n                        <div class=\"d-flex justify-content-between mb-3\">\r\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 21 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            <div class=""ps-2"">
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                            </div>
                        </div>
                        <div class=""d-flex mb-3"">
                            <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>");
#nullable restore
#line 31 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                      Write(item.BedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yatak</small>\r\n                            <small class=\"border-end me-3 pe-3\"><i class=\"fa fa-bath text-primary me-2\"></i>");
#nullable restore
#line 32 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                       Write(item.BathCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            <small><i class=\"fa fa-wifi text-primary me-2\"></i>");
#nullable restore
#line 33 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                          Write(item.Wifi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                        <p class=\"text-body mb-3\">");
#nullable restore
#line 35 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""d-flex justify-content-between"">
                                <a class=""btn btn-sm btn-primary rounded py-2 px-4"" href=""/Booking/Index/"">Detaylar</a>
                                <a class=""btn btn-sm btn-dark rounded py-2 px-4"" href=""/Booking/Index/"">Rezervasyon Yap</a>
                        </div>
                    </div>
                </div>
            </div> 
");
#nullable restore
#line 43 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DisplayRoomResponse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

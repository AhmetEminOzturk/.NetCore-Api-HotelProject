#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cf34eb4f8aa88b3a1782b39372259bbe8a65d94a59352dac65f9e0eff3db7b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminBooking_Index), @"mvc.1.0.view", @"/Views/AdminBooking/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
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
using HotelProject.WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AppUserDto.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SocialMediaFollowerDtos.Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cf34eb4f8aa88b3a1782b39372259bbe8a65d94a59352dac65f9e0eff3db7b94", @"/Views/AdminBooking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1889d52b3bdb50c53dc95dbad4190d0fe9c737ccca6cd2858ff77567f4c3709e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminBooking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DisplayBookingResponse>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th>#</th>
                <th>Misafir</th>
                <th>Giriş Tarihi</th>
                <th>Çıkış Tarigi</th>
                <th>Durum</th>
                <th>Onayla</th>
                <th>İptal Et</th>
                <th>Beklet</th>
                <th>Güncelle</th>
                <th>Detaylar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
             foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 29 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 30 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
                   Write(item.CheckIn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
                   Write(item.CheckOut.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> <span class=\"badge badge-primary px-2\">");
#nullable restore
#line 33 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
                                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1081, "\"", 1136, 2);
            WriteAttributeValue("", 1088, "/AdminBooking/ApproveReservation/", 1088, 33, true);
#nullable restore
#line 34 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
WriteAttributeValue("", 1121, item.BookingId, 1121, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Onayla</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1259, 2);
            WriteAttributeValue("", 1212, "/AdminBooking/CancelReservation/", 1212, 32, true);
#nullable restore
#line 35 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
WriteAttributeValue("", 1244, item.BookingId, 1244, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">İptal Et</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1381, 2);
            WriteAttributeValue("", 1336, "/AdminBooking/WaitReservation/", 1336, 30, true);
#nullable restore
#line 36 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
WriteAttributeValue("", 1366, item.BookingId, 1366, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Beklet</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1450, "\"", 1500, 2);
            WriteAttributeValue("", 1457, "/AdminBooking/UpdateBooking/", 1457, 28, true);
#nullable restore
#line 37 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
WriteAttributeValue("", 1485, item.BookingId, 1485, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1568, "\"", 1618, 2);
            WriteAttributeValue("", 1575, "/AdminBooking/UpdateBooking/", 1575, 28, true);
#nullable restore
#line 38 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
WriteAttributeValue("", 1603, item.BookingId, 1603, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Detaylar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminBooking\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DisplayBookingResponse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

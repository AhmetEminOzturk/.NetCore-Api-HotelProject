#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cdbac050e9569cc218464989b82a13ef3c6ef33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminContact_Inbox), @"mvc.1.0.view", @"/Views/AdminContact/Inbox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cdbac050e9569cc218464989b82a13ef3c6ef33", @"/Views/AdminContact/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4f446b2aa6baa51274ad4c98853784c27e0943", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminContact_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DisplayContactResponse>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"email-left-box\">\r\n    <a href=\"/AdminContact/AddSendMessage/\" class=\"btn btn-primary btn-block\">Yeni Mesaj Oluştur</a>\r\n    ");
#nullable restore
#line 8 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
Write(await Html.PartialAsync("SideBarAdminContactPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h5 class=\"mt-5 m-b-10\">Kategoriler</h5>\r\n    ");
#nullable restore
#line 10 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
Write(await Html.PartialAsync("SideBarAdminContactCategoryPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<div class=""email-right-box"">
    <div role=""toolbar"" class=""toolbar"">
        <div class=""btn-group"">
            <button aria-expanded=""false"" data-toggle=""dropdown"" class=""btn btn-dark dropdown-toggle"" type=""button"">
                Gelen Mesajlar <span class=""caret m-l-5""></span>
            </button>
        </div>
    </div>
    <div class=""email-list m-t-15"">
");
#nullable restore
#line 21 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"message\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 985, 2);
            WriteAttributeValue("", 936, "/AdminContact/InboxMessageDetails/", 936, 34, true);
#nullable restore
#line 24 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
WriteAttributeValue("", 970, item.ContactId, 970, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-mail col-mail-1"">
                        <div class=""email-checkbox"">
                            <input type=""checkbox"" id=""chk2"">
                            <label class=""toggle"" for=""chk2""></label>
                        </div><span class=""star-toggle ti-star""></span>
                    </div>
                    <div class=""col-mail col-mail-2"">
                        <div class=""subject""><b>KONU: ");
#nullable restore
#line 32 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
                                                 Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> GÖNDEREN ");
#nullable restore
#line 32 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                        <div class=\"date\">");
#nullable restore
#line 33 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
                                     Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Inbox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DisplayContactResponse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

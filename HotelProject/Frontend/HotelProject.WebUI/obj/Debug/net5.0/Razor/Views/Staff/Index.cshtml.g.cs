#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ef8dd3c952aaf790f942c1000db496243e6433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0ef8dd3c952aaf790f942c1000db496243e6433", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76059838a5c04be3a1d8439fb6dd3117b309d17", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StaffViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table- bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Personel Adı</th>\r\n        <th>Personel Ünvan</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 19 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
           Write(item.StaffID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 20 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 524, "\"", 563, 2);
            WriteAttributeValue("", 531, "/Staff/DeleteStaff/", 531, 19, true);
#nullable restore
#line 22 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
WriteAttributeValue("", 550, item.StaffID, 550, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 645, "\"", 684, 2);
            WriteAttributeValue("", 652, "/Staff/UpdateStaff/", 652, 19, true);
#nullable restore
#line 23 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
WriteAttributeValue("", 671, item.StaffID, 671, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n            <td><a href=\"#\" class=\"btn mb-1 btn-rounded btn-outline-dark\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Staff/AddStaff/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Personel Giriş</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StaffViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7435622e1da75a5a5a8576b3d0649f8e719e964d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout__AdminLayout), @"mvc.1.0.view", @"/Views/AdminLayout/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7435622e1da75a5a5a8576b3d0649f8e719e964d", @"/Views/AdminLayout/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09498897724d1f8f80a7f385e5c05e5869491dac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminLayout__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n        ");
#nullable restore
#line 9 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7435622e1da75a5a5a8576b3d0649f8e719e964d5752", async() => {
                WriteLiteral("\r\n\r\n\r\n        ");
#nullable restore
#line 15 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/PreLoaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div id=\"main-wrapper\">\r\n\r\n \r\n        ");
#nullable restore
#line 20 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/NavHeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 22 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n       \r\n        ");
#nullable restore
#line 24 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/SideBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
      
      
        <div class=""content-body"">     

            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                ");
#nullable restore
#line 34 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
                           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- #/ container -->\r\n        </div>\r\n\r\n        ");
#nullable restore
#line 43 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/AdminLayout/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n       \r\n    </div>\r\n\r\n    ");
#nullable restore
#line 47 "C:\GitHub\.NetCore-Api-HotelProject\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLayout/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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

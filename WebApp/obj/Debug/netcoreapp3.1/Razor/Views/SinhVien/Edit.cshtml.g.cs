#pragma checksum "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1440dea35bb4d37bdd2251da72d39e6dffcd95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinhVien_Edit), @"mvc.1.0.view", @"/Views/SinhVien/Edit.cshtml")]
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
#line 1 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1440dea35bb4d37bdd2251da72d39e6dffcd95", @"/Views/SinhVien/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_SinhVien_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.MSinhVien.SinhVienViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit</h2>\r\n");
#nullable restore
#line 6 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>sinhvien</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 13 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 17 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
   Write(Html.LabelFor(model => model.name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 19 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
       Write(Html.EditorFor(model => model.name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
   Write(Html.LabelFor(model => model.address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 26 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
       Write(Html.EditorFor(model => model.address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 37 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 40 "H:\Code_Phat_Trien_Chuan\ASP.NET Core 3.1_WebAPI_Web_HayNhat\WebAPI_ThucHanh\WebApp\Views\SinhVien\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.MSinhVien.SinhVienViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

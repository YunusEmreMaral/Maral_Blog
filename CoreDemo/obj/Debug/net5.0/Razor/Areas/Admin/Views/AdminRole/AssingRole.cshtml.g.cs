#pragma checksum "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "411d446d71ba638579c7f19588a000756b046cc67ffe7b5604a8ea27408b0ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_AssingRole), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/AssingRole.cshtml")]
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
#line 1 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"411d446d71ba638579c7f19588a000756b046cc67ffe7b5604a8ea27408b0ec9", @"/Areas/Admin/Views/AdminRole/AssingRole.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminRole_AssingRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RoleAssignViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
  
    ViewData["Title"] = "AssingRole";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form method=\"post\" asp-action=\"AssingRole\"");
            BeginWriteAttribute("asp-route-userId", " asp-route-userId=\"", 200, "\"", 238, 1);
#nullable restore
#line 8 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
WriteAttributeValue("", 219, TempData["UserId"], 219, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 9 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-check\">\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 359, "\"", 385, 1);
#nullable restore
#line 12 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
WriteAttributeValue("", 369, Model[i].RoleID, 369, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 423, "\"", 447, 1);
#nullable restore
#line 13 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
WriteAttributeValue("", 433, Model[i].Name, 433, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"checkbox\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 487, "\"", 513, 1);
#nullable restore
#line 14 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
WriteAttributeValue("", 497, Model[i].Exists, 497, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\"\r\n            ");
#nullable restore
#line 15 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
        Write(Model[i].Exists ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n            <label class=\"form-check-label\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 636, "\"", 662, 1);
#nullable restore
#line 16 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
WriteAttributeValue("", 646, Model[i].Exists, 646, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
                                                                  Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 20 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AssingRole.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"btn btn-info\">Değişiklikleri Kaydet</button>\r\n    \r\n</form>\r\n<br />\r\n<a href=\"/Admin/AdminRole/UserRoleList\" class=\"btn btn-primary\">Kullanıcı Listesine Dön</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RoleAssignViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

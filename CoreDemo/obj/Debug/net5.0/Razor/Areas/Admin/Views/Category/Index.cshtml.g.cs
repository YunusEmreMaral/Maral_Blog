#pragma checksum "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c901cf9b3578a92d581f716a1da1f2048f0b8e7873858e8ac73c813e46eca4c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 2 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c901cf9b3578a92d581f716a1da1f2048f0b8e7873858e8ac73c813e46eca4c6", @"/Areas/Admin/Views/Category/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n\t<tr>\r\n\t\t<th>#</th>\r\n\t\t<th>Kategori Adı</th>\r\n\t\t<th>Pasif Yap</th>\r\n\t\t<th>Aktif Yap</th>\r\n\t\t<th>Düzenle</th>\r\n\t</tr>\r\n");
#nullable restore
#line 22 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<th>");
#nullable restore
#line 25 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t<td>");
#nullable restore
#line 26 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 498, "\"", 552, 2);
            WriteAttributeValue("", 505, "/Admin/Category/CategoryDelete/", 505, 31, true);
#nullable restore
#line 27 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 536, item.CategoryID, 536, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\" class=\"btn btn-danger\">Pasif Yap</a></td>\r\n\t\t\t<td><a href=\"#\" class=\"btn btn-warning\">Aktif Yap</a></td>\r\n\t\t\t<td><a href=\"#\" class=\"btn btn-success\">Düzenle</a></td>\r\n\t\t</tr>\r\n");
#nullable restore
#line 31 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-primary\">Yeni Kategori</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 36 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new{page})));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

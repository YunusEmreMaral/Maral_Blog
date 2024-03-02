#pragma checksum "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45fb50660f92dcf96bebeb8f4a58037c981ef8e802346f666ae35b28e66d9183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"45fb50660f92dcf96bebeb8f4a58037c981ef8e802346f666ae35b28e66d9183", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c92a83f41f0f1d0c334c62b8f39d1ec21208a2ac881e016c2fed64a0055f3eb2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
	ViewData["Title"] = "BlogListByWriter";
	Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yazarın Blogları</h1>\r\n<table class=\"table table-bordered\">\r\n\t<tr>\r\n\t\t<th>#</th>\r\n\t\t<th>Blog Başlığı</th>\r\n\t\t<th>Oluşturma Tarihi</th>\r\n\t\t<th>Kategori</th>\r\n\t\t<th>Durum</th>\r\n\t\t<th> Sil</th>\r\n\t\t<th>Güncelle</th>\r\n\t</tr>\r\n");
#nullable restore
#line 18 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  foreach (var item in Model)
	{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<th>");
#nullable restore
#line 22 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t<th>");
#nullable restore
#line 23 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t<th>");
#nullable restore
#line 24 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(((DateTime)item.BlogCreateDate).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t<th>");
#nullable restore
#line 25 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 26 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    if (item.BlogStatus == true)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<td><div");
            BeginWriteAttribute("class", " class=\"", 599, "\"", 607, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:green;\">Aktif</div></td>\r\n");
#nullable restore
#line 29 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<td><div");
            BeginWriteAttribute("class", " class=\"", 681, "\"", 689, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red;\">Pasif</div></td>\r\n");
#nullable restore
#line 33 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<th><a");
            BeginWriteAttribute("href", " href=\"", 743, "\"", 779, 2);
            WriteAttributeValue("", 750, "/Blog/DeleteBlog/", 750, 17, true);
#nullable restore
#line 34 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 767, item.BlogID, 767, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></th>\r\n\t\t\t<th><a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 861, 2);
            WriteAttributeValue("", 834, "/Blog/EditBlog/", 834, 15, true);
#nullable restore
#line 35 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 849, item.BlogID, 849, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></th>\r\n\r\n\t\t</tr>\r\n");
#nullable restore
#line 38 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">Yeni Blog Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

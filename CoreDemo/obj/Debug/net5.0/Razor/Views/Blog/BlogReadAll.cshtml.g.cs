#pragma checksum "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ffd1fa6b76a3ff7400029c88214f5f9a7476f497a604c9063e957cbd1bd02a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ffd1fa6b76a3ff7400029c88214f5f9a7476f497a604c9063e957cbd1bd02a4f", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c92a83f41f0f1d0c334c62b8f39d1ec21208a2ac881e016c2fed64a0055f3eb2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"banner-bottom\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n");
#nullable restore
#line 13 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""blog-grid-top"">
                        <div class=""b-grid-top"">
                            <div class=""blog_info_left_grid"">
                                <a href=""single.html"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 653, "\"", 674, 1);
#nullable restore
#line 19 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 659, item.BlogImage, 659, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 693, "\"", 699, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 26 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <h3>
                            <a href=""single.html"">");
#nullable restore
#line 33 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                             Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <p>\r\n                            ");
#nullable restore
#line 36 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                       Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a href=\"/Blog/Index/\" class=\"btn btn-primary read-m\">Blog Listesi</a>\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--yorum liste-->\r\n                ");
#nullable restore
#line 42 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
           Write(await Component.InvokeAsync("CommentListByBlog", new { id = ViewBag.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--yorum ekle-->\r\n                ");
#nullable restore
#line 44 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
           Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\r\n                <div class=\"right-blog-info text-left\">\r\n                    <div class=\"tech-btm\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ffd1fa6b76a3ff7400029c88214f5f9a7476f497a604c9063e957cbd1bd02a4f9479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <h4>Mail Bültenine Abone Olun</h4>\r\n\r\n                    ");
#nullable restore
#line 54 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 55 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 56 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div class=""single-gd tech-btm"">
                        <h4>Son Eklenen Post</h4>
                        <div class=""blog-grids"">
                            <div class=""blog-grid-left"">
                                <a href=""single.html"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ffd1fa6b76a3ff7400029c88214f5f9a7476f497a604c9063e957cbd1bd02a4f12026", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </div>
                            <div class=""blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Son Eklenen Postumuz.</a>
                                </h5>
                            </div>
                            <div class=""clearfix""> </div>
                        </div>
                    </div>
                </div>
            </aside>
        </div>
    </div>
</section>
<!--//main-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

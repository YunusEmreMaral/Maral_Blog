#pragma checksum "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7f1903165b118faf6d2663daa8cd6cffb853fa8ad1c6f3717e2c3d35d44dc9d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBlog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
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
#line 1 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7f1903165b118faf6d2663daa8cd6cffb853fa8ad1c6f3717e2c3d35d44dc9d2", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
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
#nullable restore
#line 3 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f1903165b118faf6d2663daa8cd6cffb853fa8ad1c6f3717e2c3d35d44dc9d23310", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper wrapper-content animated fadeInRight\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"ibox\">\r\n                        <div class=\"ibox-content product-box\">\r\n                            <div>\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 538, "\"", 559, 1);
#nullable restore
#line 19 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 544, item.BlogImage, 544, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"225\" width=\"240\" />\r\n                            </div>\r\n                            <div class=\"product-desc\">\r\n                                <span class=\"product-price\">\r\n                                    ");
#nullable restore
#line 23 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 25 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                <a href=\"#\" class=\"product-name\">");
#nullable restore
#line 26 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                            Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                <div class=\"small m-t-xs\">\r\n");
#nullable restore
#line 28 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                      
                                        var content = item.BlogContent;
                                        if (content.Length > 100)
                                        {
                                            content = content.Substring(0, 100) + "...";
                                        }
                                        else if (content.Length == 100)
                                        {
                                            content = content;
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
#nullable restore
#line 39 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                               Write(content);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"m-t text-righ\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1927, "\"", 1964, 2);
                WriteAttributeValue("", 1934, "/Blog/BlogReadAll/", 1934, 18, true);
#nullable restore
#line 43 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1952, item.BlogID, 1952, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-xs btn-outline btn-primary"">Detaylar<i class=""fa fa-long-arrow-right""></i> </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 49 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
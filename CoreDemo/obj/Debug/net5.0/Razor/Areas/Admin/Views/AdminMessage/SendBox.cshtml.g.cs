#pragma checksum "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d205ac11cfa1fc12d68c11bde8bb2aa036ee39f3c915b3639b3c09287551fda9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_SendBox), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/SendBox.cshtml")]
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
#line 1 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d205ac11cfa1fc12d68c11bde8bb2aa036ee39f3c915b3639b3c09287551fda9", @"/Areas/Admin/Views/AdminMessage/SendBox.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminMessage_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
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
#line 4 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d205ac11cfa1fc12d68c11bde8bb2aa036ee39f3c915b3639b3c09287551fda93384", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""ibox "">
                    <div class=""ibox-content mailbox-content"">
                        <div class=""file-manager"">
                            <a class=""btn btn-block btn-primary compose-mail"" href=""/Admin/AdminMessage/ComposeMessage/"">Yeni Mesaj Oluştur</a>
                            <div class=""space-25""></div>
                            <h5>Klasörler</h5>
                            <ul class=""folder-list m-b-md"" style=""padding: 0"">
                                <li><a href=""/AdminMessage/Inbox/""> <i class=""fa fa-inbox""></i>Gelen Mesajlar<span class=""label label-warning float-right"">16</span> </a></li>
                                <li><a href=""/AdminMessage/Sendbox/""> <i class=""fa fa-envelope-o""></i>Giden Mesajlar</a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-certificate""></i>Önemli Mesajlar</a></li>
          ");
                WriteLiteral(@"                      <li><a href=""mailbox.html""> <i class=""fa fa-file-text-o""></i>Taslaklar<span class=""label label-danger float-right"">2</span></a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i>Çöp Kutusu</a></li>
                            </ul>
                            <h5>Kategoriler</h5>
                            <ul class=""category-list"" style=""padding: 0"">
                                <li><a href=""#""> <i class=""fa fa-circle text-navy""></i>İş</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-danger""></i>Dökümanlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-primary""></i>Sosyal</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-info""></i>Tanıtımlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-warning""></i>Talepler</a></li>
                            </ul>
                            <");
                WriteLiteral(@"div class=""clearfix""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 animated fadeInRight"">
                <div class=""mail-box-header"">

                    <form method=""get"" action=""index.html"" class=""float-right mail-search"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control form-control-sm"" name=""search"" placeholder=""Mail ara"">
                            <div class=""input-group-btn"">
                                <button type=""submit"" class=""btn btn-sm btn-primary"">
                                    Ara
                                </button>
                            </div>
                        </div>
                    </form>
                    <h2>
                        Giden Kutusu (0)
                    </h2>
                    <div class=""mail-tools tooltip-demo m-t-md"">
                        <div c");
                WriteLiteral(@"lass=""btn-group float-right"">
                            <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-left""></i></button>
                            <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-right""></i></button>
                        </div>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""left"" title=""Gelen kutusu yenilendi""><i class=""fa fa-refresh""></i>Yenile</button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Okundu olarak işaretle""><i class=""fa fa-eye""></i></button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Önemli olarak işaretle""><i class=""fa fa-exclamation""></i></button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Çöp kutusuna taşındı""><i class=""fa fa-trash-o""></i></button>
                    </div>
           ");
                WriteLiteral("     </div>\r\n                <div class=\"mail-box\">\r\n\r\n                    <table class=\"table table-hover table-mail\">\r\n                        <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <tr class=""read"">
                                    <td class=""check-mail"">
                                        <input type=""checkbox"" class=""i-checks"">
                                    </td>
                                    <td class=""mail-ontact""><a href=""mail_detail.html"">");
#nullable restore
#line 78 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                                                                  Write(item.ReveiverUser.WriterName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    <td class=\"mail-subject\"><a href=\"mail_detail.html\">");
#nullable restore
#line 79 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    <td class=\"text-right mail-date\">");
#nullable restore
#line 80 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                                                Write(item.MessageDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\imgoz\OneDrive\Masaüstü\Murat Yücedağ\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

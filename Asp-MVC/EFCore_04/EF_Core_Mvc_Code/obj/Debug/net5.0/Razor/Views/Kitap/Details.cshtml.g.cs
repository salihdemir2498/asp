#pragma checksum "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95308e0690fcd48561eb5984b270718d065cba6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_Details), @"mvc.1.0.view", @"/Views/Kitap/Details.cshtml")]
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
#line 1 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\_ViewImports.cshtml"
using EF_Core_Mvc_Code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\_ViewImports.cshtml"
using EF_Core_Mvc_Code.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95308e0690fcd48561eb5984b270718d065cba6f", @"/Views/Kitap/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3724761d73bf168172232dc368e61765374feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Kitap_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF_Core_Mvc_Code.Models.Kitaplar>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  
    ViewData["Title"] = @Model.Ad + " adlı Kitabın detayları";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-bottom: 28px;\">");
#nullable restore
#line 7 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
                            Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adlı Kitabın Detayları</h1>\r\n\r\n<div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Kitap ISBN: </h6>\r\n    <p>");
#nullable restore
#line 12 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Kitap Ad:</h6>\r\n    <p>");
#nullable restore
#line 16 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Kitap Sayfasayısı:</h6>\r\n    <p>");
#nullable restore
#line 20 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.SayfaSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Stok Miktarı:</h6>\r\n    <p>");
#nullable restore
#line 24 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Stok);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Tür Adı:</h6>\r\n    <p>");
#nullable restore
#line 28 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Tur.TurAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Yazarı:</h6>\r\n    <p>");
#nullable restore
#line 32 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Yazar.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"display: flex;\">\r\n    <h6 style=\"margin-right: 12px;\">Yayınevi Adı:</h6>\r\n    <p>");
#nullable restore
#line 36 "D:\Users\salih\source\repos\asp\Asp-MVC\EFCore_04\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.YayinEvi.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95308e0690fcd48561eb5984b270718d065cba6f6570", async() => {
                WriteLiteral("Kitaplara dön.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF_Core_Mvc_Code.Models.Kitaplar> Html { get; private set; }
    }
}
#pragma warning restore 1591
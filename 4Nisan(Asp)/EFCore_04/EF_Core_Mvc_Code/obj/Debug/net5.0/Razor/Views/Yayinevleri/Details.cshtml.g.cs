#pragma checksum "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\Yayinevleri\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3cab95f74075a9e5ca145b7d72dfb2ef256180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yayinevleri_Details), @"mvc.1.0.view", @"/Views/Yayinevleri/Details.cshtml")]
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
#line 1 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\_ViewImports.cshtml"
using EF_Core_Mvc_Code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\_ViewImports.cshtml"
using EF_Core_Mvc_Code.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3cab95f74075a9e5ca145b7d72dfb2ef256180", @"/Views/Yayinevleri/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3724761d73bf168172232dc368e61765374feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Yayinevleri_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF_Core_Mvc_Code.Models.Yayinevleri>
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
#nullable restore
#line 2 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\Yayinevleri\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yayınevi Detayları</h1>\r\n\r\n<div>\r\n    <h4>Yayınevi</h4>\r\n    <h5>Yayınevi ID: </h5>\r\n    <p>");
#nullable restore
#line 11 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\Yayinevleri\Details.cshtml"
  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Yayınevi Ad:</h5>\r\n    <p>");
#nullable restore
#line 13 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\Yayinevleri\Details.cshtml"
  Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Yayınevi Adres:</h5>\r\n    <p>");
#nullable restore
#line 15 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\Yayinevleri\Details.cshtml"
  Write(Model.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Yayınevi Tel:</h5>\r\n    <p>");
#nullable restore
#line 17 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\EFCore_04\EF_Core_Mvc_Code\Views\Yayinevleri\Details.cshtml"
  Write(Model.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f3cab95f74075a9e5ca145b7d72dfb2ef2561804929", async() => {
                WriteLiteral("Kitap türlerine dön.");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF_Core_Mvc_Code.Models.Yayinevleri> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\Users\salih\source\repos\asp\4Nisan(Asp)\09_Mvc_Proje1\DersBlogSite\Views\Dersler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7983c9dfa619b8261c38d78cb7cf24c3309c575e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dersler_Index), @"mvc.1.0.view", @"/Views/Dersler/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7983c9dfa619b8261c38d78cb7cf24c3309c575e", @"/Views/Dersler/Index.cshtml")]
    public class Views_Dersler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DersBlogSite.Models.Lesson>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<table class=""table table-dark table-striped w-50 mx-auto"">
    <thead>
        <tr class=""fs-2"">
            <th scope=""col"">Id</th>
            <th scope=""col"">Category</th>
            <th scope=""col"">Lesson Name</th>
        </tr>
    </thead>

");
#nullable restore
#line 24 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\09_Mvc_Proje1\DersBlogSite\Views\Dersler\Index.cshtml"
      
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr class=\"fs-4\">\r\n\r\n                    <td>");
#nullable restore
#line 30 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\09_Mvc_Proje1\DersBlogSite\Views\Dersler\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\09_Mvc_Proje1\DersBlogSite\Views\Dersler\Index.cshtml"
                   Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\09_Mvc_Proje1\DersBlogSite\Views\Dersler\Index.cshtml"
                   Write(item.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 35 "D:\Users\salih\source\repos\asp\4Nisan(Asp)\09_Mvc_Proje1\DersBlogSite\Views\Dersler\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("   </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DersBlogSite.Models.Lesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591

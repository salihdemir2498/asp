#pragma checksum "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc8099721151e26038732a5cea3b910689ebf0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentLesson_Assign), @"mvc.1.0.view", @"/Views/StudentLesson/Assign.cshtml")]
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
#line 1 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\_ViewImports.cshtml"
using StudentLesson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\_ViewImports.cshtml"
using StudentLesson.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc8099721151e26038732a5cea3b910689ebf0e", @"/Views/StudentLesson/Assign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fdfff0c336085222121fdd3a54630aa0edf33a", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentLesson_Assign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h5 class=\"display-4\">Assign Lesson</h5>\n<hr />\n<div class=\"row\">\n    <div class=\"col-md-4\">\n        <div class=\"form-group\">\n            <label class=\"col-form-label text-danger\">First Name: </label>\n            <label class=\"col-form-label\">");
#nullable restore
#line 8 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
                                     Write(Model.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n        </div>\n        <div class=\"form-group\">\n            <label class=\"col-form-label text-danger\">Last Name: </label>\n            <label class=\"col-form-label\">");
#nullable restore
#line 12 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
                                     Write(Model.StudentSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n        </div>\n        <div class=\"form-group\">\n            <label class=\"col-form-label text-danger\">Last Name: </label>\n            <label class=\"col-form-label\">");
#nullable restore
#line 16 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
                                     Write(Model.SectionLessons.Section.SectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n        </div>\n    </div>\n    <div class=\"col-md-8\">\n");
#nullable restore
#line 20 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
         for (int i = 0; i < Model.SelectedLessons.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 856, "\"", 891, 3);
            WriteAttributeValue("", 863, "SelectedCourses[", 863, 16, true);
#nullable restore
#line 22 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 879, i, 879, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 881, "].CourseId", 881, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 892, "\"", 934, 1);
#nullable restore
#line 22 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 900, Model.SelectedLessons[i].LessonId, 900, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 971, "\"", 1002, 3);
            WriteAttributeValue("", 978, "SelectedCourses[", 978, 16, true);
#nullable restore
#line 23 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 994, i, 994, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 996, "].Name", 996, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1003, "\"", 1047, 1);
#nullable restore
#line 23 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 1011, Model.SelectedLessons[i].LessonName, 1011, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 24 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
         foreach (var item in (List<Lesson>)ViewBag.lessons)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-check\">\n                <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1233, "\"", 1255, 1);
#nullable restore
#line 28 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 1241, item.LessonId, 1241, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"courseIds\"");
            BeginWriteAttribute("id", " id=\"", 1273, "\"", 1299, 2);
            WriteAttributeValue("", 1278, "course_", 1278, 7, true);
#nullable restore
#line 28 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 1285, item.LessonId, 1285, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 28 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
                                                                                                                               Write(Model.SelectedLessons.Any(x=>x.LessonId==item.LessonId)?"checked":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\n                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1423, "\"", 1450, 2);
            WriteAttributeValue("", 1429, "course_", 1429, 7, true);
#nullable restore
#line 29 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
WriteAttributeValue("", 1436, item.LessonId, 1436, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
                                                                       Write(item.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            </div>\n");
#nullable restore
#line 31 "D:\Users\salih\source\repos\asp\Asp-MVC\StudentLesson\studentlesson\Views\StudentLesson\Assign.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc410a487f1b48418ce392a038b4af65a7501984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_ViewAnsers), @"mvc.1.0.view", @"/Views/Question/ViewAnsers.cshtml")]
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
#line 1 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\_ViewImports.cshtml"
using QuestionTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\_ViewImports.cshtml"
using QuestionTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
using QuestionTask.Domain.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc410a487f1b48418ce392a038b4af65a7501984", @"/Views/Question/ViewAnsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065bac06f63d9e8a44fd15335a443c0815478702", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_ViewAnsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionSubmittDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <h5>Full Name:-</h5>\r\n               <h5> ");
#nullable restore
#line 8 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
               Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n             <div class=\"col-md-6\">\r\n                 <h5>Email :-</h5>\r\n                <h5> ");
#nullable restore
#line 12 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
         foreach(var item in @Model.QuestionDTOs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n");
#nullable restore
#line 22 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                 if(item.Type=="text")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
               Write(item.Answer);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                                
                }else{
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                     foreach(var o in item.Options)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                Write(o +" ,");

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                              
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\ViewAnsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionSubmittDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf947362995b827c407c1251a4de414fd6575cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Add), @"mvc.1.0.view", @"/Views/Question/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf947362995b827c407c1251a4de414fd6575cf", @"/Views/Question/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065bac06f63d9e8a44fd15335a443c0815478702", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ahsan\source\repos\QuestionTask\QuestionTask\Views\Question\Add.cshtml"
  
    ViewData["Title"] = "Add Quesrion";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h1>Add Question</h1>
    <div class=""row"">
    <div class=""col-md-6"">
         <div class=""form-group"">
    <label for=""exampleInputEmail1"">Question Title</label>
    <input type=""text"" class=""form-control"" id=""question-title"" aria-describedby=""emailHelp"" placeholder=""Question Title"">
   </div>
    </div>
     <div class=""col-md-6"">
         <div class=""form-group"">
    <label for=""exampleInputEmail1"">Question Type</label>
    <select class=""form-control"" id=""option-select"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf947362995b827c407c1251a4de414fd6575cf4697", async() => {
                WriteLiteral("Text");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf947362995b827c407c1251a4de414fd6575cf5862", async() => {
                WriteLiteral("CheckBok");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf947362995b827c407c1251a4de414fd6575cf7031", async() => {
                WriteLiteral("Radio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </select>
        
   </div>
    </div>
     
    </div>
    <div class=""row"">
        
         <div class=""form-group d-none"" id=""container"">
             <span class='option-container'>
          <label for=""exampleInputEmail1"">Option 1</label>
          <input type=""text"" class=""form-control"" id=""option-add-1"" aria-describedby=""emailHelp"" placeholder=""Question Title"">
              
        </span>   
      </div>
    </div>
    <div class=""btn-container d-none"">
<button class=""btn btn-primary"" id=""add-btn"">Add</button>
<button class=""btn btn-danger"" id=""add-rm"">Remove</button>
</div>
<div class=""row"">
    <div class=""col-md-12"" style=""
    float: right;
"">
    <button class=""btn btn-primary pull-right"" style=""
    float: right;
"" id=""save-btn"">Save</button>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script type=""text/javascript"">

        $(document).ready(function () {
           $('#option-select').change(function(){
               let select=$('#option-select').val()
               if(select!='text'){
                   $('#container').removeClass('d-none')
                   $('.btn-container').removeClass('d-none')

               }else{
                     $('.btn-container').addClass('d-none')
                     $('#container').addClass('d-none')
               }

               $('#add-btn').click(function(){
                   let cnt=+$('.option-container').length+1
                   $('#container').append(`<span class='option-container'>
          <label for=""exampleInputEmail1"">Option ${cnt}</label>
          <input type=""text"" class=""form-control"" id=""option-add-${cnt}"" aria-describedby=""emailHelp"" placeholder=""Option ${cnt}"">
            </span>`)
               })
           })
           $('#add-rm').click(function(){
               $('.option-contain");
                WriteLiteral(@"er').last().remove()

           })
           $('#save-btn').click(function(){
               let arry=[]
                let select=$('#option-select').val()
               if(select!='text'){
                   for(var i=0;i<$('.option-container').length;i++){
                       arry.push($(`.option-container #option-add-${i+1}`).val())
                   }
               
               }
               let obj={
                   type:$('#option-select').val(),
                   title:$('#question-title').val(),
                   options:arry

               }
                
        $.ajax({
            type: ""Post"", //HTTP POST Method
            url: '/Question/AddQuestion', // Controller/View,
            data:obj,

            success: function (response) {
                if(response.errorCode==0)
                {
                    alert(""Question Added"")
                    window.location = ""/"";
                }
                

            },
       ");
                WriteLiteral("     error: function (response) {\r\n                 \r\n            }\r\n        });\r\n        \r\n\r\n\r\n           })\r\n\r\n\r\n        });\r\n\r\n    </script>\r\n\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

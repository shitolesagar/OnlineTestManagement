#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "134ffa103fcebad519c91da2e94857d7a6c71338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result_Details), @"mvc.1.0.view", @"/Views/Result/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Result/Details.cshtml", typeof(AspNetCore.Views_Result_Details))]
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
#line 1 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\_ViewImports.cshtml"
using OnlineTestManagement;

#line default
#line hidden
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\_ViewImports.cshtml"
using OnlineTestManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"134ffa103fcebad519c91da2e94857d7a6c71338", @"/Views/Result/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Result_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.CandidateExamModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(111, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "134ffa103fcebad519c91da2e94857d7a6c713384084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(158, 252, true);
            WriteLiteral("\r\n\r\n<h2 style=\"color:red; margin-bottom:30px;\">Details</h2>\r\n<div class=\"row\">\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Candidate Name</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(412, 19, false);
#line 11 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.CandidateName);

#line default
#line hidden
            EndContext();
            BeginContext(432, 185, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Test Name</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(619, 14, false);
#line 15 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.TestName);

#line default
#line hidden
            EndContext();
            BeginContext(634, 215, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Started Time</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(851, 17, false);
#line 21 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.StartedTime);

#line default
#line hidden
            EndContext();
            BeginContext(869, 190, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Submitted Time</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(1061, 19, false);
#line 25 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.SubmittedTime);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 228, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Total Number Of Questions</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(1311, 28, false);
#line 31 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.TotalNumberOfQuestions);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 195, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Attempted Questions</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(1537, 24, false);
#line 35 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.AttemptedQuestions);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 218, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Correct Answers</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(1782, 20, false);
#line 41 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.CorrectAnswers);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 189, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"form-group mt-2 float-container position-relative col-md-6\">\r\n        <label class=\"control-label float-label\">Wrong Answers</label>\r\n        <p class=\"\"> ");
            EndContext();
            BeginContext(1994, 18, false);
#line 45 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                 Write(Model.WrongAnswers);

#line default
#line hidden
            EndContext();
            BeginContext(2013, 168, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Score</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(2183, 11, false);
#line 50 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2195, 299, true);
            WriteLiteral(@"</p>
</div>


<div id=""indexPartialContent"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Question</th>
                <th>Selected Answer</th>
                <th>Is Answer Correct</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 64 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             foreach (var obj in Model.list)
            {

#line default
#line hidden
            BeginContext(2555, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2602, 12, false);
#line 67 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                   Write(obj.Question);

#line default
#line hidden
            EndContext();
            BeginContext(2614, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2646, 18, false);
#line 68 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                   Write(obj.SelectedAnswer);

#line default
#line hidden
            EndContext();
            BeginContext(2664, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2696, 19, false);
#line 69 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
                   Write(obj.IsAnswerCorrect);

#line default
#line hidden
            EndContext();
            BeginContext(2715, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 71 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2760, 80, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<button type=\"button\" class=\"col-md-2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2840, "\"", 2895, 3);
            WriteAttributeValue("", 2850, "location.href=\'", 2850, 15, true);
#line 76 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
WriteAttributeValue("", 2865, Url.Action("Index","Result"), 2865, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2894, "\'", 2894, 1, true);
            EndWriteAttribute();
            BeginContext(2896, 76, true);
            WriteLiteral(" style=\"color:white; background-color:grey;\">Back To Index Page</button>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineTestManagement.Entities.ViewModels.CandidateExamModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3c2d71f03e77681d164c237acae2512e994dca"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3c2d71f03e77681d164c237acae2512e994dca", @"/Views/Result/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Result_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.CandidateExamModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(111, 174, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Candidate Name : </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(287, 19, false);
#line 9 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.CandidateName);

#line default
#line hidden
            EndContext();
            BeginContext(307, 162, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Test Name :</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(471, 14, false);
#line 13 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.TestName);

#line default
#line hidden
            EndContext();
            BeginContext(486, 165, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Started Time: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(653, 17, false);
#line 17 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.StartedTime);

#line default
#line hidden
            EndContext();
            BeginContext(671, 167, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Submitted Time: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(840, 19, false);
#line 21 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.SubmittedTime);

#line default
#line hidden
            EndContext();
            BeginContext(860, 178, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Total Number Of Questions: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1040, 28, false);
#line 25 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.TotalNumberOfQuestions);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 172, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Attempted Questions: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1243, 24, false);
#line 29 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.AttemptedQuestions);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 168, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Correct Answers: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1438, 20, false);
#line 33 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.CorrectAnswers);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 166, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Wrong Answers: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1627, 18, false);
#line 37 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.WrongAnswers);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 158, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Score: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1806, 11, false);
#line 41 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
             Write(Model.Score);

#line default
#line hidden
            EndContext();
            BeginContext(1818, 54, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<button type=\"button\" class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1872, "\"", 1927, 3);
            WriteAttributeValue("", 1882, "location.href=\'", 1882, 15, true);
#line 44 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Result\Details.cshtml"
WriteAttributeValue("", 1897, Url.Action("Index","Result"), 1897, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 1926, "\'", 1926, 1, true);
            EndWriteAttribute();
            BeginContext(1928, 32, true);
            WriteLiteral(">Back To Index Page</button>\r\n\r\n");
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

#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ec28b0b297ebdf19c87d47648a62b49e070fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_Details), @"mvc.1.0.view", @"/Views/Candidate/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidate/Details.cshtml", typeof(AspNetCore.Views_Candidate_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ec28b0b297ebdf19c87d47648a62b49e070fff", @"/Views/Candidate/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.CandidateDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(118, 171, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Test Name : </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(291, 10, false);
#line 10 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(302, 160, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">EmailId :</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(464, 13, false);
#line 14 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
             Write(Model.EmailId);

#line default
#line hidden
            EndContext();
            BeginContext(478, 166, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Mobile Number: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(646, 18, false);
#line 18 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
             Write(Model.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(665, 164, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Applied For: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(831, 16, false);
#line 22 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
             Write(Model.AppliedFor);

#line default
#line hidden
            EndContext();
            BeginContext(848, 157, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Test: </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(1007, 10, false);
#line 26 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
             Write(Model.Test);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 54, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<button type=\"button\" class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1072, "\"", 1130, 3);
            WriteAttributeValue("", 1082, "location.href=\'", 1082, 15, true);
#line 29 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\Details.cshtml"
WriteAttributeValue("", 1097, Url.Action("Index","Candidate"), 1097, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1129, "\'", 1129, 1, true);
            EndWriteAttribute();
            BeginContext(1131, 30, true);
            WriteLiteral(">Back To Index Page</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineTestManagement.Entities.ViewModels.CandidateDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a85927e1abdf3780207567b76be2a417e2b57a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Index), @"mvc.1.0.view", @"/Views/Question/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/Index.cshtml", typeof(AspNetCore.Views_Question_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a85927e1abdf3780207567b76be2a417e2b57a8", @"/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.QuestionWrapperViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_deletePopup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(115, 38, true);
            WriteLiteral("<button type=\"button\" class=\"col-md-2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 153, "\"", 206, 3);
            WriteAttributeValue("", 163, "location.href=\'", 163, 15, true);
#line 5 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
WriteAttributeValue("", 178, Url.Action("Index","Home"), 178, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 205, "\'", 205, 1, true);
            EndWriteAttribute();
            BeginContext(207, 114, true);
            WriteLiteral(">Back</button>\r\n<div class=\"row\">\r\n    <h1 class=\"col-md-4\">Index</h1>\r\n    <button type=\"button\" class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 321, "\"", 376, 3);
            WriteAttributeValue("", 331, "location.href=\'", 331, 15, true);
#line 8 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
WriteAttributeValue("", 346, Url.Action("Add","Question"), 346, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 375, "\'", 375, 1, true);
            EndWriteAttribute();
            BeginContext(377, 359, true);
            WriteLiteral(@">Add New Question</button>
</div>

<div id=""indexPartialContent"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th width=""20%"">Question</th>
                <th width=""20%"">Created By</th>
                <th width=""20%"" class=""text-center"">Manage</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
             foreach (var question in Model.QuestionList)
            {

#line default
#line hidden
            BeginContext(810, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(857, 17, false);
#line 24 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
                   Write(question.Question);

#line default
#line hidden
            EndContext();
            BeginContext(874, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(906, 18, false);
#line 25 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
                   Write(question.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(924, 118, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        <span title=\"Edit\" class=\"cursor-pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1042, "\"", 1097, 3);
            WriteAttributeValue("", 1052, "redirectToEdit(\'/Question/edit/", 1052, 31, true);
#line 27 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
WriteAttributeValue("", 1083, question.Id, 1083, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1095, "\')", 1095, 2, true);
            EndWriteAttribute();
            BeginContext(1098, 129, true);
            WriteLiteral("><i class=\"fa fa-pencil ml-3\" aria-hidden=\"true\"></i></span>\r\n                        <span title=\"Remove\" class=\"cursor-pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1227, "\"", 1273, 3);
            WriteAttributeValue("", 1237, "OpenDeleteConfirmBox(\'", 1237, 22, true);
#line 28 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
WriteAttributeValue("", 1259, question.Id, 1259, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1271, "\')", 1271, 2, true);
            EndWriteAttribute();
            BeginContext(1274, 111, true);
            WriteLiteral("><i class=\"fa fa-trash ml-3\" aria-hidden=\"true\"></i></span>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Question\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1400, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1442, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a85927e1abdf3780207567b76be2a417e2b57a88339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1473, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineTestManagement.Entities.ViewModels.QuestionWrapperViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

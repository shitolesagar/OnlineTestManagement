#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd32db7d992c7efd86de9a717ec4a253feb3f53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_StartTest), @"mvc.1.0.view", @"/Views/Candidate/StartTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidate/StartTest.cshtml", typeof(AspNetCore.Views_Candidate_StartTest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd32db7d992c7efd86de9a717ec4a253feb3f53", @"/Views/Candidate/StartTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_StartTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.TestDetailsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
  
    ViewData["Title"] = "StartTest";

#line default
#line hidden
            BeginContext(115, 58, true);
            WriteLiteral("\r\n<h1>Test</h1>\r\n\r\n<input type=\"text\" id=\"CandidateExamId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 173, "\"", 203, 1);
#line 8 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 181, Model.CandidateExamId, 181, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(204, 52, true);
            WriteLiteral(" />\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n");
            EndContext();
#line 10 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
      
        int i = 0;
    

#line default
#line hidden
            BeginContext(291, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 13 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
     foreach (var obj in Model.QuestionList)
    {
        i++;

#line default
#line hidden
            BeginContext(358, 218, true);
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\" id=\"headingOne\">\r\n                <h2 class=\"mb-0\">\r\n                    <button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(578, 14, false);
#line 19 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
                                                                                                Write("collapse" + i);

#line default
#line hidden
            EndContext();
            BeginContext(593, 77, true);
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                        ");
            EndContext();
            BeginContext(671, 12, false);
#line 20 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
                   Write(obj.Question);

#line default
#line hidden
            EndContext();
            BeginContext(683, 92, true);
            WriteLiteral("\r\n                    </button>\r\n                </h2>\r\n            </div>\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 775, "\"", 797, 1);
#line 24 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 780, "collapse" + i, 780, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(798, 176, true);
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordionExample\">\r\n                <div class=\"card-body\">\r\n                    <input type=\"text\" id=\"QuestionId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 974, "\"", 989, 1);
#line 26 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 982, obj.Id, 982, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(990, 25, true);
            WriteLiteral(" />\r\n                    ");
            EndContext();
            BeginContext(1015, 588, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd32db7d992c7efd86de9a717ec4a253feb3f536996", async() => {
                BeginContext(1021, 35, true);
                WriteLiteral("\r\n                        <fieldset");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1056, "\"", 1075, 1);
#line 28 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 1061, "group" + i, 1061, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1076, 76, true);
                WriteLiteral(">\r\n                            <input type=\"radio\" name=\"answer\" id=\"Option\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1152, "", 1171, 1);
#line 29 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 1159, obj.Option1, 1159, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1171, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1175, 11, false);
#line 29 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
                                                                                          Write(obj.Option1);

#line default
#line hidden
                EndContext();
                BeginContext(1186, 81, true);
                WriteLiteral("<br />\r\n                            <input type=\"radio\" name=\"answer\" id=\"Option\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1267, "", 1286, 1);
#line 30 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 1274, obj.Option2, 1274, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1286, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1290, 11, false);
#line 30 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
                                                                                          Write(obj.Option2);

#line default
#line hidden
                EndContext();
                BeginContext(1301, 81, true);
                WriteLiteral("<br />\r\n                            <input type=\"radio\" name=\"answer\" id=\"Option\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1382, "", 1401, 1);
#line 31 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 1389, obj.Option3, 1389, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1401, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1405, 11, false);
#line 31 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
                                                                                          Write(obj.Option3);

#line default
#line hidden
                EndContext();
                BeginContext(1416, 81, true);
                WriteLiteral("<br />\r\n                            <input type=\"radio\" name=\"answer\" id=\"Option\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1497, "", 1516, 1);
#line 32 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
WriteAttributeValue("", 1504, obj.Option4, 1504, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1516, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1520, 11, false);
#line 32 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
                                                                                          Write(obj.Option4);

#line default
#line hidden
                EndContext();
                BeginContext(1531, 65, true);
                WriteLiteral("<br />\r\n                        </fieldset>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1603, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 38 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
    }

#line default
#line hidden
            BeginContext(1672, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1700, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1707, 52, false);
#line 42 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Candidate\StartTest.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1759, 277, true);
                WriteLiteral(@"

    <script>
        var notificationType = $('input[type=radio][name=Type]:checked').val();
        $(document).ready(function () {

            console.log($(""#CandidateExamId"").val());
            console.log($(""#QuestionId"").val());

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(2039, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineTestManagement.Entities.ViewModels.TestDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
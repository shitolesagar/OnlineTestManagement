#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2213041bc7427a73de6f5031e88a113e4687abe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Details), @"mvc.1.0.view", @"/Views/Test/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Details.cshtml", typeof(AspNetCore.Views_Test_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2213041bc7427a73de6f5031e88a113e4687abe5", @"/Views/Test/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.TestDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(113, 171, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Test Name : </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(286, 10, false);
#line 10 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(297, 163, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Created By :</label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(462, 15, false);
#line 14 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
             Write(Model.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(478, 162, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group mt-2 float-container position-relative\">\r\n    <label class=\"control-label float-label\">Job Role : </label>\r\n    <p class=\"\"> ");
            EndContext();
            BeginContext(642, 13, false);
#line 18 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
             Write(Model.JobRole);

#line default
#line hidden
            EndContext();
            BeginContext(656, 63, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n");
            EndContext();
#line 22 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
       
        int i = 0;
    

#line default
#line hidden
            BeginContext(755, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 25 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
     foreach (var obj in Model.QuestionList)
    {
        i++;

#line default
#line hidden
            BeginContext(822, 202, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\" id=\"headingOne\">\r\n            <h2 class=\"mb-0\">\r\n                <button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(1026, 14, false);
#line 31 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
                                                                                            Write("collapse" + i);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 73, true);
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                    ");
            EndContext();
            BeginContext(1115, 12, false);
#line 32 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
               Write(obj.Question);

#line default
#line hidden
            EndContext();
            BeginContext(1127, 76, true);
            WriteLiteral("\r\n                </button>\r\n            </h2>\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1203, "\"", 1225, 1);
#line 36 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
WriteAttributeValue("", 1208, "collapse" + i, 1208, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1226, 163, true);
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordionExample\">\r\n            <div class=\"card-body\">\r\n                <ol>\r\n                    <li");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1389, "\"", 1458, 3);
            WriteAttributeValue("", 1397, "color:", 1397, 6, true);
#line 39 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
WriteAttributeValue("", 1403, obj.Option1 == obj.CorrectAnswer? "green":"#000000", 1403, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 1457, ";", 1457, 1, true);
            EndWriteAttribute();
            BeginContext(1459, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1461, 11, false);
#line 39 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
                                                                                         Write(obj.Option1);

#line default
#line hidden
            EndContext();
            BeginContext(1472, 30, true);
            WriteLiteral("</li>\r\n                    <li");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1502, "\"", 1571, 3);
            WriteAttributeValue("", 1510, "color:", 1510, 6, true);
#line 40 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
WriteAttributeValue("", 1516, obj.Option2 == obj.CorrectAnswer? "green":"#000000", 1516, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 1570, ";", 1570, 1, true);
            EndWriteAttribute();
            BeginContext(1572, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1574, 11, false);
#line 40 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
                                                                                         Write(obj.Option2);

#line default
#line hidden
            EndContext();
            BeginContext(1585, 30, true);
            WriteLiteral("</li>\r\n                    <li");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1615, "\"", 1684, 3);
            WriteAttributeValue("", 1623, "color:", 1623, 6, true);
#line 41 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
WriteAttributeValue("", 1629, obj.Option3 == obj.CorrectAnswer? "green":"#000000", 1629, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 1683, ";", 1683, 1, true);
            EndWriteAttribute();
            BeginContext(1685, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1687, 11, false);
#line 41 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
                                                                                         Write(obj.Option3);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 30, true);
            WriteLiteral("</li>\r\n                    <li");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1728, "\"", 1797, 3);
            WriteAttributeValue("", 1736, "color:", 1736, 6, true);
#line 42 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
WriteAttributeValue("", 1742, obj.Option4 == obj.CorrectAnswer? "green":"#000000", 1742, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 1796, ";", 1796, 1, true);
            EndWriteAttribute();
            BeginContext(1798, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1800, 11, false);
#line 42 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
                                                                                         Write(obj.Option4);

#line default
#line hidden
            EndContext();
            BeginContext(1811, 78, true);
            WriteLiteral("</li>\r\n                </ol>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 47 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1896, 48, true);
            WriteLiteral("</div>\r\n\r\n<button type=\"button\" class=\"col-md-4\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1944, "\"", 1997, 3);
            WriteAttributeValue("", 1954, "location.href=\'", 1954, 15, true);
#line 50 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Details.cshtml"
WriteAttributeValue("", 1969, Url.Action("Index","Test"), 1969, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1996, "\'", 1996, 1, true);
            EndWriteAttribute();
            BeginContext(1998, 32, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineTestManagement.Entities.ViewModels.TestDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

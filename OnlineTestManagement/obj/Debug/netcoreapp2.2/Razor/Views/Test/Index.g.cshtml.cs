#pragma checksum "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "930554befd2e71f1fa6f325326847804b90975fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Index.cshtml", typeof(AspNetCore.Views_Test_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930554befd2e71f1fa6f325326847804b90975fa", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e2cfb4779c270f9a626a4849989543c652b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineTestManagement.Entities.ViewModels.TestWrapperViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_deletePopup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(111, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "930554befd2e71f1fa6f325326847804b90975fa4837", async() => {
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
            BeginContext(158, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(160, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "930554befd2e71f1fa6f325326847804b90975fa6089", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 138, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h2 class=\"col-md-6\" style=\"color:red;\">Test</h2>\r\n    <i title=\"Add New Test\" class=\"fa fa-plus-circle col-md-6\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 334, "\"", 385, 3);
            WriteAttributeValue("", 344, "location.href=\'", 344, 15, true);
#line 9 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
WriteAttributeValue("", 359, Url.Action("Add","Test"), 359, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 384, "\'", 384, 1, true);
            EndWriteAttribute();
            BeginContext(386, 254, true);
            WriteLiteral(" aria-hidden=\"true\" style=\"font-size:40px; color:red; text-align:right; cursor:pointer;\"></i>\r\n</div>\r\n\r\n<div id=\"indexPartialContent\">\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th width=\"40%\">Name</th>\r\n");
            EndContext();
            BeginContext(693, 119, true);
            WriteLiteral("                <th width=\"20%\" class=\"text-center\">Manage</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 22 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
             foreach (var test in Model.TestList)
            {

#line default
#line hidden
            BeginContext(878, 65, true);
            WriteLiteral("                <tr style=\"background : #ececec; cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 943, "\'", 1029, 5);
            WriteAttributeValue("", 953, "window.location.href", 953, 20, true);
            WriteAttributeValue(" ", 973, "=", 974, 2, true);
            WriteAttributeValue(" ", 975, "\"", 976, 2, true);
#line 24 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
WriteAttributeValue("", 977, Url.Action("Details", "Test", new { id = test.Id}), 977, 51, false);

#line default
#line hidden
            WriteAttributeValue("", 1028, "\"", 1028, 1, true);
            EndWriteAttribute();
            BeginContext(1030, 27, true);
            WriteLiteral(">\r\n                    <td>");
            EndContext();
            BeginContext(1058, 9, false);
#line 25 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
                   Write(test.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1669, 46, true);
            WriteLiteral("                    <td class=\"text-center\">\r\n");
            EndContext();
            BeginContext(1871, 44, true);
            WriteLiteral("                        <span title=\"Remove\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1915, "\"", 1964, 3);
            WriteAttributeValue("", 1925, "redirectToEdit(\'/Test/delete/", 1925, 29, true);
#line 32 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
WriteAttributeValue("", 1954, test.Id, 1954, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1962, "\')", 1962, 2, true);
            EndWriteAttribute();
            BeginContext(1965, 116, true);
            WriteLiteral("><i class=\"fa fa-trash ml-3 f-16\" aria-hidden=\"true\"></i></span>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2096, 124, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<button type=\"button\" class=\"col-md-2\" style=\"color:white; background-color:gray;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2220, "\"", 2273, 3);
            WriteAttributeValue("", 2230, "location.href=\'", 2230, 15, true);
#line 40 "E:\@Saggy\Projects\OnlineTestManagement\OnlineTestManagement\Views\Test\Index.cshtml"
WriteAttributeValue("", 2245, Url.Action("Index","Home"), 2245, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 2272, "\'", 2272, 1, true);
            EndWriteAttribute();
            BeginContext(2274, 28, true);
            WriteLiteral(">Go To HomePage</button>\r\n\r\n");
            EndContext();
            BeginContext(2302, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "930554befd2e71f1fa6f325326847804b90975fa11904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2333, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2335, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "930554befd2e71f1fa6f325326847804b90975fa13161", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2371, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineTestManagement.Entities.ViewModels.TestWrapperViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

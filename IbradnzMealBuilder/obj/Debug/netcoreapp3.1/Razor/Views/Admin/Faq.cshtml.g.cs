#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f378a513fa5840a3d9e20acbbe776c43a65231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Faq), @"mvc.1.0.view", @"/Views/Admin/Faq.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Faq.cshtml", typeof(AspNetCore.Views_Admin_Faq))]
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
#line 1 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\_ViewImports.cshtml"
using IbradnzMealBuilder;

#line default
#line hidden
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\_ViewImports.cshtml"
using IbradnzMealBuilder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f378a513fa5840a3d9e20acbbe776c43a65231", @"/Views/Admin/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.ViewFaqAdminModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-primary-btn mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addFaq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm custom-secondary-btn float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFaq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFaq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
  
    ViewData["Title"] = "faq";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";
    ViewData["Header"] = "Faq".ToUpper();

#line default
#line hidden
            BeginContext(195, 105, true);
            WriteLiteral("<div class=\"font-family-poppins-medium\">\r\n    <div>\r\n        <div style=\"text-align:right\">\r\n            ");
            EndContext();
            BeginContext(300, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5f378a513fa5840a3d9e20acbbe776c43a652315236", async() => {
                BeginContext(359, 11, true);
                WriteLiteral("add new faq");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(374, 495, true);
            WriteLiteral(@"
        </div>
    </div>

    <div class=""card box-shadow bg-white"">
        <div class=""card-body"">
            <div class=""font-h1"">
                unanswered Question
            </div>
            <table class=""table table-responsive-sm"">
                <thead class=""font-h2"">
                    <tr>
                        <th>Question</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody class=""font-b1"">
");
            EndContext();
#line 27 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                     foreach (var faq in Model.UnAnsweredQuestions)
                    {
                        var answer = faq.Answer.Length > 20 ? faq.Answer.Substring(0, 20) + "..." : faq.Answer;
                        var question = faq.Question.Length > 20 ? faq.Question.Substring(0, 20) + "..." : faq.Question;

#line default
#line hidden
            BeginContext(1195, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1258, 8, false);
#line 32 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                           Write(question);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1339, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5f378a513fa5840a3d9e20acbbe776c43a652318224", async() => {
                BeginContext(1438, 6, true);
                WriteLiteral("Answer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                                                                                                              WriteLiteral(faq.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1448, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                    }

#line default
#line hidden
            BeginContext(1539, 636, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>

    <div class=""card box-shadow bg-white my-5"">
        <div class=""card-header"">
            <div class=""font-h1"">
                Answered Question
            </div>
        </div>
        <div class=""card-body"">
            <table class=""table table-responsive-sm"">
                <thead class=""font-h2"">
                    <tr>
                        <th>Question</th>
                        <th>Answer</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody class=""font-b1"">
");
            EndContext();
#line 59 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                     foreach (var faq in Model.AnsweredQuestions)
                    {
                        var answer = faq.Answer.Length > 20 ? faq.Answer.Substring(0, 20) + "..." : faq.Answer;
                        var question = faq.Question.Length > 20 ? faq.Question.Substring(0, 20) + "..." : faq.Question;

#line default
#line hidden
            BeginContext(2499, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2562, 8, false);
#line 64 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                           Write(question);

#line default
#line hidden
            EndContext();
            BeginContext(2570, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2610, 6, false);
#line 65 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                           Write(answer);

#line default
#line hidden
            EndContext();
            BeginContext(2616, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2689, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5f378a513fa5840a3d9e20acbbe776c43a6523113062", async() => {
                BeginContext(2788, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                                                                                                              WriteLiteral(faq.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2796, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\Faq.cshtml"
                    }

#line default
#line hidden
            BeginContext(2887, 86, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.ViewFaqAdminModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

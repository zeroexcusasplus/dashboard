#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a795d1875defe3984814e25dd8dcabe8d665fd4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LiveZooms), @"mvc.1.0.view", @"/Views/Admin/LiveZooms.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/LiveZooms.cshtml", typeof(AspNetCore.Views_Admin_LiveZooms))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a795d1875defe3984814e25dd8dcabe8d665fd4b", @"/Views/Admin/LiveZooms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_LiveZooms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IbradnzMealBuilder.Models.ViewLiveZoomModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-primary-btn mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddLiveZoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeLiveStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn py-0 custom-secondary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn py-0 custom-primary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
  
    ViewData["Title"] = "Live zoom";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";
    ViewData["Header"] = "Zoom en vivo".ToUpper();

#line default
#line hidden
            BeginContext(223, 88, true);
            WriteLiteral("\r\n<div class=\"font-family-poppins-medium\">\r\n    <div style=\"text-align:right\">\r\n        ");
            EndContext();
            BeginContext(311, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a795d1875defe3984814e25dd8dcabe8d665fd4b5663", async() => {
                BeginContext(375, 22, true);
                WriteLiteral("Add new live zoom link");
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
            BeginContext(401, 413, true);
            WriteLiteral(@"
    </div>
    <div class=""card box-shadow"">
        <div class=""card-body"">
            <h5>Zoom links</h5>
            <table class=""table table-responsive-sm"">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Live</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 24 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                     foreach (var liveZoom in Model)
                    {

#line default
#line hidden
            BeginContext(891, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(954, 14, false);
#line 27 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                           Write(liveZoom.Title);

#line default
#line hidden
            EndContext();
            BeginContext(968, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 29 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                 if (liveZoom.IsLive)
                                {

#line default
#line hidden
            BeginContext(1099, 65, true);
            WriteLiteral("                                    <span>Currently live</span>\r\n");
            EndContext();
#line 32 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1272, 69, true);
            WriteLiteral("                                    <span>Not currently live</span>\r\n");
            EndContext();
#line 36 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                }

#line default
#line hidden
            BeginContext(1376, 69, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 39 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                 if (liveZoom.IsLive)
                                {

#line default
#line hidden
            BeginContext(1535, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1571, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a795d1875defe3984814e25dd8dcabe8d665fd4b9783", async() => {
                BeginContext(1693, 93, true);
                WriteLiteral("\r\n                                        para no vivir\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                                                                              WriteLiteral(liveZoom.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1790, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1900, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1936, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a795d1875defe3984814e25dd8dcabe8d665fd4b12924", async() => {
                BeginContext(2056, 90, true);
                WriteLiteral("\r\n                                        para vivir\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                                                                              WriteLiteral(liveZoom.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                                }

#line default
#line hidden
            BeginContext(2187, 50, true);
            WriteLiteral("                                <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2237, "\"", 2258, 1);
#line 51 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
WriteAttributeValue("", 2244, liveZoom.Link, 2244, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2259, 119, true);
            WriteLiteral(" class=\"btn btn-sm custom-primary-btn py-0\">Ver</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\LiveZooms.cshtml"
                    }

#line default
#line hidden
            BeginContext(2401, 159, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<style>\r\n    .card {\r\n        margin-bottom: 30px;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IbradnzMealBuilder.Models.ViewLiveZoomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56454688f11b7f61393d4df9d1805707f93aab90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TrainingDays), @"mvc.1.0.view", @"/Views/Admin/TrainingDays.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/TrainingDays.cshtml", typeof(AspNetCore.Views_Admin_TrainingDays))]
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
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
using IbradnzMealBuilder.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56454688f11b7f61393d4df9d1805707f93aab90", @"/Views/Admin/TrainingDays.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TrainingDays : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IbradnzMealBuilder.Models.ViewTrainingDayModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm custom-secondary-btn py-0 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTrainingDay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
  
    ViewData["Title"] = "Training days";
    ViewData["Header"] = "Tranining days".ToUpper();
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(267, 1483, true);
            WriteLiteral(@"

<div id=""sidenav"" class=""sidenav"">
    <a href=""javascript:void(0)"" class=""closebtn"" onclick=""CloseSidenav()"">&times;</a>
    <div id=""sidebarbody"" class=""sidebarbody""></div>
</div>
<style>
    /*sidenav*/
    .sidenav {
        height: 100%;
        width: 0;
        position: fixed;
        z-index: 2000;
        top: 0;
        right: 0;
        background-color: white;
        overflow-x: hidden;
        transition: 0.3s;
        padding-top: 60px;
    }

    .sideNavBorder {
        border: 1px solid black;
    }

    .closebtn {
        padding: 8px 8px 8px 32px;
        text-decoration: none;
        font-size: 25px;
        color: #818181;
        display: block;
        transition: 0.3s;
    }

        .closebtn:hover {
            color: #dc3545;
        }

    .sidenav .closebtn {
        position: absolute;
        top: 0;
        right: 25px;
        font-size: 36px;
        margin-left: 50px;
    }
</style>

<div class=""card box-shadow font-family");
            WriteLiteral(@"-poppins-medium"">
    <div class=""card-body"">

        <h5>Training days</h5>
        <table class=""table table-responsive-sm"">
            <thead>
                <tr>
                    <th>Type</th>
                    <th>Training program</th>
                    <th>Week</th>
                    <th>Day</th>
                    <th>Name</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 71 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                 foreach (var day in Model)
                {

#line default
#line hidden
            BeginContext(1814, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1869, 23, false);
#line 74 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                       Write(day.TraininigTypeString);

#line default
#line hidden
            EndContext();
            BeginContext(1892, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1928, 19, false);
#line 75 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                       Write(day.TrainingProgram);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1983, 8, false);
#line 76 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                       Write(day.Week);

#line default
#line hidden
            EndContext();
            BeginContext(1991, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2027, 7, false);
#line 77 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                       Write(day.Day);

#line default
#line hidden
            EndContext();
            BeginContext(2034, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2070, 8, false);
#line 78 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                       Write(day.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2078, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2143, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56454688f11b7f61393d4df9d1805707f93aab908564", async() => {
                BeginContext(2271, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                                                                                                                                       WriteLiteral(day.Id);

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
            BeginContext(2281, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 83 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TrainingDays.cshtml"
                }

#line default
#line hidden
            BeginContext(2360, 421, true);
            WriteLiteral(@"            </tbody>
        </table>

    </div>
</div>
<style>
    .training-header-card-img {
        height: 50px;
        width: 50px;
        border-radius: 50%;
    }

    .training-header-text {
        font-size: 12px;
    }

    .training-card {
        min-width: 200px;
        max-width: 500px
    }

    .training-video {
        width: 100%;
        height: 135px;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IbradnzMealBuilder.Models.ViewTrainingDayModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

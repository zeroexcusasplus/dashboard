#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c04afb264654e35cf2f6d6f2280ca801f1640d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TechniqueVideos), @"mvc.1.0.view", @"/Views/Admin/TechniqueVideos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/TechniqueVideos.cshtml", typeof(AspNetCore.Views_Admin_TechniqueVideos))]
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
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
using IbradnzMealBuilder.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c04afb264654e35cf2f6d6f2280ca801f1640d", @"/Views/Admin/TechniqueVideos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TechniqueVideos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.AdminTechniqueVideosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTechniqueVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-secondary-btn my-3 btn-sm mx-auto font-family-poppins-medium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm custom-secondary-btn py-0 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTechniqueVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
  
    ViewData["Title"] = "Técnica y tutoriales";
    ViewData["Header"] = "Técnica y tutoriales".ToUpper();
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(276, 223, true);
            WriteLiteral("\r\n\r\n<div id=\"sidenav\" class=\"sidenav\">\r\n    <a href=\"javascript:void(0)\" class=\"closebtn\" onclick=\"CloseSidenav()\">&times;</a>\r\n    <div id=\"sidebarbody\" class=\"sidebarbody\"></div>\r\n</div>\r\n\r\n<div class=\"text-center\">\r\n    ");
            EndContext();
            BeginContext(499, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d6939", async() => {
                BeginContext(636, 16, true);
                WriteLiteral("Add new training");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(656, 105, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"card box-shadow font-family-poppins-medium\">\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(761, 1092, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d8725", async() => {
                BeginContext(767, 136, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3\">\r\n                    <label>Muscle</label>\r\n                    ");
                EndContext();
                BeginContext(903, 693, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d9253", async() => {
                    BeginContext(956, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(982, 30, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d9681", async() => {
                        BeginContext(1000, 3, true);
                        WriteLiteral("All");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1012, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 26 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                         foreach (var muscleGroup in Model.MuscleGroups)
                        {
                            if (muscleGroup.Id == Model.MuscleGroupId)
                            {

#line default
#line hidden
                    BeginContext(1218, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                    BeginContext(1250, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d11722", async() => {
                        BeginContext(1292, 16, false);
#line 30 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                                                                    Write(muscleGroup.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 30 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                                   WriteLiteral(muscleGroup.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1317, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 31 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                    BeginContext(1415, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                    BeginContext(1447, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d14626", async() => {
                        BeginContext(1480, 16, false);
#line 34 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                                                           Write(muscleGroup.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 34 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                                   WriteLiteral(muscleGroup.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1505, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 35 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                            }

                        }

#line default
#line hidden
                    BeginContext(1567, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 24 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MuscleGroupId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1596, 250, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <input id=\"submit-button\" type=\"submit\" value=\"filter\" class=\"btn py-0 custom-primary-btn admin-filter-btn\" />\r\n                </div>\r\n            </div>\r\n        ");
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
            BeginContext(1853, 376, true);
            WriteLiteral(@"
        <h5>Técnica y tutoriales</h5>
        <table class=""table table-responsive-sm"">
            <thead>
                <tr>
                    <th>Order</th>
                    <th>Title</th>
                    <th>Muscle</th>
                    <th>View</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 57 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                 foreach (var video in Model.TechniqueVideos)
                {

#line default
#line hidden
            BeginContext(2311, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2366, 11, false);
#line 60 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                       Write(video.Order);

#line default
#line hidden
            EndContext();
            BeginContext(2377, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2413, 11, false);
#line 61 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                       Write(video.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2424, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2460, 21, false);
#line 62 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                       Write(video.MuscleGroupName);

#line default
#line hidden
            EndContext();
            BeginContext(2481, 133, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <p class=\"font-weight-500 mb-0\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2614, "\"", 2648, 1);
#line 65 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
WriteAttributeValue("", 2621, Url.Content(video.UrlPath), 2621, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2649, 189, true);
            WriteLiteral(" target=\"_blank\" style=\"text-decoration:underline\">Ver video</a>\r\n                            </p>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2838, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c04afb264654e35cf2f6d6f2280ca801f1640d22548", async() => {
                BeginContext(2971, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                                                                                                                                          WriteLiteral(video.Id);

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
            BeginContext(2981, 99, true);
            WriteLiteral("\r\n                            <button class=\"btn btn-sm custom-primary-btn py-0 ml-2\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3080, "\"", 3121, 3);
            WriteAttributeValue("", 3090, "DeleteTechniqueVideo(", 3090, 21, true);
#line 70 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
WriteAttributeValue("", 3111, video.Id, 3111, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3120, ")", 3120, 1, true);
            EndWriteAttribute();
            BeginContext(3122, 142, true);
            WriteLiteral(">\r\n                                Eliminar\r\n                            </button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 75 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Admin\TechniqueVideos.cshtml"
                }

#line default
#line hidden
            BeginContext(3283, 2039, true);
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
            color");
            WriteLiteral(@": #dc3545;
        }

    .sidenav .closebtn {
        position: absolute;
        top: 0;
        right: 25px;
        font-size: 36px;
        margin-left: 50px;
    }
</style>

<script>
    function DeleteTechniqueVideo(id) {
        console.log(id);
        $.ajax({
            url: ""/Admin/DeleteTechniqueVideo/"" + id,
            dataType: ""html"",
            data: {},
            success: function (result) {
                $(""#sidebarbody"").html(result);
                OpenSidenav();
            },
            error: function (xhr, status, error) {

            }
        });
    }


    function OpenSidenav() {
        var sideNav = document.getElementById(""sidenav"");
        sideNav.style.width = ""300px"";
        sideNav.classList.add(""sideNavBorder"");
    }

    function CloseSidenav() {
        var sideNav = document.getElementById(""sidenav"");
        sideNav.style.width = ""0"";
        sideNav.classList.remove(""sideNavBorder"");
    }


</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.AdminTechniqueVideosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\LiveZoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001377fd10f0250d881eaa6e29f963361b21e1f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_LiveZoom), @"mvc.1.0.view", @"/Views/Training/LiveZoom.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/LiveZoom.cshtml", typeof(AspNetCore.Views_Training_LiveZoom))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001377fd10f0250d881eaa6e29f963361b21e1f4", @"/Views/Training/LiveZoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_LiveZoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IbradnzMealBuilder.Models.ViewLiveZoomModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TrainingType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\LiveZoom.cshtml"
  
    ViewData["Title"] = "ENTRENAMIENTO EN CASA".ToLower();
    ViewData["Header"] = "ENTRENAMIENTO EN CASA";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";
    ViewData["PageType"] = "Training";

#line default
#line hidden
            BeginContext(279, 70, true);
            WriteLiteral("\r\n<input id=\"active-page\" value=\"training-page\" hidden />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(349, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "001377fd10f0250d881eaa6e29f963361b21e1f43997", async() => {
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
            BeginContext(381, 878, true);
            WriteLiteral(@"
    <div class=""mx-auto training-card mt-2 pt-2 font-family-poppins-medium my-5"">
        <div class=""row p-2"">
            <div class=""col-6"">
                <video controls=""controls"" class=""w-100"" style=""height:100px"">
                    <source src="""" type=""video/mp4"" />
                </video>
            </div>
            <div class=""col-6"">
                <div class=""font-weight-bold"">
                    SESION EN VIVO VIA ZOOM
                </div>
                <div style=""font-size:13px"">
                    12 weeks program
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""mx-auto dark-grey-background training-card mt-2 pt-2 font-family-poppins-medium p-2"">
    <div style=""font-size:20px"" class=""font-weight-bold"">SESION EN VIVO VIA ZOOM</div>

    <div>
        Paragraph
    </div>
");
            EndContext();
#line 37 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\LiveZoom.cshtml"
     foreach (var liveZoom in Model)
    {

#line default
#line hidden
            BeginContext(1304, 71, true);
            WriteLiteral("        <div class=\"my-3\">\r\n            <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(1376, 14, false);
#line 40 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\LiveZoom.cshtml"
                                      Write(liveZoom.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 97, true);
            WriteLiteral("</span>\r\n            <span>\r\n                <a target=\"_blank\" style=\"text-decoration:underline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1487, "\"", 1508, 1);
#line 42 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\LiveZoom.cshtml"
WriteAttributeValue("", 1494, liveZoom.Link, 1494, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1509, 65, true);
            WriteLiteral(">Únete al zoom en vivo</a>\r\n            </span>\r\n        </div>\r\n");
            EndContext();
#line 45 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\LiveZoom.cshtml"
    }

#line default
#line hidden
            BeginContext(1581, 6, true);
            WriteLiteral("</div>");
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
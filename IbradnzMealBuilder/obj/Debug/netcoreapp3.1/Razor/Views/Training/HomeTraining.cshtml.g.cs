#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc54a83d46254346e5917d6edcff7db1099378b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_HomeTraining), @"mvc.1.0.view", @"/Views/Training/HomeTraining.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/HomeTraining.cshtml", typeof(AspNetCore.Views_Training_HomeTraining))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc54a83d46254346e5917d6edcff7db1099378b3", @"/Views/Training/HomeTraining.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_HomeTraining : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.HomeTrainingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TrainingType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Training", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LiveZoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HomeTrainingProgram", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml"
  
    ViewData["Title"] = "MI ENTRENAMIENTO".ToLower();
    ViewData["Header"] = "MI ENTRENAMIENTO";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";
    ViewData["PageType"] = "Training";

#line default
#line hidden
            BeginContext(256, 70, true);
            WriteLiteral("\r\n<input id=\"active-page\" value=\"training-page\" hidden />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(326, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc54a83d46254346e5917d6edcff7db1099378b35725", async() => {
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
            BeginContext(358, 238, true);
            WriteLiteral("\r\n    <div style=\"text-align:center;font-weight:500\" class=\"text-white my-2\">\r\n        <div style=\"margin-top:10px;text-align:left\" class=\"d-sm-block d-md-none d-lg-none d-xl-none font-b2\">\r\n            <i class=\"fas fa-arrow-left\"></i>  ");
            EndContext();
            BeginContext(596, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc54a83d46254346e5917d6edcff7db1099378b37231", async() => {
                BeginContext(650, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(660, 856, true);
            WriteLiteral(@"
        </div>
        <div class=""font-b1 text-uppercase"">Programas de Entrenamiento</div>
        <div class=""font-b2"">
            Inicia el Programa de Entrenamiento que quieras acorde a tu nivel y tu meta
        </div>
    </div>
    <div class=""mx-auto training-card mt-2 pt-2 font-b1"">

        <div class=""row p-2"">
            <div class=""col-6"">
                <video controls=""controls"" class=""w-100"" style=""height:100px"">
                    <source src="""" type=""video/mp4"" />
                </video>
            </div>
            <div class=""col-6"">
                <div class=""font-b1"">
                    SESION EN VIVO VIA ZOOM
                </div>
                <div class=""font-b2"">
                    12 weeks program
                </div>
                <div class=""text-center"">
                    ");
            EndContext();
            BeginContext(1516, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc54a83d46254346e5917d6edcff7db1099378b39568", async() => {
                BeginContext(1567, 68, true);
                WriteLiteral("\r\n                        INICIA ESTE PROGRAMA\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1639, 64, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
#line 44 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml"
         foreach (var program in Model.Programs)
        {
            string youtubeEmbededUrl = "https://youtube.com/embed/" + program.PreviewYoutubeLink;

#line default
#line hidden
            BeginContext(1863, 117, true);
            WriteLiteral("            <div class=\"row p-2\">\r\n                <div class=\"col-6\">\r\n                    <iframe id=\"YouTubevideo\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1980, "\"", 2004, 1);
#line 49 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml"
WriteAttributeValue("", 1986, youtubeEmbededUrl, 1986, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2005, 198, true);
            WriteLiteral(" width=\"100%\" height=\"100\" frameborder=\"0\" allowfullscreen></iframe>\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <div class=\"font-b1\">\r\n                        ");
            EndContext();
            BeginContext(2204, 12, false);
#line 53 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml"
                   Write(program.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2216, 214, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"font-b2\">\r\n                        12 weeks program\r\n                    </div>\r\n                    <div class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(2430, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc54a83d46254346e5917d6edcff7db1099378b313004", async() => {
                BeginContext(2519, 76, true);
                WriteLiteral("\r\n                            INICIA ESTE PROGRAMA\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml"
                                                                                        WriteLiteral(program.Id);

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
            BeginContext(2599, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 65 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\HomeTraining.cshtml"
        }

#line default
#line hidden
            BeginContext(2684, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.HomeTrainingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

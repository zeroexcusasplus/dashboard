#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd017ef80c12143635c81520a8f0e380cd1312f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscribe__SubPlanDetails), @"mvc.1.0.view", @"/Views/Subscribe/_SubPlanDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subscribe/_SubPlanDetails.cshtml", typeof(AspNetCore.Views_Subscribe__SubPlanDetails))]
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
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
using IbradnzMealBuilder.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd017ef80c12143635c81520a8f0e380cd1312f", @"/Views/Subscribe/_SubPlanDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscribe__SubPlanDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.SubscriptionPlanModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 font-b2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#e9e9ec;border:none;opacity:0;position:relative;top:-23px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("ChangeSubPlan()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "subscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-secondary-btn font-b1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "termsofuse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-b2 text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "faq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "contactus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(258, 178, true);
            WriteLiteral("<div class=\"card subscription-selection-card\" style=\"background-color:#e9e9ec;border-radius:10px\">\r\n    <div class=\"row p-2\">\r\n        <div class=\"col-7 pr-0\">\r\n            <div>");
            EndContext();
            BeginContext(437, 14, false);
#line 17 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
            Write(Model.PlanName);

#line default
#line hidden
            EndContext();
            BeginContext(451, 41, true);
            WriteLiteral("</div>\r\n            <div class=\"font-b2\">");
            EndContext();
            BeginContext(493, 22, false);
#line 18 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
                            Write(Model.PriceDescription);

#line default
#line hidden
            EndContext();
            BeginContext(515, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(677, 188, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-5 pl-0\">\r\n            <div id=\"changeplan\" class=\"font-b2\" style=\"text-align:right;cursor:pointer\">\r\n                Cambiar\r\n            </div>\r\n");
            EndContext();
            BeginContext(956, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(968, 275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd017ef80c12143635c81520a8f0e380cd1312f9146", async() => {
                BeginContext(1220, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 33 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Plan);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<SubscriptionPlan>();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1243, 76, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"form-group\">\r\n\r\n</div>\r\n\r\n");
            EndContext();
#line 44 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
 if (Model.Plan == SubscriptionPlan.Yearly)
{

#line default
#line hidden
            BeginContext(1367, 1519, true);
            WriteLiteral(@"    <div class=""font-b1"">
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Acceso total al constructor de comidas</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Soporte y Asesoría 24/7</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Control de tu progreso mensual</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Rutinas con vídeos para cada ejercicio</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%");
            WriteLiteral(@""">Entrenamiento guiado en vivo vía Zoom</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Edición de tus macronutrientes</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Sólo $ 19,99/mes  cargado anual</span>
        </div>
    </div>
");
            EndContext();
#line 76 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"

}
else if (Model.Plan == SubscriptionPlan.Monthly)
{

#line default
#line hidden
            BeginContext(2944, 1131, true);
            WriteLiteral(@"    <div class=""font-b1"">
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Acceso total al Constructor de comida</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Soporte y Asesoría 24/7</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Control de tu progreso mensual</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%"">Rutinas con vídeos para cada ejercicio</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""width:85%""");
            WriteLiteral(">Entrenamiento guiado en vivo vía Zoom</span>\r\n        </div>\r\n        <div class=\"row mx-0 sub-details\">\r\n");
            EndContext();
            BeginContext(4239, 426, true);
            WriteLiteral(@"            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""color: #717173;width:85%"">Edición de tus macronutrientes</span>
        </div>
        <div class=""row mx-0 sub-details"">
            <span style=""width:35px""><i class=""fas fa-check""></i></span>
            <span style=""color: #717173;width:85%"">Sólo $ 39,99/mes  cancela cuando quieras</span>
        </div>
    </div>
");
            EndContext();
#line 113 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
}



#line default
#line hidden
            BeginContext(6707, 38, true);
            WriteLiteral("\r\n<div class=\"text-center mt-4\">\r\n    ");
            EndContext();
            BeginContext(6745, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd017ef80c12143635c81520a8f0e380cd1312f15869", async() => {
                BeginContext(6893, 8, true);
                WriteLiteral("Continúa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-plan", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
                                                       WriteLiteral(Model.Plan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plan"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-plan", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plan"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6905, 71, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"font-b2 text-center\" style=\"margin-top:20px\">\r\n");
            EndContext();
#line 165 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
     if (Model.Plan == SubscriptionPlan.Yearly)
    {

#line default
#line hidden
            BeginContext(7032, 119, true);
            WriteLiteral("        <div>Prueba gratis, si no es para tí </div>\r\n        <div>puedes cancelar durante el período de prueba.</div>\r\n");
            EndContext();
#line 169 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
    }
    else if (Model.Plan == SubscriptionPlan.Monthly)
    {

#line default
#line hidden
            BeginContext(7219, 124, true);
            WriteLiteral("        <div>\r\n            <div>Sólo $39,99/mes</div>\r\n            <div>Cancela en cualquier momento</div>\r\n        </div>\r\n");
            EndContext();
#line 176 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Subscribe\_SubPlanDetails.cshtml"
    }
    

#line default
#line hidden
            BeginContext(7523, 89, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"row\" style=\"margin-top:20px;\">\r\n    <div class=\"col-5 text-center\">");
            EndContext();
            BeginContext(7612, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd017ef80c12143635c81520a8f0e380cd1312f19899", async() => {
                BeginContext(7690, 22, true);
                WriteLiteral("Términos y condiciones");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7716, 44, true);
            WriteLiteral("</div>\r\n    <div class=\"col-2 text-center\"> ");
            EndContext();
            BeginContext(7760, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd017ef80c12143635c81520a8f0e380cd1312f21623", async() => {
                BeginContext(7831, 3, true);
                WriteLiteral("FAQ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7838, 43, true);
            WriteLiteral("</div>\r\n    <div class=\"col-5 text-center\">");
            EndContext();
            BeginContext(7881, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd017ef80c12143635c81520a8f0e380cd1312f23328", async() => {
                BeginContext(7958, 11, true);
                WriteLiteral("Contáctanos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7973, 91, true);
            WriteLiteral("</div>\r\n</div>\r\n\r\n<style>\r\n    .sub-details {\r\n        margin-top: 20px;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.SubscriptionPlanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
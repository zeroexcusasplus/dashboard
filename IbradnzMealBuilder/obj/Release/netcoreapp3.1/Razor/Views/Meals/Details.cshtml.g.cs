#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71cdc70d582054707a5ec0358e1d0e146b44a679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meals_Details), @"mvc.1.0.view", @"/Views/Meals/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Meals/Details.cshtml", typeof(AspNetCore.Views_Meals_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cdc70d582054707a5ec0358e1d0e146b44a679", @"/Views/Meals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Meals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.ViewMealBuilderAndMealsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "meals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "mealbuilder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-size-30 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:absolute;top:7px;left:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Meals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PdfDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-primary-btn btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
  
    ViewData["Title"] = "Detalles";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";
    ViewData["Header"] = "DESCARGA TUS COMIDAS";
    ViewData["PrintMealPage"] = true;

#line default
#line hidden
            BeginContext(256, 67, true);
            WriteLiteral("\r\n\r\n<input id=\"active-page\" value=\"meal-builder-page\" hidden />\r\n\r\n");
            EndContext();
            BeginContext(323, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71cdc70d582054707a5ec0358e1d0e146b44a6795967", async() => {
                BeginContext(450, 42, true);
                WriteLiteral("\r\n    <i class=\"fa fa-chevron-left\"></i>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(496, 142, true);
            WriteLiteral("\r\n<div class=\"card box-shadow printmeal-card font-family-poppins-medium\">\r\n    <div class=\"card-body\">\r\n        <h4 style=\"text-align:center\">");
            EndContext();
            BeginContext(639, 18, false);
#line 17 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                 Write(Model.DateInString);

#line default
#line hidden
            EndContext();
            BeginContext(657, 92, true);
            WriteLiteral("</h4>\r\n        <hr />\r\n        <div id=\"print-content\" class=\"font-family-poppins-medium\">\r\n");
            EndContext();
#line 20 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
              
                int mealNumber = 1;
                foreach (var meal in Model.Meals)
                {
                    string mealName = "";
                    if (mealNumber == 1)
                    { mealName = "Desayuno"; }
                    else if (mealNumber == 2)
                    { mealName = "Almuerzo"; }
                    else if (mealNumber == 3)
                    { mealName = "Snack/Comida 3"; }
                    else if (mealNumber == 4)
                    { mealName = "Cena"; }
                    else
                    { mealName = $"Plato {mealNumber}"; }


#line default
#line hidden
            BeginContext(1379, 50, true);
            WriteLiteral("                    <h6 style=\"text-align:center\">");
            EndContext();
            BeginContext(1430, 8, false);
#line 36 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                             Write(mealName);

#line default
#line hidden
            EndContext();
            BeginContext(1438, 216, true);
            WriteLiteral("</h6>\r\n                    <hr class=\"m-0\" />\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3 col-4 my-1\">Proteína</div>\r\n                        <div class=\"col-md-6 col-4 my-1\">");
            EndContext();
            BeginContext(1655, 12, false);
#line 40 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                    Write(meal.Protein);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 65, true);
            WriteLiteral("</div>\r\n                        <div class=\"col-md-3 col-4 my-1\">");
            EndContext();
            BeginContext(1733, 18, false);
#line 41 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                    Write(meal.ProteinAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1751, 206, true);
            WriteLiteral(" gr</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3 col-4 my-1\">Grasas</div>\r\n                        <div class=\"col-md-6 col-4 my-1\">");
            EndContext();
            BeginContext(1958, 8, false);
#line 45 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                    Write(meal.Fat);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 65, true);
            WriteLiteral("</div>\r\n                        <div class=\"col-md-3 col-4 my-1\">");
            EndContext();
            BeginContext(2032, 14, false);
#line 46 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                    Write(meal.FatAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2046, 206, true);
            WriteLiteral(" gr</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-3 col-4 my-1\">Carbos</div>\r\n                        <div class=\"col-md-6 col-4 my-1\">");
            EndContext();
            BeginContext(2253, 17, false);
#line 50 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                    Write(meal.Carbohydrate);

#line default
#line hidden
            EndContext();
            BeginContext(2270, 65, true);
            WriteLiteral("</div>\r\n                        <div class=\"col-md-3 col-4 my-1\">");
            EndContext();
            BeginContext(2336, 23, false);
#line 51 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                    Write(meal.CarbohydrateAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2359, 67, true);
            WriteLiteral(" gr</div>\r\n                    </div>\r\n                    <hr />\r\n");
            EndContext();
#line 54 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                    mealNumber = mealNumber + 1;
                }
            

#line default
#line hidden
            BeginContext(2510, 26, true);
            WriteLiteral("        </div>\r\n\r\n        ");
            EndContext();
            BeginContext(2536, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71cdc70d582054707a5ec0358e1d0e146b44a67913149", async() => {
                BeginContext(2652, 17, true);
                WriteLiteral("Descarga / Guarda");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Meals\Details.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2673, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.ViewMealBuilderAndMealsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

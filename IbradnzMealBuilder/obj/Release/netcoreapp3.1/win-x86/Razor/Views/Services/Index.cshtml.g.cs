#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "384d0fd08fca5452fe85037897fd171ab332be5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Services/Index.cshtml", typeof(AspNetCore.Views_Services_Index))]
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
#line 1 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
using IbradnzMealBuilder.Core;

#line default
#line hidden
#line 3 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
using IbradnzMealBuilder.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"384d0fd08fca5452fe85037897fd171ab332be5c", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "subscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-secondary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Meals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MealBuilder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:underline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm custom-primary-btn p-1 mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:15px;font-weight:500;width:90%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm custom-secondary-btn p-1 btn-block mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/ZeroExcusasLogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-secondary-btn font-family-poppins-medium w-100 font-size-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white font-family-poppins-medium font-size-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-bottom:2px solid white;padding:3px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Servicios";
    Layout = "~/Views/Shared/_IdentityAccountLayout.cshtml";

#line default
#line hidden
            BeginContext(316, 104, true);
            WriteLiteral("\r\n<div class=\"d-none d-lg-block\">\r\n    <div class=\"container\">\r\n        <div class=\"zeroexcusas-header\">");
            EndContext();
            BeginContext(420, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c9798", async() => {
                BeginContext(464, 11, true);
                WriteLiteral("ZEROEXCUSAS");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(479, 457, true);
            WriteLiteral(@"</div>
        <h1 class=""services-header mx-auto mt-1 font-weight-bold text-white"">TOMA CONTROL SOBRE TU META</h1>
        <p class=""mx-auto mt-1 font-weight-500 text-center w-100 font-family-poppins-medium font-size-20 line-height-20 text-white"">
            Tu alimentacion, tu entrenamiento, tu progreso. Prueba la version premium sin costo por una semana
        </p>
        <div class=""text-center mb-1 font-family-poppins-medium"">
            ");
            EndContext();
            BeginContext(936, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c11842", async() => {
                BeginContext(1018, 50, true);
                WriteLiteral("HAZTE PREMIUM <i class=\"fas fa-chevron-right\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1072, 124, true);
            WriteLiteral("\r\n        </div>\r\n        <p class=\"font-weight-500 mb-0 text-center font-size-20 font-family-poppins-medium\">\r\n            ");
            EndContext();
            BeginContext(1196, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c13682", async() => {
                BeginContext(1282, 15, true);
                WriteLiteral("Continua Gratis");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1301, 4940, true);
            WriteLiteral(@"
        </p>
    </div>
    <div class=""pb-5"">
        <div class=""card services-card mt-3 box-shadow mx-auto p-0 font-size-16"" style=""border-radius:10px"">
            <div class=""card-body p-0 font-family-poppins-medium"">
                <table class=""w-100 bg-transparent"" style="" border-collapse: collapse; margin-top:5px;margin-bottom:5px; font-weight: bold"">
                    <thead>
                        <tr class=""light-grey-background p-3"">
                            <th class=""p-4""></th>
                            <th class=""text-center gratis-table-width"">Gratis</th>
                            <th class=""text-center premium-table-width"">Premium</th>
                        </tr>
                    </thead>
                    <tbody class=""bg-white"">
                        <tr class=""bg-white p-3"">
                            <td class=""font-weight-500 p-2"">Constructor de comida diaria</td>
                            <td class=""text-center"">
                               ");
            WriteLiteral(@" <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""light-grey-background p-3"">
                            <td class=""font-weight-500 p-2"">Constructor de comida semanal</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""bg-white p-3"">
                            <td class=""font-weight-500 p-2"">Soporte tenico y apoyo en tu meta</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""");
            WriteLiteral(@"text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""light-grey-background p-3"">
                            <td class=""font-weight-500 p-2"">Chequeo de progreso y ajuste mensual</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""bg-white p-3"">
                            <td class=""font-weight-500 p-2"">Entrenamiento estructurado guiado en videos (gym o en casa)</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""><");
            WriteLiteral(@"/i>
                            </td>
                        </tr>
                        <tr class=""light-grey-background p-3"">
                            <td class=""font-weight-500 p-2"">Personalizacion de tus macronutrientes</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""bg-white p-3"">
                            <td class=""font-weight-500 p-2"">Sesiones de entrenamiento en vivo</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""light-grey-b");
            WriteLiteral(@"ackground p-3"">
                            <td class=""font-weight-500 p-2"">Galeria de videos de tutoriales y tecnicas</td>
                            <td class=""text-center"">
                            </td>
                            <td class=""text-center"">
                                <i class=""fas fa-check"" style=""color:#00db6f""></i>
                            </td>
                        </tr>
                        <tr class=""bg-white p-3"" style=""border-radius:0 0px 10px 10px"">
                            <td></td>
                            <td class=""font-weight-bold p-0 text-center"">
                                GRATIS
                            </td>
                            <td class=""text-center font-weight-bold"">
                                <div>
                                    $");
            EndContext();
            BeginContext(6242, 15, false);
#line 109 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
                                Write(ViewBag.Monthly);

#line default
#line hidden
            EndContext();
            BeginContext(6257, 126, true);
            WriteLiteral(" por mes\r\n                                </div>\r\n                                <div>\r\n                                    $");
            EndContext();
            BeginContext(6384, 14, false);
#line 112 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
                                Write(ViewBag.Yearly);

#line default
#line hidden
            EndContext();
            BeginContext(6398, 315, true);
            WriteLiteral(@" anual
                                </div>
                            </td>
                        </tr>
                        <tr class=""light-grey-background p-3"">
                            <td class=""p-4""></td>
                            <td class=""text-center"">
                                ");
            EndContext();
            BeginContext(6713, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c21716", async() => {
                BeginContext(6899, 117, true);
                WriteLiteral("\r\n                                    Continua <i class=\"fas fa-chevron-right\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7020, 123, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(7143, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c23710", async() => {
                BeginContext(7303, 116, true);
                WriteLiteral("\r\n                                    PREMIUM <i class=\"fas fa-chevron-right\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7423, 309, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
</div>
<div class=""d-sm-block d-md-block d-lg-none d-xl-none"">
    <div class=""mx-auto mt-5 zeroexcusas-sm-logo-container"">
        ");
            EndContext();
            BeginContext(7732, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c25887", async() => {
                BeginContext(7776, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(7790, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "384d0fd08fca5452fe85037897fd171ab332be5c26281", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7852, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(7866, 2293, true);
            WriteLiteral(@"
    </div>

    <div class=""font-size-15 font-family-poppins-medium text-white text-center my-4"">
        Obten todo para lograr tu meta!
    </div>

    <table class=""mx-auto"" style=""width:300px;"">
        <tbody class=""font-family-poppins-medium font-size-15 text-white"">
            <tr>
                <td class=""vertical-align-baseline"">Aplica tus calorias con el constructor de comida semanal</td>
                <td class=""text-center vertical-align-baseline"">
                    <i class=""fas fa-check"" style=""color:#00db6f""></i>
                </td>
            </tr>

            <tr>
                <td class=""vertical-align-baseline"">Alcanza tu meta con Soporte y apoyo 24/7</td>
                <td class=""text-center vertical-align-baseline"">
                    <i class=""fas fa-check"" style=""color:#00db6f""></i>
                </td>
            </tr>
            <tr>
                <td class=""vertical-align-baseline"">Ajusta tu aliemntacion con chequeos mensuales</td>
      ");
            WriteLiteral(@"          <td class=""text-center vertical-align-baseline"">
                    <i class=""fas fa-check"" style=""color:#00db6f""></i>
                </td>
            </tr>
            <tr>
                <td class=""vertical-align-baseline"">Controla tus macronutrientes</td>
                <td class=""text-center vertical-align-baseline"">
                    <i class=""fas fa-check"" style=""color:#00db6f""></i>
                </td>
            </tr>
            <tr>
                <td class=""vertical-align-baseline"">Personal Trainer exclusivo en las sesiones</td>
                <td class=""text-center vertical-align-baseline"">
                    <i class=""fas fa-check"" style=""color:#00db6f""></i>
                </td>
            </tr>
            <tr>
                <td class=""vertical-align-baseline"">Evita lesionas y entrena efectivamente con la biblioteca de tutoriales y tecnica</td>
                <td class=""text-center vertical-align-baseline"">
                    <i class=""fas fa-check""");
            WriteLiteral(" style=\"color:#00db6f\"></i>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <div class=\"font-family-poppins-bold mx-2 font-size-15 justify-content-center text-center text-white mt-5\">7 dias gratis, luego  anual $");
            EndContext();
            BeginContext(10160, 14, false);
#line 190 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
                                                                                                                                       Write(ViewBag.Yearly);

#line default
#line hidden
            EndContext();
            BeginContext(10174, 3, true);
            WriteLiteral(" o ");
            EndContext();
            BeginContext(10178, 15, false);
#line 190 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Services\Index.cshtml"
                                                                                                                                                         Write(ViewBag.Monthly);

#line default
#line hidden
            EndContext();
            BeginContext(10193, 86, true);
            WriteLiteral(" mensual</div>\r\n    <div class=\"text-center mt-3 mx-auto\" style=\"width:80%\">\r\n        ");
            EndContext();
            BeginContext(10279, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c32277", async() => {
                BeginContext(10407, 71, true);
                WriteLiteral("\r\n            EMPIEZA YA <i class=\"fas fa-chevron-right\"></i>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10482, 63, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"text-center mb-5 mt-3\">\r\n        ");
            EndContext();
            BeginContext(10545, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384d0fd08fca5452fe85037897fd171ab332be5c34084", async() => {
                BeginContext(10705, 15, true);
                WriteLiteral("Continua Gratis");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10724, 544, true);
            WriteLiteral(@"
    </div>
</div>

<style>

    tr {
        height: 60px;
    }

    .zeroexcusas-sm-logo-container{
        width:400px;
    }

    .gratis-table-width {
        min-width: 110px;
        max-width: 300px;
    }

    .premium-table-width {
        min-width: 110px;
        max-width: 300px;
    }

    table {
        border-collapse: separate;
        border-radius: 10px;
        -moz-border-radius: 10px;
        padding: 0;
    }

    td {
        border-width: 1px 0;
        padding: 0;
    }

    ");
            EndContext();
            BeginContext(11269, 216, true);
            WriteLiteral("@media screen and (max-width: 379px) and (min-width: 0px) {\r\n\r\n        .gratis-table-width {\r\n            width: 100px;\r\n        }\r\n\r\n        .premium-table-width {\r\n            width: 90px;\r\n        }\r\n    }\r\n\r\n    ");
            EndContext();
            BeginContext(11486, 301, true);
            WriteLiteral(@"@media screen and (max-width: 420px) and (min-width: 380px) {

        .zeroexcusas-sm-logo-container {
            width: 90%;
        }

        .gratis-table-width {
            width: 100px;
        }

        .premium-table-width {
            width: 100px;
        }
    }


    ");
            EndContext();
            BeginContext(11788, 219, true);
            WriteLiteral("@media screen and (max-width: 820px) and (min-width: 421px) {\r\n\r\n        .gratis-table-width {\r\n            width: 100px;\r\n        }\r\n\r\n        .premium-table-width {\r\n            width: 105px;\r\n        }\r\n    }\r\n\r\n    ");
            EndContext();
            BeginContext(12008, 160, true);
            WriteLiteral("@media screen and (max-width: 420px) and (min-width: 0) {\r\n\r\n        .zeroexcusas-sm-logo-container {\r\n            width: 90%;\r\n        }\r\n    }\r\n\r\n</style>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b011b4b5b93481b7f8ec8fd640eff1f9097c1f20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PageUnderlays__Tutorial0), @"mvc.1.0.view", @"/Views/Shared/PageUnderlays/_Tutorial0.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PageUnderlays/_Tutorial0.cshtml", typeof(AspNetCore.Views_Shared_PageUnderlays__Tutorial0))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b011b4b5b93481b7f8ec8fd640eff1f9097c1f20", @"/Views/Shared/PageUnderlays/_Tutorial0.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PageUnderlays__Tutorial0 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.TutorialModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "subscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn custom-secondary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#00db6f;font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("arrow-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/icons/PreviousArrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/icons/NextArrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/icons/PROTEIN_ICON.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nutrient-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/icons/FAT_ICON.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/icons/CARBS_ICON.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 527, true);
            WriteLiteral(@"
<div class=""container-fluid pt-3"" style=""z-index: -1;height:100vh;overflow-y:no-display;background:black"">
    <div style=""font-size: 30px; line-height: 30px;"" class=""text-center text-white"">
        CONSTRUCTOR DE COMIDA DIARIO
    </div>
    <hr />
    <div class=""font-family-poppins-medium"">
        <div class=""text-center text-white"">Organiza toda tu semana, edita tus macros y  obtén todos los beneficios de Zero Excusas PLUS</div>
        <div class=""text-center my-2 font-family-poppins-medium"">
            ");
            EndContext();
            BeginContext(575, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f208374", async() => {
                BeginContext(705, 20, true);
                WriteLiteral("Prueba 7 dias gratis");
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
            BeginContext(729, 299, true);
            WriteLiteral(@"
        </div>

        <div class=""card mealbuilder-card mx-auto mt-3 box-shadow"">

            <div class=""card-header text-center"">
                <div class="""">
                    <span class=""font-size-15 secondary-color font-b1 mx-2"" style=""cursor:pointer"">
                        ");
            EndContext();
            BeginContext(1028, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2010439", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1093, 218, true);
            WriteLiteral("\r\n                    </span>\r\n                    <div class=\"d-inline-block font-weight-500 font-family-poppins-medium\">\r\n                        <span class=\"line-height-30 date-in-spanish-label\" id=\"DateInSpanish\">");
            EndContext();
            BeginContext(1312, 19, false);
#line 22 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml"
                                                                                         Write(Model.DateInSpanish);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 162, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <span class=\"font-size-15 secondary-color font-b1 mx-2\" style=\"cursor:pointer\">\r\n                        ");
            EndContext();
            BeginContext(1493, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2012525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1554, 391, true);
            WriteLiteral(@"
                    </span>
                </div>
            </div>
            <div class=""card-body p-0"">
                <div class=""bg-white py-2 px-4"">
                    <label class=""mealbuilder-label mb-0"">Tu agua del día</label>
                </div>
                <div class=""dark-grey-background py-2 px-4"">
                    <p class=""m-0 mealbuilder-p-values"">");
            EndContext();
            BeginContext(1946, 17, false);
#line 34 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml"
                                                   Write(Model.WaterIntake);

#line default
#line hidden
            EndContext();
            BeginContext(1963, 332, true);
            WriteLiteral(@" litros</p>
                </div>

                <div class=""bg-white py-2 px-4"">
                    <label class=""mealbuilder-label mb-0"">Tus calorías diarias para tu meta</label>
                </div>
                <div class=""dark-grey-background py-2 px-4"">
                    <p class=""m-0 mealbuilder-p-values"">");
            EndContext();
            BeginContext(2296, 14, false);
#line 41 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml"
                                                   Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(2310, 604, true);
            WriteLiteral(@"</p>
                </div>

                <div class=""bg-white py-2 px-4 px-320px-10"">
                    <div class=""d-inline-block protein-label""><label>Proteína</label></div>
                    <div class=""d-inline-block fat-label""><label>Grasas</label></div>
                    <div class=""d-inline-block carbs-label"" style=""word-break:break-all""><label>Carbohidratos</label></div>
                </div>
                <div class=""py-2 px-4 dark-grey-background px-320px-10"">
                    <div class=""d-inline-block mealbuilder-p-values protein-label"" id=""MacrosProteinLabel"">");
            EndContext();
            BeginContext(2915, 19, false);
#line 50 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml"
                                                                                                      Write(Model.MacrosProtein);

#line default
#line hidden
            EndContext();
            BeginContext(2934, 110, true);
            WriteLiteral(" gr</div>\r\n                    <div class=\"d-inline-block mealbuilder-p-values fat-label\" id=\"MacrosFatLabel\">");
            EndContext();
            BeginContext(3045, 14, false);
#line 51 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml"
                                                                                              Write(Model.MacroFat);

#line default
#line hidden
            EndContext();
            BeginContext(3059, 121, true);
            WriteLiteral(" gr</div>\r\n                    <div class=\"d-inline-block mealbuilder-p-values carbs-label\" id=\"MacrosCarbohydrateLabel\">");
            EndContext();
            BeginContext(3181, 24, false);
#line 52 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Shared\PageUnderlays\_Tutorial0.cshtml"
                                                                                                         Write(Model.MacrosCarbohydrate);

#line default
#line hidden
            EndContext();
            BeginContext(3205, 820, true);
            WriteLiteral(@" gr</div>
                    <div class=""d-inline-block mealbuiler-edit-icon float-right"" style="""">
                        <div class=""d-inline-block"" style=""font-size:10px;cursor:pointer;color:#2a54ff"">
                            <i class=""fas fa-pencil-alt  fa-2x""></i> <span class=""font-family-poppins-medium font-size-14"" style=""text-decoration:underline"">Editar</span>
                        </div>
                    </div>
                </div>

                <div class=""row py-2 w-100 bg-white m-0"">
                    <label class=""col-7 mealbuilder-label p-0 pl-4"">¿Cuántas comidas harás hoy?</label>
                    <div class=""col-5 mealbuilder-p-values p-0 pr-lg-4"">
                        <select class=""form-control-sm w-100 numberofmeals"" style="""">
                            ");
            EndContext();
            BeginContext(4025, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2018340", async() => {
                BeginContext(4042, 9, true);
                WriteLiteral("3 comidas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4060, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4090, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2019749", async() => {
                BeginContext(4107, 9, true);
                WriteLiteral("4 comidas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4125, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4155, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2021158", async() => {
                BeginContext(4172, 9, true);
                WriteLiteral("5 comidas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4190, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4220, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2022567", async() => {
                BeginContext(4237, 9, true);
                WriteLiteral("6 comidas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4255, 900, true);
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
            </div>
        </div>

        <div class=""mt-3"">
            <div id=""mealBuilderTable"">

                <div class=""card mealbuilder-card mx-auto box-shadow box-shadow"">
                    <div class=""card-header bg-transparent"">
                        <div class=""font-weight-bold text-center font-size-25 font-family-poppins-medium"">Desayuno</div>
                    </div>
                    <div class=""card-body p-1"">
                        <div class="""">
                            <div class=""row mb-3 w-100 mx-0"">
                                <div class=""col-3 py-0 px-1 mb-1"">
                                    <div class=""text-center"">
                                        <div class=""nutrient-label"">Proteína</div>
                                        ");
            EndContext();
            BeginContext(5155, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2024868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5223, 419, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-6 py-0 px-1 "">
                                    <div class=""nutrient-label"">Lista</div>
                                    <select class=""form-control-sm meallist-select-option mealbuilder-input w-100 bgcolor-white mealbuilder-p-values"">
                                        ");
            EndContext();
            BeginContext(5642, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2026546", async() => {
                BeginContext(5659, 16, true);
                WriteLiteral("Pavo molido 93/7");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5684, 822, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                                <div class=""col-3 py-0 pl-1 pr-2"">
                                    <div class=""nutrient-label"">Cantidad</div>
                                    <input value=""123 gr""
                                           class=""form-control-sm mealbuilder-input w-100 bg-white font-weight-bold"" readonly />
                                </div>

                            </div>

                            <div class=""row mb-3 w-100 mx-0"">
                                <div class=""col-3 py-0 px-1 mb-1"">
                                    <div class=""text-center"">
                                        <div class=""nutrient-label"">Grasas</div>
                                        ");
            EndContext();
            BeginContext(6506, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2028771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6570, 418, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-6 py-0 px-1"">
                                    <div class=""nutrient-label"">Lista</div>
                                    <select class=""form-control-sm meallist-select-option mealbuilder-input w-100 bgcolor-white mealbuilder-p-values"">
                                        ");
            EndContext();
            BeginContext(6988, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2030449", async() => {
                BeginContext(7005, 9, true);
                WriteLiteral("Almendras");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7023, 821, true);
            WriteLiteral(@"
                                    </select>

                                </div>
                                <div class=""col-3 py-0 pl-1 pr-2"">
                                    <div class=""nutrient-label"">Cantidad</div>
                                    <input value=""30 gr""
                                           class=""form-control-sm mealbuilder-input w-100 bg-white font-weight-bold"" readonly />
                                </div>
                            </div>

                            <div class=""row mb-5 w-100 mx-0"">
                                <div class=""col-3 py-0 px-1 mb-1"">
                                    <div class=""text-center"">
                                        <div class=""nutrient-label"">Carbos</div>
                                        ");
            EndContext();
            BeginContext(7844, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2032665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7910, 419, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-6 py-0 px-1 "">
                                    <div class=""nutrient-label"">Lista</div>
                                    <select class=""form-control-sm meallist-select-option mealbuilder-input w-100 bgcolor-white mealbuilder-p-values"">
                                        ");
            EndContext();
            BeginContext(8329, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b011b4b5b93481b7f8ec8fd640eff1f9097c1f2034344", async() => {
                BeginContext(8346, 7, true);
                WriteLiteral("Manzana");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8362, 1640, true);
            WriteLiteral(@"
                                    </select>

                                </div>
                                <div class=""col-3 py-0 pl-1 pr-2"">
                                    <div class=""nutrient-label"">Cantidad</div>
                                    <input value=""230 gr""
                                           class=""form-control-sm mealbuilder-input w-100 bg-white font-weight-bold"" readonly />
                                </div>

                            </div>
                        </div>
                    </div>
                </div>


            </div>
        </div>


    </div>
</div>

<style>
    .overlay {
        background-color: black;
        position: absolute;
        z-index: 1;
        width: 100%;
        height: 100vh;
        top: 0;
        left: 0;
        opacity: 0.90
    }

    .suc-overlay::after {
        background-color: #717173 !important;
        opacity: 0 !important;
    }

    .numberofmeals {
        b");
            WriteLiteral(@"ackground-color: #2a54ff;
        border: none !important;
        color: white;
        height: 42px;
        font-size: 20px;
    }

    .date-in-spanish-label {
        font-size: 20px;
    }

    .date-pencil-edit {
        right: 20px;
        position: absolute;
        top: 25px;
    }

    .protein-label {
        width: 60px;
        margin-right: 50px;
    }

    .fat-label {
        width: 65px;
        margin-right: 50px;
    }

    .carbs-label {
        width: 140px;
    }

    .mealbuiler-edit-icon {
        position: relative;
        top: -40px;
    }

    ");
            EndContext();
            BeginContext(10003, 192, true);
            WriteLiteral("@media screen and (max-width: 530px) and (min-width: 450px) {\r\n        label, .date-in-spanish-label, .mealbuilder-p-values {\r\n            font-size: 17px !important;\r\n        }\r\n    }\r\n\r\n    ");
            EndContext();
            BeginContext(10196, 576, true);
            WriteLiteral(@"@media screen and (max-width: 450px) and (min-width: 0px) {
        .mealbuiler-edit-icon {
            top: -25px;
        }

        label,
        .date-in-spanish-label,
        .mealbuilder-p-values {
            font-size: 16px !important;
        }

        .date-pencil-edit {
            position: relative;
            display: block;
            top: 0;
        }

        .nutrient-label {
            font-size: 11px;
            font-weight: 600;
        }

        .numberofmeals {
            font-size: 14px;
        }
    }


    ");
            EndContext();
            BeginContext(10773, 328, true);
            WriteLiteral(@"@media screen and (max-width: 420px) and (min-width: 0px) {
        .protein-label {
            width: 60px;
            margin-right: 10px;
        }

        .fat-label {
            width: 50px;
            margin-right: 10px;
        }

        .carbs-label {
            width: 120px;
        }
    }

    ");
            EndContext();
            BeginContext(11102, 351, true);
            WriteLiteral(@"@media screen and (max-width: 520px) and (min-width: 420px) {
        .protein-label {
            margin-right: 30px;
        }

        .fat-label {
            margin-right: 30px;
        }

        .carbs-label {
        }

        .date-pencil-edit {
            right: 10px;
            font-size: 15px;
        }
    }


    ");
            EndContext();
            BeginContext(11454, 385, true);
            WriteLiteral(@"@media screen and (max-width: 320px) and (min-width: 0px) {
        .px-320px-10 {
            padding-left: 10px !important;
            padding-right: 10px !important;
        }

        .date-pencil-edit {
            right: 10px;
            font-size: 15px;
        }
    }

    select {
        background: #2a54ff !important;
        color: white;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.TutorialModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\_TrainingVideoIntro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da3a37903be608d5a1b0b719e2260bb28d79920b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training__TrainingVideoIntro), @"mvc.1.0.view", @"/Views/Training/_TrainingVideoIntro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/_TrainingVideoIntro.cshtml", typeof(AspNetCore.Views_Training__TrainingVideoIntro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da3a37903be608d5a1b0b719e2260bb28d79920b", @"/Views/Training/_TrainingVideoIntro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Training__TrainingVideoIntro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.ViewProgramModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\_TrainingVideoIntro.cshtml"
   
    string youtubeEmbededUrl = "https://youtube.com/embed/" + Model.DescriptionYoutubeLink;

#line default
#line hidden
            BeginContext(154, 344, true);
            WriteLiteral(@"
<div class=""mx-auto my-3 light-grey-background training-card mt-2 pt-2 font-family-poppins-medium"" style=""border-radius:5px"">
    <div class="""">
        <div class=""row p-2 mb-0"">
            <div class=""col-sm-12 col-md-5"">
                <div class=""training-video light-grey-background"">
                    <iframe id=""YouTubevideo""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 498, "\"", 522, 1);
#line 12 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\_TrainingVideoIntro.cshtml"
WriteAttributeValue("", 504, youtubeEmbededUrl, 504, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(523, 272, true);
            WriteLiteral(@" width=""100%"" height=""100%"" frameborder=""0"" allowfullscreen></iframe>
                </div>
            </div>
            <div class=""col-sm-12 col-md-7 font-weight-bold"" style=""font-size:11px"">
                <div class=""font-weight-bolder"" style=""font-size:15px"">");
            EndContext();
            BeginContext(796, 10, false);
#line 16 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\_TrainingVideoIntro.cshtml"
                                                                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(806, 45, true);
            WriteLiteral("</div>\r\n                <div class=\"font-b1\">");
            EndContext();
            BeginContext(852, 17, false);
#line 17 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Training\_TrainingVideoIntro.cshtml"
                                Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(869, 66, true);
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.ViewProgramModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Account\_ProfileImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c337c886f8f0ff5aa6a1a607623ecd3c90c9ed60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__ProfileImages), @"mvc.1.0.view", @"/Views/Account/_ProfileImages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/_ProfileImages.cshtml", typeof(AspNetCore.Views_Account__ProfileImages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c337c886f8f0ff5aa6a1a607623ecd3c90c9ed60", @"/Views/Account/_ProfileImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cb0199b26a662fdcc10be66f1a6ea4c2073524", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__ProfileImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IbradnzMealBuilder.Models.ProfileImageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 116, true);
            WriteLiteral("\r\n<label class=\"mb-0 text-white\">Imágenes de mi perfil</label>\r\n<hr class=\"m-0 mb-1\" />\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 6 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Account\_ProfileImages.cshtml"
     foreach (var image in Model.Images)
    {

#line default
#line hidden
            BeginContext(221, 64, true);
            WriteLiteral("        <div class=\"d-inline-block mx-1 mb-3\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 285, "\"", 321, 1);
#line 9 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Account\_ProfileImages.cshtml"
WriteAttributeValue("", 291, Url.Content(image.ProfileUrl), 291, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 120, true);
            WriteLiteral(" style=\"height:200px;width:200px\" class=\"mb-1\" />\r\n            <div class=\"d-block\">\r\n                <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 442, "\"", 479, 1);
#line 11 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Account\_ProfileImages.cshtml"
WriteAttributeValue("", 449, Url.Content(image.ProfileUrl), 449, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(480, 118, true);
            WriteLiteral(" class=\"btn py-0 mx-1 custom-primary-btn\">View</a>\r\n                <button class=\"btn py-0 mx-1 custom-secondary-btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 598, "\"", 637, 3);
            WriteAttributeValue("", 608, "DeleteProfileImage(", 608, 19, true);
#line 12 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Account\_ProfileImages.cshtml"
WriteAttributeValue("", 627, image.Id, 627, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 636, ")", 636, 1, true);
            EndWriteAttribute();
            BeginContext(638, 54, true);
            WriteLiteral(">Delete</button>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\Users\waheedullah\source\repos\IbradnzMealBuilder\Views\Account\_ProfileImages.cshtml"
    }

#line default
#line hidden
            BeginContext(699, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IbradnzMealBuilder.Models.ProfileImageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

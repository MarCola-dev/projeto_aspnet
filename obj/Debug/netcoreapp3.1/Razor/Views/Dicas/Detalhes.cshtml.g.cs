#pragma checksum "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\Dicas\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f48f2477ba352033b75f8bade8b935948172464e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dicas_Detalhes), @"mvc.1.0.view", @"/Views/Dicas/Detalhes.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\_ViewImports.cshtml"
using Covid19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\_ViewImports.cshtml"
using Covid19.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f48f2477ba352033b75f8bade8b935948172464e", @"/Views/Dicas/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c96d574c41578cc64c4f1f79000d1e7aef2e69", @"/Views/_ViewImports.cshtml")]
    public class Views_Dicas_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcTips.Models.Tips>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\Dicas\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card mb-3\">\r\n        <img");
            BeginWriteAttribute("src", "  src=\"", 142, "\"", 162, 1);
#nullable restore
#line 9 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\Dicas\Detalhes.cshtml"
WriteAttributeValue("", 149, Model.UrlImg, 149, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n        <hr />\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\Dicas\Detalhes.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\Dicas\Detalhes.cshtml"
                            Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 14 "C:\Users\Roberto\Documents\CovidMarcos\projeto_aspnet\Views\Dicas\Detalhes.cshtml"
                                                      Write(Model.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcTips.Models.Tips> Html { get; private set; }
    }
}
#pragma warning restore 1591

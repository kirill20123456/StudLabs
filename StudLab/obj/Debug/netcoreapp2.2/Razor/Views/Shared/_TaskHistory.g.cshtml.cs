#pragma checksum "D:\Projects\StudLab\StudLab\Views\Shared\_TaskHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2825e74d4869bdfb21d05b6095846aa6a0bc6d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TaskHistory), @"mvc.1.0.view", @"/Views/Shared/_TaskHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TaskHistory.cshtml", typeof(AspNetCore.Views_Shared__TaskHistory))]
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
#line 1 "D:\Projects\StudLab\StudLab\Views\_ViewImports.cshtml"
using StudLab;

#line default
#line hidden
#line 2 "D:\Projects\StudLab\StudLab\Views\_ViewImports.cshtml"
using StudLab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2825e74d4869bdfb21d05b6095846aa6a0bc6d0", @"/Views/Shared/_TaskHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f0b1649f701e3fa81b8c72324a795d0164e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TaskHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\StudLab\StudLab\Views\Shared\_TaskHistory.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(28, 25, true);
            WriteLiteral("<div id=\"history-user\">\r\n");
            EndContext();
            BeginContext(85, 39, true);
            WriteLiteral("    <div class=\"header-history col-12\">");
            EndContext();
            BeginContext(125, 26, false);
#line 6 "D:\Projects\StudLab\StudLab\Views\Shared\_TaskHistory.cshtml"
                                  Write(TempData["header-history"]);

#line default
#line hidden
            EndContext();
            BeginContext(151, 66, true);
            WriteLiteral("</div>\r\n    <div id=\"body-history\" style=\"width: 100%;\">\r\n        ");
            EndContext();
            BeginContext(218, 12, false);
#line 8 "D:\Projects\StudLab\StudLab\Views\Shared\_TaskHistory.cshtml"
   Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(230, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

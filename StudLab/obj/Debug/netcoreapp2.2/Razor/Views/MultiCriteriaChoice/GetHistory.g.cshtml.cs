#pragma checksum "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed4fceb612fd183255b904f99fd96e4a5f44f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MultiCriteriaChoice_GetHistory), @"mvc.1.0.view", @"/Views/MultiCriteriaChoice/GetHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MultiCriteriaChoice/GetHistory.cshtml", typeof(AspNetCore.Views_MultiCriteriaChoice_GetHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed4fceb612fd183255b904f99fd96e4a5f44f4a", @"/Views/MultiCriteriaChoice/GetHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f0b1649f701e3fa81b8c72324a795d0164e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_MultiCriteriaChoice_GetHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudLab.Models.TablesEntities.MultiCriteriaTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
  
    Layout = TempData["layout"]?.ToString();
    TempData["header-history"] = "История многокритериальной задачи";

#line default
#line hidden
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(230, 29, true);
            WriteLiteral("    <div class=\"item-history\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 259, "\"", 272, 1);
#line 10 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
WriteAttributeValue("", 264, item.Id, 264, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 273, "\"", 304, 3);
            WriteAttributeValue("", 283, "selectTable(", 283, 12, true);
#line 10 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
WriteAttributeValue("", 295, item.Id, 295, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 303, ")", 303, 1, true);
            EndWriteAttribute();
            BeginContext(305, 41, true);
            WriteLiteral(">\r\n        <table class=\"table-center\">\r\n");
            EndContext();
#line 12 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
              
                var tableOne = item.GetMatrix(item.Table);
            

#line default
#line hidden
            BeginContext(437, 210, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td align=\"center\">\r\n                        <b>Матрица №1<sub>ij</sub></b>\r\n                        <table>\r\n                            <tbody>\r\n");
            EndContext();
#line 21 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
                                 for (int i = 0; i < item.NumRow; i++)
                                {

#line default
#line hidden
            BeginContext(754, 94, true);
            WriteLiteral("                                    <tr>\r\n                                        <td> </td>\r\n");
            EndContext();
#line 25 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
                                         for (int j = 0; j < item.NumColumn; j++)
                                        {

#line default
#line hidden
            BeginContext(974, 87, true);
            WriteLiteral("                                            <td><input class=\"form-control\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1061, "\"", 1085, 3);
            WriteAttributeValue("", 1068, "m", 1068, 1, true);
#line 27 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
WriteAttributeValue("", 1069, i + 1, 1069, 8, false);

#line default
#line hidden
#line 27 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
WriteAttributeValue("", 1077, j + 1, 1077, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1086, "\"", 1109, 1);
#line 27 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
WriteAttributeValue("", 1094, tableOne[i][j], 1094, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1110, 17, true);
            WriteLiteral(" disabled></td>\r\n");
            EndContext();
#line 28 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1170, 43, true);
            WriteLiteral("                                    </tr>\r\n");
            EndContext();
#line 30 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
                                }

#line default
#line hidden
            BeginContext(1248, 174, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 38 "D:\Projects\StudLab\StudLab\Views\MultiCriteriaChoice\GetHistory.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudLab.Models.TablesEntities.MultiCriteriaTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\INT156\source\repos\pie_backery\Views\Pie\longDescrip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc39e0d8aa3a975c51e25346c8118c04cc67537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_longDescrip), @"mvc.1.0.view", @"/Views/Pie/longDescrip.cshtml")]
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
#line 1 "C:\Users\INT156\source\repos\pie_backery\Views\_ViewImports.cshtml"
using pie_backery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\INT156\source\repos\pie_backery\Views\_ViewImports.cshtml"
using pie_backery.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\INT156\source\repos\pie_backery\Views\_ViewImports.cshtml"
using pie_backery.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc39e0d8aa3a975c51e25346c8118c04cc67537", @"/Views/Pie/longDescrip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c877d900e865d11fe2df69c2ddc5039b72289a1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_longDescrip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\INT156\source\repos\pie_backery\Views\Pie\longDescrip.cshtml"
  
    ViewData["Title"] = "longDescrip";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 7 "C:\Users\INT156\source\repos\pie_backery\Views\Pie\longDescrip.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 89, "\"", 119, 1);
#nullable restore
#line 8 "C:\Users\INT156\source\repos\pie_backery\Views\Pie\longDescrip.cshtml"
WriteAttributeValue("", 95, Model.ImageThumbnailUrl, 95, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<h1>");
#nullable restore
#line 9 "C:\Users\INT156\source\repos\pie_backery\Views\Pie\longDescrip.cshtml"
Write(Model.PieId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 10 "C:\Users\INT156\source\repos\pie_backery\Views\Pie\longDescrip.cshtml"
Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<h1></h1>\r\n<h1></h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591

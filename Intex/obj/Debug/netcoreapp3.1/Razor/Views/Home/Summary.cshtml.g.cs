#pragma checksum "C:\Users\ehorl\Source\Repos\INTEXII\Intex\Views\Home\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4b962b0cd82e62daaf7213f227a48d53bd9373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Summary), @"mvc.1.0.view", @"/Views/Home/Summary.cshtml")]
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
#line 1 "C:\Users\ehorl\Source\Repos\INTEXII\Intex\Views\_ViewImports.cshtml"
using Intex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ehorl\Source\Repos\INTEXII\Intex\Views\_ViewImports.cshtml"
using Intex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4b962b0cd82e62daaf7213f227a48d53bd9373", @"/Views/Home/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f800174a374869e3e1f878c96a99550cd97f7626", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crash>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ehorl\Source\Repos\INTEXII\Intex\Views\Home\Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>Summary Page</h1>\r\n\r\n\r\n<p>");
#nullable restore
#line 12 "C:\Users\ehorl\Source\Repos\INTEXII\Intex\Views\Home\Summary.cshtml"
Write(Model.CRASH_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 13 "C:\Users\ehorl\Source\Repos\INTEXII\Intex\Views\Home\Summary.cshtml"
Write(Model.CRASH_DATETIME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crash> Html { get; private set; }
    }
}
#pragma warning restore 1591

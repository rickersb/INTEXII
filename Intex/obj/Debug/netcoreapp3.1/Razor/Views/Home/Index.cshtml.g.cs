#pragma checksum "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7bd589340ab59012487137c288e80bcc1f264e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\_ViewImports.cshtml"
using Intex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\_ViewImports.cshtml"
using Intex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7bd589340ab59012487137c288e80bcc1f264e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f800174a374869e3e1f878c96a99550cd97f7626", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crash>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<header class=""jumbotron jumbotron-fluid"">
    <div class=""container-fluid text-center"">
        <h1 class=""display-3"">Think & Drive</h1>
        <p class=""lead pb-4"">Data driven decisions for you.</p>
        <p><a href=""#"" class=""btn btn-primary btn-lg"" role=""button"">Learn More</a></p>
    </div>
</header>


<div class=""container"">
    
    <div>
        <h2 class=""text-center"">Our Mission: Lower High Speed Yeets</h2>
        <br />
        <p>For years now, people have been getting yeeted from their cars at high speeds. Government agencies have been trying for years to lower
        driver fatalities in Utah with little success. Our team at Think & Drive has developed special data driven tools to help lawmakers make
        efficient and affective decisions in driving laws.</p>
    </div>
</div>


<p>ID: ");
#nullable restore
#line 28 "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\Home\Index.cshtml"
  Write(Model.CRASH_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>DATE: ");
#nullable restore
#line 29 "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\Home\Index.cshtml"
    Write(Model.CRASH_DATETIME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ROUTE: ");
#nullable restore
#line 30 "C:\Users\tstee\Source\Repos\INTEXII\Intex\Views\Home\Index.cshtml"
     Write(Model.ROUTE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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

#pragma checksum "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "221e88861c67a2354e84213b5801b87146015392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CrashesSummary), @"mvc.1.0.view", @"/Views/Shared/CrashesSummary.cshtml")]
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
#line 1 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\_ViewImports.cshtml"
using Intex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\_ViewImports.cshtml"
using Intex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\_ViewImports.cshtml"
using Intex.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\_ViewImports.cshtml"
using Intex.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221e88861c67a2354e84213b5801b87146015392", @"/Views/Shared/CrashesSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d760e2bf6fa360203bb324ab7cbfc1ed9f97aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CrashesSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crash>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<h1>Crash Data</h1>

<table class=""table table-bordered table-striped"">

    <thead class=""font-weight-bold"">
        <tr>
            <td>Date</td>
            <td>Route</td>
            <td>Mile Point</td>
            <td>Latitude</td>
            <td>Longitude</td>
            <td>Street Name</td>
            <td>Severity Level</td>



        </tr>
    </thead>

    <tbody>


      
            <tr>
                <td>");
#nullable restore
#line 27 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.CRASH_DATETIME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.ROUTE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.MILEPOINT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.LAT_UTM_Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.LONG_UTM_X);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.MAIN_ROAD_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\tstee\Source\Repos\bobby\Intex\Views\Shared\CrashesSummary.cshtml"
               Write(Model.CRASH_SEVERITY_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n\r\n        \r\n\r\n\r\n\r\n\r\n    </tbody>\r\n\r\n</table>");
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

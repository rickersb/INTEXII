// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Intex.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/_Imports.razor"
using Intex.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/details/{id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/ben/Desktop/IS/INTEXII/Intex/Intex/Pages/Admin/Details.razor"
       
    [Inject]
    public ICrashesRepository repo { get; set; }

    [Parameter]
    public int Id { get; set; }

    public Crash crash { get; set; }

    protected override void OnParametersSet()
    {
        crash = repo.Crashes.FirstOrDefault(x => x.CRASH_ID == Id);
    }

    public string EditUrl => $"/admin/crashes/edit/{crash.CRASH_ID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

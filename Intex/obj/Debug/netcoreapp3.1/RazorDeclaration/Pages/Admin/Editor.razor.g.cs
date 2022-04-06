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
#line 1 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\_Imports.razor"
using Intex.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/edit/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/create")]
    public partial class Editor : OwningComponentBase<ICrashesRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 165 "C:\Users\ehorl\source\repos\INTEXII\Intex\Pages\Admin\Editor.razor"
       

    [Parameter]
    public int Id { get; set; } = 0;

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Add" : "Edit";

    public Crash c { get; set; } = new Crash();

    public ICrashesRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id != 0) //Existing Crash
        {
            c = repo.Crashes.FirstOrDefault(x => x.CRASH_ID == Id);
        }
    }

    public void SaveCrash()
    {
        if (Id == 0) //New Crash
        {
            repo.CreateCrash(c);
        }
        else
        {
            repo.SaveCrash(c);
        }

        NavManager.NavigateTo("/admin/crashes");
    }

    [Inject]
    public NavigationManager NavManager { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

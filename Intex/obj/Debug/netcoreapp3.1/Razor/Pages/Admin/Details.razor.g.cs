#pragma checksum "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02ef11f6b25554f4bf5aa23bde1d37d3364743c"
// <auto-generated/>
#pragma warning disable 1591
namespace Intex.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Intex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/crashes/details/{id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Date & Time:</th>");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                      crash.CRASH_DATETIME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Route:</th>");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                crash.ROUTE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Milepoint:</th>");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 9 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                    crash.MILEPOINT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Latitude:</th>");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 10 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                   crash.LAT_UTM_Y

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>Longitude:</th>");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 11 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                    crash.LONG_UTM_X

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<th>Road Name:</th>");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 12 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                    crash.MAIN_ROAD_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<th>City:</th>");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 13 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                               crash.CITY_ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "<th>County:</th>");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 14 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                 crash.COUNTY_ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "<th>Crash Severity:</th>");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 15 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                         crash.CRASH_SEVERITY_ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "<th>Work Zone Related:</th>");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 16 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                            crash.WORK_ZONE_RELATED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "tr");
            __builder.AddMarkupContent(57, "<th>Pedestrian Involved:</th>");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 17 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                              crash.PEDESTRIAN_INVOLVED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "<th>Bicyclist Involved:</th>");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 18 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                             crash.BICYCLIST_INVOLVED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "tr");
            __builder.AddMarkupContent(67, "<th>Motorcycle Involved:</th>");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 19 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                              crash.MOTORCYCLE_INVOLVED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "<th>Improper Restraint:</th>");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 20 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                             crash.IMPROPER_RESTRAINT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "<th>Unrestrained:</th>");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 21 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                       crash.UNRESTRAINED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "tr");
            __builder.AddMarkupContent(82, "<th>DUI:</th>");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 22 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                              crash.DUI

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "<th>Intersection Related:</th>");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 23 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                               crash.INTERSECTION_RELATED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "tr");
            __builder.AddMarkupContent(92, "<th>Wild Animal Related:</th>");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 24 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                              crash.WILD_ANIMAL_RELATED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "tr");
            __builder.AddMarkupContent(97, "<th>Deomestic Animal Related:</th>");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 25 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                                   crash.DOMESTIC_ANIMAL_RELATED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.OpenElement(101, "tr");
            __builder.AddMarkupContent(102, "<th>Rollover:</th>");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 26 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                   crash.OVERTURN_ROLLOVER

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.OpenElement(106, "tr");
            __builder.AddMarkupContent(107, "<th>Commercial Vehicle Involved:</th>");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 27 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                                      crash.COMMERCIAL_MOTOR_VEH_INVOLVED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.OpenElement(111, "tr");
            __builder.AddMarkupContent(112, "<th>Teenage Driver Involved:</th>");
            __builder.OpenElement(113, "td");
            __builder.AddContent(114, 
#nullable restore
#line 28 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                                  crash.TEENAGE_DRIVER_INVOLVED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenElement(116, "tr");
            __builder.AddMarkupContent(117, "<th>Older Driver Involved:</th>");
            __builder.OpenElement(118, "td");
            __builder.AddContent(119, 
#nullable restore
#line 29 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                                crash.OLDER_DRIVER_INVOLVED

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.OpenElement(121, "tr");
            __builder.AddMarkupContent(122, "<th>Nighttime Crash:</th>");
            __builder.OpenElement(123, "td");
            __builder.AddContent(124, 
#nullable restore
#line 30 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                          crash.NIGHT_DARK_CONDITION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.OpenElement(126, "tr");
            __builder.AddMarkupContent(127, "<th>Single Vehicle Crash:</th>");
            __builder.OpenElement(128, "td");
            __builder.AddContent(129, 
#nullable restore
#line 31 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                               crash.SINGLE_VEHICLE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.OpenElement(131, "tr");
            __builder.AddMarkupContent(132, "<th>Distracted Driving:</th>");
            __builder.OpenElement(133, "td");
            __builder.AddContent(134, 
#nullable restore
#line 32 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                             crash.DISTRACTED_DRIVING

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.OpenElement(136, "tr");
            __builder.AddMarkupContent(137, "<th>Drowsy Driving:</th>");
            __builder.OpenElement(138, "td");
            __builder.AddContent(139, 
#nullable restore
#line 33 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                         crash.DROWSY_DRIVING

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.OpenElement(141, "tr");
            __builder.AddMarkupContent(142, "<th>Roadway Departure:</th>");
            __builder.OpenElement(143, "td");
            __builder.AddContent(144, 
#nullable restore
#line 34 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                            crash.ROADWAY_DEPARTURE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(148);
            __builder.AddAttribute(149, "class", "btn btn-warning");
            __builder.AddAttribute(150, "href", 
#nullable restore
#line 39 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(151, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(152, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(153, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(154);
            __builder.AddAttribute(155, "class", "btn btn-secondary");
            __builder.AddAttribute(156, "href", "/admin/crashes");
            __builder.AddAttribute(157, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(158, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\tstee\Source\Repos\bobby\Intex\Pages\Admin\Details.razor"
       
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

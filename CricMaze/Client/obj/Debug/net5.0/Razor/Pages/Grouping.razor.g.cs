#pragma checksum "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "814de2b72d819534ff6322c995e9cc75f2a17f26"
// <auto-generated/>
#pragma warning disable 1591
namespace CricMaze.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using CricMaze.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using CricMaze.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using CricMaze.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\_Imports.razor"
using CricMaze.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
using CricMaze.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/grouping")]
    public partial class Grouping : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.CricMaze.Client.Pages.Grouping.TypeInference.CreateSfGrid_0(__builder, 0, 1, 
#nullable restore
#line 5 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                     Players

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 5 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                                             true

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridGroupSettings>(4);
                __builder2.AddAttribute(5, "ShowGroupedColumn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ShowUngroupButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                                                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ShowToggleButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "CaptionTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
#nullable restore
#line 8 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
               
                var player = (context as CaptionTemplateContext);

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(9, "div");
                    __builder3.AddContent(10, 
#nullable restore
#line 10 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                       player.Field

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(11, " : ");
                    __builder3.AddContent(12, 
#nullable restore
#line 10 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                                       player.Key

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(13, " - ");
                    __builder3.AddContent(14, 
#nullable restore
#line 10 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                                                     player.Count

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(15, " Players");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(19);
                    __builder3.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.PlayerId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "HeaderText", "Player ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(23);
                    __builder3.AddAttribute(24, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "HeaderText", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(27);
                    __builder3.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "HeaderText", " Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(31);
                    __builder3.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.Country)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "HeaderText", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(35);
                    __builder3.AddAttribute(36, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.Role)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "HeaderText", "Role");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(39);
                    __builder3.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.Matches)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "HeaderText", "Matches");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(43);
                    __builder3.AddAttribute(44, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.Runs)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "HeaderText", "Runs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(47);
                    __builder3.AddAttribute(48, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.Highest)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "HeaderText", "Highest");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
                           nameof(Player.Wickets)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "HeaderText", "Wickets");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(55);
                    __builder3.AddAttribute(56, "Field", "Team.TeamName");
                    __builder3.AddAttribute(57, "HeaderText", "Team");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Grouping.razor"
       
    public List<Player> Players { get; set; }

    [Inject]
    public IPlayerService PlayerService{ get; set; }
    public List<Team> Teams { get; set; }
    [Inject]
   public ITeamService TeamService { get; set; }



    protected override async Task OnInitializedAsync()
    {
        Players = (await PlayerService.GetAllPlayers()).ToList();
        Teams = (await TeamService.GetTeams()).ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CricMaze.Client.Pages.Grouping
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowGrouping", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
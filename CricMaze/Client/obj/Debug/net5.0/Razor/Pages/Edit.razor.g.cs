#pragma checksum "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "112f383259ad3076558188d788272387002edb88"
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
#line 2 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
using CricMaze.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.CricMaze.Client.Pages.Edit.TypeInference.CreateSfGrid_0(__builder, 0, 1, 
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                       Players

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                             true

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                                              new List<string>() { "Add", "Edit", "Update", "Delete", "Cancel" }

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(5);
                __builder2.AddAttribute(6, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(8);
                __builder2.AddAttribute(9, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Player>>(13);
                __builder2.AddAttribute(14, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Player>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Player>>(this, 
#nullable restore
#line 9 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                               ActionBeginHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(18);
                    __builder3.AddAttribute(19, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                                   nameof(Player.PlayerId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "HeaderText", "Player ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(24);
                    __builder3.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "HeaderText", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(28);
                    __builder3.AddAttribute(29, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "HeaderText", " Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(32);
                    __builder3.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.Country)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "HeaderText", "Country");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(36);
                    __builder3.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.Role)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "HeaderText", "Role");
                    __builder3.AddAttribute(39, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<Role, string>>(40);
                        __builder4.AddAttribute(41, "ID", "Role");
                        __builder4.AddAttribute(42, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 17 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                       RoleEnumValues

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Role>(
#nullable restore
#line 17 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                                                                                    (context as Player).Role

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Role>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Role>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => (context as Player).Role = __value, (context as Player).Role))));
                        __builder4.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Role>>>(() => (context as Player).Role));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(47);
                    __builder3.AddAttribute(48, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.Matches)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "HeaderText", "Matches");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.Runs)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "HeaderText", "Runs");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(55);
                    __builder3.AddAttribute(56, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.Highest)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "HeaderText", "Highest");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(59);
                    __builder3.AddAttribute(60, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                           nameof(Player.Wickets)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "HeaderText", "Wickets");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n        ");
                    __Blazor.CricMaze.Client.Pages.Edit.TypeInference.CreateGridForeignColumn_1(__builder3, 63, 64, 
#nullable restore
#line 27 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                  nameof(Player.TeamId)

#line default
#line hidden
#nullable disable
                    , 65, "Team", 66, 
#nullable restore
#line 27 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
                                                                                              Teams

#line default
#line hidden
#nullable disable
                    , 67, "TeamName");
                }
                ));
                __builder2.CloseComponent();
            }
            , 68, (__value) => {
#nullable restore
#line 6 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
              playerGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\dot net by rohit\development\CricMazeProject\CricMaze\Client\Pages\Edit.razor"
       
    public List<Player> Players { get; set; }

    [Inject]
    public IPlayerService PlayerService { get; set; }
    public List<Team> Teams { get; set; }
    [Inject]
    public ITeamService TeamService { get; set; }

    public SfGrid<Player> playerGrid { get; set; }

    public string[] RoleEnumValues { get; set; } = Enum.GetNames(typeof(Role));


    protected override async Task OnInitializedAsync()
    {
        Players = (await PlayerService.GetAllPlayers()).ToList();
        Teams = (await TeamService.GetTeams()).ToList();
    }

    public async void ActionBeginHandler(ActionEventArgs<Player> Args)
    {
        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
        {
            if (Args.Action == "Add")
            {
                await PlayerService.AddPlayer(Args.Data);
                Players = (await PlayerService.GetAllPlayers()).ToList();
                playerGrid.Refresh();
            }
            else
            {
                await PlayerService.UpdatePlayer(Args.Data);
            }
        }

        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Delete))
        {
            await PlayerService.DeletePlayer(Args.Data.PlayerId);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CricMaze.Client.Pages.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "Toolbar", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.AddComponentReferenceCapture(__seq4, (__value) => { __arg4((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateGridForeignColumn_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<TValue> __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.GridForeignColumn<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Field", __arg0);
        __builder.AddAttribute(__seq1, "HeaderText", __arg1);
        __builder.AddAttribute(__seq2, "ForeignDataSource", __arg2);
        __builder.AddAttribute(__seq3, "ForeignKeyValue", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
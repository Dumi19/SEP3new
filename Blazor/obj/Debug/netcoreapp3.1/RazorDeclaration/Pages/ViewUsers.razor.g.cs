#pragma checksum "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\Pages\ViewUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ea2d385a164a578cbdf05f6819e508952981c0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\Pages\ViewUsers.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\Pages\ViewUsers.razor"
using Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewUsers")]
    public partial class ViewUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\maria\OneDrive\Documents\.NET\SEP3\Blazor\Pages\ViewUsers.razor"
       

    private IList<User> users;
    private IList<User> usersToShow;
    
    protected override async Task OnInitializedAsync()
    {
        users = await AddUserService.GetUserAsync();
        usersToShow = users;
        
        base.OnInitialized();
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddUserService AddUserService { get; set; }
    }
}
#pragma warning restore 1591

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
#line 1 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/Pages/ContactsPage.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/Pages/ContactsPage.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ContactsPage")]
    public partial class ContactsPage : Syncfusion.Blazor.SfBaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor/Pages/ContactsPage.razor"
      

    static List<DataModel> ListData = new List<DataModel>();
    
    IEnumerable<DataModel> EListData = ListData.Where(i => i.Name.ToLower().Contains(SearchTerm.ToLower()));
    
    static string SearchTerm { get; set; } = "";

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ListData.Add(new DataModel { Name = "Nancy", Icon = "N", Id = "0", Category = "Contacts", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Andrew", Icon = "A", Id = "1", Category = "Contacts", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Margaret", Icon = "M", Category = "Contacts", Id = "3", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "$teven2001", Icon = "S", Id = "4", Category = "Contacts", Nickname = "'Steven Thompson'", Status = "online"});
        ListData.Add(new DataModel { Name = "Laura", Icon = "L", Category = "Contacts", Id = "5", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Michael", Icon = "M", Id = "7", Category = "Contacts", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Albert", Icon = "A", Category = "Contacts", Id = "8", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Bums United", Icon = "M", Id = "7", Category = "Groups", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Amogus", Icon = "A", Category = "Groups", Id = "8", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "DOL", Icon = "N", Id = "9", Category = "Groups", Nickname = "", Status = ""});
    }

    public class DataModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public string Category { get; set; }
        public string Nickname { get; set; }
        public string Status { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

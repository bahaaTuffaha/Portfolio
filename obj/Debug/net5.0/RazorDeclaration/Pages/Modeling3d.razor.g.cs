// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace app_port.Pages
{
    #line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using app_port;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using app_port.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BAHAA\source\repos\app_port\app_port\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Modeling3d.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Modeling3d.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Modeling3d.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Modeling3d.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/3d")]
    public partial class Modeling3d : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\BAHAA\source\repos\app_port\app_port\Pages\Modeling3d.razor"
          
        class gallery
        {
            public string imageURL { get; protected set; }
            public string imageALT { get; protected set; }
            public int imageWidth { get; protected set; }
            public gallery(string url, string alt, int wd)
            {
                this.imageURL = url;
                this.imageALT = alt;
                this.imageWidth = wd;
            }

        }

        private bool arrows = false;
        private bool bullets = true;
        private bool autocycle = true;
        private Transition transition = Transition.Slide;
        Random rnd = new Random();
        public int spacing { get; set; } = 2;
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

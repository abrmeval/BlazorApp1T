#pragma checksum "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8856bd36b69b090ea3719cb11da66700dfbd7b1a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test")]
    public partial class Test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Test</h3>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 7 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
     Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, 
#nullable restore
#line 8 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
     Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, 
#nullable restore
#line 9 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
     Configuration["message"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
                         Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Projects\Testing Projects\.NET Core\BlazorApp1T\BlazorApp1\Pages\Test.razor"
       
    private string Name = "Jose";
    private string Address = "Benito Juarez";
    [Parameter]
    public string Phone { get; set; } = "77123456789";

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
    }
}
#pragma warning restore 1591

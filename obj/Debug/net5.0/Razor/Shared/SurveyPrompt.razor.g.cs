#pragma checksum "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6fafc2643092bca6566560c3a7d0f9a391d67a4"
// <auto-generated/>
#pragma warning disable 1591
namespace Pertemuan_2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Pertemuan_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\_Imports.razor"
using Pertemuan_2.Shared;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Home Page</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(3, "role", "alert");
            __builder.AddMarkupContent(4, "<span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(5, "strong");
            __builder.AddContent(6, 
#nullable restore
#line 4 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.AddMarkupContent(8, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2137916\">brief survey</a></span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Kuliah\Semester\Semester 5\Visual Studio Code\Pemrogramman Frontend\Pertemuan 2\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

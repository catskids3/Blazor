#pragma checksum "D:\github\Blazor\blazorcalculator\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c090fe762ae5444f8f2c134def8024d860d73ef"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCalculator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using BlazorCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\github\Blazor\blazorcalculator\_Imports.razor"
using BlazorCalculator.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Basic Calculator Demo Using Blazor</h1>\r\n");
            __builder.AddMarkupContent(1, "<h4>Ported to .NET Core 3.1 from \'ASP.NET Core-Getting Started With Blazor\' by Ankit Sharma, March 31, 2018</h4>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<div class=\"col-sm-3\">\r\n            <p>First Number</p>\r\n        </div>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-4");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "placeholder", "Enter First Number");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                                                           num1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => num1 = __value, num1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    <br>\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<div class=\"col-sm-3\">\r\n            <p>Second Number</p>\r\n        </div>\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-4");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "placeholder", "Enter Second Number");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                                                            num2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => num2 = __value, num2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    <br>\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<div class=\"col-sm-3\">\r\n            <p>Result</p>\r\n        </div>\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-sm-4");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "readonly", true);
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                                   finalResult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => finalResult = __value, finalResult));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    <br>\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-sm-2");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                              AddNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "btn btn-success");
            __builder.AddContent(55, "Add (+)");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-sm-2");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                              SubtractNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "class", "btn btn-warning");
            __builder.AddContent(64, "Subtract (+)");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-2");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                              MultiplyNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "class", "btn btn-info");
            __builder.AddContent(73, "Multiply (X)");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-sm-2");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
                              DivideNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "class", "btn btn-danger");
            __builder.AddContent(82, "Divide (/)");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\github\Blazor\blazorcalculator\Pages\Index.razor"
       
    string num1;
    string num2;
    string finalResult;

    void AddNumbers()
    {
        finalResult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
    }

    void SubtractNumbers()
    {
        finalResult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
    }

    void MultiplyNumbers()
    {
        finalResult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
    }

    void DivideNumbers()
    {
        if(Convert.ToDouble(num2) != 0)
        {
            finalResult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();            
        }
        else
        {
            finalResult = "Cannot Divide by Zero";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

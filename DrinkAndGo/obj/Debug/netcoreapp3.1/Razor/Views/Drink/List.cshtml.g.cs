#pragma checksum "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873222f4ef4750f73f4f756bb6554f611be91981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873222f4ef4750f73f4f756bb6554f611be91981", @"/Views/Drink/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6505ef9ef9daf82d811da15cc9ef3bc27ded435", @"/Views/_ViewImports.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid d-flex justify-content-center\">\r\n\r\n    <div class=\"row w-75 d-flex flex-column\">\r\n        <h1>");
#nullable restore
#line 8 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
       Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
             foreach (Drink drink in Model.Drinks)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
           Write(Html.PartialAsync("_drinkCard", drink).Result);

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
                                                              ;


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'[data-toggle=\"tooltip\"]\').tooltip();\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e161d166cf9719e4ddc80475124d5a788492d09a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#nullable restore
#line 3 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e161d166cf9719e4ddc80475124d5a788492d09a", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28df4fa97b4ca3173c043fb3045c6a60b3fc855a", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container checkoutForm"">
    <h2>Your shopping cart</h2>
    <h4>Here are the drinks in your shopping cart.</h4>
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Selected amount</th>
                <th>Drink</th>
                <th class=""text-right"">Price</th>
                <th class=""text-right"">Subtotal</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
             foreach (var line in Model.ShoppingCart.ShoppingCartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 25 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
                                       Write(line.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 26 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
                                     Write(line.Drink.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 27 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
                                      Write(line.Drink.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">\r\n                        ");
#nullable restore
#line 29 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
                    Write((line.Amount * line.Drink.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\"><a class=\"glyphicon glyphicon-remove text-danger remove\" asp-controller=\"ShoppingCart\" asp-action=\"RemoveFromShoppingCart\"");
            BeginWriteAttribute("asp-route-drinkId", " asp-route-drinkId=\"", 1188, "\"", 1222, 1);
#nullable restore
#line 31 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1208, line.Drink.Id, 1208, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n                <td class=\"text-right\">\r\n                    ");
#nullable restore
#line 39 "D:\WEB\ASP\DrinkAndGo\DrinkAndGo\Views\ShoppingCart\Index.cshtml"
               Write(Model.TotalPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>
        </tfoot>
    </table>

    <div class=""text-right"">
        <div class=""btn-group "">
            <a class=""btn btn-success"" asp-controller=""Order"" asp-action=""Checkout"">Check out</a>
            <a class=""btn-group"">
                <a class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"">
                    Add more drinks<span class=""caret""></span>
                </a>
                <ul class=""dropdown-menu"" role=""menu"">
                    <li><a asp-controller=""Drink"" asp-action=""List"" asp-route-category=""Alcoholic"">Alcoholic</a></li>
                    <li><a asp-controller=""Drink"" asp-action=""List"" asp-route-category=""Non-alcoholic"">Non Alcoholic</a></li>
                </ul>
            </a>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
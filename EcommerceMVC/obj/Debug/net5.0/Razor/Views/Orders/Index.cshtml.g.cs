#pragma checksum "C:\Users\mirko.MIRKO\source\repos\EcommerceMVC\EcommerceMVC\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a5e5b8dd0eabf176f7c3a091493b5678a1ce652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\mirko.MIRKO\source\repos\EcommerceMVC\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirko.MIRKO\source\repos\EcommerceMVC\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mirko.MIRKO\source\repos\EcommerceMVC\EcommerceMVC\Views\Orders\Index.cshtml"
using EcommerceMVC.Data.Cart;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5e5b8dd0eabf176f7c3a091493b5678a1ce652", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b95bdb520a4101d64f735ad34f10dba324a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\mirko.MIRKO\source\repos\EcommerceMVC\EcommerceMVC\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""text-center"">
            <h2>Your Shopping Cart Summary</h2>
        </div>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Selected Amount</th>
                    <th>Movie</th>
                    <th>Price</th>
                    <th>Subtotal</th>
                    <th></th>
                </tr>
            </thead>

           <tbody></tbody>

            <tfoot></tfoot>
        </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591

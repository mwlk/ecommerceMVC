#pragma checksum "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3bb514ecf1c5653ecd412bcaf19613b7ba0953c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producers_Index), @"mvc.1.0.view", @"/Views/Producers/Index.cshtml")]
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
#line 1 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3bb514ecf1c5653ecd412bcaf19613b7ba0953c", @"/Views/Producers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b95bdb520a4101d64f735ad34f10dba324a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
  
    ViewData["Title"] = "List of Producers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table table-hover table-responsive-lg\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 16 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Profile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 17 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 18 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 872, "\"", 891, 1);
#nullable restore
#line 27 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
WriteAttributeValue("", 878, item.Profile, 878, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 892, "\"", 912, 1);
#nullable restore
#line 27 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
WriteAttributeValue("", 898, item.FullName, 898, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 style=\"max-width: 125px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <div class=""container-fluid"">
                                <a class=""btn btn-outline-primary"">
                                    <i class=""bi bi-pencil-square""></i>
                                    Edit
                                </a> |

                                <a class=""btn btn-outline-info"">
                                    <i class=""bi bi-eye""></i>
                                    Detail
                                </a> |

                                <a class=""btn btn-danger text-white"">
                                    <i class=""bi bi-trash""></i>
                                    Delete
                                </a>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 55 "C:\Users\mirko.MIRKO\source\repos\ecommerceMVC\EcommerceMVC\Views\Producers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026f383f71c25e962ff246a54b1db8ac17d01f56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ShoppingCart), @"mvc.1.0.view", @"/Views/Movie/ShoppingCart.cshtml")]
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
#line 1 "C:\Users\herri\source\repos\Lab22-Sessions\Views\_ViewImports.cshtml"
using Lab21_MovieRegisteration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\herri\source\repos\Lab22-Sessions\Views\_ViewImports.cshtml"
using Lab21_MovieRegisteration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"026f383f71c25e962ff246a54b1db8ac17d01f56", @"/Views/Movie/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a54cf2a2455759c92c418f96273e25c372ed6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>ShoppingCart</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
  
    for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>");
#nullable restore
#line 8 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
       Write(Model[i].ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>");
#nullable restore
#line 9 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
       Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>");
#nullable restore
#line 10 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
       Write(Model[i].Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>");
#nullable restore
#line 11 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
       Write(Model[i].Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>");
#nullable restore
#line 12 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
       Write(Model[i].Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 13 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\ShoppingCart.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
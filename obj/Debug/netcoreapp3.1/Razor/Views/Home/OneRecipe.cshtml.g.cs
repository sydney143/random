#pragma checksum "C:\Users\sydney1423\random\Views\Home\OneRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0e125e58f9c6cfa0b681cbc651216da1a8df5ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneRecipe), @"mvc.1.0.view", @"/Views/Home/OneRecipe.cshtml")]
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
#line 1 "C:\Users\sydney1423\random\Views\_ViewImports.cshtml"
using Random;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sydney1423\random\Views\_ViewImports.cshtml"
using Random.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e125e58f9c6cfa0b681cbc651216da1a8df5ca", @"/Views/Home/OneRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d645ce978c40a10278b9f0b34a7f9f083f93cb5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1> Chef\'s Name: ");
#nullable restore
#line 1 "C:\Users\sydney1423\random\Views\Home\OneRecipe.cshtml"
             Write(ViewBag.OneRecipe.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Dish Name: ");
#nullable restore
#line 2 "C:\Users\sydney1423\random\Views\Home\OneRecipe.cshtml"
          Write(ViewBag.OneRecipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1> Calories:");
#nullable restore
#line 3 "C:\Users\sydney1423\random\Views\Home\OneRecipe.cshtml"
         Write(ViewBag.OneRecipe.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Tastiness:");
#nullable restore
#line 4 "C:\Users\sydney1423\random\Views\Home\OneRecipe.cshtml"
         Write(ViewBag.OneRecipe.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Description:");
#nullable restore
#line 5 "C:\Users\sydney1423\random\Views\Home\OneRecipe.cshtml"
           Write(ViewBag.OneRecipe.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
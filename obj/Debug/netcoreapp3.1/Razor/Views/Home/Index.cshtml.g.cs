#pragma checksum "C:\Users\sydney1423\random\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06eeb9f5a91c7161dc089944f24173b910a5ef8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06eeb9f5a91c7161dc089944f24173b910a5ef8d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d645ce978c40a10278b9f0b34a7f9f083f93cb5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
<h1>Welcome to CRUDelicious</h1>
<h2>Check out some recent dishes!</h2>
<table class = ""table table-striped"">
    <tr>
       <th>Chef</th> 
        <th>Name</th>
        <th>Calories</th>
        <th>Tastiness</th>
        <th>Description</th>
        <th>Actions</th>
        </tr>

");
#nullable restore
#line 18 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
          
            foreach(Recipe g in ViewBag.AllRecipes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 499, "\"", 528, 2);
            WriteAttributeValue("", 506, "/onerecipe/", 506, 11, true);
#nullable restore
#line 22 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
WriteAttributeValue("", 517, g.RecipeId, 517, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
                                                    Write(g.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
                   Write(g.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
                   Write(g.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
                   Write(g.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
                   Write(g.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 738, "\"", 763, 2);
            WriteAttributeValue("", 745, "delete/", 745, 7, true);
#nullable restore
#line 27 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
WriteAttributeValue("", 752, g.RecipeId, 752, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> /  <a");
            BeginWriteAttribute("href", " href=\"", 781, "\"", 804, 2);
            WriteAttributeValue("", 788, "edit/", 788, 5, true);
#nullable restore
#line 27 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
WriteAttributeValue("", 793, g.RecipeId, 793, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\sydney1423\random\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n</table>\r\n</div>\r\n");
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

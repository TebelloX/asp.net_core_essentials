#pragma checksum "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d45dd01929859b740c71eedb52211a8774c8ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCraftsWebsite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCraftsWebsite.Pages
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
#line 1 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\_ViewImports.cshtml"
using ContosoCraftsWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml"
using ContosoCraftsWebsite.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d45dd01929859b740c71eedb52211a8774c8ce8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18e8b8a17978aae9fb8112e6c3d4f73175339e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Contoso Crafts</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml"
 foreach( var product in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 407, "\"", 454, 4);
            WriteAttributeValue("", 415, "background-image:", 415, 17, true);
            WriteAttributeValue(" ", 432, "url(\'", 433, 6, true);
#nullable restore
#line 16 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml"
WriteAttributeValue("", 438, product.Image, 438, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 452, "\')", 452, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\tnamo\Desktop\asp.net_core_essentials\ContosoCrafts\ContosoCraftsWebsite\Pages\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

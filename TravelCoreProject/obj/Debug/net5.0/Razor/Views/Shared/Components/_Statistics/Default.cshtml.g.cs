#pragma checksum "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Shared\Components\_Statistics\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81f8bd15c989c6b820e2af91a4df2257f9b75da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Statistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Statistics/Default.cshtml")]
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
#line 1 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\_ViewImports.cshtml"
using TravelCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\_ViewImports.cshtml"
using TravelCoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81f8bd15c989c6b820e2af91a4df2257f9b75da", @"/Views/Shared/Components/_Statistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c391ead22fe854d42be9e38773f792c7b70667", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Statistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"w3l-stats py-5\" id=\"stats\">\r\n    <div class=\"gallery-inner container py-lg-0 py-3\">\r\n        <div class=\"row stats-con pb-lg-3\">\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid\">\r\n                <p class=\"counter\">");
#nullable restore
#line 5 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Shared\Components\_Statistics\Default.cshtml"
                              Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Routes</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid1\">\r\n                <p class=\"counter\">");
#nullable restore
#line 9 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Shared\Components\_Statistics\Default.cshtml"
                              Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Travel Guides</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid mt-lg-0 mt-5\">\r\n                <p class=\"counter\">");
#nullable restore
#line 13 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Shared\Components\_Statistics\Default.cshtml"
                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <h4>Happy Customers</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid2 mt-lg-0 mt-5"">
                <p class=""counter"">27</p>
                <h4>Awards</h4>
            </div>
        </div>
    </div>
</section>");
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

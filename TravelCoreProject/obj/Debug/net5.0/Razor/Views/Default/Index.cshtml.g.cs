#pragma checksum "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad66d59d9b0188309bb5355f267b1df8f29ac37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad66d59d9b0188309bb5355f267b1df8f29ac37", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c391ead22fe854d42be9e38773f792c7b70667", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Tuncer Rüstemoğlu\source\repos\TravelCoreProject\TravelCoreProject\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_SliderPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Visit</h6>
            <h3 class=""hny-title"">Popular Destinations</h3>
        </div>
        <div class=""row bottom-ab-grids"">
            <!--/row-grids-->
            <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 865, "\"", 871, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Paris</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1190, "\"", 1198, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1650</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g2.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1928, "\"", 1934, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Bankok</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 2254, "\"", 2262, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1850</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <!--//row-grids-->
            <!--/row-grids-->
            <div class=""col-lg-6 subject-card mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3047, "\"", 3053, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Maldives</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 3375, "\"", 3383, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1350</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <div class=""col-lg-6 subject-card mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g4.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4105, "\"", 4111, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Greece</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 4431, "\"", 4439, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1650</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <!--//row-grids-->
            <!--/row-grids-->
            <div class=""col-lg-6 subject-card mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g5.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5224, "\"", 5230, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>London</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 5550, "\"", 5558, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1750</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <div class=""col-lg-6 subject-card mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g6.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6280, "\"", 6286, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Julian Alps</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 6611, "\"", 6619, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1950</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <!--//row-grids-->
            <!--/row-grids-->
            <div class=""col-lg-6 subject-card mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g7.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7404, "\"", 7410, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Thailand</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 7732, "\"", 7740, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1750</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <div class=""col-lg-6 subject-card mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img src=""assets/images/g8.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 8462, "\"", 8468, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-sm-7 subject-content mt-sm-0 mt-4"">
                                <h4>Singapore</h4>
                                <p>3Days, 4 Nights</p>
                                <div class=""dst-btm"">
                                    <h6");
            BeginWriteAttribute("class", " class=\"", 8791, "\"", 8799, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Start From </h6>
                                    <span>$1950</span>
                                </div>
                                <p class=""sub-para"">Per person on twin sharing</p>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <!--//row-grids-->
        </div>
    </div>
</section>

<section class=""w3l-stats py-5"" id=""stats"">
    <div class=""gallery-inner container py-lg-0 py-3"">
        <div class=""row stats-con pb-lg-3"">
            <div class=""col-lg-3 col-6 stats_info counter_grid"">
                <p class=""counter"">730</p>
                <h4>Branches</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid1"">
                <p class=""counter"">1680</p>
                <h4>Travel Guides</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid mt-lg-0 mt-5"">
                <p class=""counter"">812</p>
      ");
            WriteLiteral(@"          <h4>Happy Customers</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid2 mt-lg-0 mt-5"">
                <p class=""counter"">990</p>
                <h4>Awards</h4>
            </div>
        </div>
    </div>
</section>

<div class=""best-rooms py-5"">
    <div class=""container py-md-5"">
        <div class=""ban-content-inf row"">
            <div class=""maghny-gd-1 col-lg-6"">
                <div class=""maghny-grid"">
                    <figure class=""effect-lily border-radius  m-0"">
                        <img class=""img-fluid"" src=""assets/images/g10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10444, "\"", 10450, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <figcaption>
                            <div>
                                <h4>3Days, 4 Nights</h4>
                                <p>From 1720$ </p>
                            </div>

                        </figcaption>
                    </figure>
                </div>
            </div>
            <div class=""maghny-gd-1 col-lg-6 mt-lg-0 mt-4"">
                <div class=""row"">
                    <div class=""maghny-gd-1 col-6"">
                        <div class=""maghny-grid"">
                            <figure class=""effect-lily border-radius"">
                                <img class=""img-fluid"" src=""assets/images/g9.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11144, "\"", 11150, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <figcaption>
                                    <div>
                                        <h4>3Days, 4 Nights</h4>
                                        <p>From 1220$ </p>
                                    </div>

                                </figcaption>
                            </figure>
                        </div>
                    </div>
                    <div class=""maghny-gd-1 col-6"">
                        <div class=""maghny-grid"">
                            <figure class=""effect-lily border-radius"">
                                <img class=""img-fluid"" src=""assets/images/g8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11820, "\"", 11826, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <figcaption>
                                    <div>
                                        <h4>3Days, 4 Nights</h4>
                                        <p>From 1620$ </p>
                                    </div>

                                </figcaption>
                            </figure>
                        </div>
                    </div>
                    <div class=""maghny-gd-1 col-6 mt-4"">
                        <div class=""maghny-grid"">
                            <figure class=""effect-lily border-radius"">
                                <img class=""img-fluid"" src=""assets/images/g7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12501, "\"", 12507, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <figcaption>
                                    <div>
                                        <h4>3Days, 4 Nights</h4>
                                        <p>From 1820$ </p>
                                    </div>

                                </figcaption>
                            </figure>
                        </div>
                    </div>
                    <div class=""maghny-gd-1 col-6 mt-4"">
                        <div class=""maghny-grid"">
                            <figure class=""effect-lily border-radius"">
                                <img class=""img-fluid"" src=""assets/images/g6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13182, "\"", 13188, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <figcaption>
                                    <div>
                                        <h4>3Days, 4 Nights</h4>
                                        <p>From 1520$ </p>
                                    </div>

                                </figcaption>
                            </figure>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""w3l-bottom py-5"">
    <div class=""container py-md-4 py-3 text-center"">
        <div class=""row my-lg-4 mt-4"">
            <div class=""col-lg-9 col-md-10 ml-auto"">
                <div class=""bottom-info ml-auto"">
                    <div class=""header-section text-left"">
                        <h3 class=""hny-title two"">Traveling makes a man wiser, but less happy.</h3>
                        <p class=""mt-3 pr-lg-5"">
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. ");
            WriteLiteral(@"Velit beatae laudantium
                            voluptate rem ullam dolore nisi voluptatibus esse quasi. Integer sit amet .Lorem ipsum dolor sit
                            amet adipisicing elit.
                        </p>
                        <a href=""about.html"" class=""btn btn-style btn-secondary mt-5"">Read More</a>
                    </div>


                </div>
            </div>
        </div>
    </div>
</section>

<section class=""w3l-clients"" id=""clients"">
    <!-- /grids -->
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Here’s what they have to say</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">our clients do the talking</h3>
            </div>
            <!-- /grids -->
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
              ");
            WriteLiteral(@"      <div class=""item"">
                        <div class=""testimonial-content"">
                            <div class=""testimonial"">
                                <blockquote>
                                    <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit beatae laudantium
                                    voluptate rem ullam dolore nisi voluptatibus esse quasi. Integer sit amet .Lorem ipsum dolor sit
                                    amet adipisicing elit. Laborum dolor facere ipsum adipisicingelit.
                                </blockquote>
                                <div class=""testi-des"">
                                    <div class=""test-img"">
                                        <img src=""assets/images/c1.jpg"" class=""img-fluid"" alt=""client-img"">
                                    </div>
                                    <div class=""peopl align-self"">
  ");
            WriteLiteral(@"                                      <h3>Rohit Paul</h3>
                                        <p class=""indentity"">Example City</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimonial-content"">
                            <div class=""testimonial"">
                                <blockquote>
                                    <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit beatae laudantium
                                    voluptate rem ullam dolore nisi voluptatibus esse quasi. Integer sit amet .Lorem ipsum dolor sit
                                    amet adipisicing elit. Laborum dolor facere ipsum adipisicingelit.
                                </blockquote>
        ");
            WriteLiteral(@"                        <div class=""testi-des"">
                                    <div class=""test-img"">
                                        <img src=""assets/images/c2.jpg"" class=""img-fluid"" alt=""client-img"">
                                    </div>
                                    <div class=""peopl align-self"">
                                        <h3>Shveta</h3>
                                        <p class=""indentity"">Example City</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimonial-content"">
                            <div class=""testimonial"">
                                <blockquote>
                                    <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                    Lorem ipsum dolor sit amet consectetur adipisic");
            WriteLiteral(@"ing elit. Velit beatae laudantium
                                    voluptate rem ullam dolore nisi voluptatibus esse quasi. Integer sit amet .Lorem ipsum dolor sit
                                    amet adipisicing elit. Laborum dolor facere ipsum adipisicingelit.
                                </blockquote>
                                <div class=""testi-des"">
                                    <div class=""test-img"">
                                        <img src=""assets/images/c3.jpg"" class=""img-fluid"" alt=""client-img"">
                                    </div>
                                    <div class=""peopl align-self"">
                                        <h3>Roy Linderson</h3>
                                        <p class=""indentity"">Example City</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
   ");
            WriteLiteral(@"                     <div class=""testimonial-content"">
                            <div class=""testimonial"">
                                <blockquote>
                                    <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit beatae laudantium
                                    voluptate rem ullam dolore nisi voluptatibus esse quasi. Integer sit amet .Lorem ipsum dolor sit
                                    amet adipisicing elit. Laborum dolor facere ipsum adipisicingelit.
                                </blockquote>
                                <div class=""testi-des"">
                                    <div class=""test-img"">
                                        <img src=""assets/images/c4.jpg"" class=""img-fluid"" alt=""client-img"">
                                    </div>
                                    <div class=""peopl align-self"">
                               ");
            WriteLiteral(@"         <h3>Mike Thyson</h3>
                                        <p class=""indentity"">Example City</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                </div>
            </div>
        </div>
        <!-- /grids -->
    </div>
    <!-- //grids -->
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

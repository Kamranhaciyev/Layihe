#pragma checksum "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d0ff16d3165e03099ffbe90188389a3b1e2e800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\_ViewImports.cshtml"
using FinalLayihesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\_ViewImports.cshtml"
using FinalLayihesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\_ViewImports.cshtml"
using FinalLayihesi.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0ff16d3165e03099ffbe90188389a3b1e2e800", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd51b0f086d85cb643dbdb293b8bc396b753527", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelAbout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/about-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""header-third-part"">
    <div class=""container"">
        <h1>About Us</h1>
    </div>
</section>
<main>
    <section id=""about-main-second-part"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-lg-8"">
                    <span class=""pre-title m-0"">");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                           Write(Model.About.Pretitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h2><span class=\"featured\">");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                          Write(Model.About.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                                                     Write(Model.About.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras iaculis diam varius diam ultricies lacinia. <b>Mauris lacus tellus, ultrices eu volutpat sit amet, finibus a ipsum.</b> Nullam sit amet pretium felis.</p>
                    <p>Curabitur convallis, diam a egestas iaculis, neque lorem interdum felis, in viverra lacus tortor in leo.</p>
                    <p>Donec tristique diam id mi venenatis facilisis eget sed mi. Phasellus malesuada nulla diam, a dignissim quam congue et.</p>
                    <p><b>Cras sem ante, accumsan quis sem sed, rutrum varius nunc.</b></p>
                </div>
                <div class=""col-12 col-lg-4"">
                    <div class=""cards mt-5 mt-lg-0"">
                        <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 26 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                             foreach (var item in Model.AboutCards)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item d-flex justify-content-center align-items-center item-color\">\r\n                                    <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1598, "\"", 1616, 1);
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
WriteAttributeValue("", 1606, item.Icon, 1606, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                    <div class=\"list-group-content\">\r\n                                        <h4>");
#nullable restore
#line 31 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p>");
#nullable restore
#line 32 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 35 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""about-main-third-part"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-md-6 pe-md-5"">
                    <span class=""pre-title m-0"">");
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                           Write(Model.Results.Pretitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h2><span class=\"featured\">");
#nullable restore
#line 48 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                          Write(Model.Results.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 48 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                                                       Write(Model.Results.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras iaculis diam varius diam ultricies lacinia.</p>
                    <p>Mauris lacus tellus, ultrices eu volutpat sit amet, finibus a ipsum.</p>
                    <p>Curabitur convallis, diam a egestas iaculis, neque lorem interdum felis, in viverra lacus tortor in leo.</p>
                    <blockquote>Donec tristique diam id mi venenatis facilisis eget sed mi. Phasellus malesuada nulla diam, a dignissim quam.</blockquote>
                </div>
                <div class=""col-12 col-md-6 pe-md-5"">
                    <div class=""row"">
");
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                         foreach (var item in Model.ResultCards.Take(2))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div data-aos=\"fade-up\" class=\"col-12 col-md-6 p-0 pe-md-4 mb-2 item\">\r\n                                <span class=\"numbers\">");
#nullable restore
#line 59 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                                 Write(item.Numbers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h4>");
#nullable restore
#line 60 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 61 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 63 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </div>\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 67 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                          foreach (var item in Model.ResultCards.Skip(2))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div data-aos=\"fade-up\" class=\"col-12 col-md-6 p-0 pe-md-4 mb-2 item\">\r\n                                <span class=\"numbers\">");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                                                 Write(item.Numbers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h4>");
#nullable restore
#line 71 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 72 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 74 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""main-third-part"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <span class=""span-about mt-5 mb-4"">ABOUT THE NETWORK</span>
                    <h2><span class=""span-h2""> The</span> Company</h2>
                    <p class=""mt-4"">
                        For 12 years we have been providing audit and warranty,
                        financial advice, risk advice, taxes and related services to
                        select clients.
                    </p>
                    <div class=""row"" style=""padding-bottom: 100px"">
                        <div class=""col-md-6"">
                            <h4><i class=""me-2 fas fa-certificate""></i>Tradition</h4>
                            <p>Lorem ipsum dolor sit amet consectetur adipiscing elit.</p>
                        </div>
 ");
            WriteLiteral(@"                       <div class=""col-md-6"">
                            <h4><i class=""me-2 fas fa-lock""></i>Security</h4>
                            <p>Lorem ipsum dolor sit amet consectetur adipiscing elit.</p>
                        </div>
                        <div class=""col-md-6"">
                            <h4><i class=""me-2 far fa-sticky-note""></i>Certificate</h4>
                            <p>Lorem ipsum dolor sit amet consectetur adipiscing elit.</p>
                        </div>
                        <div class=""col-md-6"">
                            <h4><i class=""me-2 fas fa-graduation-cap""></i>Expertise</h4>
                            <p>Lorem ipsum dolor sit amet consectetur adipiscing elit.</p>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-6 p-0 image"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d0ff16d3165e03099ffbe90188389a3b1e2e80016529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>

    <section id=""about-main-fourth-part"">
        <div class=""container"">
            <div class=""row text-center intro"">
                <div class=""col-12"">
                    <span class=""pre-title m-auto"">Customer Testimonials</span>
                    <h2>Trusted <span>Feedback</span></h2>
                    <p class=""text-max-800"">We work intensively in search of ideals that can add up in the lives of our customers. This is what moves us and we are grateful for the recognition.</p>
                </div>
            </div>
            <div class=""owl-carousel owl-theme"">
");
#nullable restore
#line 128 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                 foreach (var item in Model.Testimonials)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row card\">\r\n                        <div class=\"col-12\">\r\n                            <div class=\"item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d0ff16d3165e03099ffbe90188389a3b1e2e80018786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6995, "~/images/about/", 6995, 15, true);
#nullable restore
#line 133 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 7010, item.Image, 7010, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <p>Praesent volutpat justo sit amet elementum malesuada. Praesent sagittis augue justo, in accumsan orci rhoncus at pellentesque.</p>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                <i class=""fas fa-quote-right""></i>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 140 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\About\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591

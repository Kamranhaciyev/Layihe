#pragma checksum "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402da526964736ddaeb974fa0a08e53923a49ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402da526964736ddaeb974fa0a08e53923a49ab0", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd51b0f086d85cb643dbdb293b8bc396b753527", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelServices>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("php/form.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("nexgen-simple-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nexgen-simple-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""process-management"">
        <div class=""container full"">
            <div class=""row text-center intro"">
                <div class=""col-12"">
                    <span class=""pre-title"">How it works in practice</span>
                    <h2><span>Process</span> Management</h2>
                    <p style=""margin-left: 20%; margin-right: 20%;"">We work with innovative methodologies to ensure that the entire reformatting process is done from start to finish as planned.</p>
                </div>
            </div>
            <div class=""row justify-content-center text-center items"">
");
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                 foreach (var item in Model.Process)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-md-6 col-lg-2 item\">\r\n                        <div class=\"number\"><span>0 ");
#nullable restore
#line 20 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                                               Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        <h4>");
#nullable restore
#line 21 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 24 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </div>
        </div>
    </section>
    <section id=""excellence"">
        <div class=""container"">
            <div class=""row intro"">
                <div class=""col-12 col-md-9"">
                    <span class=""pre-title m-auto ms-md-0"">Our business areas</span>
                    <h2 class=""mb-0"">Excellence in <span>Services</span></h2>
                </div>
                <div class=""col-12 col-md-3 align-self-end"">
                    <a href=""#contact"" class=""smooth-anchor btn mx-auto mr-md-0 ml-md-auto outline-button"">GET IN TOUCH</a>
                </div>
            </div>
            <div class=""row justify-content-center items"">
");
#nullable restore
#line 41 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                 foreach (var item in Model.Businesses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div data-aos=\"fade-up\" class=\"col-12 col-md-6 item\">\r\n                        <div class=\"card mt-5\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 1984, "\"", 2007, 2);
            WriteAttributeValue("", 1992, "icon", 1992, 4, true);
#nullable restore
#line 45 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
WriteAttributeValue(" ", 1996, item.Icon, 1997, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            <h4>");
#nullable restore
#line 46 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras iaculis diam varius diam ultricies lacinia.</p>
                            <p>Curabitur convallis, diam a egestas iaculis, neque lorem interdum felis, in viverra lacus tortor in leo.</p>
                            <a href=""#""><i class=""btn-icon pulse fas fas fa-arrow-right""></i></a>
                        </div>
                    </div>
");
#nullable restore
#line 52 "C:\Users\Asus\Desktop\Layihe\FinalLayihesi\FinalLayihesi\Views\Services\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </div>
        </div>
    </section>
    <section id=""message"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-md-8 pe-5"">
                    <div class=""col-12 p-0"">
                        <span class=""pre-title m-0"">Send a message</span>
                        <h2>Get in <span>Touch</span></h2>
                        <p>We will respond to your message as soon as possible.</p>
                    </div>
                    <div class=""row"">
                        <div class=""col-12 p-0"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab010650", async() => {
                WriteLiteral(@"
                                <input type=""hidden"" name=""section"" value=""nexgen_form"">

                                <input type=""hidden"" name=""reCAPTCHA"">
                                <div class=""row form-group-margin"">
                                    <div class=""col-12 col-md-6 m-0 p-2"">
                                        <input type=""text"" name=""name"" class=""form-control field-name"" placeholder=""Name"">
                                    </div>
                                    <div class=""col-12 col-md-6 m-0 p-2"">
                                        <input type=""email"" name=""email"" class=""form-control field-email"" placeholder=""Email"">
                                    </div>
                                    <div class=""col-12 col-md-6 m-0 p-2"">
                                        <input type=""text"" name=""phone"" class=""form-control field-phone"" placeholder=""Phone"">
                                    </div>
                                    <div class=""col-1");
                WriteLiteral("2 col-md-6 m-0 p-2\">\r\n                                        <i class=\"icon-arrow-down mr-3\"></i>\r\n                                        <select name=\"info\" class=\"form-control field-info\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab012259", async() => {
                    WriteLiteral("More Info");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab014176", async() => {
                    WriteLiteral("Audit & Assurance");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab015246", async() => {
                    WriteLiteral("Financial Advisory");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab016317", async() => {
                    WriteLiteral("Analytics and M&A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab017387", async() => {
                    WriteLiteral("Middle Marketing");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab018456", async() => {
                    WriteLiteral("Legal Consulting");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab019525", async() => {
                    WriteLiteral("Regulatory Risk");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "402da526964736ddaeb974fa0a08e53923a49ab020593", async() => {
                    WriteLiteral("Other");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                    <div class=""col-12 m-0 p-2"">
                                        <textarea name=""message"" class=""form-control field-message"" placeholder=""Message""></textarea>
                                    </div>
                                    <div class=""col-12 col-12 m-0 p-2"">
                                        <span class=""form-alert""></span>
                                    </div>
                                    <div class=""col-12 m-0 p-2"">
                                        <a class=""btn primary-button"">SEND</a>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                <div class=""col-12 col-md-4"">
                    <div class=""contacts"">
                        <h4>Example Inc.</h4>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                        <p>Praesent diam lacus, dapibus sed imperdiet consectetur.</p>
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link"">
                                    <i class=""fas fa-phone-alt mr-2""></i>
                                    +1 (305) 1234-5678
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link"">
                                    <i class=""fas fa-envelope mr-2""></i>
                                    hello@example.com
             ");
            WriteLiteral(@"                   </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link"">
                                    <i class=""fas fa-map-marker-alt mr-2""></i>
                                    Main Avenue, 987
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#"" class=""mt-2 btn outline-button"" data-toggle=""modal"" data-target=""#map"">VIEW MAP</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
    </section>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelServices> Html { get; private set; }
    }
}
#pragma warning restore 1591

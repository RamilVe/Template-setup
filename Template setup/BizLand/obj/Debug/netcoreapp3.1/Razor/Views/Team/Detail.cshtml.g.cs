#pragma checksum "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5176f7cd05e5d06c3b63fd6eaa8d8329bc3dfe3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Detail), @"mvc.1.0.view", @"/Views/Team/Detail.cshtml")]
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
#line 1 "C:\Users\User\source\c#\Template setup\BizLand\Views\_ViewImports.cshtml"
using BizLand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\c#\Template setup\BizLand\Views\_ViewImports.cshtml"
using BizLand.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5176f7cd05e5d06c3b63fd6eaa8d8329bc3dfe3c", @"/Views/Team/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b23dcae0cf384a93ce4754210ca53ec0a53f58", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<main id=""main"">
    
    <!-- ======= Team Section ======= -->
    <section id=""team"" class=""team section-bg"">
      <div class=""container"" data-aos=""fade-up"">

        <div class=""section-title"">
          <h2>Team</h2>
          <h3>Our Hardworking <span>Team</span></h3>
          <p>Ut possimus qui ut temporibus culpa velit eveniet modi omnis est adipisci expedita at voluptas atque vitae autem.</p>
        </div>

        <div class=""row"">
           
                  <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                    <div class=""Model"">
                      <div class=""Model-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5176f7cd05e5d06c3b63fd6eaa8d8329bc3dfe3c4535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 731, "~/assets/img/team/", 731, 18, true);
#nullable restore
#line 21 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
AddHtmlAttributeValue("", 749, Model.Image, 749, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"social\">\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 864, "\"", 871, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
                                Write(Html.Raw(Model.Icon1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 936, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
                                Write(Html.Raw(Model.Icon2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1001, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
                                Write(Html.Raw(Model.Icon3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1066, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
                                Write(Html.Raw(Model.Icon4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                      </div>\r\n                      <div class=\"Model-info\">\r\n                        <h4>");
#nullable restore
#line 30 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
                       Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                        <span>");
#nullable restore
#line 31 "C:\Users\User\source\c#\Template setup\BizLand\Views\Team\Detail.cshtml"
                         Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                    \r\n              \r\n\r\n        </div>\r\n\r\n      </div>\r\n    </section><!-- End Team Section -->\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

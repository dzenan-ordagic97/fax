#pragma checksum "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "255adafbdea2ed933b476970382487253ad435ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Prijevoznik_Views_Prijevoz_PrikaziMapu), @"mvc.1.0.view", @"/Areas/Prijevoznik/Views/Prijevoz/PrikaziMapu.cshtml")]
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
#line 1 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Areas.Prijevoznik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255adafbdea2ed933b476970382487253ad435ce", @"/Areas/Prijevoznik/Views/Prijevoz/PrikaziMapu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5665a0e98f63ed9a874f500630650ba9478dea6", @"/Areas/Prijevoznik/Views/_ViewImports.cshtml")]
    public class Areas_Prijevoznik_Views_Prijevoz_PrikaziMapu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrijevozMapaVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"floating-panel\">\r\n    <b>Start: </b>\r\n    <select id=\"start\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "255adafbdea2ed933b476970382487253ad435ce4473", async() => {
#nullable restore
#line 9 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml"
                                           Write(Model.PocetnaLokacija);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml"
           WriteLiteral(Model.PocetnaLokacija);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </select>\r\n    <b>End: </b>\r\n    <select id=\"end\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "255adafbdea2ed933b476970382487253ad435ce6395", async() => {
#nullable restore
#line 13 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml"
                                           Write(Model.KrajnjaLokacija);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml"
           WriteLiteral(Model.KrajnjaLokacija);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </select>\r\n    <button id=\"start2\" class=\"btn btn-primary\" >\r\n        Prikazi rutu\r\n        <p hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 474, "\"", 504, 1);
#nullable restore
#line 17 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\PrikaziMapu.cshtml"
WriteAttributeValue("", 482, Model.PocetnaLokacija, 482, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n    </button>\r\n</div>\r\n<div id=\"map\"></div>\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrijevozMapaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc14eb60d259ae18af1aad52da34e487588da08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Prijevoznik_Views_Vozilo_Index), @"mvc.1.0.view", @"/Areas/Prijevoznik/Views/Vozilo/Index.cshtml")]
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
#line 1 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Areas.Prijevoznik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc14eb60d259ae18af1aad52da34e487588da08", @"/Areas/Prijevoznik/Views/Vozilo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5665a0e98f63ed9a874f500630650ba9478dea6", @"/Areas/Prijevoznik/Views/_ViewImports.cshtml")]
    public class Areas_Prijevoznik_Views_Vozilo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VoziloVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Prijevoznik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vozilo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalji", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info align-middle w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;margin-top:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cc14eb60d259ae18af1aad52da34e487588da088210", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
 if (Model.Vozila.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section>
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <center style=""margin-top:5%;"">
                <img class=""center"" style=""width:100%; padding:10px;"" src=""https://image.flaticon.com/icons/svg/832/832868.svg"" alt=""Nema slike"" />
                <br />
                <hr />
                <h4>No vehicle available!</h4>
                <br />
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc14eb60d259ae18af1aad52da34e487588da0810006", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </center>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 23 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n\r\n\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title mt-0 primary3\">\r\n                    Vozila ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc14eb60d259ae18af1aad52da34e487588da0812139", async() => {
                WriteLiteral("Add vehicle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h4>\r\n\r\n                <div class=\"col-md-12\">\r\n");
#nullable restore
#line 36 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
                     for (int i = 0; i < Model.Vozila.Count; i += 4)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row \">\r\n\r\n");
#nullable restore
#line 41 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
                             for (int y = 0; y < 4 && (i + y) < Model.Vozila.Count; y++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("id", " id=\"", 1381, "\"", 1427, 1);
#nullable restore
#line 43 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
WriteAttributeValue("", 1386, Model.Vozila[i + y].RegistracijskaOznaka, 1386, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""col-md-6 col-lg-3 justify-content-center align-items-center"" style=""margin-bottom:10px"">
                                    <div class=""row justify-content-center align-items-center "">
                                        <div class=""col-11 card"">
                                            <div class=""row"">

                                                <div class=""col-12"">
                                                    <img style=""width:100%; padding:10px""");
            BeginWriteAttribute("alt", " alt=\"", 1915, "\"", 1953, 1);
#nullable restore
#line 49 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
WriteAttributeValue("", 1921, Model.Vozila[i + y].Slika.Naziv, 1921, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1954, "\"", 1990, 1);
#nullable restore
#line 49 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
WriteAttributeValue("", 1960, Model.Vozila[i + y].Slika.URL, 1960, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </div>
                                                <div class=""col-12 "" style="" margin-bottom:10px"">
                                                    <div class=""col-lg-12 col-xl-12 col-md-12 align-middle"">
                                                        <p style=""text-align:center; margin-top:10px"" class=""align-middle"">");
#nullable restore
#line 53 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
                                                                                                                      Write(Model.Vozila[i + y].ModelVozila);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                    <div class=\"col-lg-12 col- col-xl-12 col-md-12\">\r\n\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc14eb60d259ae18af1aad52da34e487588da0816934", async() => {
                WriteLiteral("\r\n                                                            <i class=\"fas fa-info fa-sm text-black-50\"></i>\r\n\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
                                                                                                                                 WriteLiteral(Model.Vozila[i + y].VoziloID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3079, "\"", 3126, 3);
            WriteAttributeValue("", 3089, "obrisi(", 3089, 7, true);
#nullable restore
#line 61 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
WriteAttributeValue("", 3096, Model.Vozila[i + y].VoziloID, 3096, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3125, ")", 3125, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger align-middle w-100 "" style=""color:white;margin-top:5px""> <i class=""fas fa-trash fa-sm text-black-50""></i></button>

                                                    </div>

                                                </div>
                                            </div>

                                        </div>

                                    </div>


                                </div>
");
#nullable restore
#line 74 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 77 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Vozilo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\r\n    function obrisi(x) {\r\n        $.get(\"/Prijevoznik/Vozilo/Obrisi?id=\" + x, function (data, status) {\r\n            $(\"#\" + data).remove();\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VoziloVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

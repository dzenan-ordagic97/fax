#pragma checksum "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819f0b1a99d14ac27f299649f28d7a6b4db3336d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Prijevoznik_Views_Prijevoz_Index), @"mvc.1.0.view", @"/Areas/Prijevoznik/Views/Prijevoz/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819f0b1a99d14ac27f299649f28d7a6b4db3336d", @"/Areas/Prijevoznik/Views/Prijevoz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5665a0e98f63ed9a874f500630650ba9478dea6", @"/Areas/Prijevoznik/Views/_ViewImports.cshtml")]
    public class Areas_Prijevoznik_Views_Prijevoz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrijevozIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pregled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detaljno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ukloni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Zavrsi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "819f0b1a99d14ac27f299649f28d7a6b4db3336d8181", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<h4>\r\n    <span class=\"primary2\">Pregled rezervacije</span> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d9368", async() => {
                WriteLiteral("Prikaz zavrsenih transakcija");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</h4>\r\n<hr />\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-danger\">Neprihvaćene rezervacije (All)</h6>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 18 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
         if (Model.BrojacGlobalno == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"width:100%;color:red;text-align:center\">Nema rezultata</p>\r\n");
#nullable restore
#line 21 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""stil"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Pocetna lokacija</th>
                            <th>Krajnja lokacija</th>
                            <th>Pocetni datum prijevoza</th>
                            <th>User</th>
                            <th>Mogucnosti</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 36 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                         if (Model.BrojacGlobalno == 0)
                        {

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                         foreach (var item in Model.rezervacije)
                        {
                            if (!item.Prihvaceno && item.PrijevozID == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 45 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.PocetnaLokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 46 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.KrajnjaLokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.PocetniDatumPrijevoza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d14210", async() => {
                WriteLiteral("Detaljno");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                                                                                     WriteLiteral(item.TeretRezervacijaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 58 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-primary\">Neprihvaćene rezervacije (For you)</h6>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 67 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
         if (Model.BrojacPrijevoznik == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"width:100%;color:red;text-align:center\">Nema rezultata</p>\r\n");
#nullable restore
#line 70 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""stil"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Pocetna lokacija</th>
                            <th>Krajnja lokacija</th>
                            <th>Pocetni datum prijevoza</th>
                            <th>User</th>
                            <th>Mogucnosti</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 85 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                         foreach (var item in Model.rezervacije)
                        {
                            if (!item.Prihvaceno && item.PrijevozID != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 90 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.PocetnaLokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 91 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.KrajnjaLokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 92 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.PocetniDatumPrijevoza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 93 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d20418", async() => {
                WriteLiteral("Uklonite");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                                                                                  WriteLiteral(item.TeretRezervacijaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <hr />\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d22836", async() => {
                WriteLiteral("Detaljno");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                                                                                     WriteLiteral(item.TeretRezervacijaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 100 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 105 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-success\">Prihvaćene rezervacije</h6>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 114 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
         if (Model.BrojacPrihvacenih == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"width:100%;color:red;text-align:center\">Nema rezultata</p>\r\n");
#nullable restore
#line 117 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""stil"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Pocetna lokacija</th>
                            <th>Krajnja lokacija</th>
                            <th>Pocetni datum prijevoza</th>
                            <th>User</th>
                            <th>Mogucnosti</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 132 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                         foreach (var item in Model.rezervacije)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                             if (item.Prihvaceno == true && item.Zavrseno == false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 137 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.PocetnaLokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 138 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.KrajnjaLokacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 139 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.PocetniDatumPrijevoza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 140 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                   Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d29258", async() => {
                WriteLiteral("Uklonite");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                                                                                  WriteLiteral(item.TeretRezervacijaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <hr />\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d31677", async() => {
                WriteLiteral("Zavrsite");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                                                                                   WriteLiteral(item.TeretRezervacijaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <hr />\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819f0b1a99d14ac27f299649f28d7a6b4db3336d34099", async() => {
                WriteLiteral("Detaljno");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                                                                                                     WriteLiteral(item.TeretRezervacijaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 149 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 154 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Prijevoz\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrijevozIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

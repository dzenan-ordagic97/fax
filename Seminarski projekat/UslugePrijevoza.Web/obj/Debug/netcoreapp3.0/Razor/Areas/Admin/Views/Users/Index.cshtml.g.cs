#pragma checksum "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451d7972739605498a197c5f4664e15fdf2f1559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\_ViewImports.cshtml"
using UslugePrijevoza.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451d7972739605498a197c5f4664e15fdf2f1559", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60706f234e94a4cb7b30cff503330a1187c3827", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Obrisi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger align-middle w-100 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;margin-top:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451d7972739605498a197c5f4664e15fdf2f15596181", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""col-md-12"">
    <div class=""row ustify-content-center align-items-center "">
        <div class=""col-md-12 card card-plain"">
            <div class=""card-header card-header-info"">
                <h4 class=""card-title mt-0 primary2"">  Detalji usera </h4>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-hover"" id=""stil"">
                        <thead");
            BeginWriteAttribute("class", " class=\"", 660, "\"", 668, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <tr>
                                <th class=""primary2"">Username</th>
                                <th class=""primary2"">Ime</th>
                                <th class=""primary2"">Prezime</th>
                                <th class=""primary2"">Datum rodjenja</th>
                                <th class=""primary2"">JMBG</th>
                                <th class=""primary2"">Spol</th>
                                <th class=""primary2"">Tip usera</th>
                                <th class=""primary2"">Mogućnost</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                             foreach (var item in Model.userRow)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                               Write(item.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                               Write(item.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                               Write(item.DatumRodjenja);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                               Write(item.JMBG);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                               Write(item.Spol);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                <td>\r\n");
#nullable restore
#line 41 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                     if (item.TipUsera == "1")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Prijevoznik</span>\r\n");
#nullable restore
#line 44 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                     if (item.TipUsera == "2")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Klijent</span>\r\n");
#nullable restore
#line 48 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                     if (item.TipUsera == "3")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Administrator</span>\r\n");
#nullable restore
#line 52 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n");
#nullable restore
#line 54 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                 if (item.UserID == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <span style=\"color:red;\">Can\'t delete!</span>\r\n                                    </td>\r\n");
#nullable restore
#line 59 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451d7972739605498a197c5f4664e15fdf2f155913397", async() => {
                WriteLiteral(" <i class=\"fas fa-trash fa-sm text-black-50\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                                                                        WriteLiteral(item.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 65 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Admin\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\TipVozila\TipVozilaElement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a9fcc2a64153b50b190a610cd0694a836fd108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Prijevoznik_Views_TipVozila_TipVozilaElement), @"mvc.1.0.view", @"/Areas/Prijevoznik/Views/TipVozila/TipVozilaElement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a9fcc2a64153b50b190a610cd0694a836fd108", @"/Areas/Prijevoznik/Views/TipVozila/TipVozilaElement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5665a0e98f63ed9a874f500630650ba9478dea6", @"/Areas/Prijevoznik/Views/_ViewImports.cshtml")]
    public class Areas_Prijevoznik_Views_TipVozila_TipVozilaElement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TipVozilaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <tr");
            BeginWriteAttribute("id", " id=\"", 27, "\"", 67, 1);
#nullable restore
#line 2 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\TipVozila\TipVozilaElement.cshtml"
WriteAttributeValue("", 32, Model.TipVozilaForSave.TipVozilaID, 32, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <td width=\"95%\">");
#nullable restore
#line 3 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\TipVozila\TipVozilaElement.cshtml"
                   Write(Model.TipVozilaForSave.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td width=\"5%\">\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 177, "\"", 230, 3);
            WriteAttributeValue("", 187, "obrisi(", 187, 7, true);
#nullable restore
#line 6 "C:\Users\dzena\Source\Repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\TipVozila\TipVozilaElement.cshtml"
WriteAttributeValue("", 194, Model.TipVozilaForSave.TipVozilaID, 194, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 229, ")", 229, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger align-middle w-100 \" style=\"color:white;margin-top:5px\"> <i class=\"fas fa-trash fa-sm text-black-50\"></i></button>\r\n        </td>\r\n    </tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TipVozilaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

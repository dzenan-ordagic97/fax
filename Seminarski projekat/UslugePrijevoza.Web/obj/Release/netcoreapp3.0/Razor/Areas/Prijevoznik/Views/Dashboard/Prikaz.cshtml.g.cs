#pragma checksum "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1fcbb9393d37faf4e1687113932f36fd1706945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Prijevoznik_Views_Dashboard_Prikaz), @"mvc.1.0.view", @"/Areas/Prijevoznik/Views/Dashboard/Prikaz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1fcbb9393d37faf4e1687113932f36fd1706945", @"/Areas/Prijevoznik/Views/Dashboard/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5665a0e98f63ed9a874f500630650ba9478dea6", @"/Areas/Prijevoznik/Views/_ViewImports.cshtml")]
    public class Areas_Prijevoznik_Views_Dashboard_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardPrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/chart.js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1fcbb9393d37faf4e1687113932f36fd17069454721", async() => {
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

<div class=""row"">
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Ukupno zaradjeno</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$");
#nullable restore
#line 14 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                                        Write(Model.Cijene);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Neprihvacene rezervacije</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 29 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                                       Write(Model.BrojacRezervacije);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Ukupno vozila</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 44 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                                       Write(Model.BrojVozila);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-car fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Ukupno prijevoza izvrseno</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 59 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                                       Write(Model.UkupnoPrijevoza);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-truck fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Prikaz vasih ocjena od strane korisnika</h6>
    </div>
    <div class=""card-body"">
        <div class=""chart-area"">
            <canvas id=""myAreaChart""></canvas>
        </div>
    </div>
</div>
<div id=""KomentariOcjene"">

</div>

<div class=""row"">
    <div class=""col-lg-12 mb-4"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Ukupan broj vozila po nazivu modela vozila</h6>
            </div>
            <div class=""card-body"">
");
#nullable restore
#line 91 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                 foreach (var item in Model.naziviModela)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"small font-weight-bold\">");
#nullable restore
#line 93 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                  Write(item.NazivModela);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"float-right\">");
#nullable restore
#line 93 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                                                              Write(item.BrojacVozila);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kom</span></h4>\r\n                    <div class=\"progress mb-4\">\r\n                        <div class=\"progress-bar progress-bar-striped progress-bar-animated bg-info \" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 4122, "\"", 4168, 3);
            WriteAttributeValue("", 4130, "width:", 4130, 6, true);
#nullable restore
#line 95 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
WriteAttributeValue(" ", 4136, item.BrojacVozila.ToString(), 4137, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4166, "0%", 4166, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 4169, "\"", 4215, 2);
#nullable restore
#line 95 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
WriteAttributeValue("", 4185, item.BrojacVozila.ToString(), 4185, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4214, "0", 4214, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n");
#nullable restore
#line 97 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    var ctx = document.getElementById(""myAreaChart"");
    var myBarChart = new Chart(ctx, {
  type: 'bar',
  data: {
    labels: ['Ocjena 1', 'Ocjena 2', 'Ocjena 3', 'Ocjena 4', 'Ocjena 5'],
    datasets: [{
        label: ""Ukupno"",
      backgroundColor: ""#4e73df"",
      hoverBackgroundColor: ""#2e59d9"",
      borderColor: ""#4e73df"",
      data: [");
#nullable restore
#line 114 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
        Write(Model.Ocjena1);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 114 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                        Write(Model.Ocjena2);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 114 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                        Write(Model.Ocjena3);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 114 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                        Write(Model.Ocjena4);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 114 "C:\Users\dzena\source\repos\web\UslugePrijevoza.Web\Areas\Prijevoznik\Views\Dashboard\Prikaz.cshtml"
                                                                        Write(Model.Ocjena5);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
    }],
  },
  options: {
    maintainAspectRatio: false,
    layout: {
      padding: {
        left: 10,
        right: 25,
        top: 25,
        bottom: 0
      }
      },
      onClick: function (c,i) {
        e = i[0];
        console.log(e._index)
        var x_value = this.data.labels[e._index];
        var y_value = this.data.datasets[0].data[e._index];
      

           $.get(""/Prijevoznik/Dashboard/KomentarOcjena?ocjena=""+(e._index+1), function (data, status) {
            $(""#KomentariOcjene"").html(data);
        });

      },
    scales: {
      xAxes: [{
        time: {
          unit: 'month'
        },
        gridLines: {
          display: false,
          drawBorder: false
        },
        ticks: {
          maxTicksLimit: 6
        },
        maxBarThickness: 25,
      }],
      yAxes: [{
        ticks: {
          min: 0,
          max: 15,
          maxTicksLimit: 5,
          padding: 10,
          // Include a dollar sign in the tic");
            WriteLiteral(@"ks

        },
        gridLines: {
          color: ""rgb(234, 236, 244)"",
          zeroLineColor: ""rgb(234, 236, 244)"",
          drawBorder: false,
          borderDash: [2],
          zeroLineBorderDash: [2]
        }
      }],
    },
    legend: {
      display: false
    },
    tooltips: {
      titleMarginBottom: 10,
      titleFontColor: '#6e707e',
      titleFontSize: 14,
      backgroundColor: ""rgb(255,255,255)"",
      bodyFontColor: ""#858796"",
      borderColor: '#dddfeb',
      borderWidth: 1,
      xPadding: 15,
      yPadding: 15,
      displayColors: false,
      caretPadding: 10,

    },
  }
});
");
            WriteLiteral("\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
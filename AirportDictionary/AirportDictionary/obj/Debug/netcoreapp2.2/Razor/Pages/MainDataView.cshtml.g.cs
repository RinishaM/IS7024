#pragma checksum "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4d189b0062487745a246a8f75b2860c9ff742c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AirportDictionary.Pages.Pages_MainDataView), @"mvc.1.0.razor-page", @"/Pages/MainDataView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MainDataView.cshtml", typeof(AirportDictionary.Pages.Pages_MainDataView), null)]
namespace AirportDictionary.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\_ViewImports.cshtml"
using AirportDictionary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4d189b0062487745a246a8f75b2860c9ff742c", @"/Pages/MainDataView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f127cec50d2885206f8ce3e554d759f3e2580d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MainDataView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
  
    ViewData["Title"] = "Home page";
    List<AirportDetails.Airport> requiredAirports = (List<AirportDetails.Airport>)ViewData["RequiredAirports"];
    CityDetails.City allCities = (CityDetails.City)ViewData["City"];

#line default
#line hidden
            BeginContext(261, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe4d189b0062487745a246a8f75b2860c9ff742c4625", async() => {
                BeginContext(267, 45, true);
                WriteLiteral("\r\n    <title>Airport Dictionary</title>\r\n    ");
                EndContext();
                BeginContext(312, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe4d189b0062487745a246a8f75b2860c9ff742c5052", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(381, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(392, 243, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"text-white\" >Airport Dictionary</h2>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-10\">\r\n            <table class=\"table table-border table-dark table-striped table-hover auto-index\">\r\n");
            EndContext();
#line 19 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                  
                    int count = 0;
                

#line default
#line hidden
            BeginContext(710, 534, true);
            WriteLiteral(@"                <thead class=""thead-dark"">
                    <tr>
                        <th>S.No.</th>
                        <th>Country</th>
                        <th>State</th>
                        <th>City</th>
                        <th>Geo ID</th>
                        <th>Airport Name</th>
                        <th>Type</th>
                        <th>Local Code</th>
                        <th>Elevation (in ft.)</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                     foreach (AirportDetails.Airport airport in requiredAirports)
                    {

#line default
#line hidden
            BeginContext(1350, 56, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n");
            EndContext();
#line 40 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                               count++; 

#line default
#line hidden
            BeginContext(1449, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1478, 5, false);
#line 41 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1483, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(1545, 17, false);
#line 43 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(allCities.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1598, 20, false);
#line 44 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(allCities.Subcountry);

#line default
#line hidden
            EndContext();
            BeginContext(1618, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1654, 14, false);
#line 45 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(allCities.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1668, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1704, 19, false);
#line 46 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(allCities.GeoNameID);

#line default
#line hidden
            EndContext();
            BeginContext(1723, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1759, 12, false);
#line 47 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(airport.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1771, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1807, 12, false);
#line 48 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(airport.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1819, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1855, 17, false);
#line 49 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(airport.LocalCode);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1908, 21, false);
#line 50 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                       Write(airport.ElevationFeet);

#line default
#line hidden
            EndContext();
            BeginContext(1929, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 52 "C:\Users\anami\Source\Repos\FinalProject\AirportDictionary\AirportDictionary\Pages\MainDataView.cshtml"
                    }

#line default
#line hidden
            BeginContext(1986, 126, true);
            WriteLiteral("                    }\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <br />\r\n    </div>\r\n</div>\r\n}\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainDataViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MainDataViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MainDataViewModel>)PageContext?.ViewData;
        public MainDataViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

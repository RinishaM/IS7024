#pragma checksum "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793a15b96e38c62407a50fa6bdd299a2b8939e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AirportDictionary.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(AirportDictionary.Pages.Pages_Index), null)]
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
#line 1 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\_ViewImports.cshtml"
using AirportDictionary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793a15b96e38c62407a50fa6bdd299a2b8939e43", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f127cec50d2885206f8ce3e554d759f3e2580d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var cities = (CityDetails.Welcome[])ViewData["Welcome"];

#line default
#line hidden
            BeginContext(133, 283, true);
            WriteLiteral(@"
  
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to Airport Dictionary</h1>
    <table border=""1"" width=""90%"">
        <tr>
            <th>Country</th>
            <th>GeoName Id</th>
            <th>Name</th>
            <th>State/City</th>
        </tr>
");
            EndContext();
#line 19 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
             foreach (CityDetails.Welcome city in cities)
            {

#line default
#line hidden
            BeginContext(502, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(549, 12, false);
#line 22 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
                   Write(city.Country);

#line default
#line hidden
            EndContext();
            BeginContext(561, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(593, 14, false);
#line 23 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
                   Write(city.GeoNameID);

#line default
#line hidden
            EndContext();
            BeginContext(607, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(639, 9, false);
#line 24 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
                   Write(city.Name);

#line default
#line hidden
            EndContext();
            BeginContext(648, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(680, 15, false);
#line 25 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
                   Write(city.Subcountry);

#line default
#line hidden
            EndContext();
            BeginContext(695, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 27 "C:\Users\bha28\Desktop\MS IS\Fall 2019\Flex 2\XML\Project\review\AirportDictionary\AirportDictionary\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(751, 32, true);
            WriteLiteral("    </table>\r\n    <br />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Aishwarya\MSIS\Flex2\XML_WebServices\FinalProject\AirportDictionary\AirportDictionary\Pages\GoogleMaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3d858919939920117c548526bbe30c06a2eedf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AirportDictionary.Pages.Pages_GoogleMaps), @"mvc.1.0.razor-page", @"/Pages/GoogleMaps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/GoogleMaps.cshtml", typeof(AirportDictionary.Pages.Pages_GoogleMaps), null)]
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
#line 1 "E:\Aishwarya\MSIS\Flex2\XML_WebServices\FinalProject\AirportDictionary\AirportDictionary\Pages\_ViewImports.cshtml"
using AirportDictionary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d858919939920117c548526bbe30c06a2eedf8", @"/Pages/GoogleMaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f127cec50d2885206f8ce3e554d759f3e2580d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GoogleMaps : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://maps.google.com/maps?"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Aishwarya\MSIS\Flex2\XML_WebServices\FinalProject\AirportDictionary\AirportDictionary\Pages\GoogleMaps.cshtml"
  
    ViewData["Title"] = "GoogleMaps";

#line default
#line hidden
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(103, 641, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d858919939920117c548526bbe30c06a2eedf84439", async() => {
                BeginContext(109, 628, true);
                WriteLiteral(@"
    <meta http-equiv=""content-type"" content=""text/html; charset=utf-8"" />
    <link href='css/site.css' rel='stylesheet' type='text/css' />
    <link rel=""stylesheet"" href=""http://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/base/jquery-ui.css"" />
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
    <script type=""text/javascript"">
        $(function () {
            $(""#q"").autocomplete({
                source: ""/AutoCompleteSearch"",
                minLength: 3
            });
        });
    </script>
");
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
            BeginContext(744, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(746, 1559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d858919939920117c548526bbe30c06a2eedf86266", async() => {
                BeginContext(752, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(758, 393, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d858919939920117c548526bbe30c06a2eedf86652", async() => {
                    BeginContext(815, 329, true);
                    WriteLiteral(@"
        <div class=""form-group"">
            <label class=""control-label"" for=""q""><strong></strong></label>
            <input type=""text"" class=""form-control"" name=""q"" id=""q"" />
        </div>
        <div class=""form-group"">
            <input type=""submit"" value=""Search"" class=""btn btn-danger"" />
        </div>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1151, 1147, true);
                WriteLiteral(@"

    <!--Grid row-->
    <div class=""row"">

        <!--Grid column-->
        <div class=""col-md-6 mb-4"">

            <!--Card-->
            <div class=""card card-cascade narrower"">

                <!--Card image-->
                <div class=""view view-cascade gradient-card-header peach-gradient"">
                    <h5 class=""mb-0"">Custom map</h5>
                </div>
                <!--/Card image-->
                <!--Card content-->
                <div class=""card-body card-body-cascade text-center"">

                    <!--Google map-->
                    <div id=""map-container-google-9"" class=""z-depth-1-half map-container-5"" style=""height: 300px"">
                        <iframe src=""https://maps.google.com/maps?q=Madryt&t=&z=13&ie=UTF8&iwloc=&output=embed"" frameborder=""0""
                                style=""border:0"" allowfullscreen=allowfullscreen></iframe>
                    </div>


                </div>
                <!--/.Card content-->

         ");
                WriteLiteral("   </div>\r\n            <!--/.Card-->\r\n\r\n        </div>\r\n        <!--Grid column-->\r\n\r\n    </div>\r\n    <!--Grid row-->\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2305, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AirportDictionary.Pages.GoogleMapsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AirportDictionary.Pages.GoogleMapsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AirportDictionary.Pages.GoogleMapsModel>)PageContext?.ViewData;
        public AirportDictionary.Pages.GoogleMapsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

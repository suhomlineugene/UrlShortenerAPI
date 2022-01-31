#pragma checksum "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca689e7b6a02c6605b52a7f7b337ca88bcfec203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca689e7b6a02c6605b52a7f7b337ca88bcfec203", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UrlShortenerApi.Data.Dto.ShortLinkDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n\r\n</div>\r\n\r\n\r\n<div style=\"width: 100%; margin-top: 60px;\">\r\n    <div style=\"width: 65%; margin-left: auto; margin-right: auto;\">\r\n");
#nullable restore
#line 14 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
         using (Html.BeginForm("ShortenUrl", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <form id=""form"" style=""text-align: center;"" asp-controller=""Home"" asp-action=""ShortenUrl"" method=""post"">
                <input
                    type=""text""
                    placeholder=""Enter Url ...""
                    style=""width: 100%; border-radius: 5px; height: 45px;""
                    name=""longUrl""/>

                <button
                    type=""submit""
                    style=""background-color: darkgreen; color: white; padding: 10px; margin-top: 25px; border-radius: 8px;"">
                    Shorten Url
                </button>
            </form>
");
#nullable restore
#line 29 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <div>
        <table>
            <thead>
            <tr>
                <th>
                    Original Url
                </th>
                <th>
                    Short Url
                </th>
                <th>
                    Creation Date
                </th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 48 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
             foreach (var b in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
                   Write(b.OriginalUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
                   Write(b.ShortUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
                   Write(b.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\GamePC\Documents\GitHub\UrlShortenerAPI\UrlShortenerAPI\UrlShortenerApi\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UrlShortenerApi.Data.Dto.ShortLinkDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

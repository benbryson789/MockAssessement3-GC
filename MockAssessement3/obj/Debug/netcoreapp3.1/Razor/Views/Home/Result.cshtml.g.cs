#pragma checksum "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bde2810f78754bf2e17d92488061f3ffdbd0157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\repos\MockAssessement3\MockAssessement3\Views\_ViewImports.cshtml"
using MockAssessement3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\MockAssessement3\MockAssessement3\Views\_ViewImports.cshtml"
using MockAssessement3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bde2810f78754bf2e17d92488061f3ffdbd0157", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae5d8cf1847da87040ac88b3723aa188ff02b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\nmock    <ul>\r\n");
#nullable restore
#line 3 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
         if (ViewData.TryGetValue("CanVote", out object canVote))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 5 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
           Write(canVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 6 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
         if (ViewData.TryGetValue("CanDrink", out object canDrink))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 9 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
           Write(canDrink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
         if (ViewData.TryGetValue("TooYoung", out object tooYoung))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 13 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
           Write(tooYoung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
         if (ViewData.TryGetValue("CanRent", out object canRent))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 17 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
           Write(canRent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\repos\MockAssessement3\MockAssessement3\Views\Home\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

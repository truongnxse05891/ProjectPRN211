#pragma checksum "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b37af706d9d171f049c143ddff7681dd37c79e"
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
#nullable restore
#line 1 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\_ViewImports.cshtml"
using ProjectPRN211;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\_ViewImports.cshtml"
using ProjectPRN211.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b37af706d9d171f049c143ddff7681dd37c79e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb08cd2de48cd0f9e9f21266fa01caa796c8e29d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectPRN211.Models.Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Home\Index.cshtml"
  
    var userName = TempData["userName"];
    var userId = TempData["userId"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Welcome : ");
#nullable restore
#line 10 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Home\Index.cshtml"
         Write(userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with ID: ");
#nullable restore
#line 10 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Home\Index.cshtml"
                            Write(userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectPRN211.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f578a740050016beeeb6835a943ffc5ca102521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f578a740050016beeeb6835a943ffc5ca102521", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb08cd2de48cd0f9e9f21266fa01caa796c8e29d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectPRN211.Models.Account>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\'#AlertBox\').removeClass(\'hide\');\r\n            $(\'#AlertBox\').delay(2000).slideUp(500);\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f578a740050016beeeb6835a943ffc5ca1025213597", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Register</title>
    <link href=""http://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"" />
    <script type=""text/javascript"" src=""http://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script type=""text/javascript"" src=""http://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js""></script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f578a740050016beeeb6835a943ffc5ca1025215125", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
     if (TempData["alertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div id=\"AlertBox\" style=\"color:red; position: center; text-align:center\" role=\"alert\">\r\n            <p>");
#nullable restore
#line 32 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
          Write(TempData["alertMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
     using (Html.BeginForm("Register", "Account", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <br/>
        <br/>
        <br/>
        <br/>
        <div class=""container register"">
            <div class=""row"">
                <div class=""col-md-3 register-left"">
                    <img style=""max-width:100%; margin:auto"" src=""https://img.freepik.com/free-vector/register-now-hanging-sign-white-background_100456-2067.jpg?size=626&ext=jpgg""");
                BeginWriteAttribute("alt", " alt=\"", 1617, "\"", 1623, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

                </div>
                <div class=""col-md-9 register-right"">
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                            <div class=""row register-form"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        ");
#nullable restore
#line 53 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.TextBoxFor(e => e.FullName, new { @class = "form-control", placeholder = "Full Name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 54 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(e => e.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n\r\n                                    <div class=\"form-group\">\r\n                                        ");
#nullable restore
#line 58 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.PasswordFor(e => e.Password, new { id = "password", @class = "form-control", placeholder = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span id=\"result\"></span>\r\n                                        ");
#nullable restore
#line 60 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(e => e.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        ");
#nullable restore
#line 63 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control", @placeholder = "Confim Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 64 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n\r\n\r\n                                    <div class=\"form-group\">\r\n                                        <div class=\"form-check form-check-inline\">\r\n                                            ");
#nullable restore
#line 70 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                       Write(Html.RadioButtonFor(e => e.Gender, true, new { @class = "radio inline" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<span> Male </span>\r\n                                            <span style=\"padding-left:14px\"></span>\r\n                                            ");
#nullable restore
#line 72 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                       Write(Html.RadioButtonFor(e => e.Gender, false, new { @class = "radio inline" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<span>Female </span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        ");
#nullable restore
#line 78 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.TextBoxFor(e => e.Email, new { @class = "form-control", placeholder = "Your Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 79 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(e => e.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        ");
#nullable restore
#line 82 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.TextBoxFor(e => e.Address, new { @class = "form-control", placeholder = "Your Address" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 83 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(e => e.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n\r\n                                    <div class=\"form-group\">\r\n                                        ");
#nullable restore
#line 88 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.TextBoxFor(e => e.DateOfBirth, new { @type = "date", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 89 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(e => e.DateOfBirth));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                    </div>


                                </div>
                                <div class=""form-group"" style=""margin:auto"">
                                    <input type=""submit"" class=""btn btn-primary"" value=""Register"" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>



            
        </div>
");
#nullable restore
#line 108 "C:\Users\24h\Desktop\ProjectPRN211\ProjectPRN211\Views\Account\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>    ");
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
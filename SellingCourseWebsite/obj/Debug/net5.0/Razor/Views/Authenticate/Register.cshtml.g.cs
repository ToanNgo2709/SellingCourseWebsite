#pragma checksum "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a572def677544bbd39a3921eeaee8b4b5fb193d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authenticate_Register), @"mvc.1.0.view", @"/Views/Authenticate/Register.cshtml")]
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
#line 1 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\_ViewImports.cshtml"
using SellingCourseWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\_ViewImports.cshtml"
using SellingCourseWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a572def677544bbd39a3921eeaee8b4b5fb193d7", @"/Views/Authenticate/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737c70c24b6e231b52de3f57d69951d075c8e7af", @"/Views/_ViewImports.cshtml")]
    public class Views_Authenticate_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myForm text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_layoutAuthenticate.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"myCard\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"myLeftCtn\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a572def677544bbd39a3921eeaee8b4b5fb193d74411", async() => {
                WriteLiteral("\r\n                        <div class=\"myFormFooterRegister\">\r\n                            <div class=\"row\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 505, "\"", 541, 1);
#nullable restore
#line 14 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
WriteAttributeValue("", 512, Url.Action("ForgotPassword"), 512, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""ml-auto"">Forgot Password?</a>
                            </div>
                        </div>
                        <header>Create New Account</header>

                        <div class=""form-group"">
                            <i class=""fas fa-user""></i>
                            <input class=""myInput"" type=""text"" placeholder=""Username"" id=""username"" name=""username"" required>
                            <div class=""invalid-feedback"">Please fill out this field</div>
                        </div>

                        <div class=""form-group"">
                            <i class=""fas fa-envelope""></i>
                            <input class=""myInput"" type=""text"" placeholder=""Email"" id=""email"" name=""email"" required>
                            <div class=""invalid-feedback"">Please fill out this field</div>
                        </div>

                        <div class=""form-group"">
                            <i class=""fas fa-lock""></i>
                            <inp");
                WriteLiteral(@"ut class=""myInput"" type=""password"" placeholder=""Password"" id=""password"" name=""password"" required>
                            <div class=""invalid-feedback"">Please fill out this field</div>
                        </div>

                        <div class=""form-group"">
                            <i class=""fas fa-lock""></i>
                            <input class=""myInput"" type=""password"" placeholder=""Re-Password"" id=""re_password"" name=""re_password"" required>
                            <div class=""invalid-feedback"">Please fill out this field</div>
                        </div>

                        <div class=""form-group"">
                            <label>
                                <input id=""check1"" name=""check1"" type=""checkbox"" required />
                                <small> I read and agree to Term & Conditions </small>
                            </label>
                        </div>

                        <input type=""submit"" class=""butt"" value=""CREATE ACCOUNT"">

");
                WriteLiteral("                        <div class=\"myFormFooterRegister\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2791, "\"", 2826, 1);
#nullable restore
#line 55 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
WriteAttributeValue("", 2798, Url.Action("Index", "Home"), 2798, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Return to HomePage</a>\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2986, "\"", 3013, 1);
#nullable restore
#line 58 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
WriteAttributeValue("", 2993, Url.Action("Login"), 2993, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Login?</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
AddHtmlAttributeValue("", 294, Url.Action("RegisterDb"), 294, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""myRightCtn"">
                    <div class=""box"">
                        <header>Hello World!</header>
                    </div>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the
                        industry's standard dummy text ever since the 1500
                    </p>
                    <input type=""button"" class=""butt_out"" value=""Learn More"">
                </div>
            </div>
        </div>
    </div>

</div>

<!--Modal Alert-->
<div class=""modal fade"" id=""alertModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""alertModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""alertModalLabel"">Alert</h5>
                <but");
            WriteLiteral("ton type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <h6>");
#nullable restore
#line 94 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
               Write(ViewBag.alert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 103 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
 if (ViewBag.alert != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#alertModel\").modal(\'show\');\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 110 "D:\Project\C#\SellingCourseWebsite\SellingCourseWebsite\Views\Authenticate\Register.cshtml"
}

#line default
#line hidden
#nullable disable
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

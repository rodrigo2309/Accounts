#pragma checksum "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a138de997f8f33d600f00960e5a6aa20bcf8fac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Releases_Details), @"mvc.1.0.view", @"/Views/Releases/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Releases/Details.cshtml", typeof(AspNetCore.Views_Releases_Details))]
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
#line 1 "C:\Estudos\Accounts\AccountWebMVC\Views\_ViewImports.cshtml"
using AccountWebMVC;

#line default
#line hidden
#line 2 "C:\Estudos\Accounts\AccountWebMVC\Views\_ViewImports.cshtml"
using AccountWebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a138de997f8f33d600f00960e5a6aa20bcf8fac4", @"/Views/Releases/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8217982877896d984bde8cc17dfc702d567eeb87", @"/Views/_ViewImports.cshtml")]
    public class Views_Releases_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountWebMVC.Models.Release>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 341, true);
            WriteLiteral(@"
<h2>Details</h2>

<div class=""container"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h2>Detalhes</h2>
            </div>
            <div class=""modal-body"">
                <hr />
                <dl class=""dl-horizontal"">
                    <dt>");
            EndContext();
            BeginContext(424, 41, false);
#line 18 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Local));

#line default
#line hidden
            EndContext();
            BeginContext(465, 31, true);
            WriteLiteral("</dt>\r\n                    <dd>");
            EndContext();
            BeginContext(497, 42, false);
#line 19 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Local.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(539, 31, true);
            WriteLiteral("</dd>\r\n                    <dt>");
            EndContext();
            BeginContext(571, 41, false);
#line 20 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(612, 31, true);
            WriteLiteral("</dt>\r\n                    <dd>");
            EndContext();
            BeginContext(644, 37, false);
#line 21 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(681, 31, true);
            WriteLiteral("</dd>\r\n                    <dt>");
            EndContext();
            BeginContext(713, 40, false);
#line 22 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(753, 31, true);
            WriteLiteral("</dt>\r\n                    <dd>");
            EndContext();
            BeginContext(785, 36, false);
#line 23 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(821, 243, true);
            WriteLiteral("</dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Fechar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountWebMVC.Models.Release> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\VSEstudos\Accounts\AccountWebMVC\Views\Conta\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e4650006cefc604fb96672b68df33aac2e7adcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_Registrar), @"mvc.1.0.view", @"/Views/Conta/Registrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/Registrar.cshtml", typeof(AspNetCore.Views_Conta_Registrar))]
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
#line 1 "C:\VSEstudos\Accounts\AccountWebMVC\Views\_ViewImports.cshtml"
using AccountWebMVC;

#line default
#line hidden
#line 2 "C:\VSEstudos\Accounts\AccountWebMVC\Views\_ViewImports.cshtml"
using AccountWebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4650006cefc604fb96672b68df33aac2e7adcd", @"/Views/Conta/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8217982877896d984bde8cc17dfc702d567eeb87", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountWebMVC.Models.ContaRegistroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\VSEstudos\Accounts\AccountWebMVC\Views\Conta\Registrar.cshtml"
  
    ViewBag.Title = "Registrar";
    //Layout = "~/View/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 24, true);
            WriteLiteral("\r\n<h2>Registrar</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\VSEstudos\Accounts\AccountWebMVC\Views\Conta\Registrar.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(197, 60, true);
            WriteLiteral("  <h4> Complete o cadastro da sua conta! </h4>  \r\n  <hr />\r\n");
            EndContext();
            BeginContext(262, 57, false);
#line 15 "C:\VSEstudos\Accounts\AccountWebMVC\Views\Conta\Registrar.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(328, 21, false);
#line 17 "C:\VSEstudos\Accounts\AccountWebMVC\Views\Conta\Registrar.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
            EndContext();
            BeginContext(353, 185, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Registrar\" class=\"btn btn-default\"/>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 24 "C:\VSEstudos\Accounts\AccountWebMVC\Views\Conta\Registrar.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountWebMVC.Models.ContaRegistroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
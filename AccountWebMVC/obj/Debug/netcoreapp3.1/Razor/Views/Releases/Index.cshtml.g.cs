#pragma checksum "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8afa64f3233d3fd609543a980b13a1c556d52dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Releases_Index), @"mvc.1.0.view", @"/Views/Releases/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Releases/Index.cshtml", typeof(AspNetCore.Views_Releases_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8afa64f3233d3fd609543a980b13a1c556d52dc", @"/Views/Releases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8217982877896d984bde8cc17dfc702d567eeb87", @"/Views/_ViewImports.cshtml")]
    public class Views_Releases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccountWebMVC.Models.Release>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(89, 189, true);
            WriteLiteral("<h2>Clientes</h2>\r\n\r\n<p>\r\n    <button class=\"btn btn-success create\">Criar Novo Cliente<i class=\"glyphicon glyphicon-open\"></i></button>\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>");
            EndContext();
            BeginContext(279, 38, false);
#line 13 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(317, 19, true);
            WriteLiteral("</th>\r\n        <th>");
            EndContext();
            BeginContext(337, 41, false);
#line 14 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Local));

#line default
#line hidden
            EndContext();
            BeginContext(378, 19, true);
            WriteLiteral("</th>\r\n        <th>");
            EndContext();
            BeginContext(398, 41, false);
#line 15 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(439, 19, true);
            WriteLiteral("</th>\r\n        <th>");
            EndContext();
            BeginContext(459, 40, false);
#line 16 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(499, 37, true);
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 19 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(577, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(608, 37, false);
#line 22 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(645, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(669, 45, false);
#line 23 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Local.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(714, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(738, 40, false);
#line 24 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(778, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(802, 39, false);
#line 25 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(841, 90, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <button class=\"btn btn-success details\" data-id=\"");
            EndContext();
            BeginContext(932, 7, false);
#line 27 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
                                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(939, 117, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-file\"></i></button>\r\n                <button class=\"btn btn-danger delete \" data-id=\"");
            EndContext();
            BeginContext(1057, 10, false);
#line 28 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
                                                           Write(item.Local);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 118, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-trash\"></i> </button>\r\n                <button class=\"btn btn-primary edit \" data-id=\"");
            EndContext();
            BeginContext(1186, 10, false);
#line 29 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
                                                          Write(item.Local);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 88, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-edit\"></i> </button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "C:\Estudos\Accounts\AccountWebMVC\Views\Releases\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1291, 65, true);
            WriteLiteral("</table>\r\n<div id=\"modal\" class=\"modal fade\" role=\"dialog\" />\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1373, 1090, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $("".details"").click(function () {
                var id = $(this).attr(""data-id"");
                alert(id);
                $(""#modal"").load(""Details?id="" + id, function () {
                    $(""#modal"").modal();
                })
            });

            $("".edit"").click(function () {
                var id = $(this).attr(""data-id"");
                alert(id);
                $(""#modal"").load(""Edit?id="" + id, function () {
                    $(""#modal"").modal();
                })
            });

            $("".delete"").click(function () {
                var id = $(this).attr(""data-id"");
                alert(id);
                $(""#modal"").load(""Delete?id="" + id, function () {
                    $(""#modal"").modal();
                })
            });

            $("".create"").click(function () {
                $(""#modal"").load(""/ReleasesController/Create"", function () {
                    $(""#modal"").modal();
");
                WriteLiteral("                })\r\n            });\r\n\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccountWebMVC.Models.Release>> Html { get; private set; }
    }
}
#pragma warning restore 1591

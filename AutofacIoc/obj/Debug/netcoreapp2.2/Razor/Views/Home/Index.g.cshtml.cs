#pragma checksum "F:\workspace-local\DotNetCore\AutofacIoc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a45651c159b7ec26cc3b56d2255e3c79deae8e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\workspace-local\DotNetCore\AutofacIoc\Views\_ViewImports.cshtml"
using AutofacIoc;

#line default
#line hidden
#line 2 "F:\workspace-local\DotNetCore\AutofacIoc\Views\_ViewImports.cshtml"
using AutofacIoc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a45651c159b7ec26cc3b56d2255e3c79deae8e7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54d6b212d7072c03357bda5a8b7185015eb31d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\workspace-local\DotNetCore\AutofacIoc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 37, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>");
            EndContext();
            BeginContext(83, 11, false);
#line 6 "F:\workspace-local\DotNetCore\AutofacIoc\Views\Home\Index.cshtml"
   Write(ViewBag.eat);

#line default
#line hidden
            EndContext();
            BeginContext(94, 15, true);
            WriteLiteral("</h2>\r\n    <h2>");
            EndContext();
            BeginContext(110, 14, false);
#line 7 "F:\workspace-local\DotNetCore\AutofacIoc\Views\Home\Index.cshtml"
   Write(ViewBag.alipay);

#line default
#line hidden
            EndContext();
            BeginContext(124, 15, true);
            WriteLiteral("</h2>\r\n    <h2>");
            EndContext();
            BeginContext(140, 13, false);
#line 8 "F:\workspace-local\DotNetCore\AutofacIoc\Views\Home\Index.cshtml"
   Write(ViewBag.wxpay);

#line default
#line hidden
            EndContext();
            BeginContext(153, 169, true);
            WriteLiteral("</h2>\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

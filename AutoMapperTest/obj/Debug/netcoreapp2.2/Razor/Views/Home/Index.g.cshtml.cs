#pragma checksum "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54969de00b77cd596240ff061bc5dac0de879dae"
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
#line 1 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\_ViewImports.cshtml"
using AutoMapperTest;

#line default
#line hidden
#line 2 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\_ViewImports.cshtml"
using AutoMapperTest.Models;

#line default
#line hidden
#line 1 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
using AutoMapperTest.Enity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54969de00b77cd596240ff061bc5dac0de879dae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77deeb048133284cf8f773fc1ca91bba6f9a543d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoMapperTest.Enity.UserDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(111, 161, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <table class=\"table\">\r\n        <tr><td>序号</td><td>用户名</td><td>性别</td><td>地址</td><td>时间</td></tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(273, 8, false);
#line 11 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(281, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(305, 14, false);
#line 12 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(319, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(343, 12, false);
#line 13 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
           Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(355, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(379, 13, false);
#line 14 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(392, 289, true);
            WriteLiteral(@"</td>
        </tr>

    </table>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<div class=""text-center"">
    <table class=""table"">
        <tr><td>序号</td><td>用户名</td><td>性别</td><td>地址</td><td>时间</td></tr>
");
            EndContext();
#line 23 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
          
            foreach (var items in ViewBag.userList)
            {


#line default
#line hidden
            BeginContext(763, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(810, 8, false);
#line 28 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.Id);

#line default
#line hidden
            EndContext();
            BeginContext(818, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(850, 14, false);
#line 29 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(864, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(896, 12, false);
#line 30 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(908, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(940, 13, false);
#line 31 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.Address);

#line default
#line hidden
            EndContext();
            BeginContext(953, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1009, 207, true);
            WriteLiteral("\r\n\r\n    </table>\r\n    <p>Learn about <a href=\"\">ViewBag</a>.</p>\r\n</div>\r\n\r\n\r\n<div class=\"text-center\">\r\n    <table class=\"table\">\r\n        <tr><td>序号</td><td>用户名</td><td>性别</td><td>地址</td><td>时间</td></tr>\r\n");
            EndContext();
#line 45 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
          
            foreach (var items in ViewData["userList"]as List<UserDTO>)
            {


#line default
#line hidden
            BeginContext(1318, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1365, 8, false);
#line 50 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1373, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1405, 14, false);
#line 51 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1451, 12, false);
#line 52 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1495, 13, false);
#line 53 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
                   Write(items.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1508, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 55 "F:\workspace-local\DotNetCore\AutoMapperTest\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1564, 75, true);
            WriteLiteral("\r\n\r\n    </table>\r\n    <p>Learn about <a href=\"\">ViewData</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoMapperTest.Enity.UserDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591

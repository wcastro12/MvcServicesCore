#pragma checksum "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af2a1a5fa44e22153e7b09cc86c63ffb96191bb2"
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
#line 1 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\_ViewImports.cshtml"
using WebAppli;

#line default
#line hidden
#line 2 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\_ViewImports.cshtml"
using WebAppli.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af2a1a5fa44e22153e7b09cc86c63ffb96191bb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d6a04ae4d1a28afc90ebd89786a45b0587a7535", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 96, true);
            WriteLiteral("\r\n<div style=\"background-color:aliceblue; border-bottom-color:black;\">\r\n    SSingletonInstance: ");
            EndContext();
            BeginContext(142, 30, false);
#line 6 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
                   Write(ViewData["SSingletonInstance"]);

#line default
#line hidden
            EndContext();
            BeginContext(172, 32, true);
            WriteLiteral(" ;\r\n    <br />\r\n    SSingleton: ");
            EndContext();
            BeginContext(205, 22, false);
#line 8 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
           Write(ViewData["SSingleton"]);

#line default
#line hidden
            EndContext();
            BeginContext(227, 31, true);
            WriteLiteral(" ;\r\n    <br />\r\n    STransing: ");
            EndContext();
            BeginContext(259, 21, false);
#line 10 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
          Write(ViewData["STransing"]);

#line default
#line hidden
            EndContext();
            BeginContext(280, 29, true);
            WriteLiteral(" ;\r\n    <br />\r\n    SScode : ");
            EndContext();
            BeginContext(310, 18, false);
#line 12 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
        Write(ViewData["SScode"]);

#line default
#line hidden
            EndContext();
            BeginContext(328, 51, true);
            WriteLiteral(" ;\r\n    <br />\r\n    <br />\r\n    SingletonInstance: ");
            EndContext();
            BeginContext(380, 29, false);
#line 15 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
                  Write(ViewData["SingletonInstance"]);

#line default
#line hidden
            EndContext();
            BeginContext(409, 31, true);
            WriteLiteral(" ;\r\n    <br />\r\n    Singleton: ");
            EndContext();
            BeginContext(441, 21, false);
#line 17 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
          Write(ViewData["Singleton"]);

#line default
#line hidden
            EndContext();
            BeginContext(462, 30, true);
            WriteLiteral(" ;\r\n    <br />\r\n    Transing: ");
            EndContext();
            BeginContext(493, 20, false);
#line 19 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
         Write(ViewData["Transing"]);

#line default
#line hidden
            EndContext();
            BeginContext(513, 27, true);
            WriteLiteral(" ;\r\n    <br />\r\n    Scode: ");
            EndContext();
            BeginContext(541, 17, false);
#line 21 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
      Write(ViewData["Scode"]);

#line default
#line hidden
            EndContext();
            BeginContext(558, 169, true);
            WriteLiteral(" ;\r\n</div>\r\n\r\n<div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"6000\" style=\"display:flex;text-align:center;\">\r\n    <h1>Students</h1>\r\n    ");
            EndContext();
            BeginContext(728, 38, false);
#line 26 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Student"));

#line default
#line hidden
            EndContext();
            BeginContext(766, 166, true);
            WriteLiteral(";\r\n</div>\r\n\r\n<div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"6000\" style=\"display:flex;text-align:center;\">\r\n    <h1>Course</h1>\r\n    ");
            EndContext();
            BeginContext(933, 37, false);
#line 31 "E:\Net\Net Core\web aplication\WebAppli\WebAppli\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Course"));

#line default
#line hidden
            EndContext();
            BeginContext(970, 15, true);
            WriteLiteral(";\r\n</div>\r\n\r\n\r\n");
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

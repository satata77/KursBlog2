#pragma checksum "E:\önemliler\KursBlog\WebAppUI\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6c76ca52202b64bdb21d3352e95afd95180e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
#line 1 "E:\önemliler\KursBlog\WebAppUI\Views\_ViewImports.cshtml"
using WebAppUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\önemliler\KursBlog\WebAppUI\Views\_ViewImports.cshtml"
using WebAppUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6c76ca52202b64bdb21d3352e95afd95180e90", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ae49699090cf166d233cca4aebc1da166fdce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppUI.Models.UserComment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\önemliler\KursBlog\WebAppUI\Views\Shared\Components\CommentList\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "E:\önemliler\KursBlog\WebAppUI\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 6 "E:\önemliler\KursBlog\WebAppUI\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "E:\önemliler\KursBlog\WebAppUI\Views\Shared\Components\CommentList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppUI.Models.UserComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591

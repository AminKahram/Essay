#pragma checksum "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordDrp\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5015abb26561186707135556133aee6fc0dd90d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_KeywordDrp_Default), @"mvc.1.0.view", @"/Views/Shared/Components/KeywordDrp/Default.cshtml")]
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
#line 1 "F:\MVCEX\Essay\Essay\Views\_ViewImports.cshtml"
using Essay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MVCEX\Essay\Essay\Views\_ViewImports.cshtml"
using Essay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5015abb26561186707135556133aee6fc0dd90d5", @"/Views/Shared/Components/KeywordDrp/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b789cbd8066d07baf8a094b4bbea5b0306e6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_KeywordDrp_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article.DomainModel.Query.Keyword.DrpKeywordModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--keyword-select-->\r\n");
#nullable restore
#line 14 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordDrp\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"multiselectDrp-select keyword-select\" data-list=\".keyword-Drp\" data-search=\".keywordDrp-search\" data-id=\"");
#nullable restore
#line 16 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordDrp\Default.cshtml"
                                                                                                                           Write(item.KeywordID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-value=\"");
#nullable restore
#line 16 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordDrp\Default.cshtml"
                                                                                                                                                        Write(item.KeywordName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#KeywordID\"><span>");
#nullable restore
#line 16 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordDrp\Default.cshtml"
                                                                                                                                                                                                          Write(item.KeywordName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 17 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordDrp\Default.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article.DomainModel.Query.Keyword.DrpKeywordModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
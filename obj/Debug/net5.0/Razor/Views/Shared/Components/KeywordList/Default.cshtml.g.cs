#pragma checksum "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54198838196a9461c238b23ebe511cad79241485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_KeywordList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/KeywordList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54198838196a9461c238b23ebe511cad79241485", @"/Views/Shared/Components/KeywordList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b789cbd8066d07baf8a094b4bbea5b0306e6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_KeywordList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article.DomainModel.Query.Keyword.KeywordListItemModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-hover table-responsive table-striped table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.KeywordID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.KeywordName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.KeywordID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.KeywordName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"btn btn-danger btnDelete\" data-action=\"");
#nullable restore
#line 25 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
                                                               Write(Url.Action("Delete","KeywordManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 25 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
                                                                                                                   Write(item.KeywordID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</span>\r\n                <span class=\"btn btn-info btnEdit\" data-id=\"");
#nullable restore
#line 26 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
                                                       Write(item.KeywordID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-action=\"");
#nullable restore
#line 26 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
                                                                                     Write(Url.Action("Update","KeywordManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#dvContent\" data-target-Modal=\"#KeywordAddEditModal\">Edit</span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "F:\MVCEX\Essay\Essay\Views\Shared\Components\KeywordList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article.DomainModel.Query.Keyword.KeywordListItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
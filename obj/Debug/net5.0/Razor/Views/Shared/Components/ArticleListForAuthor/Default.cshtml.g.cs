#pragma checksum "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b17cf8986f144219f868b08b78305049ab09c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ArticleListForAuthor_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ArticleListForAuthor/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b17cf8986f144219f868b08b78305049ab09c6", @"/Views/Shared/Components/ArticleListForAuthor/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b789cbd8066d07baf8a094b4bbea5b0306e6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ArticleListForAuthor_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article.DomainModel.Query.Article.ArticleListItemForAuthorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-bordered table-hover table-responsive table-striped table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.ArticleID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.ArticleSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.SmallDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.PublicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.ArticlImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArticleID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArticleSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.SmallDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.PublicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArticlImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"btn btn-danger btnDeleteArticle\" data-id=\"");
#nullable restore
#line 55 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                                  Write(item.ArticleID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-img-name=\"");
#nullable restore
#line 55 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                                                                  Write(item.ArticlImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-action=\"");
#nullable restore
#line 55 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                                                                                                      Write(Url.Action("Delete","ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-author-id=\"");
#nullable restore
#line 55 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                                                                                                                                                                 Write(item.AuthorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-action-serach=\"");
#nullable restore
#line 55 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                                                                                                                                                                                                     Write(Url.Action("GetArticles","AuthorManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</span>\r\n                <span class=\"btn btn-info btnEdit\" data-id=\"");
#nullable restore
#line 56 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                       Write(item.ArticleID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-action=\"");
#nullable restore
#line 56 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
                                                                                     Write(Url.Action("Update","ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#dvContent\" data-target-Modal=\"#AuthorAddEditModal\">Edit</span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "F:\MVCEX\Essay\Essay\Views\Shared\Components\ArticleListForAuthor\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<span class=\"btn btn-danger btnCloseGrid\" data-show-target=\".AuthorGrid\" data-hide-target=\".ArticleGrid\">Close</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article.DomainModel.Query.Article.ArticleListItemForAuthorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

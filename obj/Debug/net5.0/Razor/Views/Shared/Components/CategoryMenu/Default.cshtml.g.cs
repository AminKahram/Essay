#pragma checksum "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea340285bea4974b51a31ce9679a99ebdaaf8888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea340285bea4974b51a31ce9679a99ebdaaf8888", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b789cbd8066d07baf8a094b4bbea5b0306e6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article.DomainModel.Query.Category.CategoryMenuItemModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    #mydropdown-menu {\r\n        left: -45px !important;\r\n        right: unset !important;\r\n    }\r\n</style>\r\n<nav class=\"main-menu\">\r\n    <div class=\"container\">\r\n        <ul class=\"list float-right\">\r\n");
#nullable restore
#line 21 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
             foreach (var Layer1 in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-item list-item-has-children mega-menu mega-menu-col-5\">\r\n                    <a class=\"nav-link\" href=\"#\">");
#nullable restore
#line 24 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                            Write(Layer1.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <ul class=\"sub-menu nav\">\r\n");
#nullable restore
#line 26 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
                         foreach (var Layer2 in Layer1.Children)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-item list-item-has-children\">\r\n                                <i class=\"now-ui-icons arrows-1_minimal-left\"></i>\r\n                                <a class=\"main-list-item nav-link btnarts\" data-action=\"");
#nullable restore
#line 30 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                   Write(Url.Action("ClientMenuSearch","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 30 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                                                                    Write(Layer2.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("href", " href=\'", 1226, "\'", 1301, 1);
#nullable restore
#line 30 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1233, Url.Action("ClientMenuSearch","Home",new{ID = @Layer2.CategoryID }), 1233, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 30 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                                                                                                                                                                          Write(Layer2.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
            WriteLiteral("                            </li>\r\n");
#nullable restore
#line 37 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n");
#nullable restore
#line 40 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <li class=""list-item amazing-item"">
                <div class=""user-login dropdown"">
                    <a href='#' class=""btn btn-neutral dropdown-toggle"" data-toggle=""dropdown"" id=""navbarDropdownMenuLink1"">
                        ورود
                    </a>
                    <ul class=""dropdown-menu"" id=""mydropdown-menu"" aria-labelledby=""navbarDropdownMenuLink1"" >
                        <div class=""dropdown-item"">
                            <a");
            BeginWriteAttribute("href", " href=\'", 2225, "\'", 2262, 1);
#nullable restore
#line 48 "F:\MVCEX\Essay\Essay\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 2232, Url.Action("Login","Account"), 2232, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info"">ورود</a>
                        </div>
                        <!-- <div class=""dropdown-item font-weight-bold"">
            <span>کاربر جدید هستید؟</span> <a class=""register"" href=""#"">ثبت‌نام</a>
        </div>
        <hr>
        <div class=""dropdown-item"">
            <a href=""#"" class=""dropdown-item-link"">
                <i class=""now-ui-icons users_single-02""></i>
                پروفایل
            </a>
        </div>
        <div class=""dropdown-item"">
            <a href=""#"" class=""dropdown-item-link"">
                <i class=""now-ui-icons shopping_bag-16""></i>
                پیگیری سفارش
            </a>
        </div>-->
                    </ul>
                </div>
            </li>
        </ul>
    </div>
</nav>
<!--<div class=""user-login dropdown"">
    <a href='#' class=""btn btn-neutral dropdown-toggle"" data-toggle=""dropdown"" id=""navbarDropdownMenuLink1"">
        ورود
    </a>
    <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownM");
            WriteLiteral(@"enuLink1"">
        <div class=""dropdown-item"">
            <a href='Url.Action(""Login"",""Account"")' class=""btn btn-info"">ورود</a>
        </div>-->
        <!-- <div class=""dropdown-item font-weight-bold"">
            <span>کاربر جدید هستید؟</span> <a class=""register"" href=""#"">ثبت‌نام</a>
        </div>
        <hr>
        <div class=""dropdown-item"">
            <a href=""#"" class=""dropdown-item-link"">
                <i class=""now-ui-icons users_single-02""></i>
                پروفایل
            </a>
        </div>
        <div class=""dropdown-item"">
            <a href=""#"" class=""dropdown-item-link"">
                <i class=""now-ui-icons shopping_bag-16""></i>
                پیگیری سفارش
            </a>
        </div>-->
    <!--</ul>
</div>-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article.DomainModel.Query.Category.CategoryMenuItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d72a049b5fba502924dc21755ea9266dc6fdfec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ArticleManagement_Index), @"mvc.1.0.view", @"/Views/ArticleManagement/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d72a049b5fba502924dc21755ea9266dc6fdfec", @"/Views/ArticleManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b789cbd8066d07baf8a094b4bbea5b0306e6f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ArticleManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article.DomainModel.Query.Article.ArticleSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ArticleManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmSearchArticle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .multiselectDrp-search {
        display: flex;
        flex-direction: column;
        flex-wrap: wrap;
        padding: 0;
        align-content: flex-start;
        justify-content: flex-start;
        align-items: center;
        height: fit-content;
        width: fit-content;
        border-radius: 16px;
        border: 1px solid #ccc !important;
        min-height: 35px;
        /*        overflow: hidden;
        max-height: 65px;
        overflow-y: auto;*/
    }

        .multiselectDrp-search > .multiselectDrp-colected {
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;
            align-content: flex-start;
            justify-content: flex-start;
            align-items: flex-start;
        }

            .multiselectDrp-search > .multiselectDrp-colected > .multiselectDrp-search-selected {
                display: flex;
                flex-direction: row;
                flex-wrap: nowrap;
                align-co");
            WriteLiteral(@"ntent: flex-start;
                justify-content: flex-start;
                align-items: center;
                width: fit-content;
                margin: 2px;
                border: 1px solid steelblue !important;
                border-radius: 16px;
                padding: 0.08em 16px;
                background-color: steelblue;
                color: white;
            }

        .multiselectDrp-search > .multiselectDrp-search-text {
            display: flex !important;
            flex-direction: row;
            flex-wrap: nowrap;
            align-content: flex-start;
            justify-content: flex-start;
            align-items: center;
            width: 99px;
            outline: 0;
            margin: 5px !important;
            border: 0;
        }

    .multiselectDrp-search-click {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        padding: 0;
        align-content: flex-start;
        justify-content: flex-start;
    ");
            WriteLiteral(@"    align-items: center;
        height: fit-content;
        width: 200px;
    }

    .multiselectDrp-search > .multiselectDrp-colected > .multiselectDrp-search-selected > a {
        font-family: cursive;
        margin-left: 10px;
        line-height: 1;
        text-decoration: none;
        color: white;
    }

        .multiselectDrp-search > .multiselectDrp-colected > .multiselectDrp-search-selected > a:hover {
            color: #ccc
        }

    .multiselectDrp-wrapper {
        border: 1px solid #ccc !important;
        border-top: none !important;
        padding: 0.01em 16px;
        height: fit-content;
        width: 200px;
        display: none;
        padding: 0;
        overflow: hidden;
        border-radius: 16px;
    }

    .multiselectDrp-wrapper-toggle-show {
        display: flex !important;
        flex-direction: column;
        flex-wrap: nowrap;
        align-content: flex-start;
        justify-content: flex-start;
        align-items: stretch;");
            WriteLiteral(@"
        overflow: hidden;
        max-height: 94px;
        overflow-y: auto;
    }

    .multiselectDrp-wrapper > .multiselectDrp-select {
        border-top: 1px solid #ccc !important;
        padding: 5px;
        color: black;
        text-decoration: none;
    }

        .multiselectDrp-wrapper > .multiselectDrp-select:hover {
            background-color: #3c8dbc;
        }

    .multiselectDrp-select-toggle {
        background-color: #ccc;
    }

    .multiselectDrp-wrapper > .multiselectDrp-select > span {
        margin-left: 5px;
    }
</style>
<script>
    $(document).on(""click"", "".authorDrp-search"", function () {
        var T = $(this).attr(""data-list"");
        $("".authorDrp-search"").toggleClass(""multiselectDrp-search-click"");
        $(T).toggleClass(""multiselectDrp-wrapper-toggle-show"");
    });
    $(document).on(""click"", "".keywordDrp-search"", function () {
        var T = $(this).attr(""data-list"");
        $("".keywordDrp-search"").toggleClass(""multiselectDrp");
            WriteLiteral(@"-search-click"");
        $(T).toggleClass(""multiselectDrp-wrapper-toggle-show"");
    });
    $(document).on(""click"", "".author-select"", function () {
        var T = $(this).attr(""data-list"");
        var S = $(this).attr(""data-search"");
        $(T).toggleClass(""multiselectDrp-wrapper-toggle-show"");
        $(S).toggleClass(""multiselectDrp-search-click"");
    });
    $(document).on(""click"", "".keyword-select"", function () {
        var T = $(this).attr(""data-list"");
        var S = $(this).attr(""data-search"");
        $(T).toggleClass(""multiselectDrp-wrapper-toggle-show"");
        $(S).toggleClass(""multiselectDrp-search-click"");
    });
</script>
<script>
    var myid = """";
    var myidkey = """";
    $(document).on(""click"", "".author-select"", function () {
        var T = $(this).attr(""data-target"");
        var thisId = $(this).attr(""data-id"") + "","";
        var thisValue = $(this).attr(""data-value"");
        var idtest = myid;
        if (!idtest.includes(thisId)) {
            myid = ");
            WriteLiteral(@"myid + thisId;
            buildSearchResultBasedOnDataForAuthor(thisValue, thisId);
        } else {
            myid = myid.replace(thisId, """");
            var str = `[data-item-value=""${thisValue}""]`;
            RemoveBasedOnData(str);
        }
        console.log(myid);
        $(T).val(myid);
    });
    $(document).on(""click"", "".keyword-select"", function () {
        var T = $(this).attr(""data-target"");
        var thisId = $(this).attr(""data-id"") + "","";
        var thisValue = $(this).attr(""data-value"");
        var idtest = myidkey;
        if (!idtest.includes(thisId)) {
            myidkey = myidkey + thisId;
            buildSearchResultBasedOnDataForKeyword(thisValue, thisId);
        } else {
            myidkey = myidkey.replace(thisId, """");
            var str = `[data-item-value=""${thisValue}""]`;
            RemoveBasedOnData(str);
        }
        console.log(myidkey);
        $(T).val(myidkey);
    });
    $(document).on('click', '.author-selected', function () ");
            WriteLiteral(@"{
        var thisid = $(this).attr(""data-id"");
        var T = $(this).attr(""data-target"");
        var thisvalue = $(this).attr(""data-item-value"");
        myid = myid.replace(thisid, """");
        $(T).val(myid);
        $(this).closest('div').remove();

    });
    $(document).on('click', '.keyword-selected', function () {
        var thisid = $(this).attr(""data-id"");
        var T = $(this).attr(""data-target"");
        var thisvalue = $(this).attr(""data-item-value"");
        myidkey = myidkey.replace(thisid, """");
        $(T).val(myidkey);
        $(this).closest('div').remove();
    });
    function buildSearchResultBasedOnDataForAuthor(value, id) {
        let test = `<div href=""#"" class=""multiselectDrp-search-selected"" ><a href=""#"" class=""multiselectDrp-search-selected-remove author-selected"" data-target=""#AuthorID"" data-id=""${id}"" data-item-value=""${value}"">x</a><span>${value}</span></div>`;
        console.log(test);
        $("".authorDrp-search >.multiselectDrp-colected"").append(");
            WriteLiteral(@"test);
    }
    function buildSearchResultBasedOnDataForKeyword(value, id) {
        let test = `<div href=""#"" class=""multiselectDrp-search-selected""><a href=""#"" class=""multiselectDrp-search-selected-remove keyword-selected"" data-target=""#KeywordID"" data-id=""${id}"" data-item-value=""${value}"" >x</a><span>${value}</span></div>`;
        console.log(test);
        $("".keywordDrp-search >.multiselectDrp-colected"").append(test);
    }

    function RemoveBasedOnData(str) {
        $(str).closest('div').remove();
    }
</script>
<script>
    $(""#ArticleSubject"").keyup(function () {
        $("".btnSearch"").click();
    });
</script>
<script>
    function SuccessMessage(SuccessTxt) {
        Swal.fire({
            icon: 'success',
            title: 'وضعیت ثبت',
            text: SuccessTxt,
        });
    }
    function ErrorMessage(ErrorTxt) {
        Swal.fire({
            icon: 'error',
            title: 'خطا',
            text: ErrorTxt,
        });
    }
</script>
<script>
            WriteLiteral(@"
    function BindGrid() {
        $("".btnSearch"").click();
    };
    function hideModal() {
        $(""#AddEditModal"").modal(""hide"");
    }
    $(document).on(""click"", ""#btnCancel"", function () {
        hideModal();
    });
    $(document).on(""click"", ""#btnAdd"", function () {
        myid = """";
        myidkey = """";
        var SU = $(this).attr(""data-Action"");
        var SD = null;
        var T = $(this).attr(""data-target"");
        var M = $(this).attr(""data-Modal"");
        $.get(SU, SD, function (rc) {
            $(T).html(rc);
            $(M).modal(""show"");
        });
    });
    $(document).on(""click"", "".btnDelete"", function () {
        if (confirm(""Are you sure you want to delete this record ?"")) {
            var SU = $(this).attr(""data-action"");
            var id = $(this).attr(""data-id"");
            var imgname = $(this).attr(""data-img-name"");
            var SD = ""id="" + id + ""&imgname="" + imgname;
            $.post(SU, SD, function (operationResult) {
      ");
            WriteLiteral(@"          if (operationResult.succes) {
                    SuccessMessage(operationResult.message);
                    BindGrid();

                }
                else {
                    ErrorMessage(operationResult.message);
                }
            });
        }

    });
    $(document).on(""click"", "".btnEdit"", function () {
        myid = """";
        myidkey = """";
        var SU = $(this).attr(""data-action"");
        var id = $(this).attr(""data-id"");
        var T = $(this).attr(""data-target"");
        var M = $(this).attr(""data-target-Modal"");
        var SD = ""id="" + id;
        $.get(SU, SD, function (rc) {
            $(T).html(rc);
            $(M).modal(""show"");
        });
    });

</script>
<script>
    function BindGridKeyword(articleid) {
        var SU = '");
#nullable restore
#line 303 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
             Write(Url.Action("GetKeywords","ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var id = articleid;
        var SD = ""id="" + id;
        var Target = $("".KeywordGrid"");
        $.get(SU, SD, function (rc) {
            $(Target).html(rc);
        });
    }
    function BindGridAuthor(articleid) {
        var SU = '");
#nullable restore
#line 312 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
             Write(Url.Action("GetAuthors","ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var id = articleid;
        var SD = ""id="" + id;
        var Target = $("".AuthorGrid"");
        $.get(SU, SD, function (rc) {
            $(Target).html(rc);
        });
    }

    $(document).ready(function () {
        $("".btnSearch"").click(function (e) {
            var SU = $(this).attr(""data-Action"");
            var frmID = $(this).attr(""data-form"");
            var SD = $(frmID).serialize();
            var Target = $(this).attr(""data-target"");
                e.preventDefault();
                $.get(SU, SD, function (rc) {
                    $(Target).html(rc);
                });

        });
        $(""#ArticleSubject"").keyup(function () {
            $("".btnSearch"").click();
        });
         $("".author-search"").keyup(function () {
            var SearchText = $("".author-search"").val();
            //var Searcheddata = $(`[data-slide-author=""${SearchText}""]`).prop('outerHTML');
            //if (Searcheddata.includes(SearchText)) {
            //    $("".a");
            WriteLiteral(@"uthor-Drp"").html(Searcheddata);
            //    $("".author-Drp"").addClass(""multiselectDrp-wrapper-toggle-show"");
            //    //myid = myid + thisId;
            //    ////myvalue = myvalue + $thisValue;
            //    //buildSearchResultBasedOnDataForAuthor($thisValue, thisId);
            //}
            //$('#the_list_item').prop('outerHTML');
            //console.log(Searcheddata);
            /*if (SearchText == null || SearchText.length >= 0) {*/
            var sendingUrl = $(this).attr(""data-action"");
            var SendingRoute = $(this).attr(""data-sending"");
            var sendingData = SendingRoute + ""="" + SearchText;
            $.get(sendingUrl,
                sendingData,
                function (data) {
                    $("".author-Drp"").html(data);
                    $("".author-Drp"").addClass(""multiselectDrp-wrapper-toggle-show"");
                    //    $("".multiselectDrp-wrapper"").slideDown();
                });
            /*}*/
        });
        ");
            WriteLiteral(@"$("".keyword-search"").keyup(function () {
            var SearchText = $("".keyword-search"").val();

            var sendingUrl = $(this).attr(""data-action"");
            var SendingRoute = $(this).attr(""data-sending"");
            var sendingData = SendingRoute + ""="" + SearchText;
            $.get(sendingUrl,
                sendingData,
                function (data) {
                    $("".keyword-Drp"").html(data);
                    $("".keyword-Drp"").addClass(""multiselectDrp-wrapper-toggle-show"");
                    //    $("".multiselectDrp-wrapper"").slideDown();
                });
            /*}*/

        });
        $(""#KeywordSelected"").change(function () {
            $("".btnSearch"").click();
        });
        $(""#PageIndex"").change(function () {
            $("".btnSearch"").click();
        });
    })
    $(document).on(""change"",""#FirstLayerCat"",function () {
            var ParentID = $(""#FirstLayerCat"").val();
        $.get('");
#nullable restore
#line 386 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
          Write(Url.Action("GetSubCat", "ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', ""ParentID="" + ParentID, function (rc) {
            $("".subCat"").html(rc);
        });
    });
    $(document).on(""click"", "".btnDeleteKeyword"", function () {
        if (confirm(""Are you sure you want to delete this record ?"")) {
            var SU = $(this).attr(""data-action"");
            var articleid = $(this).attr(""data-article-id"");
            var keywordid = $(this).attr(""data-keyword-id"");
            var SD = ""ArticleID="" + articleid + ""&KeywordID="" + keywordid;
            $.post(SU, SD, function (operationResult) {
                if (operationResult.succes) {
                    SuccessMessage(operationResult.message);
                    BindGridKeyword(articleid);
                    BindGrid();
                }
                else {
                    ErrorMessage(operationResult.message);
                }
            });
        }
    });
    $(document).on(""click"", "".btnDeleteAuthor"", function () {
        if (confirm(""Are you sure you want to delete this record");
            WriteLiteral(@" ?"")) {
            var SU = $(this).attr(""data-action"");
            var articleid = $(this).attr(""data-article-id"");
            var authorid = $(this).attr(""data-author-id"");
            var SD = ""ArticleID="" + articleid + ""&AuthorID="" + authorid;
            $.post(SU, SD, function (operationResult) {
                if (operationResult.succes) {
                    SuccessMessage(operationResult.message);
                    BindGridAuthor(articleid);
                    BindGrid();
                }
                else {
                    ErrorMessage(operationResult.message);
                }
            });
        }
    });
    $(document).on(""submit"", ""#frmAddNew"", function (e) {
         e.preventDefault();
         $(""#preLoaderSpinner"").css(""display"", ""initial"");
         $(""#btnAddNew"").css(""display"", ""none"");
         $(""#btnCancel"").css(""display"", ""none"");
         var formData = new FormData(this);
         $.ajax({
             type: ""POST"",
             url: """);
#nullable restore
#line 434 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
              Write(Url.Action("AddNew", "ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
             contentType: false,
             processData: false,
             data: formData,
             success: function (operationResult) {
                 SuccessMessage(operationResult.message);
                 $(""#preLoaderSpinner"").css(""display"", ""none"");
                 BindGrid();
                 hideModal();
             },
             error: function (operationResult) {
                 ErrorMessage(operationResult.message);
                 $(""#preLoaderSpinner"").css(""display"", ""none"");
                 hideModal();
             }
         });
    });
    $(document).on(""submit"", ""#frmUpdateArtice"", function (e) {
        e.preventDefault();
        $(""#preLoaderSpinner"").css(""display"", ""initial"");
        $(""#btnEditChanges"").css(""display"", ""none"");
        $(""#btnCancel"").css(""display"", ""none"");
         var formData = new FormData(this);
         $.ajax({
             type: ""POST"",
             url: """);
#nullable restore
#line 459 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
              Write(Url.Action("Update", "ArticleManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
             contentType: false,
             processData: false,
             data: formData,
             success: function (operationResult) {
                 SuccessMessage(operationResult.message);
                 $(""#preLoaderSpinner"").css(""display"", ""none"");

                 BindGrid();
                 hideModal();
             },
             error: function (operationResult) {
                 ErrorMessage(operationResult.message);
                 $(""#preLoaderSpinner"").css(""display"", ""none"");

                 hideModal();

             }
         });
    });
    $(document).on(""click"", "".btnCloseGrid"", function () {
        var showgrid = $(this).attr(""data-show-target"");
        var hidegrid = $(this).attr(""data-hide-target"");
        $(hidegrid).hide();
        $(showgrid).show();
    });
    $(document).on(""click"", "".btnKeywords , .btnAuthors"", function () {
        var SU = $(this).attr(""data-action"");
        var id = $(this).attr(""data-id"");
        var SD");
            WriteLiteral(@" = ""id="" + id;
        var T = $(this).attr(""data-target"");
        var H = $(this).attr(""data-hide-target"");
        $.get(SU, SD, function (rc) {
            $(H).hide();
            $(T).show();
            $(T).html(rc);
        })
    });
</script>
<div class=""row"">
    <div class=""col-md-4"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a049b5fba502924dc21755ea9266dc6fdfec25545", async() => {
                WriteLiteral("\r\n            <div>\r\n");
#nullable restore
#line 502 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
                  
                    if (TempData["ErrorMessage"] != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h3 style=\"color:red;\">");
#nullable restore
#line 505 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
                                          Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 506 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a049b5fba502924dc21755ea9266dc6fdfec26707", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 510 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArticleSubject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d72a049b5fba502924dc21755ea9266dc6fdfec28289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 511 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArticleSubject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a049b5fba502924dc21755ea9266dc6fdfec29929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 514 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.KeywordSelected);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a049b5fba502924dc21755ea9266dc6fdfec31512", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 516 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
               Write(await Component.InvokeAsync("KeywordDrpSearch"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 515 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.KeywordSelected);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a049b5fba502924dc21755ea9266dc6fdfec33453", async() => {
                    WriteLiteral("\r\n                ");
#nullable restore
#line 520 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
           Write(await Component.InvokeAsync("Pager", @TempData["PageCountArticle"]));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 519 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageIndex);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-primary btnSearch\" data-IsAjax=\"True\" data-action=\"");
#nullable restore
#line 523 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
                                                                                                                 Write(Url.Action("Search","ArticleManagement"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-target=\"#dvGrid\" data-form=\"#frmSearchArticle\" />\r\n                <span class=\"btn btn-success \" id=\"btnAdd\" data-Action=\"");
#nullable restore
#line 524 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
                                                                   Write(Url.Action("AddNew", "ArticleManagement"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-target=\"#dvContent\" data-Modal=\"#AddEditModal\">Add</span>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md\">\r\n        <div id=\"dvGrid\" class=\"ArticleGrid\">\r\n            ");
#nullable restore
#line 530 "F:\MVCEX\Essay\Essay\Views\ArticleManagement\Index.cshtml"
       Write(await Component.InvokeAsync("ArticleList", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""KeywordGrid"">

        </div>
        <div class=""AuthorGrid"">

        </div>
    </div>
  

</div>
    <!-- Modal -->
    <div class=""modal fade"" id=""AddEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"" id=""myModalLabel"">Author Add Edit</h4>
                </div>
                <div class=""modal-body"" id=""dvContent"">
                    ...
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article.DomainModel.Query.Article.ArticleSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
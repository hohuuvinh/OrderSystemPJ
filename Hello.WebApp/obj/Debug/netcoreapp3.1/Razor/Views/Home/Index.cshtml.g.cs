#pragma checksum "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e83ebbf084014946e95b036b664aa27944a086d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\_ViewImports.cshtml"
using Hello.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\_ViewImports.cshtml"
using Hello.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e83ebbf084014946e95b036b664aa27944a086d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34f3112ccbb817533c6a64656cb97ca1d747613", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hello.Application.MTbl_product.Tbl_productResponse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_calculator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .shadow-ok {
        -webkit-box-shadow: 0px 2px 12px 2px rgba(218,255,212,0.6);
        -moz-box-shadow: 0px 2px 12px 2px rgba(218,255,212,0.6);
        box-shadow: 0px 2px 12px 2px rgba(218,255,212,0.6);
    }

    #scroll--item::-webkit-scrollbar {
        width: 6px;
        background-color: #F5F5F5;
    }

    #scroll--item::-webkit-scrollbar-thumb {
        background-color: #000000;
    }
</style>

<div class=""container-fluid p-0"" style=""height: 100vh; min-width: 1000px"">
    <div class=""float-left"" style=""width: 380px;height: 100vh;border-right: 2px solid #28a745"">
        <div style=""width: 100%;height: 50px;background: #fff"">
            <p class=""font-weight-bold text-success ml-2 float-left mb-0"" style=""font-size: 150%;line-height: 50px;"">POSystem</p>
            <p class=""float-right mb-0 mr-2"" style=""line-height: 50px;"">Adminitrator</p>
            <div style=""clear: both;""></div>
        </div>
        <div style=""width: 100%;height: calc(100vh - 250px);back");
            WriteLiteral(@"ground: #fff;"">
            <div id=""scroll--item"" class=""p-2 pt-2"" style=""height: calc(100vh - 250px);overflow-y: scroll;"">
                <div id=""ListItem"">

                </div>
                <div class=""shadow-ok p-2"" style=""width: 100%;border-radius:10px"">
                    <p class=""float-left mb-0"">Giam giá</p>
                    <p id=""discount"" class=""float-right mb-0"">0</p>
                    <div style=""clear: both;""></div>
                    <p class=""float-left mb-0"">Phí</p>
                    <p class=""float-right mb-0"">0đ</p>
                    <div style=""clear: both;""></div>
                    <p class=""float-left mb-0 font-weight-bold"">Tổng cộng</p>
                    <p id=""total"" class=""float-right mb-0 font-weight-bold"">0</p>
                    <div style=""clear: both;""></div>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e83ebbf084014946e95b036b664aa27944a086d5987", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"float-right\" style=\"width: calc(100% - 380px);height: 100vh;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e83ebbf084014946e95b036b664aa27944a086d7211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"row m-0 p-2\">\r\n");
#nullable restore
#line 53 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2364, "\"", 2393, 3);
            WriteAttributeValue("", 2374, "addToCart(", 2374, 10, true);
#nullable restore
#line 55 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2384, item.id, 2384, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2392, ")", 2392, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"col-2 p-2\">\r\n                    <div class=\"shadow-ok\" style=\"width: 100%;height: 160px;background: #fff;border-radius:10px;\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2559, "\"", 2588, 1);
#nullable restore
#line 57 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2565, "/image/"+item.image, 2565, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"100px\" style=\"border-top-left-radius:10px;border-top-right-radius:10px;\">\r\n                        <p class=\"font-weight-bold text-center mt-1 mb-0\">");
#nullable restore
#line 58 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
                                                                     Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-center\">");
#nullable restore
#line 59 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
                                           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\KimAnh\source\repos\OrderSystemPJ\Hello.WebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>


    </div>
</div>

<script>
    function addToCart(id) {
        var check = -1;
        $(document).ready(function () {
            $.ajax({
                type: ""get"",
                dataType: ""json"",
                url: ""https://localhost:44358/api/Tbl_order/GetOrder"",
                contentType: ""html"",
                success: function (data) {
                    console.log(data);
                    $.each(data, function (index, value) {
                        console.log(value.idproduct);
                        console.log(id);
                        if (value.idproduct == id) {

                            check = 1;
                            return false;
                        } else {
                            check = 0;
                        }
                    });
                    //console.log(""chon o"" + check);
                    if (check == 1) {
                        var iditem = $(""#iditem"" + id).val();
                 ");
            WriteLiteral(@"       var discount = $(""#discount"" + id).val();
                        var quanlity = $(""#quanlity"" + id).val();
                        var idproduct = $(""#idproduct"" + id).val();
                        var idorder = $(""#idorder"" + id).val();
                        //console.log(iditem);
                        var SetData = $(""#ListItem"");
                        SetData.html("""");
                        $.ajax({
                            method: ""post"",
                            url: ""https://localhost:44358/api/Tbl_item/UpdateQuanlity"",
                            data: JSON.stringify({
                                id: parseInt(iditem),
                                discount: parseInt(discount),
                                quanlity: parseInt(1 * quanlity + 1),
                                idproduct: parseInt(idproduct),
                                idorder: parseInt(idorder)
                            }),
                            headers: {
                    ");
            WriteLiteral(@"            'Accept': 'application/json',
                                'Content-Type': 'application/json'
                            },
                            success: function (data) {
                                featchListItem();
                            }
                        });
                    } else {
                        var SetData = $(""#ListItem"");
                        SetData.html("""");
                        $.ajax({
                            method: ""post"",
                            url: ""https://localhost:44358/api/Tbl_item/Create"",
                            data: JSON.stringify({
                                idproduct: id,
                                discount: 0,
                                quanlity: 1
                            }),
                            headers: {
                                'Accept': 'application/json',
                                'Content-Type': 'application/json'
                            },");
            WriteLiteral(@"
                            success: function (data) {
                                featchListItem();
                            }
                        });
                    }
                }
            });
        });
    }

    function deleteItem(id) {
        var SetData = $(""#ListItem"");
        SetData.html("""");
        $.ajax({
            method: ""post"",
            url: ""https://localhost:44358/api/Tbl_item/Delete"",
            data: JSON.stringify({
                id: id
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            success: function (data) {
                featchListItem();
            }
        });
    }

</script>
<style>
    .idItemBoxBackground {
        background: #ceffd9 !important;
    }
</style>
<script>
    var idItemMax = 0;
    var checkSelect = 0;
    function actionItemMax() {
        $(""#idItemBox"" + idItemMax).addC");
            WriteLiteral(@"lass(""idItemBoxBackground"");
        console.log(""ok"" + idItemMax);
    }


    var idItemNow = -1;
    var idDiscountNow = -1;
    var idQuanlityNow = -1;
    var idProductNow = -1;
    var idOrderNow = -1;

    featchListItem();
    function featchListItem() {
        var total = 0;
        var discount = 0;
        $(document).ready(function () {
            var SetData = $(""#ListItem"");
            SetData.html("""");
            $.ajax({
                type: ""get"",
                dataType: ""json"",
                url: ""https://localhost:44358/api/Tbl_order/GetOrder"",
                contentType: ""html"",
                success: function (data) {
                    //console.log(data);
                    $.each(data, function (index, value) {
                        total += value.price * value.quanlity * ((100 - value.discount) / 100);
                        discount += value.price * value.quanlity * value.discount / 100;
                        var priceItem = value.price ");
            WriteLiteral(@"* value.quanlity * ((100 - value.discount) / 100);

                        if (checkSelect == 0) {
                            idItemMax = value.iditem;
                            idItemNow = value.iditem;
                            idDiscountNow = value.discount;
                            idQuanlityNow = value.quanlity;
                            idProductNow = value.idproduct;
                            idOrderNow = value.idorder;
                        }

                        
                        var Data = `
                <div onclick=""selectItem(` + value.iditem + `,` + value.discount + `,` + value.quanlity + `,` + value.idproduct + `,` + value.idorder + `)"" id=""idItemBox` + value.iditem + `"" class=""shadow-ok mb-2 item--box"" style=""width: 100%; border-radius: 10px"">
                <div class=""float-left"" style=""height: 55px;width: 60px;"">
                    <img src=""/image/` + value.image + `"" width=""100%"" height=""100%"" style=""border-top-left-radius: 10px;border-bottom-");
            WriteLiteral(@"left-radius: 10px"">
                </div>
                <div class=""float-left p-1 pt-0"" style=""height: 50px;width: calc(100% - 170px);"">
                    <p class=""font-weight-bold mb-0 cl ml-1"" style=""font-size: 90%"">` + value.name + `</p>
                    <p class=""cl mb-0 ml-1 float-left"" style=""font-size: 90%"">Số lượng: ` + value.quanlity + `- Giam gia: </p><p class=""float-left"" id=""discountText` + value.iditem + `"" style=""font-size: 90%"">` + value.discount + `%</p>
                </div>
                   <div onclick=""deleteItem(` + value.iditem + `)"" class=""float-right p-1 bg-success text-center"" style=""width: 30px;height: 55px;border-top-right-radius: 10px;border-bottom-right-radius: 10px;"">
                        <i class=""fa fa-trash text-white "" aria-hidden=""true"" style=""line-height: 46px;""></i>
                    </div>
                <div class=""float-right p-1"" style=""width: 80px;height: 50px;"">
                    <p class=""font-weight-bold float-right cl"" style=""font-si");
            WriteLiteral(@"ze: 90%"">` + priceItem + `đ</p>
                </div>
                <div style=""clear: both;""></div>
                <input style=""display:none"" id=""iditem`+ value.idproduct + `"" value=""` + value.iditem + `""/>
                <input style=""display:none"" id=""discount`+ value.idproduct + `"" value=""` + value.discount + `""/>
                <input style=""display:none"" id=""quanlity`+ value.idproduct + `"" value=""` + value.quanlity + `""/>
                <input style=""display:none"" id=""idproduct`+ value.idproduct + `"" value=""` + value.idproduct + `""/>
                <input style=""display:none"" id=""idorder`+ value.idproduct + `"" value=""` + value.idorder + `""/>
            </div>`;
                        SetData.append(Data);

                    });
                    $(""#total"").text(total);
                    $(""#discount"").text(discount);
                    actionItemMax();
                }

            });
        });
    }


    function selectItem(iditem, discount, quanlity, idpro");
            WriteLiteral(@"duct, idorder) {

        //var btns = document.getElementsByClassName(""item--box"");
        //for (var i = 0; i < btns.length; i++) {
        //    $(""item--box"").removeClass(""idItemBoxBackground"");
        //}
        checkSelect = 1;

        number = '';
        idItemMax = iditem;
        idDiscountNow = discount;
        idQuanlityNow = quanlity;
        idProductNow = idproduct;
        idOrderNow = idorder;
        console.log(iditem, idDiscountNow, idQuanlityNow, idProductNow, idOrderNow)
        //$(""#idItemBox"" + idItemMax).removeClass(""idItemBoxBackground"");
        $(""#idItemBox"" + iditem).addClass(""idItemBoxBackground"");
    }












</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hello.Application.MTbl_product.Tbl_productResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0a48ffa24bb375c3171ca1b476ac0f263e98c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\_ViewImports.cshtml"
using Hello.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\_ViewImports.cshtml"
using Hello.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0a48ffa24bb375c3171ca1b476ac0f263e98c3", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34f3112ccbb817533c6a64656cb97ca1d747613", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hello.Application.MTbl_payment.Tbl_paymentResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid p-0"" style=""height: 100vh;min-width: 1000px"">
        <div class=""float-right"" style=""width: 100%;height: 100vh;"">
            <div class=""p-2"" style=""        width: 100%;
        height: 55px;
        background: #D1CAFF
"">
                <div class=""bg-white text-center pt-1 float-left mr-2 hidePrinf"" style=""width: 50px;height: 100%;border-radius: 6px"">
                    <a href=""/"">
                        <i class=""fa fa-home text-primary"" aria-hidden=""true"" style=""font-size: 200%""></i>
                        </a>
                </div>
            </div>
            <div class=""container"" style=""height: 1000px"">
                <div class="" p-3"" style=""width: 100%"">
                    <div class=""hidePrinf"">
                      
                            <div onclick=""addNewOrder()"" class=""btn btn-primary float-right"">Create new order</div>
                       
                        <p class=""text-center font-weight-bold ml-5"" style=""font-si");
            WriteLiteral("ze: 150%\">Refund: ");
#nullable restore
#line 24 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.refund));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</p>
                        <div style=""clear: both;""></div>
                    </div>
                    <div class=""row m-0"">
                        <div class=""shadow-ok bg-white p-3 "" style=""width: 40%;height: 600px;margin: auto"">
                            <div class=""btn btn-primary js-print-link hidePrinf"" style=""width: 100%""><i class=""fa fa-print mr-2"" aria-hidden=""true""></i> Print bill</div>
                            <div id=""print"" class=""mt-2 p-4 shadow-ok"" style=""width: 100%;height: 500px;"">
                                <p class=""text-center"">");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                                                  Write(Html.DisplayFor(model => model.create_at));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Code ");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.idorder));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <p class=""mb-0"">Shohoz Hisab</p>
                                <p class=""mb-0"">Phone: +01700000000</p>
                                <p>Account:Admin</p>
                                <div id=""GetAjax"">
                                    
                                </div>
                                <p class=""float-left mb-0 mt-3"">Discount</p>
                                <p class=""float-right mb-0 mt-3"">
                                    ");
#nullable restore
#line 40 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                               Write(Html.DisplayFor(model => model.discount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"৳
                                                            </p>
                                <div style=""clear: both;""></div>
                                <p class=""float-left mb-0"">Fee</p>
                                <p class=""float-right mb-0"">0</p>
                                <div style=""clear: both;""></div>
                                <p class=""float-left mb-0 font-weight-bold"" style=""font-size: 130%"">Total</p>
                                <p class=""float-right mb-0 font-weight-bold"" style=""font-size: 130%"">
                                    ");
#nullable restore
#line 48 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                               Write(Html.DisplayFor(model => model.total));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"৳
                                                            </p>
                                <div style=""clear: both;""></div>

                                <p class=""float-left mb-0 mt-3"">Pay</p>
                                <p class=""float-right mb-0 mt-3"">
                                    ");
#nullable restore
#line 54 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                               Write(Html.DisplayFor(model => model.receive));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"৳
                                                            </p>
                                <div style=""clear: both;""></div>
                                <p class=""float-left mb-0"">Refund</p>
                                <p class=""float-right mb-0"">
                                    ");
#nullable restore
#line 59 "C:\Users\HP\OneDrive\Desktop\Final project000\Final project000\Hello.WebApp\Views\Payment\Index.cshtml"
                               Write(Html.DisplayFor(model => model.refund));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"৳
                                                            </p>
                                <div style=""clear: both;""></div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>

    <script type=""text/javascript"">
        $('.js-print-link').on('click', function () {
            $("".hidePrinf"").hide();

            window.print();
            $("".hidePrinf"").show();
        });

        fetchItemBill();
        function fetchItemBill() {
            var SetGetAjax = $(""#GetAjax"");
            SetGetAjax.html("""");
            $(document).ready(function () {
                $(""#GetAll"").hide();
                $(""#GetAjax"").show();
                $.ajax({
                    type: ""get"",
                    dataType: ""json"",
                    url: ""https://localhost:44358/api/Tbl_order/GetOrder"",
                    contentType: ""html"",
                    suc");
            WriteLiteral(@"cess: function (data) {
                        //console.log(data);
                        $.each(data, function (index, value) {
                            var Data = `<p class=""float-left mb-0"" style=""width: 50%"">` + value.name + `</p><p class=""float-left mb-0"" style=""width: 25%"">` + value.quanlity +`</p><p class=""float-left mb-0 bg-danger"" style=""width: 25%"">
                                    <p class=""float-right mb-0"">`+ value.price +`৳
</p></p>
                                    <div style=""clear: both;""></div>`;
                            SetGetAjax.append(Data);
                        }
                        )
                    }
                });
            })
        }

        function addNewOrder() {
            $.ajax({
                method: ""post"",
                url: ""https://localhost:44358/api/Tbl_order/Create"",
                data: JSON.stringify({
                    fee: 0,
                    total: 0,
                    discount: 0
             ");
            WriteLiteral(@"   }),
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                success: function (data) {
                    window.location.href = ""/"";
                }
            });
        }
    </script>

    




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hello.Application.MTbl_payment.Tbl_paymentResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75cc7262eaf8d2338f6766232e39cdf121650fe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Case_index), @"mvc.1.0.view", @"/Views/Case/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Case/index.cshtml", typeof(AspNetCore.Views_Case_index))]
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
#line 1 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75cc7262eaf8d2338f6766232e39cdf121650fe3", @"/Views/Case/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Case_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(42, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(79, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba61bdafeee74ac8bf09028f19f0e90e", async() => {
                BeginContext(85, 297, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>客户案例 - 格莱软件</title>
    <link rel=""stylesheet"" href=""css/common.css"">
    <link rel=""stylesheet"" href=""css/case.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(389, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(393, 11392, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e47b12aad14a33a4595e7c8551d7f8", async() => {
                BeginContext(399, 97, true);
                WriteLiteral("\r\n    <!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 496, "\"", 530, 1);
#line 20 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 503, Url.Action("Index","Home"), 503, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(531, 280, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 811, "\"", 845, 1);
#line 27 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 818, Url.Action("Index","Home"), 818, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(846, 288, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1134, "\"", 1178, 1);
#line 33 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1141, Url.Action("Classic","WebSiteBuild"), 1141, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1179, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1331, "\"", 1377, 1);
#line 36 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1338, Url.Action("Marketing","WebSiteBuild"), 1338, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1378, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1530, "\"", 1579, 1);
#line 39 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1537, Url.Action("ResponseType","WebSiteBuild"), 1537, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1580, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1732, "\"", 1775, 1);
#line 42 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1739, Url.Action("DirSir","WebSiteBuild"), 1739, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1776, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1928, "\"", 1970, 1);
#line 45 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1935, Url.Action("Dress","WebSiteBuild"), 1935, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1971, 212, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2183, "\"", 2218, 1);
#line 50 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2190, Url.Action("Index","Offer"), 2190, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2219, 128, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item cur\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2347, "\"", 2381, 1);
#line 53 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2354, Url.Action("Index","Case"), 2354, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2382, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2506, "\"", 2543, 1);
#line 56 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2513, Url.Action("Index","NetWork"), 2513, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2544, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2668, "\"", 2703, 1);
#line 59 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2675, Url.Action("Index","About"), 2675, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2704, 3631, true);
                WriteLiteral(@">关于我们</a>
                    </li>
                </ul>
            </div>

            <div class=""hd-tel"">
                <div class=""tel-title"">售前咨询</div>
                <div class=""tel-num"">
                    <p class=""tel-num-t"">400-660-8066</p>
                    <p class=""tel-num-b"">400-660-5555转1</p>
                </div>
            </div>
        </div>
    </section>
    <!-- 公共头部导航 end -->
    <!-- 主体内容 start -->
    <div id=""app"">
        <section class=""case-main"">
            <!-- banner start -->
            <section class=""main-banner"">
                <div class=""img-box"">
                    <img src=""/images/case/case-banner.png"" alt="""">
                </div>
                <div class=""banner-contetn"">
                    <div class=""banner-wrap"">
                        <h2 class=""banner-tit"">精品案例</h2>
                        <p class=""banner-p"">行业，风格，功能，产品……您只管选，我们负责呈现！</p>
                    </div>
                </div>
            </section>
  ");
                WriteLiteral(@"          <!-- banner end -->
            <!--筛选项 start-->
            <section>
                <div class=""top-nav public-center"">
                    <div class=""nav-item"">
                        <div class=""item-label"">行业分类：</div>
                        <ul class=""list current type"">
                            <li class=""item"" v-on:click=""industryid = null,getData()"" v-bind:class=""{ cur: industryid==null }"">不限</li>
                            <li class=""item"" v-for=""item in industries"" v-on:click=""industryid = item.id,getData()"" v-bind:class=""{ cur: industryid==item.id }"">{{item.name}}</li>
                        </ul>
                        <div class=""slider-up"">展开</div>
                    </div>
                    <div class=""line""></div>
                    <div class=""nav-item"">
                        <div class=""item-label"">颜色：</div>
                        <ul class=""list bgcolor"">
                            <li class=""item"" v-bind:class=""{ cur: colorid==null }"" v-on:click=");
                WriteLiteral(@"""colorid = null,getData()""></li>
                            <li class=""item"" v-for=""item in colors"" v-bind:title=""item.name"" v-on:click=""colorid = item.id,getData()"" v-bind:class=""{ cur: item.id==colorid }""></li>
                        </ul>
                    </div>
                    <div class=""nav-item"">
                        <div class=""item-label"">产品分类：</div>
                        <ul class=""list"">
                            <li class=""item"" v-bind:class=""{ cur: productid==null }"" v-on:click=""productid = null,getData()"">不限</li>
                            <li class=""item"" v-for=""item in products"" v-on:click=""productid = item.id,getData()"" v-bind:class=""{ cur: item.id==productid }"">{{item.name}}</li>
                        </ul>
                    </div>
                    <div class=""nav-item"">
                        <div class=""item-label"">客户端：</div>
                        <ul class=""list"">
                            <li class=""item"" v-bind:class=""{ cur: clientid==null }"" v");
                WriteLiteral(@"-on:click=""clientid = null,getData()"">不限</li>
                            <li class=""item"" v-for=""item in clients"" v-on:click=""clientid = item.id,getData()"" v-bind:class=""{ cur: item.id==clientid }"">{{item.name}}</li>
                        </ul>
                    </div>
                </div>
            </section>
            <!--筛选项 end-->
            <!--案例列表 start-->
            <section>
                <ul class=""public-list public-center"">
                    <li class=""public-item"" v-for=""item in cases"">
                        <a");
                EndContext();
                BeginWriteAttribute(":href", " :href=\"", 6335, "\"", 6389, 3);
                WriteAttributeValue("", 6343, "\'", 6343, 1, true);
#line 130 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 6344, Url.Action("CaseDetail","Case"), 6344, 32, false);

#line default
#line hidden
                WriteAttributeValue("", 6376, "?id=\'+item.id", 6376, 13, true);
                EndWriteAttribute();
                BeginContext(6390, 1239, true);
                WriteLiteral(@" target=""_blank"">
                            <div class=""img-box"">
                                <img :src=""item.cover"" alt=""深圳市超跃食品有限公司"">
                            </div>
                            <div class=""item-desc"">
                                <p class=""item-tit"">{{item.name}}</p>
                                <p class=""item-type"">食品餐饮</p>
                            </div>
                        </a>
                    </li>
                </ul>
            </section>
            <!--案例列表 end-->
            <!--分页 start-->
            <section>
                <div class=""pagination public-center"">
                    <a class=""first"" href="""" v-on:click=""page=1"">首页</a>
                    <a class=""prev"" href="""" v-if=""paging>1 && page-1>0"">上一页</a>
                    <a class=""num"" href="""" v-for=""item in paging"" v-bind:class=""{ active: page==item }"">{{item}}</a>
                    <a class=""next"" href="""" v-if=""paging>1 && page+1<=paging"">下一页</a>
                    ");
                WriteLiteral("<a class=\"end\" href=\"\" v-on:click=\"page=paging\">尾页</a>\r\n                </div>\r\n            </section>\r\n            <!--分页 end-->\r\n        </section>\r\n    </div>\r\n    <!-- 主体内容 end -->\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(7630, 23, false);
#line 158 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(7653, 2490, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

    <script src=""assets/jquery1.11.2.js""></script>
    <script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""js/public.js""></script>
    <script src=""https://cdn.bootcss.com/vue/2.5.17/vue.min.js""></script>
    <script src=""https://cdn.bootcss.com/axios/0.18.0/axios.min.js""></script>
    <script>


        //Vue
        var app = new Vue({
            el: '#app',
            data: {
                industries: null,
                colors: null,
                products: null,
                clients: null,
                cases: null,
                industryid: null,
                colorid: null,
                productid: null,
                clientid: null,
                case: null,
                paging: 0,
                page: 1,
                limit: 10
            },
            mounted: function () {
                this.initStyle();
                this.initData();
            },
         ");
                WriteLiteral(@"   methods: {
                initStyle: function () {
                    // 展开效果
                    (function () {
                        var bool = true;
                        $('.slider-up').click(function () {
                            $(this).toggleClass('current');
                            if (bool) {
                                bool = false;
                                var list = $('.list.type');
                                if (list.hasClass('current')) {
                                    list.animate({
                                        height: '87px',
                                    }, function () {
                                        bool = true;
                                    }).removeClass('current');

                                    $(this).html('收起');
                                } else {
                                    list.animate({
                                        height: ""29px"",
                                 ");
                WriteLiteral(@"   }, function () {
                                        bool = true;
                                    }).addClass('current')
                                    $(this).html('展开');
                                }
                            }
                        })
                    })()
                },
                initData: function () {
                    var that = this;
                    axios.get('");
                EndContext();
                BeginContext(10144, 29, false);
#line 223 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
                          Write(Url.Action("InitData","Case"));

#line default
#line hidden
                EndContext();
                BeginContext(10173, 894, true);
                WriteLiteral(@"')
                        .then(function (response) {
                            that.industries = response.data.data.industries;
                            that.colors = response.data.data.colors;
                            that.products = response.data.data.products;
                            that.clients = response.data.data.clients;
                            that.paging = response.data.total == 0 ? 0 : response.data.total <= response.data.limit ? 1 : Math.ceil(response.data.total / response.data.limit);
                            that.getData();
                        })
                        .catch(function (error) {
                            console.log(error);
                        });

                },
                getData: function () {
                    var that = this;
                    that.page = 1;
                    $.post('");
                EndContext();
                BeginContext(11068, 32, false);
#line 240 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Case\index.cshtml"
                       Write(Url.Action("SelectCases","Case"));

#line default
#line hidden
                EndContext();
                BeginContext(11100, 678, true);
                WriteLiteral(@"',
                        {
                            page: that.page,
                            limit: that.limit,
                            industryid: that.industryid,
                            colorid: that.colorid,
                            productid: that.productid,
                            clientid: that.clientid
                        }, function (data, status) {
                            that.cases = data.data;
                            that.paging = data.total == 0 ? 0 : data.total <= data.limit ? 1 : Math.ceil(data.total / data.limit);
                        });
                }
            }
        });

    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11785, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
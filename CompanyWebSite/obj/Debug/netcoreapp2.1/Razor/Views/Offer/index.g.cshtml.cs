#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d6b93cd14a7b6fb28d824f1f82e66085d1e5e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offer_index), @"mvc.1.0.view", @"/Views/Offer/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offer/index.cshtml", typeof(AspNetCore.Views_Offer_index))]
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
#line 1 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
using Newtonsoft.Json.Serialization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6b93cd14a7b6fb28d824f1f82e66085d1e5e69", @"/Views/Offer/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Offer_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
  
    Layout = null;
    var serializerSettings = new JsonSerializerSettings
    {
        // 设置为驼峰命名
        ContractResolver = new CamelCasePropertyNamesContractResolver()
    };
    var dataStr = JsonConvert.SerializeObject(Model, Formatting.None, serializerSettings);

#line default
#line hidden
            BeginContext(361, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(398, 484, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b16a80819ff453986407ca32f0b1d20", async() => {
                BeginContext(404, 471, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>建站报价 - 格莱软件</title>
    <link rel=""stylesheet"" href=""css/common.css"">
    <link rel=""stylesheet"" href=""css/public.css"">
    <!-- <link rel=""stylesheet"" href=""css/offer.css""> -->
    <link href=""/layui/css/layui.css"" rel=""stylesheet"" />
    <link href=""/css/cooper.css"" rel=""stylesheet"" />
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
            BeginContext(882, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(886, 22063, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae00d653fb34033a9b31bb7ace377c0", async() => {
                BeginContext(892, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(895, 23, false);
#line 29 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
Write(Html.Partial("_Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(918, 93, true);
                WriteLiteral("\r\n<!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1011, "\"", 1045, 1);
#line 32 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 1018, Url.Action("Index","Home"), 1018, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1046, 280, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1326, "\"", 1360, 1);
#line 39 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 1333, Url.Action("Index","Home"), 1333, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1361, 288, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1649, "\"", 1693, 1);
#line 45 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 1656, Url.Action("Classic","WebSiteBuild"), 1656, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1694, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1846, "\"", 1892, 1);
#line 48 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 1853, Url.Action("Marketing","WebSiteBuild"), 1853, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1893, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2045, "\"", 2094, 1);
#line 51 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 2052, Url.Action("ResponseType","WebSiteBuild"), 2052, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2095, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2247, "\"", 2290, 1);
#line 54 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 2254, Url.Action("DirSir","WebSiteBuild"), 2254, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2291, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2443, "\"", 2485, 1);
#line 57 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 2450, Url.Action("Dress","WebSiteBuild"), 2450, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2486, 216, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item cur\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2702, "\"", 2737, 1);
#line 62 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 2709, Url.Action("Index","Offer"), 2709, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2738, 124, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2862, "\"", 2896, 1);
#line 65 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 2869, Url.Action("Index","Case"), 2869, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2897, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3021, "\"", 3058, 1);
#line 68 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 3028, Url.Action("Index","NetWork"), 3028, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3059, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3183, "\"", 3218, 1);
#line 71 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
WriteAttributeValue("", 3190, Url.Action("Index","About"), 3190, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3219, 1040, true);
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
    <section class=""offer-main"">
        <!-- banner start -->
        <section class=""main-banner"">
            <div class=""img-box"">
                <img src=""/images/offer/offer-banner.png"" alt="""">
            </div>
            <div class=""banner-text public-center"">
                <p class=""text-title"">想建网站不知道价格？</p>
                <p class=""text-p"">中企免费报价让您不再吃亏！</p>
            </div>
        </section>
        <!-- banner end -->
        <!-- 免费报价 start -->
        <section class=""main-body"">
            <h3 class=""body-title"">中企动力为您提供免费报价</h");
                WriteLiteral("3>\r\n            ");
                EndContext();
                BeginContext(4259, 16444, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d931fb6b0a5436abc6f1b813c8649b6", async() => {
                    BeginContext(4288, 16408, true);
                    WriteLiteral(@"
                <dl class=""form-dl public-center"">
                    <dt class=""form-dt"">1 . 选择产品类型</dt>
                    <dd class=""form-dd"">
                        <ul class=""type-group"">
                            <li class=""type-item cur"">
                                <div class=""img-box"">
                                    <img src=""/images/public/items-website-1.png"">
                                    <img class=""img-cur"" src=""/images/public/items-website-1-cur.png"">
                                </div>
                                <p class=""item-title"">经典型网站</p>
                                <p class=""item-p"">品牌展示</p>
                                <p class=""item-p"">提升公司和产品形象</p>
                                <p class=""item-p"">个性化定制视觉设计</p>
                                <p class=""item-p"">HTML5酷炫效果</p>
                                <p class=""item-p"">与访问者无缝沟通</p>
                                <p class=""item-p"">PC、手机多端覆盖</p>
                            </li>
                    WriteLiteral(@"
                            <li class=""type-item"">
                                <div class=""img-box"">
                                    <img src=""/images/public/items-website-2.png"">
                                    <img class=""img-cur"" src=""/images/public/items-website-2-cur.png"">
                                </div>
                                <p class=""item-title"">营销型网站</p>
                                <p class=""item-p"">营销推广</p>
                                <p class=""item-p"">渠道拓展、迅速覆盖全国</p>
                                <p class=""item-p"">多种高性价比营销推广功能</p>
                                <p class=""item-p"">可视化管理后</p>
                                <p class=""item-p"">可跟踪推广效果</p>
                            </li>
                            <li class=""type-item"">
                                <div class=""img-box"">
                                    <img src=""/images/public/items-website-4.png"">
                                    <img class=""img-cur"" src=""/images/public/");
                    WriteLiteral(@"items-website-4-cur.png"">
                                </div>
                                <p class=""item-title"">电商型网站</p>
                                <p class=""item-p"">您自己的电商平台</p>
                                <p class=""item-p"">打通线上线下流程</p>
                                <p class=""item-p"">支持兑换券和礼品</p>
                                <p class=""item-p"">会员精细化运营</p>
                            </li>
                            <li class=""type-item"">
                                <div class=""img-box"">
                                    <img src=""/images/public/items-website-5.png"">
                                    <img class=""img-cur"" src=""/images/public/items-website-5-cur.png"">
                                </div>
                                <p class=""item-title"">外贸型网站</p>
                                <p class=""item-p"">多语种，一语一设计</p>
                                <p class=""item-p"">境外CDN加速</p>
                                <p class=""item-p"">Google友好、推广</p>
       ");
                    WriteLiteral(@"                         <p class=""item-p"">国际社交平台分享</p>
                                <p class=""item-p"">在线商机收集功能</p>
                            </li>
                        </ul>
                    </dd>
                    <dt class=""form-dt"">2 . 选择功能</dt>
                    <dd class=""form-dd"">
                        <ul class=""fn-group"">
                            <li class=""fn-item"">
                                <p class=""item-title"">核心功能</p>
                                <p class=""item-p"">运营监控系统</p>
                                <p class=""item-p"">商机管理</p>
                                <p class=""item-p"">后台可视化管理</p>
                                <p class=""item-p"">智能网站宣传系统</p>
                                <p class=""item-p"">搜索优化设置</p>
                                <p class=""item-p"">流量统计分析</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">基础功能</p>
                              ");
                    WriteLiteral(@"  <p class=""item-p"">内容管理</p>
                                <p class=""item-p"">商品管理</p>
                                <p class=""item-p"">资讯管理</p>
                                <p class=""item-p"">留言管理</p>
                                <p class=""item-p"">图片管理</p>
                                <p class=""item-p"">海外访问加速</p>
                                <p class=""item-p"">短信邮件业务提醒</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">销售功能</p>
                                <p class=""item-p"">广告管理</p>
                                <p class=""item-p"">询价管理</p>
                                <p class=""item-p"">订购管理</p>
                                <p class=""item-p"">在线支付中心</p>
                                <p class=""item-p"">文件下载系统</p>
                                <p class=""item-p"">企业邮箱</p>
                                <p class=""item-p"">可信网站验证</p>
                            </li>
                  ");
                    WriteLiteral(@"          <li class=""fn-item"">
                                <p class=""item-title"">互动功能</p>
                                <p class=""item-p"">招聘管理</p>
                                <p class=""item-p"">智能地图系统</p>
                                <p class=""item-p"">友情链接</p>
                                <p class=""item-p"">网上调查</p>
                                <p class=""item-p"">在线客服系统</p>
                                <p class=""item-p"">会员管理系统</p>
                                <p class=""item-p"">二维码营销</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">400电话</p>
                                <p class=""item-p"">普通号码</p>
                                <p class=""item-p"">星级号码</p>
                                <p class=""item-p"">特价靓号</p>
                                <p class=""item-p"">靓号</p>
                                <p class=""item-p"">IVR功能</p>
                            </li>
                 ");
                    WriteLiteral(@"           <li class=""fn-item"">
                                <p class=""item-title"">视觉设计</p>
                                <p class=""item-p"">形象首页(官网+客户端)</p>
                                <p class=""item-p"">内页风格</p>
                                <p class=""item-p"">内容页面</p>
                                <p class=""item-p"">广告图片(官网+客户端)</p>
                                <p class=""item-p"">Flash动画</p>
                                <p class=""item-p"">视频演示</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">其他服务</p>
                                <p class=""item-p"">标准录入(官网+客户端)</p>
                                <p class=""item-p"">排版录入(官网+客户端)</p>
                                <p class=""item-p"">短信（中文）</p>
                                <p class=""item-p"">站点卫士</p>
                                <p class=""item-p"">翻译</p>
                            </li>
                        </ul>
                 ");
                    WriteLiteral(@"       <ul class=""fn-group"" style=""display: none"">
                            <li class=""fn-item"">
                                <p class=""item-title"">核心功能</p>
                                <p class=""item-p"">运营监控系统</p>
                                <p class=""item-p"">商机管理</p>
                                <p class=""item-p"">后台可视化管理</p>
                                <p class=""item-p"">智能网站宣传系统</p>
                                <p class=""item-p"">搜索优化设置</p>
                                <p class=""item-p"">流量统计分析</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">销售功能</p>
                                <p class=""item-p"">广告管理</p>
                                <p class=""item-p"">询价管理</p>
                                <p class=""item-p"">订购管理</p>
                                <p class=""item-p"">在线支付中心</p>
                                <p class=""item-p"">文件下载系统</p>
                                ");
                    WriteLiteral(@"<p class=""item-p"">企业邮箱</p>
                                <p class=""item-p"">可信网站验证</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">互动功能</p>
                                <p class=""item-p"">招聘管理</p>
                                <p class=""item-p"">智能地图系统</p>
                                <p class=""item-p"">友情链接</p>
                                <p class=""item-p"">网上调查</p>
                                <p class=""item-p"">在线客服系统</p>
                                <p class=""item-p"">会员管理系统</p>
                                <p class=""item-p"">二维码营销</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">400电话</p>
                                <p class=""item-p"">普通号码</p>
                                <p class=""item-p"">星级号码</p>
                                <p class=""item-p"">特价靓号</p>
                            ");
                    WriteLiteral(@"    <p class=""item-p"">靓号</p>
                                <p class=""item-p"">IVR功能</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">视觉设计</p>
                                <p class=""item-p"">形象首页(官网+客户端)</p>
                                <p class=""item-p"">内页风格</p>
                                <p class=""item-p"">内容页面</p>
                                <p class=""item-p"">广告图片(官网+客户端)</p>
                                <p class=""item-p"">Flash动画</p>
                                <p class=""item-p"">视频演示</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">其他服务</p>
                                <p class=""item-p"">标准录入(官网+客户端)</p>
                                <p class=""item-p"">排版录入(官网+客户端)</p>
                                <p class=""item-p"">短信（中文）</p>
                                <p class=""item-p"">站点卫士</p>");
                    WriteLiteral(@"
                                <p class=""item-p"">翻译</p>
                            </li>
                        </ul>
                        <ul class=""fn-group"" style=""display: none"">
                            <li class=""fn-item"">
                                <p class=""item-title"">核心功能</p>
                                <p class=""item-p"">运营监控系统</p>
                                <p class=""item-p"">商机管理</p>
                                <p class=""item-p"">后台可视化管理</p>
                                <p class=""item-p"">智能网站宣传系统</p>
                                <p class=""item-p"">搜索优化设置</p>
                                <p class=""item-p"">流量统计分析</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">基础功能</p>
                                <p class=""item-p"">内容管理</p>
                                <p class=""item-p"">商品管理</p>
                                <p class=""item-p"">资讯管理</p>
             ");
                    WriteLiteral(@"                   <p class=""item-p"">留言管理</p>
                                <p class=""item-p"">图片管理</p>
                                <p class=""item-p"">海外访问加速</p>
                                <p class=""item-p"">短信邮件业务提醒</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">销售功能</p>
                                <p class=""item-p"">广告管理</p>
                                <p class=""item-p"">询价管理</p>
                                <p class=""item-p"">订购管理</p>
                                <p class=""item-p"">在线支付中心</p>
                                <p class=""item-p"">文件下载系统</p>
                                <p class=""item-p"">企业邮箱</p>
                                <p class=""item-p"">可信网站验证</p>
                            </li>
                        </ul>
                        <ul class=""fn-group"" style=""display: none"">
                            <li class=""fn-item"">
                               ");
                    WriteLiteral(@" <p class=""item-title"">核心功能</p>
                                <p class=""item-p"">运营监控系统</p>
                                <p class=""item-p"">商机管理</p>
                                <p class=""item-p"">后台可视化管理</p>
                                <p class=""item-p"">智能网站宣传系统</p>
                                <p class=""item-p"">搜索优化设置</p>
                                <p class=""item-p"">流量统计分析</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">基础功能</p>
                                <p class=""item-p"">内容管理</p>
                                <p class=""item-p"">商品管理</p>
                                <p class=""item-p"">资讯管理</p>
                                <p class=""item-p"">留言管理</p>
                                <p class=""item-p"">图片管理</p>
                                <p class=""item-p"">海外访问加速</p>
                                <p class=""item-p"">短信邮件业务提醒</p>
                            </li>
        ");
                    WriteLiteral(@"                    <li class=""fn-item"">
                                <p class=""item-title"">销售功能</p>
                                <p class=""item-p"">广告管理</p>
                                <p class=""item-p"">询价管理</p>
                                <p class=""item-p"">订购管理</p>
                                <p class=""item-p"">在线支付中心</p>
                                <p class=""item-p"">文件下载系统</p>
                                <p class=""item-p"">企业邮箱</p>
                                <p class=""item-p"">可信网站验证</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">互动功能</p>
                                <p class=""item-p"">招聘管理</p>
                                <p class=""item-p"">智能地图系统</p>
                                <p class=""item-p"">友情链接</p>
                                <p class=""item-p"">网上调查</p>
                                <p class=""item-p"">在线客服系统</p>
                                <p clas");
                    WriteLiteral(@"s=""item-p"">会员管理系统</p>
                                <p class=""item-p"">二维码营销</p>
                            </li>
                            <li class=""fn-item"">
                                <p class=""item-title"">400电话</p>
                                <p class=""item-p"">普通号码</p>
                                <p class=""item-p"">星级号码</p>
                                <p class=""item-p"">特价靓号</p>
                                <p class=""item-p"">靓号</p>
                                <p class=""item-p"">IVR功能</p>
                            </li>
                        </ul>
                    </dd>
                    <dt class=""form-dt"">3 . 填写信息</dt>
                    <dd class=""form-dd"">
                        <ul class=""inp-group"">
                            <li class=""inp-item"">
                                <label>公司</label>
                                <input type=""text"" name=""company"" value="""" />
                            </li>
                            <li class");
                    WriteLiteral(@"=""inp-item"">
                                <label>姓名</label>
                                <input type=""text"" name=""truename"" value="""" />
                            </li>
                            <li class=""inp-item"">
                                <label>手机号</label>
                                <input type=""text"" value="""" name=""mobile"" />
                            </li>
                            <li class=""inp-item"">
                                <label>验证码</label>
                                <input type=""text"" id=""verify"" name=""verify"" class=""verify-inp"">
                                <a class=""verify-link"" href=""javascript:void(0);"">
                                    <img src=""/images/public/yzm_null.jpg"">
                                </a>
                            </li>
                        </ul>
                    </dd>
                </dl>
                <div class=""form-bottom"">
                    <button type=""button"">给我报价</button>
            ");
                    WriteLiteral("    </div>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(20703, 69, true);
                WriteLiteral("\r\n        </section>\r\n        <!-- 免费报价 end -->\r\n    </section>\r\n    ");
                EndContext();
                BeginContext(20773, 21, false);
#line 394 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
Write(Html.Partial("_Help"));

#line default
#line hidden
                EndContext();
                BeginContext(20794, 54, true);
                WriteLiteral("\r\n    <!-- 主体内容 end -->\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(20849, 23, false);
#line 397 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(20872, 770, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

<script src=""assets/jquery1.11.2.js""></script>
<script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""js/public.js""></script>
<script>
    $('.type-group .type-item').click(function () {
        var index = $(this).index();
        $(this).addClass('cur').siblings('.type-item').removeClass('cur');
        $('.fn-group').eq(index).fadeIn('fast').siblings().hide();
        $('.fn-group .fn-item').removeClass('cur');
    })
    $('.fn-group .fn-item').click(function () {
        $(this).toggleClass('cur');
    })
</script>
<script src=""https://cdn.bootcss.com/vue/2.5.18-beta.0/vue.min.js""></script>
<script src=""/layui/layui.js""></script>
<script>
    var data = JSON.parse('");
                EndContext();
                BeginContext(21643, 17, false);
#line 417 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
                      Write(Html.Raw(dataStr));

#line default
#line hidden
                EndContext();
                BeginContext(21660, 900, true);
                WriteLiteral(@"');
    layui.use(['form','jquery','layer'], function () {
        var form = layui.form;
        var $ = layui.$;
        var layer = layui.layer;

        $(""#cooper"").on(""click"", function(data) {
            $(""#app"").css(""display"", ""block"");
            $(""#app"").css(""animation"", ""cooperation-animation 1.2s"");
        });

        var app = new Vue({
            el: '#app',
            data: {
                titles: data
            },
            mounted: function() {
                form.render();
            }
        });

        form.on(""submit(commit)"", function (data) {
            var details = $("":checked"");
            var detail = """";
            for (var i = 0; i < details.length; i++) {
                detail += details[i].value + "" | "";
            }
            data.field.detail = detail;
            console.log(data);
            $.post('");
                EndContext();
                BeginContext(22561, 32, false);
#line 446 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Offer\index.cshtml"
               Write(Url.Action("AddCooper","Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(22593, 349, true);
                WriteLiteral(@"', data.field, function(data,status) {
                if (data.data == 1) {
                    layer.msg(""提交成功！请等待我们联系您！"");
                    $('#app').css('display', 'none');
                } else {
                    layer.msg(""提交失败！"");
                }
            });

            return false;
        });
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
            BeginContext(22949, 11, true);
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
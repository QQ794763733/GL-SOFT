#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00803adff848452cd0ab40f4818cb452ce10d6f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_micro), @"mvc.1.0.view", @"/Views/Mobile/micro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mobile/micro.cshtml", typeof(AspNetCore.Views_Mobile_micro))]
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
#line 1 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
using Newtonsoft.Json.Serialization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00803adff848452cd0ab40f4818cb452ce10d6f5", @"/Views/Mobile/micro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_micro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
#line 4 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
  
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
            BeginContext(398, 428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05d37518fa484feb9d4f75901866cd49", async() => {
                BeginContext(404, 415, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>经典型网站 - 格莱软件</title>
    <link rel=""stylesheet"" href=""/css/common.css"">
    <link rel=""stylesheet"" href=""/css/mobile.css"">
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
            BeginContext(826, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(830, 9365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75dc3ff842504a1eba613409723711a0", async() => {
                BeginContext(836, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(839, 23, false);
#line 28 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
Write(Html.Partial("_Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(862, 93, true);
                WriteLiteral("\r\n<!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 955, "\"", 989, 1);
#line 31 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 962, Url.Action("Index","Home"), 962, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(990, 284, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item cur"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1274, "\"", 1308, 1);
#line 38 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 1281, Url.Action("Index","Home"), 1281, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1309, 288, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1597, "\"", 1641, 1);
#line 44 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 1604, Url.Action("Classic","WebSiteBuild"), 1604, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1642, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1794, "\"", 1840, 1);
#line 47 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 1801, Url.Action("Marketing","WebSiteBuild"), 1801, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1841, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1993, "\"", 2042, 1);
#line 50 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 2000, Url.Action("ResponseType","WebSiteBuild"), 2000, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2043, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2195, "\"", 2238, 1);
#line 53 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 2202, Url.Action("DirSir","WebSiteBuild"), 2202, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2239, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2391, "\"", 2433, 1);
#line 56 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 2398, Url.Action("Dress","WebSiteBuild"), 2398, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2434, 212, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2646, "\"", 2681, 1);
#line 61 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 2653, Url.Action("Index","Offer"), 2653, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2682, 124, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2806, "\"", 2840, 1);
#line 64 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 2813, Url.Action("Index","Case"), 2813, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2841, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2965, "\"", 3002, 1);
#line 67 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 2972, Url.Action("Index","NetWork"), 2972, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3003, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3127, "\"", 3162, 1);
#line 70 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
WriteAttributeValue("", 3134, Url.Action("Index","About"), 3134, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3163, 5287, true);
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
    <section class=""mobile-wyx"">
        <!-- banner广告 start -->
        <section class=""p-banner"">
            <div class=""banner-con"">
                <h3 class=""banner-tit"">让公众号活起来</h3>
                <p class=""banner-desc"">展示、互动、营销 一个都不能少</p>
                <div class=""banner-btn"">
                    <a href="""" target=""_blank"">在线咨询</a>
                </div>
            </div>
        </section>
        <!-- banner广告 end -->
        <section class=""items"">
            <ul class=""block-1 public-center"">
                <li class=""item"">
       ");
                WriteLiteral(@"             <h4 class=""small-title"">展示</h4>
                    <ul class=""list"">
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                    </ul>
                </li>
                <li class=""item"">
                    <h4 class=""small-title"">互动</h4>
                    <ul class=""list"">
  ");
                WriteLiteral(@"                      <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                    </ul>
                </li>
                <li class=""item"">
                    <h4 class=""small-title"">营销</h4>
                    <ul class=""list"">
                        <li class=""sub-item"">
                            <div class=""su");
                WriteLiteral(@"b-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                        <li class=""sub-item"">
                            <div class=""sub-icon""></div>
                            <p class=""sub-p"">微官网</p>
                        </li>
                    </ul>
                </li>
            </ul>
        </section>
        <section class=""items bgimg"">
            <div class=""block-2 public-center"">
                <h4 class=""items-title"">微信公众号类型</h4>
                <ul class=""list"">
                    <li class=""item"">
                        <div class=""item-icon""><");
                WriteLiteral(@"/div>
                        <div class=""item-tit"">订阅号</div>
                        <p class=""item-p"">适用于新闻出版业</p>
                        <p class=""item-p"">每天1次群发</p>
                    </li>
                    <li class=""item"">
                        <div class=""item-icon""></div>
                        <div class=""item-tit"">服务号</div>
                        <p class=""item-p"">适用于任何企业</p>
                        <p class=""item-p"">可以无限扩充功能</p>
                    </li>
                    <li class=""item"">
                        <div class=""item-icon""></div>
                        <div class=""item-tit"">企业号</div>
                        <p class=""item-p"">适用于大型企业，相当</p>
                        <p class=""item-p"">于多个服务号集成</p>
                    </li>
                </ul>
            </div>
        </section>
        <section class=""items"">
            <div class=""block-3"">
                <h4 class=""items-title"">微信公众号类型</h4>
                <img src=""/images/mobile/wyx/weiyingxiao-");
                WriteLiteral("show-3-1.png\" alt=\"img\">\r\n            </div>\r\n        </section>\r\n    </section>\r\n    <!-- 主体内容 end -->\r\n    <!-- 公共 - 更多服务 start -->\r\n    <!-- 公共 - 更多服务 end -->\r\n    ");
                EndContext();
                BeginContext(8451, 21, false);
#line 200 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
Write(Html.Partial("_Help"));

#line default
#line hidden
                EndContext();
                BeginContext(8472, 31, true);
                WriteLiteral("\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(8504, 23, false);
#line 202 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(8527, 361, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

<script src=""/assets/jquery1.11.2.js""></script>
<script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""/js/public.js""></script>
<script src=""https://cdn.bootcss.com/vue/2.5.18-beta.0/vue.min.js""></script>
<script src=""/layui/layui.js""></script>
<script>
    var data = JSON.parse('");
                EndContext();
                BeginContext(8889, 17, false);
#line 211 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
                      Write(Html.Raw(dataStr));

#line default
#line hidden
                EndContext();
                BeginContext(8906, 900, true);
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
                BeginContext(9807, 32, false);
#line 240 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\micro.cshtml"
               Write(Url.Action("AddCooper","Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(9839, 349, true);
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
            BeginContext(10195, 11, true);
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
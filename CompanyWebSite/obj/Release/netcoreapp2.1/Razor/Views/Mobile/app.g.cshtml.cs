#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b0291936496173e62b20407ccec63c1fee4aa7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_app), @"mvc.1.0.view", @"/Views/Mobile/app.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mobile/app.cshtml", typeof(AspNetCore.Views_Mobile_app))]
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
#line 1 "F:\Project\visual studio\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite;

#line default
#line hidden
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite.Models;

#line default
#line hidden
#line 1 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
using Newtonsoft.Json.Serialization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b0291936496173e62b20407ccec63c1fee4aa7a", @"/Views/Mobile/app.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_app : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
#line 4 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
  
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
            BeginContext(398, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb3a1f804544503bdd88fadca4d8e09", async() => {
                BeginContext(404, 456, true);
                WriteLiteral(@"
    <meta name=""keywords"" content=""xiaoyu"" /><meta charset=""UTF-8"">
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
            BeginContext(867, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(871, 12230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec3aa23bdabc4025a65bd7159a6eb336", async() => {
                BeginContext(877, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(880, 23, false);
#line 28 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
Write(Html.Partial("_Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(903, 93, true);
                WriteLiteral("\r\n<!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 996, "\"", 1030, 1);
#line 31 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 1003, Url.Action("Index","Home"), 1003, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1031, 294, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""" id=""logo"">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item cur"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1325, "\"", 1359, 1);
#line 38 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 1332, Url.Action("Index","Home"), 1332, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1360, 288, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1648, "\"", 1692, 1);
#line 44 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 1655, Url.Action("Classic","WebSiteBuild"), 1655, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1693, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1845, "\"", 1891, 1);
#line 47 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 1852, Url.Action("Marketing","WebSiteBuild"), 1852, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1892, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2044, "\"", 2093, 1);
#line 50 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 2051, Url.Action("ResponseType","WebSiteBuild"), 2051, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2094, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2246, "\"", 2289, 1);
#line 53 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 2253, Url.Action("DirSir","WebSiteBuild"), 2253, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2290, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2442, "\"", 2484, 1);
#line 56 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 2449, Url.Action("Dress","WebSiteBuild"), 2449, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2485, 212, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2697, "\"", 2732, 1);
#line 61 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 2704, Url.Action("Index","Offer"), 2704, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2733, 124, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2857, "\"", 2891, 1);
#line 64 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 2864, Url.Action("Index","Case"), 2864, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2892, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3016, "\"", 3053, 1);
#line 67 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 3023, Url.Action("Index","NetWork"), 3023, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3054, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3178, "\"", 3213, 1);
#line 70 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
WriteAttributeValue("", 3185, Url.Action("Index","About"), 3185, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3214, 8139, true);
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
    <section class=""mobile-app"">
        <!-- banner广告 start -->
        <section class=""p-banner"">
            <div class=""banner-con"">
                <h3 class=""banner-tit"">移动端产品锐不可当</h3>
                <p class=""banner-desc"">拥有移动端应用是企业发展必行之路，APP、微信公众号、小程序等应用专属功能专属定制</p>
                <div class=""banner-btn"">
                    <a href="""" target=""_blank"">在线咨询</a>
                </div>
            </div>
        </section>
        <!-- banner广告 end -->
        <section class=""items"">
            <div class=""block-1"">
                <h3 class=""");
                WriteLiteral(@"items-title"">移动端应用定制服务</h3>
                <ul class=""list"">
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-1.png"">
                        <p class=""item-p"">手机App</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-2.png"">
                        <p class=""item-p"">微信公众号</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-3.png"">
                        <p class=""item-p"">微信小程序</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-4.png"">
                        <p class=""item-p"">移动端网站</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-");
                WriteLiteral(@"img"" src=""/images/mobile/app/shoujiyingyong-show-1-5.png"">
                        <p class=""item-p"">IOS</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-6.png"">
                        <p class=""item-p"">Android</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-7.png"">
                        <p class=""item-p"">Windows</p>
                    </li>
                    <li class=""item"">
                        <img class=""item-img"" src=""/images/mobile/app/shoujiyingyong-show-1-8.png"">
                        <p class=""item-p"">Symbian</p>
                    </li>
                </ul>
            </div>
        </section>
        <section class=""items"">
            <div class=""block-2"">
                <h3 class=""items-title"">我们的优势</h3>
                <div class=""img-box"">");
                WriteLiteral(@"
                    <img src=""http://s.300.cn/v2.0/home/images/special/shoujiyingyong/shoujiyingyong-show-2.png"" alt=""img"">
                </div>
            </div>
        </section>


    </section>
    <!-- 主体内容 end -->

    <section class=""main-steps"">
        <div class=""steps-wrap public-center"">
            <div class=""steps-title"">8大标准环节 确保品质服务</div>
            <ul class=""steps-list"">
                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-officer.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">商务代表</p>
                    <p class=""item-p"">售前咨询</p>
                    <p class=""item-p"">确认需求</p>
                    <p class=""item-p"">签订合同</p>
                    <p class=""item-p"">联络沟通</p>
                </li>
                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-des");
                WriteLiteral(@"igner.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">视觉设计师</p>
                    <p class=""item-p"">和您沟通细节</p>
                    <p class=""item-p"">向您收集资料</p>
                    <p class=""item-p"">提交设计样稿</p>
                    <p class=""item-p"">约5个工作日</p>
                </li>
                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-manager.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">设计经理</p>
                    <p class=""item-p"">验收设计稿</p>
                </li>


                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-front.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">前端工程师</p>
                    <p class=""item-p"">制作页面</p>
                    <p class=""item-p"">开发功能</p>
                    <p class");
                WriteLiteral(@"=""item-p"">实现效果</p>
                    <p class=""item-p"">10-15个工作日</p>
                </li>

                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-engineer.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">质检工程师</p>
                    <div class=""item-group"">
                        <div class=""item-box"">
                            <p class=""item-p"">客户需求核对</p>
                            <p class=""item-p"">功能测试</p>
                            <p class=""item-p"">展示效果验证</p>
                            <p class=""item-p"">网站性能测试</p>
                        </div>
                        <div class=""item-box"">
                            <p class=""item-p"">合规性检查</p>
                            <p class=""item-p"">技术规范检查</p>
                            <p class=""item-p"">第三方业务验证</p>
                            <p class=""item-p"">3-5个工作日</p>
                        </div>
      ");
                WriteLiteral(@"              </div>
                </li>

                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-officer.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">商务代表</p>
                    <p class=""item-p"">请您验收</p>
                    <p class=""item-p"">转运维部门</p>
                    <p class=""item-p"">转客服部门</p>
                </li>

                <li class=""steps-item"">
                    <div class=""img-box"">
                        <img src=""/images/index/items-steps-engineer.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">运维工程师</p>
                    <p class=""item-p"">网站上线</p>
                    <p class=""item-p"">网络、服务器保障</p>
                    <p class=""item-p"">平台升级、故障排除</p>
                    <p class=""item-p"">病毒、黑客防范</p>
                </li>
                <li class=""steps-item"">
                    <div class=""img-bo");
                WriteLiteral(@"x"">
                        <img src=""/images/index/items-steps-cc.png"" alt=""img"">
                    </div>
                    <p class=""item-title"">客服专员</p>
                    <p class=""item-p"">解答疑问</p>
                    <p class=""item-p"">使用指导</p>
                    <p class=""item-p"">友情提示</p>
                    <p class=""item-p"">协助内容维护</p>
                </li>

                <li class=""stpes-line"">
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                    <div class=""line-step""></div>
                </li>
            </ul>
        </div>
    </section>

    <!-- 公共 - 更多服务 start -->
    <!-- 公共 - 更多服务 end -->
    ");
                EndContext();
                BeginContext(11354, 21, false);
#line 262 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
Write(Html.Partial("_Help"));

#line default
#line hidden
                EndContext();
                BeginContext(11375, 31, true);
                WriteLiteral("\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(11407, 23, false);
#line 264 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(11430, 364, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

<script src=""/assets/jquery1.11.2.js""></script>
<script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""/js/public.js""></script>
<script src=""https://cdn.bootcss.com/vue/2.5.18-beta.0/vue.min.js""></script>
<script src=""/layui/layui.js""></script>
<script>
    var dataDto = JSON.parse('");
                EndContext();
                BeginContext(11795, 17, false);
#line 273 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
                         Write(Html.Raw(dataStr));

#line default
#line hidden
                EndContext();
                BeginContext(11812, 900, true);
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
                BeginContext(12713, 32, false);
#line 302 "F:\Project\visual studio\Company\CompanyWebSite\Views\Mobile\app.cshtml"
               Write(Url.Action("AddCooper","Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(12745, 349, true);
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
            BeginContext(13101, 11, true);
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
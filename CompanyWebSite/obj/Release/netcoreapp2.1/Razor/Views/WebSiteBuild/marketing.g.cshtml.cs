#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebceb8059ab194a0bf6a42f3a178314a0e2de116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebSiteBuild_marketing), @"mvc.1.0.view", @"/Views/WebSiteBuild/marketing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WebSiteBuild/marketing.cshtml", typeof(AspNetCore.Views_WebSiteBuild_marketing))]
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
#line 1 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
using Newtonsoft.Json.Serialization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebceb8059ab194a0bf6a42f3a178314a0e2de116", @"/Views/WebSiteBuild/marketing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_WebSiteBuild_marketing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
  
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
            BeginContext(398, 471, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de06efe03974d13a80c05a4ce7ead32", async() => {
                BeginContext(404, 458, true);
                WriteLiteral(@"
    <meta name=""keywords"" content=""xiaoyu"" /><meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>营销型网站 - 格莱软件</title>
    <link rel=""stylesheet"" href=""/css/common.css"">
    <link rel=""stylesheet"" href=""/css/siteType.css"">
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
            BeginContext(869, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(873, 21532, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0571f77f5714d5b8e06a555d267a4c7", async() => {
                BeginContext(879, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(882, 23, false);
#line 28 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
Write(Html.Partial("_Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(905, 93, true);
                WriteLiteral("\r\n<!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 998, "\"", 1032, 1);
#line 31 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 1005, Url.Action("Index","Home"), 1005, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1033, 290, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""" id=""logo"">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1323, "\"", 1357, 1);
#line 38 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 1330, Url.Action("Index","Home"), 1330, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1358, 292, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item cur"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1650, "\"", 1694, 1);
#line 44 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 1657, Url.Action("Classic","WebSiteBuild"), 1657, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1695, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1847, "\"", 1893, 1);
#line 47 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 1854, Url.Action("Marketing","WebSiteBuild"), 1854, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1894, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2046, "\"", 2095, 1);
#line 50 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 2053, Url.Action("ResponseType","WebSiteBuild"), 2053, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2096, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2248, "\"", 2291, 1);
#line 53 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 2255, Url.Action("DirSir","WebSiteBuild"), 2255, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2292, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2444, "\"", 2486, 1);
#line 56 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 2451, Url.Action("Dress","WebSiteBuild"), 2451, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2487, 212, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2699, "\"", 2734, 1);
#line 61 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 2706, Url.Action("Index","Offer"), 2706, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2735, 124, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2859, "\"", 2893, 1);
#line 64 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 2866, Url.Action("Index","Case"), 2866, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2894, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3018, "\"", 3055, 1);
#line 67 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 3025, Url.Action("Index","NetWork"), 3025, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3056, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3180, "\"", 3215, 1);
#line 70 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
WriteAttributeValue("", 3187, Url.Action("Index","About"), 3187, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3216, 7307, true);
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
    <section class=""yingxiao-main"">
        <!-- banner广告 start -->
        <div class=""public-banner"">
            <div class=""img-box"">
                <img src=""/images/siteType/yingxiao/yingxiao-banner.png"" alt="""">
            </div>
            <div class=""banner-contetn"">
                <div class=""banner-wrap"">
                    <h3 class=""banner-title"">营销型网站</h3>
                    <p class=""banner-desc"">懂市场，才能更精准营销</p>
                    <p class=""banner-small"">企业建站终极解决方案，120+企业建站的最终选择</p>
                    <div class=""banner-btn"">
     ");
                WriteLiteral(@"                   <a href="""" target=""_blank"">在线咨询</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- banner广告 end -->
        <!-- 基础功能 start -->
        <div class=""layer"">
            <h3 class=""public-title"">基础功能</h3>
            <ul class=""jc-list public-center"">
                <li class=""jc-item"">
                    <div class=""item-icon""></div>
                    <div class=""item-title"">精准市场定位</div>
                    <p class=""item-p"">通过对企业的品牌、产品、目标人群</p>
                    <p class=""item-p"">关键词的定位，占领网络营销市场</p>
                    <div class=""jc-hover"">
                        <div class=""hover-title"">国内搜索引擎全优化</div>
                        <ul class=""hover-list"">
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">百度</p>
                            </li>
                            <li class=""hover-item"">
      ");
                WriteLiteral(@"                          <div class=""hover-icon""></div>
                                <p class=""hover-p"">360</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">搜狗</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">必应</p>
                            </li>
                        </ul>
                    </div>

                </li>
                <li class=""jc-item"">
                    <div class=""item-icon""></div>
                    <div class=""item-title"">友好的用户界面</div>
                    <p class=""item-p"">营销型网站建设注重网站展示的视觉感受，</p>
                    <p class=""item-p"">更好的用户体验才能吸引眼球。</p>
                    <div class=""jc-hover"">
                        <div class=""hover-title"">技术设");
                WriteLiteral(@"计相结合</div>
                        <ul class=""hover-list"">
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">HTML 5</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">CSS 3</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">JavaScript</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">动画、视频</p>
                            </li>
                        </ul>
                    </div>
                </li>
                <li");
                WriteLiteral(@" class=""jc-item"">
                    <div class=""item-icon""> </div>
                    <div class=""item-title"">专业销营运营</div>
                    <p class=""item-p"">多种网络营销功能组建获取意向，不错过任何</p>
                    <p class=""item-p"">一次询盘。</p>

                    <div class=""jc-hover"">
                        <div class=""hover-title"">潜客根据自己喜好发起沟通</div>
                        <ul class=""hover-list"">
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">表单</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">400电话、离线宝</p>
                            </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">QQ、微信</p>
          ");
                WriteLiteral(@"                  </li>
                            <li class=""hover-item"">
                                <div class=""hover-icon""></div>
                                <p class=""hover-p"">53、商桥</p>
                            </li>
                        </ul>
                    </div>
                </li>
            </ul>
        </div>
        <!-- 基础功能 end -->
        <!-- 晋级功能 start -->
        <div class=""layer"">
            <h3 class=""public-title"">晋级功能</h3>
            <div class=""btn-group"">
                <button class=""active"" type=""button"">主动出击找客户</button>
                <button type=""button"">深挖访客再营销</button>
            </div>
            <div class=""con-wrap public-center"">
                <ul class=""content"">
                    <li class=""item"">
                        <div class=""item-tit"">微信运营</div>
                        <p class=""item-p"">微信公众号管理群发营销</p>
                        <p class=""item-p"">粉丝管理</p>
                    </li>
                    <li clas");
                WriteLiteral(@"s=""item"">
                        <div class=""item-tit"">社区分享</div>
                        <p class=""item-p"">社交网站、微博博客、论坛等 </p>
                    </li>
                </ul>
                <ul class=""content"" style=""display: none;"">
                    <li class=""item"">
                        <div class=""item-tit"">访客分析</div>
                        <p class=""item-p"">统计和分析客户访问数据，总结</p>
                        <p class=""item-p"">客户访问规律，进行差异性的网络</p>
                        <p class=""item-p"">营销</p>
                    </li>
                    <li class=""item"">
                        <div class=""item-tit"">商机管理</div>
                        <p class=""item-p"">汇集各终端意向信息集中管理，对接</p>
                        <p class=""item-p"">企业CRM系统，提升转化</p>
                    </li>
                    <li class=""item"">
                        <div class=""item-tit"">客户再营销</div>
                        <p class=""item-p"">分析会员消费信息，挖掘顾客的后续消</p>
                        <p class=""item-p""> 费力，实现客户价值最大化</p>
           ");
                WriteLiteral("         </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <!-- 晋级功能 end -->\r\n        <!-- 经典案例 start -->\r\n        ");
                EndContext();
                BeginContext(10524, 25, false);
#line 235 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
   Write(Html.Partial("_CaseShow"));

#line default
#line hidden
                EndContext();
                BeginContext(10549, 7186, true);
                WriteLiteral(@"
        <!-- 经典案例 end -->
        <!-- 覆盖各个行业 start -->
        <div class=""layer"">
            <h3 class=""public-title"">覆盖各个行业</h3>
            <ul class=""category-list public-center"">
                <li class=""ca-item"">服装/鞋靴/箱包/配饰</li>
                <li class=""ca-item"">原材料/纺织</li>
                <li class=""ca-item"">家居建材/百货/食品</li>
                <li class=""ca-item"">文化/旅游</li>
                <li class=""ca-item"">零售</li>
                <li class=""ca-item"">母婴/美妆</li>
                <li class=""ca-item"">外贸</li>
                <li class=""ca-item"">服务业/酒店</li>
                <li class=""ca-item"">工业/制造</li>
                <li class=""ca-item"">农业</li>
                <li class=""ca-item"">数码家电/运动户外</li>
                <li class=""ca-item"">餐饮</li>
            </ul>
        </div>
        <!-- 覆盖各个行业 end -->

    </section>
    <!-- 主体内容 end -->
    <!-- 公共 - 更多服务 start -->
    <section class=""public-more-service"">
        <div class=""public-head"">
            <h3 class=""head-title"">更多");
                WriteLiteral(@"服务</h3>
            <p class=""head-small"">各种扩展应用、营销工具，更有完善的管家服务</p>
        </div>
        <div class=""more-service-body"">
            <div class=""app-block public-center"">
                <h4>相关营销应用</h4>
                <ul class=""app-list"">
                    <li class=""app-item"">
                        <div class=""item-pic""></div>
                        <div class=""item-title"">营销宝</div>
                        <p class=""item-p"">集移动H5、会销、二维码推广</p>
                        <p class=""item-p"">等营销场景于一体</p>
                    </li>
                    <li class=""app-item"">
                        <div class=""item-pic""></div>
                        <div class=""item-title"">微信小程序</div>
                        <p class=""item-p"">可通过定位\应用等小程</p>
                        <p class=""item-p"">序渠道增加用户预订来源</p>
                    </li>
                    <li class=""app-item"">
                        <div class=""item-pic""></div>
                        <div class=""item-title"">H5企业秀</div>
            ");
                WriteLiteral(@"            <p class=""item-p"">用于移动端营销推广</p>
                        <p class=""item-p"">及交互活动</p>
                    </li>
                    <li class=""app-item"">
                        <div class=""item-pic""></div>
                        <div class=""item-title"">短信/邮件营销</div>
                        <p class=""item-p"">应用短信\邮件渠道即时业务</p>
                        <p class=""item-p"">提醒，转化购买意向</p>
                    </li>
                    <li class=""app-item"">
                        <div class=""item-pic""></div>
                        <div class=""item-title"">微信粉丝营销</div>
                        <p class=""item-p"">门户后台统一管理公众号，</p>
                        <p class=""item-p"">提升粉丝经济</p>
                    </li>
                </ul>
            </div>
            <div class=""entrust-block public-center"">
                <h4>
                    管家服务
                    <span style=""color:#3CA7FC;"">全</span>委托
                </h4>
                <ul class=""entrust-list"">
                    <");
                WriteLiteral(@"li class=""entrust-item"">公众号代维</li>
                    <li class=""entrust-item"">图片处理</li>
                    <li class=""entrust-item"">banner设计</li>
                    <li class=""entrust-item"">新闻录入</li>
                    <li class=""entrust-item"">代码插入</li>
                    <li class=""entrust-item"">7*24服务热线</li>
                </ul>
            </div>

            <div class=""banner-block public-banner"">
                <div class=""img-box"">
                    <img src=""/images/siteType/pay-tip-bg.png"" alt="""">
                </div>
                <div class=""banner-contetn"">
                    <div class=""banner-wrap"">
                        <p class=""banner-p1"">网站交付后，三个月网站内容免费代维护</p>
                        <p class=""banner-p2"">（限客户购买的设计套餐范围内的内容，不含网站改版）</p>
                    </div>
                </div>
            </div>

            <div class=""service-block"">
                <div class=""public-head"">
                    <h3 class=""head-title"">服务保障</h3>
                ");
                WriteLiteral(@"    <p class=""head-small"">全程专业质控，保证高质高效服务</p>
                </div>
                <ul class=""service-list public-center"">
                    <li class=""service-item"">
                        <div class=""item-title"">顾问咨询</div>
                        <div class=""item-con"">
                            <div class=""con-name"">顾问咨询</div>
                            <p class=""con-p"">上门服务</p>
                            <p class=""con-p"">客户需求采集分析</p>
                            <p class=""con-p"">提供专属门户方案</p>
                        </div>
                    </li>
                    <li class=""service-item"">
                        <div class=""item-title"">全案设计</div>
                        <div class=""item-con"">
                            <div class=""con-name"">全案设计</div>
                            <p class=""con-p"">设计需求沟通</p>
                            <p class=""con-p"">设计稿提案</p>
                            <p class=""con-p"">全案设计</p>
                        </div>
                    </li>
   ");
                WriteLiteral(@"                 <li class=""service-item"">
                        <div class=""item-title"">设计验收</div>
                        <div class=""item-con"">
                            <div class=""con-name"">设计验收</div>
                            <p class=""con-p"">客户在线确认设计效果</p>
                        </div>
                    </li>
                    <li class=""service-item"">
                        <div class=""item-title"">开发制作</div>
                        <div class=""item-con"">
                            <div class=""con-name"">开发制作</div>
                            <p class=""con-p"">制作页面</p>
                            <p class=""con-p"">开发功能</p>
                            <p class=""con-p"">实现效果</p>
                        </div>
                    </li>
                    <li class=""service-item"">
                        <div class=""item-title"">网站验收</div>
                        <div class=""item-tag"">全面测试</div>
                    </li>
                    <li class=""service-item"">
          ");
                WriteLiteral(@"              <div class=""item-title"">网站上线</div>
                        <div class=""item-tag"">
                            安全防护
                            <br> 网站加速
                        </div>
                    </li>
                    <li class=""service-item"">
                        <div class=""item-title"">管家服务</div>
                        <div class=""item-con"">
                            <div class=""con-name"">管家服务</div>
                            <p class=""con-p"">专属管家</p>
                            <p class=""con-p"">解答疑问</p>
                            <p class=""con-p"">使用指导</p>
                            <p class=""con-p"">3个月免费内容维护</p>
                        </div>
                    </li>
                </ul>
            </div>
            <div class=""form-block"">
                <div class=""form-title"">
                    填写您的需求，我们免费为您定制方案并获取
                    <span class=""small"">1000-3000元</span>优惠
                </div>
                <div class=""form-wrap"">
  ");
                WriteLiteral("                  ");
                EndContext();
                BeginContext(17735, 1436, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d13b1814ad4535b249e43024d31c08", async() => {
                    BeginContext(17758, 1406, true);
                    WriteLiteral(@"
                        <div class=""form-content"">
                            <div class=""inp-textarea"">
                                <textarea class=""remark"" name=""remark"" placeholder=""我的需求""></textarea>
                            </div>
                            <div class=""inp-group"">
                                <div class=""inp-row"">
                                    <input type=""text"" name=""company"" placeholder=""单位名称"" value="""">
                                </div>
                                <div class=""inp-row"">
                                    <input type=""text"" name=""truename"" placeholder=""联系人姓名"" value="""">
                                    <input type=""text"" name=""mobile"" placeholder=""回访电话"" value="""">
                                </div>
                                <div class=""inp-row"">
                                    <input type=""text"" name=""verify"" placeholder=""验证码"">
                                    <a href=""javascript:void(0);"">
                   ");
                    WriteLiteral(@"                     <img src=""/images/public/yzm_null.jpg"" alt="""">
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""form-btn"">
                            <button type=""button"">提交</button>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(19171, 106, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- 公共 - 更多服务 end -->\r\n");
                EndContext();
                BeginContext(19278, 21, false);
#line 427 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
Write(Html.Partial("_Help"));

#line default
#line hidden
                EndContext();
                BeginContext(19299, 31, true);
                WriteLiteral("\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(19331, 23, false);
#line 429 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(19354, 760, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

<script src=""/assets/jquery1.11.2.js""></script>
<script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""/js/public.js""></script>
    <script>
        // 晋级功能
        $(function () {
            $('.btn-group button').on('click', function () {
                var i = $(this).index();
                $('.btn-group button').removeClass('active');
                $(this).addClass('active');
                $('.content').hide();
                $('.content').eq(i).show();
            })
        });
    </script>
<script src=""https://cdn.bootcss.com/vue/2.5.18-beta.0/vue.min.js""></script>
<script src=""/layui/layui.js""></script>
<script>
    var dataDto = JSON.parse('");
                EndContext();
                BeginContext(20115, 17, false);
#line 450 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
                         Write(Html.Raw(dataStr));

#line default
#line hidden
                EndContext();
                BeginContext(20132, 1276, true);
                WriteLiteral(@"');
    //修改系统信息
    $(""#logo"").attr(""src"", dataDto.systemInfo.logoUrl); //修改Logo
    $(""#logo"").css(""width"", ""150px"");   //修改尺寸
    $(""#copyright"").text(dataDto.systemInfo.copyright); //修改版权
    $(""#record"").text(dataDto.systemInfo.record);   //修改备案
    $(""#weChatQR"").attr(""src"", dataDto.systemInfo.weChatQR);   //修改二维码
    $(""#weChatQR"").css(""width"", ""130px"");   //修改二维码尺寸
    document.title = dataDto.systemInfo.siteTitle; //修改标题
    document.getElementsByTagName(""meta"")[0].content = dataDto.systemInfo.keyWords;   //修改网站关键字

    layui.use(['form','jquery','layer'], function () {
        var form = layui.form;
        var $ = layui.$;
        var layer = layui.layer;

        $(""#cooper"").on(""click"", function(data) {
            $(""#app"").css(""display"", ""block"");
            $(""#app"").css(""animation"", ""cooperation-animation 1.2s"");
        });

        //合作意向表单渲染
        var app = new Vue({
            el: '#app',
            data: {
                titles: dataDto.cooperData
        ");
                WriteLiteral("    },\r\n            mounted: function () {\r\n                form.render();\r\n            }\r\n        });\r\n\r\n        //案例欣赏\r\n        dataDto.cases.forEach((itemData,index) => {\r\n            var item =\r\n                \'<li class=\"public-item\"><a href=\"\'+\'");
                EndContext();
                BeginContext(21409, 31, false);
#line 485 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
                                                Write(Url.Action("CaseDetail","Case"));

#line default
#line hidden
                EndContext();
                BeginContext(21440, 576, true);
                WriteLiteral(@"?id=' + itemData.id+'"" target=""_blank""><div class=""img-box""><img src=""'+itemData.cover+'"" alt=""'+itemData.name+'""></div><div class=""item-desc"">'+itemData.name+'</div></a></li>';
            $(""#list"").append(item);
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
                BeginContext(22017, 32, false);
#line 498 "F:\Project\visual studio\Company\CompanyWebSite\Views\WebSiteBuild\marketing.cshtml"
               Write(Url.Action("AddCooper","Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(22049, 349, true);
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
            BeginContext(22405, 11, true);
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

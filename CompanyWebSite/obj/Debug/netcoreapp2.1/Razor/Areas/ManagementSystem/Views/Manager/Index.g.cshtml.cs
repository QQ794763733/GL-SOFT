#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51867a3f7968dcfd186e272a2a575790ca8058e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_Manager_Index), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/Manager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/Manager/Index.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_Manager_Index))]
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
#line 1 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51867a3f7968dcfd186e272a2a575790ca8058e", @"/Areas/ManagementSystem/Views/Manager/Index.cshtml")]
    public class Areas_ManagementSystem_Views_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
  
    Layout = null;
    var name = ViewData["name"];

#line default
#line hidden
            BeginContext(110, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(135, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63610a377734095a5df7ce86536af34", async() => {
                BeginContext(141, 250, true);
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"xiaoyu\" /><meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>格莱软件后台管理</title>\r\n    <link href=\"/layui/css/layui.css\" rel=\"stylesheet\" />\r\n");
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
            BeginContext(398, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(400, 6682, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824f09b214ac44e281f440d5497fdb9c", async() => {
                BeginContext(432, 235, true);
                WriteLiteral("\r\n    <div class=\"layui-layout layui-layout-admin\">\r\n        <div class=\"layui-header\">\r\n            <div class=\"layui-logo\">格莱软件</div>\r\n            <!-- 头部区域（可配合layui已有的水平导航） -->\r\n            <ul class=\"layui-nav layui-layout-left\">\r\n");
                EndContext();
                BeginContext(1235, 295, true);
                WriteLiteral(@"            </ul>
            <ul class=""layui-nav layui-layout-right"" lay-filter=""setting"">
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">
                        <img src=""/images/public/favicon.png"" class=""layui-nav-img"">
                        ");
                EndContext();
                BeginContext(1531, 4, false);
#line 37 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                   Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(1535, 654, true);
                WriteLiteral(@"
                    </a>
                    <!--<dl class=""layui-nav-child"">
                        <dd><a href=""javascript:;"">系统设置</a></dd>
                    </dl>-->
                </li>
                <li class=""layui-nav-item""><a href=""javascript:;"" id=""logout"">安全退出</a></li>
            </ul>
        </div>

        <div class=""layui-side layui-bg-black"">
            <div class=""layui-side-scroll"">
                <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
                <ul class=""layui-nav layui-nav-tree"" lay-filter=""Left-Nav"">
                    <li class=""layui-nav-item""><a href=""javascript:;"" data-content=""/ManagementSystem/");
                EndContext();
                BeginContext(2190, 32, false);
#line 51 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                                 Write(Url.Action("Index","SystemInfo"));

#line default
#line hidden
                EndContext();
                BeginContext(2222, 299, true);
                WriteLiteral(@""" data-id=""SystemBaseTab"">系统基本设置</a></li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;"">案例管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"" data-content=""/ManagementSystem/");
                EndContext();
                BeginContext(2522, 30, false);
#line 55 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index","Industry"));

#line default
#line hidden
                EndContext();
                BeginContext(2552, 126, true);
                WriteLiteral("\" data-id=\"IndustryTab\">行业管理</a></dd>\r\n                            <dd><a href=\"javascript:;\" data-content=\"/ManagementSystem/");
                EndContext();
                BeginContext(2679, 27, false);
#line 56 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index","Color"));

#line default
#line hidden
                EndContext();
                BeginContext(2706, 123, true);
                WriteLiteral("\" data-id=\"ColorTab\">颜色管理</a></dd>\r\n                            <dd><a href=\"javascript:;\" data-content=\"/ManagementSystem/");
                EndContext();
                BeginContext(2830, 29, false);
#line 57 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index","Product"));

#line default
#line hidden
                EndContext();
                BeginContext(2859, 125, true);
                WriteLiteral("\" data-id=\"ProductTab\">产品管理</a></dd>\r\n                            <dd><a href=\"javascript:;\" data-content=\"/ManagementSystem/");
                EndContext();
                BeginContext(2985, 28, false);
#line 58 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index","Client"));

#line default
#line hidden
                EndContext();
                BeginContext(3013, 125, true);
                WriteLiteral("\" data-id=\"ClientTab\">客户端管理</a></dd>\r\n                            <dd><a href=\"javascript:;\" data-content=\"/ManagementSystem/");
                EndContext();
                BeginContext(3139, 33, false);
#line 59 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index","CaseManager"));

#line default
#line hidden
                EndContext();
                BeginContext(3172, 342, true);
                WriteLiteral(@""" data-id=""CaseTab"">案例管理</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;"">合作意向管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"" data-content=""/ManagementSystem/");
                EndContext();
                BeginContext(3515, 35, false);
#line 65 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index","CooperManager"));

#line default
#line hidden
                EndContext();
                BeginContext(3550, 125, true);
                WriteLiteral("\" data-id=\"CooperTab\">合作意向表</a></dd>\r\n                            <dd><a href=\"javascript:;\" data-content=\"/ManagementSystem/");
                EndContext();
                BeginContext(3676, 34, false);
#line 66 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index", "CooperTitle"));

#line default
#line hidden
                EndContext();
                BeginContext(3710, 128, true);
                WriteLiteral("\" data-id=\"CooperTitleTab\">标题表</a></dd>\r\n                            <dd><a href=\"javascript:;\" data-content=\"/ManagementSystem/");
                EndContext();
                BeginContext(3839, 36, false);
#line 67 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                                                                  Write(Url.Action("Index", "CooperContent"));

#line default
#line hidden
                EndContext();
                BeginContext(3875, 2836, true);
                WriteLiteral(@""" data-id=""CooperContentTab"">子选项表</a></dd>
                        </dl>
                    </li>
                    <!--<li class=""layui-nav-item"">
                            <a href=""javascript:;"">解决方案</a>
                            <dl class=""layui-nav-child"">
                                <dd><a href=""javascript:;"">列表一</a></dd>
                                <dd><a href=""javascript:;"">列表二</a></dd>
                                <dd><a href=""javascript:;"">超链接</a></dd>
                            </dl>
                        </li>
                        <li class=""layui-nav-item""><a href="""">云市场</a></li>
                        <li class=""layui-nav-item""><a href="""">发布商品</a></li>-->
                </ul>
            </div>
        </div>

        <div class=""layui-body"">
            <!-- 内容主体区域 -->
            <div class=""layui-tab layui-tab-brief"" lay-filter=""ManagementTab"" lay-allowClose=""true"">
                <ul class=""layui-tab-title"">
                    <li class=""layui-");
                WriteLiteral(@"this"" lay-id=""HomeTab"">主页</li>
                </ul>
                <div class=""layui-tab-content"">
                    <div class=""layui-tab-item layui-show"">
                        
                    </div>
                </div>
            </div>
        </div>

        <div class=""layui-footer"">
            <!-- 底部固定区域 -->
            底部
        </div>
    </div>
    <script src=""/layui/layui.js""></script>
    <script>
        //JavaScript代码区域
        layui.use('element', function () {
            var element = layui.element;
            var $ = layui.$;

            //左侧导航事件监听
            element.on('nav(Left-Nav)', function (data) {
                
                if (data.context.dataset.id != undefined) {
                    var temp = $(""[lay-id='"" + data.context.dataset.id + ""']"");
                    if (temp.length == 0) {
                        tabHeight = window.innerHeight * 0.8;
                        element.tabAdd(""ManagementTab"",
                       ");
                WriteLiteral(@"     {
                                title: data.context.innerText,
                                content: '<iframe height=""' + tabHeight +'"" width=""100%"" frameborder=""0"" scrolling=""no"" src=""'+data.context.dataset.content+'""></iframe>',
                                id: data.context.dataset.id
                            });
                        element.tabChange(""ManagementTab"", data.context.dataset.id);
                    } else {
                        element.tabChange(""ManagementTab"", data.context.dataset.id);
                    }
                }
            });

            element.on('nav(setting)', function(data) {
                switch (data.context.id) {
                    case 'logout':
                        $.post('/ManagementSystem/");
                EndContext();
                BeginContext(6712, 30, false);
#line 133 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Manager\Index.cshtml"
                                             Write(Url.Action("Logout","Manager"));

#line default
#line hidden
                EndContext();
                BeginContext(6742, 333, true);
                WriteLiteral(@"', {}, (response,status) => {
                            if (response.status == 200) {
                                window.location.href = ""login"";
                            }
                        });
                    break;
                default:
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7082, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591

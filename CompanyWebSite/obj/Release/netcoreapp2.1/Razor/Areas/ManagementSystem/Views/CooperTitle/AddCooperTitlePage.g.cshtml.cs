#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperTitle\AddCooperTitlePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f146279b72f72a9302380fda3838a9ca5ddd0fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_CooperTitle_AddCooperTitlePage), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/CooperTitle/AddCooperTitlePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/CooperTitle/AddCooperTitlePage.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_CooperTitle_AddCooperTitlePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f146279b72f72a9302380fda3838a9ca5ddd0fa6", @"/Areas/ManagementSystem/Views/CooperTitle/AddCooperTitlePage.cshtml")]
    public class Areas_ManagementSystem_Views_CooperTitle_AddCooperTitlePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
            BeginContext(15, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(42, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8182a84776403891d831dff697a301", async() => {
                BeginContext(48, 190, true);
                WriteLiteral("\r\n    <title>AddCooperTitlePage</title>\r\n    <link href=\"/layui/css/layui.css\" rel=\"stylesheet\" />\r\n    <style>\r\n        .center {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
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
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(247, 2252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e1496130a04fc29eb93a9fbda4292a", async() => {
                BeginContext(253, 2239, true);
                WriteLiteral(@"
    <!--对话框-->
    <form class=""layui-form layui-form-pane"" lay-filter=""updateCooperTitle"">
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">标题</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""name"" lay-verify=""required"" class=""layui-input"" />
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">选择框</label>
                <div class=""layui-input-inline"">
                    <input type=""radio"" name=""type"" value=""1"" title=""复选框"" checked />
                    <input type=""radio"" name=""type"" value=""2"" title=""单选框"" />
                </div>
            </div>
            <div class=""layui-form-item"">
                <div class=""layui-btn-container center"">
                    <button class=""layui-btn"" id=""cancel"" lay-filter=""cancel"" onclick=""javascript: ;"">取消</button>
                    <button class=""layui-btn"" lay-filter=""sure"" lay-submit>保存</button>
        ");
                WriteLiteral(@"        </div>
            </div>
        </div>
    </form>
    <script src=""https://cdn.bootcss.com/jquery/3.3.1/jquery.min.js""></script>
    <script src=""/layui/layui.js""></script>
    <script>
        layui.use(['form'],
            function() {
                var form = layui.form;
                var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
                $(""#cancel"").click(function () {
                    parent.layer.close(index); //执行关闭
                });
                form.on('submit(sure)', function (data) {
                    $.post(""/ManagementSystem/CooperTitle/AddCooperTitle"",
                        data.field, function (data, status) {
                            if (data.total > 0) {
                                parent.layer.close(index); //执行关闭
                                parent.layer.msg(""添加成功！"");
                                parent.layui.table.reload(""CooperTitleTable"");
                            } else {
                 ");
                WriteLiteral("               parent.layer.msg(\"添加失败！\");\r\n                            }\r\n                        });\r\n                    return false;\r\n                });\r\n            });\r\n    </script>\r\n");
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
            BeginContext(2499, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591

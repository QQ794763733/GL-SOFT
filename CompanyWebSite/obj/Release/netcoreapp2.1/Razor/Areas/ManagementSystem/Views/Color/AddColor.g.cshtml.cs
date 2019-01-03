#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Color\AddColor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e9ffc6e04cdfd0a1b739ad0a36813447241a3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_Color_AddColor), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/Color/AddColor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/Color/AddColor.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_Color_AddColor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e9ffc6e04cdfd0a1b739ad0a36813447241a3a", @"/Areas/ManagementSystem/Views/Color/AddColor.cshtml")]
    public class Areas_ManagementSystem_Views_Color_AddColor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
            BeginContext(15, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(44, 347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c66ab3a28241c08f8cd8cd5e889e11", async() => {
                BeginContext(50, 334, true);
                WriteLiteral(@"
    <title>ColorManagement</title>
    <link href=""/layui/css/layui.css"" rel=""stylesheet"" />
    <style>
        .wh {
            width: 100%;
        }

        .center {
            text-align: center;
        }

        .input-style {
            width: 80%;
            margin: 6px auto;
        }
    </style>
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
            BeginContext(391, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(393, 1740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eea7256d9a744427b9f024d35d423763", async() => {
                BeginContext(399, 1727, true);
                WriteLiteral(@"
    <!--颜色编辑对话框-->
    <div id=""ColorDialog"" class=""wh"">
        <div class=""input-style"">
            <input class=""layui-input"" placeholder=""请输入颜色名字"" id=""colorName"" />
        </div>
        <div class=""input-style"">
            <input class=""layui-input"" placeholder=""请输入颜色值"" id=""colorValue"" />
        </div>
        <div class=""layui-btn-container center input-style"">
            <button class=""layui-btn layui-btn-primary"" id=""cancel"">取消</button>
            <button class=""layui-btn"" id=""save"">保存</button>
        </div>
    </div>
    <script src=""https://cdn.bootcss.com/jquery/3.3.1/jquery.min.js""></script>
    <script>
        var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
        $(""#cancel"").click(function () {
            parent.layer.close(index); //执行关闭
        });
        $(""#save"").click(function () {
            var colorName = $(""#colorName"").val();
            var colorValue = $(""#colorValue"").val();
            if (colorName == """" || colorValue =");
                WriteLiteral(@"= """") {
                alert(""不能为空值"");
            } else {
                $.post(""/ManagementSystem/Color/AddColor"",
                    {
                        name: colorName,
                        value: colorValue
                    }, function (data, status) {
                        if (data.total > 0) {
                            parent.layer.close(index); //执行关闭
                            parent.layer.msg(""添加成功！"");
                            parent.layui.table.reload(""ColorTable"");
                        } else {
                            parent.layer.msg(""添加失败！"");
                        }
                    });
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
            BeginContext(2133, 9, true);
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

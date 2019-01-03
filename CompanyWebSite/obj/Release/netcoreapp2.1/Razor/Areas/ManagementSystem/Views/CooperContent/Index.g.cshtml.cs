#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperContent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c425a5c496c66d41a88dd6892dac6d70a19e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_CooperContent_Index), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/CooperContent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/CooperContent/Index.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_CooperContent_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c425a5c496c66d41a88dd6892dac6d70a19e5c", @"/Areas/ManagementSystem/Views/CooperContent/Index.cshtml")]
    public class Areas_ManagementSystem_Views_CooperContent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
            BeginContext(44, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e1aba5cb5c147f2ae770086ce28a34b", async() => {
                BeginContext(50, 105, true);
                WriteLiteral("\r\n    <title>CooperContentManagement</title>\r\n    <link href=\"/layui/css/layui.css\" rel=\"stylesheet\" />\r\n");
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
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(164, 7774, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3af0ef7cb6848ad8060c8436fb08a39", async() => {
                BeginContext(170, 1742, true);
                WriteLiteral(@"
    <div>
        <table id=""CooperContentTable"" lay-filter=""CooperContentTableContainer""></table>
        <script src=""/layui/layui.js""></script>
        <!--表工具条-->
        <script type=""text/html"" id=""ToolBar"">
            <div>
                <button class=""layui-btn"" lay-event=""AddCooperContent"">增加</button>
                <button class=""layui-btn layui-btn-danger"" lay-event=""DeleteSelectCooperContents"">批量删除</button>
                <div class=""layui-input-inline"" style=""margin-left: 200px"">
                    <input class=""layui-input"" placeholder=""查找名称"" id=""KeyWord"" />
                </div>
                <button class=""layui-btn layui-btn-normal"" lay-event=""SearchCooperContents"">搜索</button>
            </div>
        </script>
        <!--列工具条-->
        <script type=""text/html"" id=""ColumnToolBar"">
            <div class=""layui-btn-container"">
                <button class=""layui-btn layui-btn-warm layui-btn-sm"" lay-event=""EditCooperContent"">编辑</button>
                <button ");
                WriteLiteral(@"class=""layui-btn layui-btn-danger layui-btn-sm"" lay-event=""DeleteCooperContent"">删除</button>
            </div>
        </script>
        <script>

            layui.use(['jquery','table', 'layer'],
                function () {
                    //初始化
                    var table = layui.table;
                    var layer = layui.layer;
                    var $ = layui.$;
                    //计算窗口高度
                    var tableHeight = window.innerHeight*0.98;
                    //渲染数据表格
                    var CooperTable = table.render({
                        elem: '#CooperContentTable',
                        height: tableHeight,
                        url: '/ManagementSystem/");
                EndContext();
                BeginContext(1913, 51, false);
#line 46 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperContent\Index.cshtml"
                                           Write(Url.Action("SelectCooperContents", "CooperContent"));

#line default
#line hidden
                EndContext();
                BeginContext(1964, 1715, true);
                WriteLiteral(@"' //数据接口
                        ,
                        page: true //开启分页
                        ,
                        toolbar: ""#ToolBar"",
                        cols: [
                            [//表头
                                { field: 'checkbox', type: ""checkbox"", width: 80, fixed: 'left' },
                                { field: 'id', title: 'ID', width: 80, sort: true, fixed: 'left' },
                                { field: 'name', title: '选项名', width: 280 },
                                { field: 'cooperationTitleName', title: '属于标题', width: 180 },
                                { field: 'tool', title: '工具条', width: 135, toolbar: ""#ColumnToolBar"" }
                            ]
                        ]
                        ,
                        response: {
                            statusName: 'status' //规定数据状态的字段名称，默认：code
                            ,statusCode: 200 //规定成功的状态码，默认：0
                            ,msgName: 'message' //规定状态信息的字段名称，默认：msg");
                WriteLiteral(@"
                            ,countName: 'total' //规定数据总数的字段名称，默认：count
                            ,dataName: 'data' //规定数据列表的字段名称，默认：data
                        }
                    });

                    //表工具条监听
                    table.on('toolbar(CooperContentTableContainer)', function(obj) {
                        console.log(obj);
                        switch (obj.event) {
                            //增加子选项
                        case ""AddCooperContent"":
                            layer.open({
                                type: 2,
                                area: ['400px', '270px'],
                                content: '/ManagementSystem/");
                EndContext();
                BeginContext(3680, 51, false);
#line 79 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperContent\Index.cshtml"
                                                       Write(Url.Action("AddCooperContentPage", "CooperContent"));

#line default
#line hidden
                EndContext();
                BeginContext(3731, 766, true);
                WriteLiteral(@"'
                            });
                            break;
                        //批量删除
                        case ""DeleteSelectCooperContents"":
                            var select = table.checkStatus('CooperContentTable');
                            if (select.data.length <= 0) {
                                layer.msg(""您还未选中！"");
                                return;
                            }
                            layer.confirm('真的要删除吗？', {
                                btn: ['确定', '取消'] //可以无限个按钮
                            }, function (index, layero) {
                                layer.close(index);
                                //按钮【按钮一】的回调
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(4498, 50, false);
#line 94 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperContent\Index.cshtml"
                                                     Write(Url.Action("DeleteCooperContents","CooperContent"));

#line default
#line hidden
                EndContext();
                BeginContext(4548, 1817, true);
                WriteLiteral(@"',
                                    {
                                        cooperationContents: select.data
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""删除成功！"");
                                            table.reload(""CooperContentTable"");
                                        } else {
                                            layer.msg(""删除失败！"");
                                        }
                                    });
                            }, function (index) {
                                layer.close(index);
                                //按钮【按钮二】的回调

                            });
                            break;
                        //关键字搜索
                        case ""SearchCooperContents"":
                            var value = $(""#KeyWord"").val();

                        ");
                WriteLiteral(@"    table.reload(""CooperContentTable"",
                                {
                                    where: {
                                        keyword: value
                                    }
                                });
                            break;
                        }
                    });

                    //列工具条监听
                    table.on('tool(CooperContentTableContainer)', function (obj) {
                        switch (obj.event) {
                            //编辑行业
                        case ""EditCooperContent"":
                            layer.open({
                                type: 2,
                                area: ['400px', '270px'],
                                content: '/ManagementSystem/");
                EndContext();
                BeginContext(6366, 53, false);
#line 134 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperContent\Index.cshtml"
                                                       Write(Url.Action("UpdateCooperContentPage","CooperContent"));

#line default
#line hidden
                EndContext();
                BeginContext(6419, 507, true);
                WriteLiteral(@"?id=' + obj.data.id
                            });
                            break;
                        //删除子选项
                        case ""DeleteCooperContent"":
                            layer.confirm('真的要删除吗？', {
                                btn: ['确定', '取消'] //可以无限个按钮
                            }, function(index, layero){
                                //按钮【按钮一】的回调
                                layer.close(index);
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(6927, 50, false);
#line 144 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\CooperContent\Index.cshtml"
                                                     Write(Url.Action("DeleteCooperContents","CooperContent"));

#line default
#line hidden
                EndContext();
                BeginContext(6977, 954, true);
                WriteLiteral(@"',
                                    {
                                        cooperationContents: [obj.data]
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""删除成功！"");
                                            table.reload(""CooperContentTable"");
                                        } else {
                                            layer.msg(""删除失败！"");
                                        }
                                    });
                            }, function (index) {
                                layer.close(index);
                                //按钮【按钮二】的回调

                            });

                            break;
                        }
                    });
                });
        </script>
    </div>
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
            BeginContext(7938, 9, true);
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

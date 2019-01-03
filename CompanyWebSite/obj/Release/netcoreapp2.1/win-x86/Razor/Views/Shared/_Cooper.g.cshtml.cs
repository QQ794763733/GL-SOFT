#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Shared\_Cooper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82b65ca1e08f47335b9ad76697f84269ac5ae563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Cooper), @"mvc.1.0.view", @"/Views/Shared/_Cooper.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Cooper.cshtml", typeof(AspNetCore.Views_Shared__Cooper))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82b65ca1e08f47335b9ad76697f84269ac5ae563", @"/Views/Shared/_Cooper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Cooper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 311, true);
            WriteLiteral(@"<div id=""app"" class=""cooperation-area"">
    <i class=""layui-icon layui-icon-close-fill"" style=""color: red; float: right; font-size: 20px;"" onclick=""$('#app').css('display','none');""></i>
    <div class=""center-content""><h1 style=""font-size: 20px; margin-top: 20px; margin-bottom: 20px;"">合作意向表</h1></div>
    ");
            EndContext();
            BeginContext(311, 1740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef34198c5e2a4c2388447d74c21665be", async() => {
                BeginContext(352, 1692, true);
                WriteLiteral(@"
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">公司名称：</label>
            <div class=""layui-input-block"">
                <input class=""layui-input"" lay-verify=""required"" name=""company"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">邮箱地址：</label>
            <div class=""layui-input-block"">
                <input class=""layui-input"" lay-verify=""required|email"" name=""email"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">姓名：</label>
            <div class=""layui-input-block"">
                <input class=""layui-input"" lay-verify=""required"" name=""linkman"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">电话：</label>
            <div class=""layui-input-block"">
                <input class=""layui-input"" lay-verify=""required|phone"" name=""contact"" />
");
                WriteLiteral(@"            </div>
        </div>
        <div class=""layui-form-item options"">
            <div v-for=""title in titles"">
                <h1 style=""font-size: 15px"">{{title.name}}</h1>
                <div>
                    <input v-for=""content in title.cooperationContents"" :type=""title.type==1?'checkbox':'radio'"" :name=""title.type==1?'detail':title.id"" :title=""content.name"" class=""layui-input"" :value=""content.name"" />
                </div>
            </div>
        </div>
        <div class=""layui-form-item"">
            <button type=""button"" class=""layui-btn layui-btn-fluid"" lay-submit lay-filter=""commit"">提交需求</button>
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
            BeginContext(2051, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
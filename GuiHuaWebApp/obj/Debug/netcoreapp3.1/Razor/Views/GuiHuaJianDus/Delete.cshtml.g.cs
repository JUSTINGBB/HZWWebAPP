#pragma checksum "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee1637129868759830556d1d4ac7029acf72fccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GuiHuaJianDus_Delete), @"mvc.1.0.view", @"/Views/GuiHuaJianDus/Delete.cshtml")]
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
#nullable restore
#line 1 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\_ViewImports.cshtml"
using GuiHuaWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\_ViewImports.cshtml"
using GuiHuaWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1637129868759830556d1d4ac7029acf72fccd", @"/Views/GuiHuaJianDus/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e32bce4b0eb1401fa1576418dc4cbb85a4507bdc", @"/Views/_ViewImports.cshtml")]
    public class Views_GuiHuaJianDus_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GuiHuaWebApp.Models.GuiHuaJianDu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>删除</h1>\r\n\r\n<h3>确定删除这条数据?</h3>\r\n<div>\r\n");
            WriteLiteral("    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 16 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrjName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 19 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrjName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 22 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JSDanWei));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 25 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JSDanWei));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 28 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JSWeiZhi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 31 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JSWeiZhi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 34 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FaZhengTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 37 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FaZhengTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 40 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GongGuiNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 43 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GongGuiNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 46 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JSGuiMo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 49 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JSGuiMo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 亩\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 52 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SFYanXian));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 55 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SFYanXian));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            是否施工现场检查：\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 61 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsChecked1));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 61 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
                                                        Write(Html.DisplayFor(model => model.IsChecked1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n");
            WriteLiteral("        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 67 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsChecked2));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 67 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
                                                        Write(Html.DisplayFor(model => model.IsChecked2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 70 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SFFaWenXinTiShiKa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 73 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SFFaWenXinTiShiKa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 76 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 79 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 82 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 85 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 88 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 91 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 94 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 97 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 100 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 103 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 106 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 109 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 112 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.checkItem7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 115 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.checkItem7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 124 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SFJunGongHeShi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 127 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SFJunGongHeShi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 130 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BeiZhu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 133 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BeiZhu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1637129868759830556d1d4ac7029acf72fccd17421", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee1637129868759830556d1d4ac7029acf72fccd17688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 138 "D:\VSprojects\vs2019Projects\HZWWebAPP\GuiHuaWebApp\Views\GuiHuaJianDus\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"删除\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1637129868759830556d1d4ac7029acf72fccd19478", async() => {
                    WriteLiteral("返回列表");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GuiHuaWebApp.Models.GuiHuaJianDu> Html { get; private set; }
    }
}
#pragma warning restore 1591

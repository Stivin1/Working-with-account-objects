#pragma checksum "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ba71fec1d42059659d5386edd4c1e907e4728bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserUpdate), @"mvc.1.0.view", @"/Views/Home/UserUpdate.cshtml")]
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
#line 1 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\_ViewImports.cshtml"
using OpenSourceEnity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\_ViewImports.cshtml"
using OpenSourceEnity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba71fec1d42059659d5386edd4c1e907e4728bd", @"/Views/Home/UserUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b431a70cc7812a70f8a0731dbda4eb3a09a34714", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpenSourceEnity.Models.ModelViews.EntityViews.UserUpdate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/AccountUpdate.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomeMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
  
    ViewData["Title"] = "UserUpdate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"en\" dir=\"ltr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba71fec1d42059659d5386edd4c1e907e4728bd7378", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ba71fec1d42059659d5386edd4c1e907e4728bd7672", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ba71fec1d42059659d5386edd4c1e907e4728bd8851", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ba71fec1d42059659d5386edd4c1e907e4728bd10030", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title></title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba71fec1d42059659d5386edd4c1e907e4728bd11937", async() => {
                WriteLiteral("\r\n    <div class=\"list-navigation\">\r\n        <nav>\r\n            <ul>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 480, "\"", 518, 1);
#nullable restore
#line 20 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
WriteAttributeValue("", 487, Url.ActionLink("Index","Home"), 487, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">OpenSource</a></li>\r\n                <li><input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 579, "\"", 586, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 587, "\"", 595, 0);
                EndWriteAttribute();
                WriteLiteral("></li>\r\n                <li class=\"container-li\">");
#nullable restore
#line 22 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                                    Write(Html.ActionLink("Выход", "Logout", "Home", null, new { @class = "container-thref-a" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                <li><a href=""#"">О сайте</a></li>
                <li><a href=""#"">Контакты</a></li>
            </ul>
        </nav>
    </div>
    <div class=""base"">
        <div class=""container-home"">
            <div class=""container-home-menu"">
                <nav>
                    <ul>
                        <li>");
#nullable restore
#line 33 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Моя страница", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 34 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Список пользователей", "Index", "ListUser", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 35 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Добавить роль пользователю", "RoleAppendUser", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 36 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Добавить группу пользователю", "TeamUserCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 37 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Обновить учетные данные", "UserUpdate", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 38 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Обновить пользовательские данные", "UpdateParticipant", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 39 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Добавить роль", "RoleCreate", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 40 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Добавить группу", "TeamCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 41 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Отправить сообщения", "UserListMessage", "Message", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 42 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                       Write(Html.ActionLink("Прочитать сообщения", "ReceivingMessage", "Message", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                    </ul>
                </nav>
            </div>
        </div>
        <div class=""information"">
            <div class=""container-home-base"">
                <div class=""info"">
                    Обновить учетные данные
                </div>
                <div class=""container-location"">
                    <div class=""container-base-participant"">
                        <div class=""container-info-participant"">
                            <label");
                BeginWriteAttribute("for", " for=\"", 2813, "\"", 2819, 0);
                EndWriteAttribute();
                WriteLiteral(">Обновить учетные данные</label>\r\n                        </div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba71fec1d42059659d5386edd4c1e907e4728bd18079", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba71fec1d42059659d5386edd4c1e907e4728bd18374", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 58 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            <div class=\"container-participant\">\r\n                                ");
#nullable restore
#line 60 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
                           Write(Html.Hidden("UserId", Model.UserId));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                <div class=\"container-label\">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 3313, "\"", 3319, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Email</label>\r\n                                </div>\r\n                                <div class=\"container-part-input\">\r\n                                    <input type=\"text\" name=\"UserName\"");
                    BeginWriteAttribute("value", " value=\"", 3514, "\"", 3537, 1);
#nullable restore
#line 65 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
WriteAttributeValue("", 3522, Model.UserName, 3522, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly>\r\n                                </div>\r\n                                <div class=\"container-label\">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 3695, "\"", 3701, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Пароль</label>\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba71fec1d42059659d5386edd4c1e907e4728bd21739", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 69 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OldPassword);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("<br />\r\n                                </div>\r\n                                <div class=\"container-part-input\">\r\n                                    <input type=\"text\" name=\"OldPassword\"");
                    BeginWriteAttribute("value", " value=\"", 4008, "\"", 4016, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"container-label\">\r\n                                    <label");
                    BeginWriteAttribute("for", " for=\"", 4165, "\"", 4171, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Повторите пароль</label>\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba71fec1d42059659d5386edd4c1e907e4728bd24202", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 76 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Home\UserUpdate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewPassword);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("<br />\r\n                                </div>\r\n                                <div class=\"container-part-input\">\r\n                                    <input type=\"text\" name=\"NewPassword\"");
                    BeginWriteAttribute("value", " value=\"", 4488, "\"", 4496, 0);
                    EndWriteAttribute();
                    WriteLiteral(" >\r\n                                </div>\r\n                                <div class=\"container-reg\">\r\n                                    <input type=\"submit\"");
                    BeginWriteAttribute("name", " name=\"", 4658, "\"", 4665, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Обновить\">\r\n                                </div>\r\n                            </div>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenSourceEnity.Models.ModelViews.EntityViews.UserUpdate> Html { get; private set; }
    }
}
#pragma warning restore 1591
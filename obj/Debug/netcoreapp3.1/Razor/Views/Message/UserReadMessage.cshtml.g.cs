#pragma checksum "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad66c096b32bbeb437c9ad7887460b925173361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_UserReadMessage), @"mvc.1.0.view", @"/Views/Message/UserReadMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad66c096b32bbeb437c9ad7887460b925173361", @"/Views/Message/UserReadMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b431a70cc7812a70f8a0731dbda4eb3a09a34714", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_UserReadMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpenSourceEnity.Models.ModelViews.EntityViews.UserReadMessage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/UserMessages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomeMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
  
    ViewData["Title"] = "UserReadMessage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"en\" dir=\"ltr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad66c096b32bbeb437c9ad7887460b9251733615243", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ad66c096b32bbeb437c9ad7887460b9251733615537", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ad66c096b32bbeb437c9ad7887460b9251733616716", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ad66c096b32bbeb437c9ad7887460b9251733617895", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad66c096b32bbeb437c9ad7887460b9251733619801", async() => {
                WriteLiteral("\r\n    <div class=\"list-navigation\">\r\n        <nav>\r\n            <ul>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 489, "\"", 527, 1);
#nullable restore
#line 20 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
WriteAttributeValue("", 496, Url.ActionLink("Index","Home"), 496, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">OpenSource</a></li>\r\n                <li><input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 588, "\"", 595, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 596, "\"", 604, 0);
                EndWriteAttribute();
                WriteLiteral("></li>\r\n                <li class=\"container-li\">");
#nullable restore
#line 22 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
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
#line 33 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Моя страница", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 34 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Список пользователей", "Index", "ListUser", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 35 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Добавить роль пользователю", "RoleAppendUser", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 36 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Добавить группу пользователю", "TeamUserCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 37 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Обновить учетные данные", "UserUpdate", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 38 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Обновить пользовательские данные", "UpdateParticipant", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 39 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Добавить роль", "RoleCreate", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 40 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Добавить группу", "TeamCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 41 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                       Write(Html.ActionLink("Отправить сообщения", "UserListMessage", "Message", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 42 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
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
                    Сообщение
                </div>
                <div class=""container-location"">
                    <div class=""container-base-participant"">
                        <div class=""container-participant"">
");
                WriteLiteral("                                <div class=\"container-part-input\">\r\n");
#nullable restore
#line 57 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                                     if (Model.UserId != Model.UserRecipientId)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"container-label\">\r\n                                            ");
#nullable restore
#line 60 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                                       Write(Html.Label("Направлено пользователю"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n                                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3250, "\"", 3257, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3258, "\"", 3289, 1);
#nullable restore
#line 62 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
WriteAttributeValue("", 3266, Model.UserRecipienName, 3266, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n");
#nullable restore
#line 63 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"container-label\">\r\n                                            ");
#nullable restore
#line 67 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                                       Write(Html.Label("Получено от пользователя"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n                                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3684, "\"", 3691, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3692, "\"", 3720, 1);
#nullable restore
#line 69 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
WriteAttributeValue("", 3700, Model.UserDonorName, 3700, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n");
#nullable restore
#line 70 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                                <div class=\"container-label\">\r\n                                    ");
#nullable restore
#line 73 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                               Write(Html.Label("Текст сообщения"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                                </div>\r\n                                <div class=\"container-message-input\">\r\n                                    <textarea type=\"textarea\" name=\"name\" rows=\"8\" cols=\"80\" readonly>");
#nullable restore
#line 76 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Message\UserReadMessage.cshtml"
                                                                                                 Write(Model.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                                </div>\r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenSourceEnity.Models.ModelViews.EntityViews.UserReadMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7947fce82cf2bfe181c30b3334699888bb3617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListUser_Index), @"mvc.1.0.view", @"/Views/ListUser/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7947fce82cf2bfe181c30b3334699888bb3617", @"/Views/ListUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b431a70cc7812a70f8a0731dbda4eb3a09a34714", @"/Views/_ViewImports.cshtml")]
    public class Views_ListUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpenSourceEnity.Models.ModelViews.EntityViews.ListUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ListUser.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"en\" dir=\"ltr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7947fce82cf2bfe181c30b3334699888bb36175300", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a7947fce82cf2bfe181c30b3334699888bb36175594", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a7947fce82cf2bfe181c30b3334699888bb36176773", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a7947fce82cf2bfe181c30b3334699888bb36177952", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7947fce82cf2bfe181c30b3334699888bb36179858", async() => {
                WriteLiteral("\r\n    <div class=\"list-navigation\">\r\n        <nav>\r\n            <ul>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 468, "\"", 506, 1);
#nullable restore
#line 20 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 475, Url.ActionLink("Index","Home"), 475, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">OpenSource</a></li>\r\n                <li><input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 567, "\"", 574, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 575, "\"", 583, 0);
                EndWriteAttribute();
                WriteLiteral("></li>\r\n                <li class=\"container-li\">");
#nullable restore
#line 22 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
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
#line 33 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Моя страница", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 34 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Список пользователей", "Index", "ListUser", new { UserId = Model.UserId}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 35 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Добавить роль пользователю", "RoleAppendUser", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 36 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Добавить группу пользователю", "TeamUserCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 37 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Обновить учетные данные", "UserUpdate", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 38 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Обновить пользовательские данные", "UpdateParticipant", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 39 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Добавить роль", "RoleCreate", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 40 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Добавить группу", "TeamCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 41 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                       Write(Html.ActionLink("Отправить сообщения", "UserListMessage", "Message", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 42 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
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
                    Список пользователей
                </div>
                <div class=""container-list-user"">
");
#nullable restore
#line 53 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                     using (Html.BeginForm("Index","ListUser", FormMethod.Get))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                   Write(Html.Hidden("UserId",Model.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"container-list-user-form\">\r\n                            <div class=\"style-location\">\r\n                                <div");
                BeginWriteAttribute("class", " class=\"", 2959, "\"", 2967, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
#nullable restore
#line 59 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.Label("Фамилия"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"container-part-input\">\r\n                                    ");
#nullable restore
#line 62 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.TextBox("MiddleName", null, new { type="text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"style-location\">\r\n                                <div");
                BeginWriteAttribute("class", " class=\"", 3401, "\"", 3409, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
#nullable restore
#line 67 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.Label("Имя"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"container-part-input\">\r\n                                    ");
#nullable restore
#line 70 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.TextBox("Name", null, new { type="text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"style-location\">\r\n                                <div");
                BeginWriteAttribute("class", " class=\"", 3833, "\"", 3841, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
#nullable restore
#line 75 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.Label("Отчество"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"container-part-input\">\r\n                                    ");
#nullable restore
#line 78 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.TextBox("LastName", null, new { type="text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"container-reg\">\r\n                            <input type=\"submit\"");
                BeginWriteAttribute("name", " name=\"", 4313, "\"", 4320, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Найти\">\r\n                        </div>\r\n");
#nullable restore
#line 85 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("class", " class=\"", 4413, "\"", 4421, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <table");
                BeginWriteAttribute("style", " style=\"", 4451, "\"", 4459, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 91 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.ActionLink("Фамилия","Index","ListUser",new { UserId = Model.UserId,  sorting = Model.listParticiapntSorting.MiddleName }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 92 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.ActionLink("Имя", "Index", "ListUser", new { UserId = Model.UserId, sorting = Model.listParticiapntSorting.Name }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 93 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                               Write(Html.ActionLink("Отчество", "Index", "ListUser", new { UserId = Model.UserId, sorting = Model.listParticiapntSorting.LastName }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th>Имя пользователя</th>\r\n                                <th>Дата создания</th>\r\n                                <th>Обновить учетные данные</th>\r\n                            </tr>\r\n");
#nullable restore
#line 98 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                            foreach (var list in Model.Participants)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 101 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                   Write(list.MiddleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 102 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                   Write(list.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 103 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                   Write(list.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 104 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                   Write(list.User.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 105 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                   Write(list.User.DateChanges);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td><a class=\"update-account-input\"");
                BeginWriteAttribute("href", " href=\"", 5775, "\"", 5848, 1);
#nullable restore
#line 106 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
WriteAttributeValue("", 5782, Url.ActionLink("UserUpdate","Home", new { UserId = list.User.Id}), 5782, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Изменить</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 108 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                            }

                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                    \r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 114 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                          
                            for (int i = 1; i < Model.ListUserPagination.CountPage; i++)
                            {
                                if (Model.ListUserPagination.BeforePage)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7947fce82cf2bfe181c30b3334699888bb361725240", async() => {
#nullable restore
#line 122 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                                  WriteLiteral(Model.listParticiapntSorting.Default);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sorting"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sorting", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sorting"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                                 WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 124 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                }
                                if (Model.ListUserPagination.AfterPage)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7947fce82cf2bfe181c30b3334699888bb361729475", async() => {
#nullable restore
#line 130 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                                  WriteLiteral(Model.listParticiapntSorting.Default);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sorting"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sorting", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sorting"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                                 WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 132 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\ListUser\Index.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenSourceEnity.Models.ModelViews.EntityViews.ListUser> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daf49e740309bed34dc54b6b74db9f443df34cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportProject.Pages.Forms.Pages_Forms_List), @"mvc.1.0.razor-page", @"/Pages/Forms/List.cshtml")]
namespace SportProject.Pages.Forms
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
#line 1 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\_ViewImports.cshtml"
using SportProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf49e740309bed34dc54b6b74db9f443df34cbf", @"/Pages/Forms/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf490abe2329b86ae29a33580ec1b2e683beb0b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forms_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
<div class=""col-md-10"">
    <div class=""mx-auto"" style=""padding-left: 3%; padding-top: 3%;"">
        <div class=""text-center"" style=""padding-bottom: 3%;"">
            <h3>Lista podań</h3>
        </div>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Data</th>
                    <th scope=""col"">Nazwa</th>
                    <th scope=""col"">Opcje</th>
                    <th scope=""col"">Decyzja</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 42 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                 foreach (var form in Model.Forms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a class=\"btn\">");
#nullable restore
#line 45 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                                  Write(form.Date.ToString("d/M/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                   Write(form.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daf49e740309bed34dc54b6b74db9f443df34cbf5380", async() => {
                WriteLiteral("Wyświetl szczegóły");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-formId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                                                                          WriteLiteral(form.IdForm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["formId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-formId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["formId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                     if (@form.Accepted == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><i class=\'fas fa-check\' style=\'font-size:36px;color:green\'></i></td>\r\n");
#nullable restore
#line 51 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                    }
                    else if (@form.Accepted == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><i class=\'fas fa-minus\' style=\'font-size:36px;color:red\'></i></td>\r\n");
#nullable restore
#line 55 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><i class=\'fas fa-question\' style=\'font-size:36px;\'></i></td>\r\n");
#nullable restore
#line 59 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Krystian Dębek\source\repos\SportProject\SportProject\Pages\Forms\List.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportProject.Pages.Forms.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SportProject.Pages.Forms.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SportProject.Pages.Forms.ListModel>)PageContext?.ViewData;
        public SportProject.Pages.Forms.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

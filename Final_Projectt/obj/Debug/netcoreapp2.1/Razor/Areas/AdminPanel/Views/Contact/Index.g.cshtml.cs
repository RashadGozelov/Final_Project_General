#pragma checksum "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5cb185570cc8bfa638bb7b915a69b28ac7afcd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Contact/Index.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Contact_Index))]
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
#line 1 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Final_Projectt.Models;

#line default
#line hidden
#line 2 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Final_Projectt.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5cb185570cc8bfa638bb7b915a69b28ac7afcd3", @"/Areas/AdminPanel/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8ba71763a6b6623f284227857fa6a3b4439634", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Yenilə"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 40px;margin-left: 12px;width: 117px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Bax"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 351, true);
            WriteLiteral(@"
<style>
    p {
        margin-bottom: 0rem;
    }
</style>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header card-header-rose card-header-icon"">
                </div>
                <div class=""offset-md-10 col-md-2 col-sm-5"">
");
            EndContext();
#line 19 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                     foreach (var contact in Model)
                    {

#line default
#line hidden
            BeginContext(497, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(521, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee2bc9da5ba5435e9838aa40efbe7fe4", async() => {
                BeginContext(669, 108, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-edit\" style=\"font-size: 22px;\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                 WriteLiteral(contact.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(806, 625, true);
            WriteLiteral(@"                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""text-center"">№</th>
                                    <th>Address</th>
                                    <th>Mail</th>
                                    <th>Phone</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 39 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                  
                                    int count = 0;

                                

#line default
#line hidden
            BeginContext(1556, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                 foreach (var contact in Model)
                                {
                                    count++;

#line default
#line hidden
            BeginContext(1704, 98, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
            EndContext();
            BeginContext(1803, 5, false);
#line 48 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 50 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                         if (contact.Address.Length > 30)
                                        {
                                            

#line default
#line hidden
            BeginContext(2020, 50, false);
#line 52 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                       Write(Html.Raw(contact.Address.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 52 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                                               
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(2249, 25, false);
#line 56 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                       Write(Html.Raw(contact.Address));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                      
                                        }

#line default
#line hidden
            BeginContext(2319, 85, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
            EndContext();
#line 60 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                         if (contact.Mail.Length > 30)
                                        {
                                            

#line default
#line hidden
            BeginContext(2564, 47, false);
#line 62 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                       Write(Html.Raw(contact.Mail.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 62 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                                            
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(2790, 22, false);
#line 66 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                       Write(Html.Raw(contact.Mail));

#line default
#line hidden
            EndContext();
#line 66 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                   
                                        }

#line default
#line hidden
            BeginContext(2857, 85, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
            EndContext();
#line 70 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                         if (contact.Phone.Length > 30)
                                        {
                                            

#line default
#line hidden
            BeginContext(3103, 48, false);
#line 72 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                       Write(Html.Raw(contact.Phone.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 72 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                                             
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(3330, 23, false);
#line 76 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                       Write(Html.Raw(contact.Phone));

#line default
#line hidden
            EndContext();
#line 76 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                    
                                        }

#line default
#line hidden
            BeginContext(3398, 155, true);
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-right td-actions\">\r\n                                        ");
            EndContext();
            BeginContext(3553, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92c8846eea324820ac3a58c75ee8d37d", async() => {
                BeginContext(3639, 140, true);
                WriteLiteral("\r\n                                            <i class=\"fas fa-info\" style=\"font-size: 17px;\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                                                 WriteLiteral(contact.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3783, 85, true);
            WriteLiteral("\r\n                                     </td>\r\n                                </tr>\r\n");
            EndContext();
#line 85 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Contact\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3903, 182, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
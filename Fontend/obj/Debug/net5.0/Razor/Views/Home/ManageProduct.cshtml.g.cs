#pragma checksum "D:\Demo api\Watch\Fontend\Views\Home\ManageProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240b59dd3a55c8e285acf938786c50760e813722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManageProduct), @"mvc.1.0.view", @"/Views/Home/ManageProduct.cshtml")]
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
#line 1 "D:\Demo api\Watch\Fontend\Views\_ViewImports.cshtml"
using Fontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Demo api\Watch\Fontend\Views\_ViewImports.cshtml"
using Fontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240b59dd3a55c8e285acf938786c50760e813722", @"/Views/Home/ManageProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef187eee78259a5a13d4f9274553feb76a1dd62", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ManageProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ManagerProduct.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Demo api\Watch\Fontend\Views\Home\ManageProduct.cshtml"
  
    ViewData["Title"] = "ProductManager";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 align=""center"">Danh S??ch S???n Ph???m</h1>

    <p>

       <button type=""button"" class=""btn btn-primary"" data-bind=""click:$root.Create"">T???o M???i</button>
    </p>
<div align=""center"" > 
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Id
                <th>
                    T??n 
                </th>
                <th>
                    So luong
                </th>

                <th>
                    Ma the loai
                </th>
                <th>
                    Don gia nhap
                </th>
                <th>
                    Don gia ban
                </th>
                <th>
                    action
                </th>
            </tr>
        </thead>
        <tbody data-bind=""foreach:$root.array"">
            <tr>
                <td data-bind=""text:id"">
                </td>
                <td data-bind=""text:name"">
                </td>
                <td data-bind=""");
            WriteLiteral(@"text:mount"">
                </td>
                 <td data-bind=""text:categoryId"">
                </td>
                 <td data-bind=""text:priceN"">
                </td>
                <td data-bind=""text:priceB"">
                </td>
                <td>
                   
                    <button class=""btn btn-primary"" id=""Update"" data-bind=""click:$root.Update"">S???a</button> |
                    
                    <button class=""btn btn-primary"" id=""Delete"" data-bind=""click:$root.del"">X??a</button>
                </td>
                
            </tr>
        </tbody>
    </table>
    <div id=""modal"" class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Modal title</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
               ");
            WriteLiteral(@" <div class=""mb-3"">
                    <label class=""col-form-label"" for=""name"">T??n: </label>  <input class=""form-control"" type=""text"" id=""name""><br />
                </div>
                <div class=""mb-3"">
                    <label class=""col-form-label"" for=""mount"">So luong </label> <input class=""form-control"" type=""text"" id=""mount""><br />
                </div>
                <div class=""mb-3"">
                    <label class=""col-form-label"" for=""categoryId"">Ma the loai: </label> <input class=""form-control"" type=""text"" id=""categoryId"" /><br />
                </div>
                 <div class=""mb-3"">
                    <label class=""col-form-label"" for=""priceN"">Gia nhap: </label> <input class=""form-control"" type=""text"" id=""priceN"" /><br />
                </div>
                 <div class=""mb-3"">
                    <label class=""col-form-label"" for=""priceB"">Gia ban: </label> <input class=""form-control"" type=""text"" id=""priceB"" /><br />
                </div>
                
    ");
            WriteLiteral(@"            <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">????ng</button>
                    <button type=""button"" class=""btn btn-primary"" data-bind=""click:$root.save"">L??u</button>
                </div>
            </div>
        </div>
    </div>
</div>
    </div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240b59dd3a55c8e285acf938786c50760e8137227424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dba0f2e3f0e431f51fb4154f43862521a0b0cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conferencia_Create), @"mvc.1.0.view", @"/Views/Conferencia/Create.cshtml")]
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
#line 1 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dba0f2e3f0e431f51fb4154f43862521a0b0cad", @"/Views/Conferencia/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdcc855e83a87d6560769b7be82a94b7774f6ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferencia_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/conferencia/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dba0f2e3f0e431f51fb4154f43862521a0b0cad5435", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dba0f2e3f0e431f51fb4154f43862521a0b0cad6549", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
  
    var conferencia = (Conferencia)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Programar Conferencia</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6 offset-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dba0f2e3f0e431f51fb4154f43862521a0b0cad8015", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                Imagen\r\n                <input type=\"file\" class=\"form-control\" required name=\"Image\"");
                BeginWriteAttribute("value", " value=\"", 499, "\"", 529, 1);
#nullable restore
#line 17 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
WriteAttributeValue("", 507, conferencia.ImagePath, 507, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                ");
#nullable restore
#line 18 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
           Write(Html.ValidationMessage("ImagePath"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Nombre de Conferencista</label>\r\n                <input class=\"form-control\" placeholder=\"Nombre\" required name=\"NameConf\"");
                BeginWriteAttribute("value", " value=\"", 793, "\"", 822, 1);
#nullable restore
#line 23 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
WriteAttributeValue("", 801, conferencia.NameConf, 801, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
#nullable restore
#line 24 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
           Write(Html.ValidationMessage("NameConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Fecha</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Fecha\" required name=\"FechaConf\"");
                BeginWriteAttribute("value", " value=\"", 1080, "\"", 1110, 1);
#nullable restore
#line 29 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
WriteAttributeValue("", 1088, conferencia.FechaConf, 1088, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
#nullable restore
#line 30 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
           Write(Html.ValidationMessage("FechaConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Título de Conferencia</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Titulo\" required name=\"TituloConf\"");
                BeginWriteAttribute("value", " value=\"", 1387, "\"", 1418, 1);
#nullable restore
#line 35 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
WriteAttributeValue("", 1395, conferencia.TituloConf, 1395, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
#nullable restore
#line 36 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
           Write(Html.ValidationMessage("TituloConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Precio</label>\r\n                <input type=\"number\" class=\"form-control\" placeholder=\"Precio\" required name=\"PrecioConf\"");
                BeginWriteAttribute("value", " value=\"", 1683, "\"", 1714, 1);
#nullable restore
#line 41 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
WriteAttributeValue("", 1691, conferencia.PrecioConf, 1691, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
#nullable restore
#line 42 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
           Write(Html.ValidationMessage("PrecioConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Detalle de la Conferencia</label>\r\n                <textarea name=\"DetalleConf\" class=\"form-control\" required");
                BeginWriteAttribute("value", " value=\"", 1967, "\"", 1999, 1);
#nullable restore
#line 47 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
WriteAttributeValue("", 1975, conferencia.DetalleConf, 1975, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n");
                WriteLiteral("                ");
#nullable restore
#line 49 "C:\Users\JC\source\repos\GoldConf\GoldConf\Views\Conferencia\Create.cshtml"
           Write(Html.ValidationMessage("DetalleConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <button class=\"btn btn-primary\">Registrar</button>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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

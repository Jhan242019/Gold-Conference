#pragma checksum "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e72bf20ff35d22624421e7317690a40f941f7d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conferencia_Edit), @"mvc.1.0.view", @"/Views/Conferencia/Edit.cshtml")]
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
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e72bf20ff35d22624421e7317690a40f941f7d83", @"/Views/Conferencia/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdcc855e83a87d6560769b7be82a94b7774f6ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferencia_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/conferencia/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e72bf20ff35d22624421e7317690a40f941f7d835670", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e72bf20ff35d22624421e7317690a40f941f7d836784", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   var conferencia = (Conferencia)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Editar Conferencia</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e72bf20ff35d22624421e7317690a40f941f7d838226", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 288, "\"", 311, 1);
#nullable restore
#line 9 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 296, conferencia.Id, 296, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ImagePath\"");
                BeginWriteAttribute("value", " value=\"", 358, "\"", 388, 1);
#nullable restore
#line 10 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 366, conferencia.ImagePath, 366, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"form-group\">\r\n        <label>Nombre de Conferencista</label>\r\n        <select name=\"PonenteId\" class=\"form-control\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e72bf20ff35d22624421e7317690a40f941f7d839615", async() => {
                    WriteLiteral("-- Selecciona una opcion --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
             foreach (var item in ViewBag.Ponentes)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                 if (conferencia.Ponentes == item)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e72bf20ff35d22624421e7317690a40f941f7d8311503", async() => {
#nullable restore
#line 20 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                                                 Write(item.NomApe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 21 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e72bf20ff35d22624421e7317690a40f941f7d8314134", async() => {
#nullable restore
#line 24 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                                        Write(item.NomApe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 25 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        ");
#nullable restore
#line 28 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("NameConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Fecha</label>\r\n        <input type=\"datetime-local\" class=\"form-control\" placeholder=\"Fecha\" name=\"FechaConf\"");
                BeginWriteAttribute("value", " value=\"", 1207, "\"", 1275, 1);
#nullable restore
#line 33 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 1215, string.Format("{0:yyyy-MM-ddTHH:mm}",conferencia.FechaConf), 1215, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
#nullable restore
#line 34 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("FechaConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Título de Conferencia</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Titulo\" name=\"TituloConf\"");
                BeginWriteAttribute("value", " value=\"", 1503, "\"", 1534, 1);
#nullable restore
#line 39 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 1511, conferencia.TituloConf, 1511, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
#nullable restore
#line 40 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("TituloConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Precio</label>\r\n        <input type=\"number\" class=\"form-control\" placeholder=\"Precio\" name=\"PrecioConf\"");
                BeginWriteAttribute("value", " value=\"", 1750, "\"", 1781, 1);
#nullable restore
#line 45 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 1758, conferencia.PrecioConf, 1758, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
#nullable restore
#line 46 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("PrecioConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Detalle de la Conferencia</label>\r\n        <textarea type=\"text\" name=\"DetalleConf\" placeholder=\"Detalle\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2019, "\"", 2051, 1);
#nullable restore
#line 51 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 2027, conferencia.DetalleConf, 2027, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n        ");
#nullable restore
#line 52 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("DetalleConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Aprendizajes de la conferencia</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Aprendizaje\" name=\"Ap1\"");
                BeginWriteAttribute("value", " value=\"", 2297, "\"", 2321, 1);
#nullable restore
#line 57 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 2305, conferencia.Ap1, 2305, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
#nullable restore
#line 58 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("Ap1"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Aprendizaje\" name=\"Ap2\"");
                BeginWriteAttribute("value", " value=\"", 2451, "\"", 2475, 1);
#nullable restore
#line 59 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 2459, conferencia.Ap2, 2459, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
#nullable restore
#line 60 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("Ap2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Aprendizaje\" name=\"Ap3\"");
                BeginWriteAttribute("value", " value=\"", 2605, "\"", 2629, 1);
#nullable restore
#line 61 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 2613, conferencia.Ap3, 2613, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
#nullable restore
#line 62 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("Ap3"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Definicion de la conferencia</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Definicion\" name=\"Definicion\"");
                BeginWriteAttribute("value", " value=\"", 2862, "\"", 2893, 1);
#nullable restore
#line 67 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 2870, conferencia.Definicion, 2870, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        ");
#nullable restore
#line 68 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("TituloConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Objetivo de la Conferencia</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Objetivo\" name=\"Objetivo\"");
                BeginWriteAttribute("value", " value=\"", 3126, "\"", 3155, 1);
#nullable restore
#line 73 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 3134, conferencia.Objetivo, 3134, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        ");
#nullable restore
#line 74 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("TituloConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Meta final</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Meta Final\" name=\"MetaFinal\"");
                BeginWriteAttribute("value", " value=\"", 3375, "\"", 3405, 1);
#nullable restore
#line 79 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
WriteAttributeValue("", 3383, conferencia.MetaFinal, 3383, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        ");
#nullable restore
#line 80 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T4\Gold-Conference\GoldConf\Views\Conferencia\Edit.cshtml"
   Write(Html.ValidationMessage("TituloConf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <button class=\"btn btn-primary\">Aplicar</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

#pragma checksum "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93ef873052c75ddc94d46a0713bdbc667214497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conferencia_Conferencias), @"mvc.1.0.view", @"/Views/Conferencia/Conferencias.cshtml")]
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
#line 1 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93ef873052c75ddc94d46a0713bdbc667214497", @"/Views/Conferencia/Conferencias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252177f1550bb91d2ad4557077ea297e3367bc71", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferencia_Conferencias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Conf.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
   var conferencias = (List<Conferencia>)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b93ef873052c75ddc94d46a0713bdbc6672144975829", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b93ef873052c75ddc94d46a0713bdbc6672144976089", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b93ef873052c75ddc94d46a0713bdbc6672144977265", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b93ef873052c75ddc94d46a0713bdbc6672144978441", async() => {
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
                WriteLiteral("\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b93ef873052c75ddc94d46a0713bdbc66721449710322", async() => {
                WriteLiteral("\n    <header>\n        <div class=\"container\">\n            <h1 class=\"h-100 badge badge-dark\">Usuario: ");
#nullable restore
#line 12 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                   Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n        </div>\n    </header>\n");
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
            WriteLiteral("\n\n<h1 class=\"text-black text-center\">Lista de conferencias</h1>\n<bir />\n");
#nullable restore
#line 19 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
 if (ViewBag.Usuario != "LanRhXXX")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/conferencia/create\" class=\"btn btn-outline-dark\">Programar Conferencia</a>\n    <bir />\n");
#nullable restore
#line 23 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b93ef873052c75ddc94d46a0713bdbc66721449712447", async() => {
                WriteLiteral("\n    <div class=\"form-group mb-2\">\n        <input class=\"form-control\" style=\"background-color:transparent; \" type=\"search\" placeholder=\"Buscar\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 832, "\"", 855, 1);
#nullable restore
#line 27 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 840, ViewBag.Buscar, 840, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    </div>\n    \n    <button class=\"form-control btn btn-outline-dark btn-sm\" type=\"button\">Buscar</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th>Imagen</th>
            <th>Ponente</th>
            <th>Fecha</th>
            <th>Titulo</th>
            <th>Precio</th>
            <th>Detalle</th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 47 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
         foreach (var item in conferencias)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
             if (item.FechaConf >= DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1476, "\"", 1497, 1);
#nullable restore
#line 53 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 1482, item.ImagePath, 1482, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" alt=\"Alternate Text\" />\n                    </td>\n                    <td>");
#nullable restore
#line 55 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                   Write(item.Ponentes.NomApe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 56 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                   Write(item.FechaConf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 57 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                   Write(item.TituloConf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 58 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                   Write(item.PrecioConf);

#line default
#line hidden
#nullable disable
            WriteLiteral(" S/.</td>\n                    <td>");
#nullable restore
#line 59 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                   Write(item.DetalleConf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                    <td>\n");
#nullable restore
#line 62 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                         if (ViewBag.Usuario != "LanRhXXX")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1941, "\"", 1977, 2);
            WriteAttributeValue("", 1948, "/conferencia/edit?id=", 1948, 21, true);
#nullable restore
#line 64 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 1969, item.Id, 1969, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar | </a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2023, "\"", 2061, 2);
            WriteAttributeValue("", 2030, "/conferencia/delete?id=", 2030, 23, true);
#nullable restore
#line 65 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2053, item.Id, 2053, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Eliminar </a>\n");
#nullable restore
#line 66 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2189, "\"", 2229, 2);
            WriteAttributeValue("", 2196, "/conferencia/comprar?idF=", 2196, 25, true);
#nullable restore
#line 69 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2221, item.Id, 2221, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Comprar</a>\n");
#nullable restore
#line 76 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
               
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n");
#nullable restore
#line 80 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\JC\Downloads\Gold-Conference-master (1)\Gold-Conference-master\GoldConf\Views\Conferencia\Conferencias.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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

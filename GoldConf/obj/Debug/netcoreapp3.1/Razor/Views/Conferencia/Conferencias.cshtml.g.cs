#pragma checksum "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948e9419000063f83df16dba814b4af90d3a1d9d"
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
#line 1 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948e9419000063f83df16dba814b4af90d3a1d9d", @"/Views/Conferencia/Conferencias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdcc855e83a87d6560769b7be82a94b7774f6ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferencia_Conferencias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Conf.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
   var conferencias = (List<Conferencia>)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948e9419000063f83df16dba814b4af90d3a1d9d6024", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "948e9419000063f83df16dba814b4af90d3a1d9d6286", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "948e9419000063f83df16dba814b4af90d3a1d9d7464", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "948e9419000063f83df16dba814b4af90d3a1d9d8642", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948e9419000063f83df16dba814b4af90d3a1d9d10568", async() => {
                WriteLiteral(@"

    <div class=""barra"">
        <div class=""contenedor clearfix"">
            <div class=""logo"">
                <a href=""/Home"">
                    <img src=""/img/LOGO.png"" alt=""logo"">
                </a>
            </div>

            <div class=""menu-movil"">
                <span></span>
                <span></span>
                <span></span>
            </div>

            <nav class=""navegacion-principal clearfix"">
                <a href=""/conferencia/CompraConf"">Mis Conferencias</a>
                <a href=""#"">Calendario</a>
                <a href=""#"">Invitados</a>
");
#nullable restore
#line 41 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Login\">Login</a>\r\n");
#nullable restore
#line 44 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Logout\">LogOut</a>\r\n                    <a href=\"/#\">");
#nullable restore
#line 48 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                            Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 49 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </nav>\r\n        </div>\r\n        <!--.contenedor-->\r\n    </div>\r\n    <!--.barra-->\r\n    <!--.Contenido-->\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948e9419000063f83df16dba814b4af90d3a1d9d12957", async() => {
                    WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <input class=\"form-control\" style=\"background-color:transparent; \" type=\"search\" placeholder=\"Buscar\" name=\"search\"");
                    BeginWriteAttribute("value", " value=\"", 1848, "\"", 1871, 1);
#nullable restore
#line 59 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 1856, ViewBag.Buscar, 1856, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n        </div>\r\n        <button class=\"form-control btn btn-outline-dark btn-sm\" type=\"button\">Buscar</button>\r\n    ");
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
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 64 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
     if (ViewBag.Usuario != "LanRhXXX")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a href=\"/conferencia/create\" class=\"btn btn-outline-dark\">Programar Conferencia</a>\r\n        <bir />\r\n");
#nullable restore
#line 68 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <section class=\"precios seccion\">\r\n        <h2>Conferencias</h2>\r\n        <div class=\"contenedor\">\r\n            <ul class=\"lista-precios clearfix\">\r\n");
#nullable restore
#line 74 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 foreach (var item in conferencias)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                     if (item.FechaConf >= DateTime.Now)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            <div class=\"tabla-precio\">\r\n                                <h3>");
#nullable restore
#line 80 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                               Write(item.TituloConf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                                <a class=\"course-card--image-wrapper--Sxd90\"");
                BeginWriteAttribute("href", " href=\"", 2699, "\"", 2716, 2);
                WriteAttributeValue("", 2706, "#/", 2706, 2, true);
#nullable restore
#line 82 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2708, item.Id, 2708, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <img");
                BeginWriteAttribute("alt", " alt=\"", 2760, "\"", 2766, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"240\" height=\"135\"");
                BeginWriteAttribute("src", " src=\"", 2792, "\"", 2813, 1);
#nullable restore
#line 83 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2798, item.ImagePath, 2798, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("srcset", " srcset=\"", 2814, "\"", 2861, 4);
#nullable restore
#line 83 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2823, item.ImagePath, 2823, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2838, "1x,", 2839, 4, true);
#nullable restore
#line 83 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue(" ", 2842, item.ImagePath, 2843, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2858, "2x", 2859, 3, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </a>\r\n\r\n");
                WriteLiteral("                                <div> __________________________</div>\r\n                                <ul>\r\n                                    <li><i class=\"fa fa-user\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 89 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                 Write(item.Ponentes.NomApe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li><i class=\"fa fa-calendar\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 90 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                     Write(item.FechaConf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
                WriteLiteral("                                </ul>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3582, "\"", 3622, 2);
                WriteAttributeValue("", 3589, "/conferencia/comprar?idF=", 3589, 25, true);
#nullable restore
#line 93 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 3614, item.Id, 3614, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"button hollow\">");
#nullable restore
#line 93 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                             Write(string.Format("{0:N2}", item.PrecioConf));

#line default
#line hidden
#nullable disable
                WriteLiteral(" S/.</a>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 96 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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

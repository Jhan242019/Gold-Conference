#pragma checksum "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afcaed0f04cac45402c405c77d052ceabda7a784"
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
#line 1 "D:\Visual\T4_PROYECTO\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual\T4_PROYECTO\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afcaed0f04cac45402c405c77d052ceabda7a784", @"/Views/Conferencia/Conferencias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdcc855e83a87d6560769b7be82a94b7774f6ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferencia_Conferencias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
  
    var conferencias = (List<Conferencia>)Model;
    //var compras = (List<Comprar>)ViewBag.Compra;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\"/css/Detalle.css\" rel=\"stylesheet\" />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afcaed0f04cac45402c405c77d052ceabda7a7843727", async() => {
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
                <a href=""/conferencia/Pasadas"">Mis Conferencias</a>
                <a href=""/conferencia/Futuras"">Calendario</a>
                <a href=""/Ponente/ponente"">Invitados</a>
");
#nullable restore
#line 28 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Login\">Login</a>\r\n");
#nullable restore
#line 31 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Logout\">LogOut</a>\r\n                    <a href=\"/#\">");
#nullable restore
#line 35 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                            Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 36 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </nav>
        </div>
        <!--.contenedor-->
    </div>
    <!--.barra-->
    <!--.Contenido-->

    <div class=""seccion contenedor"">
        <div class=""form-group mb-2"">
            <input style=""background-size:cover; "" type=""search"" name=""search""");
                BeginWriteAttribute("value", " value=\"", 1464, "\"", 1487, 1);
#nullable restore
#line 46 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 1472, ViewBag.Buscar, 1472, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button class=\"button jhan\" type=\"submit\"><i class=\"fa fa-search\" aria-hidden=\"true\"></i> Buscar</button>\r\n        </div>\r\n    </div>\r\n\r\n    <section class=\"seccion contenedor\">\r\n\r\n");
#nullable restore
#line 53 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
         if (ViewBag.Usuario != "LanRhXXX")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a href=\"/conferencia/create\" class=\"button hollow\">Programar Conferencia</a>\r\n            <bir />\r\n");
#nullable restore
#line 57 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <h2>Conferencias</h2>\r\n");
#nullable restore
#line 60 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
         if (TempData["COMPRA"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-danger\">\r\n                ");
#nullable restore
#line 63 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
           Write(TempData["COMPRA"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 66 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"calendario\">\r\n            <ul class=\"lista-precios clearfix\">\r\n");
#nullable restore
#line 69 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 foreach (var item in conferencias)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li>\r\n                        <div class=\"tabla-precio\">\r\n                            <h3>");
#nullable restore
#line 73 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                           Write(item.TituloConf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                            <a class=\"course-card--image-wrapper--Sxd90\"");
                BeginWriteAttribute("href", " href=\"", 2427, "\"", 2477, 2);
                WriteAttributeValue("", 2434, "/conferencia/Detalle?idConferencia=", 2434, 35, true);
#nullable restore
#line 75 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2469, item.Id, 2469, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <img");
                BeginWriteAttribute("alt", " alt=\"", 2517, "\"", 2523, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"240\" height=\"135\"");
                BeginWriteAttribute("src", " src=\"", 2549, "\"", 2570, 1);
#nullable restore
#line 76 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2555, item.ImagePath, 2555, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("srcset", " srcset=\"", 2571, "\"", 2618, 4);
#nullable restore
#line 76 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 2580, item.ImagePath, 2580, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2595, "1x,", 2596, 4, true);
#nullable restore
#line 76 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue(" ", 2599, item.ImagePath, 2600, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2615, "2x", 2616, 3, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </a>\r\n\r\n");
                WriteLiteral("                            <div> __________________________</div>\r\n                            <ul>\r\n                                <li><i class=\"fa fa-user\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 82 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                             Write(item.Ponentes.NomApe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 83 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                Write(string.Format("{0: hh:mm tt}", item.FechaConf));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-calendar\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 84 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                 Write(string.Format("{0:dd MMMM yyyy}", item.FechaConf));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            </ul>\r\n");
#nullable restore
#line 86 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                             if (ViewBag.Usuario != "LanRhXXX")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a");
                BeginWriteAttribute("href", " href=\"", 3513, "\"", 3549, 2);
                WriteAttributeValue("", 3520, "/conferencia/Edit?id=", 3520, 21, true);
#nullable restore
#line 88 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 3541, item.Id, 3541, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"button hollow\"> Editar Conferencia</a>\r\n");
#nullable restore
#line 89 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a");
                BeginWriteAttribute("href", " href=\"", 3728, "\"", 3768, 2);
                WriteAttributeValue("", 3735, "/conferencia/comprar?idF=", 3735, 25, true);
#nullable restore
#line 92 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 3760, item.Id, 3760, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"button hollow\">");
#nullable restore
#line 92 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                             Write(string.Format("{0:N2}", item.PrecioConf));

#line default
#line hidden
#nullable disable
                WriteLiteral(" S/.</a>\r\n");
#nullable restore
#line 93 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 96 "D:\Visual\T4_PROYECTO\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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

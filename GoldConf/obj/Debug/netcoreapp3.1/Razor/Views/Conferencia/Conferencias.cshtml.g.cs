#pragma checksum "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a27607a548effa4fd499aaf65d986e945ed5f7"
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
#line 1 "D:\Visual\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a27607a548effa4fd499aaf65d986e945ed5f7", @"/Views/Conferencia/Conferencias.cshtml")]
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
#line 1 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
  
    var conferencias = (List<Conferencia>)Model;
    var compras = (List<Comprar>)ViewBag.Compra;
    bool estado = false;
    int presentes = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\"/css/Detalle.css\" rel=\"stylesheet\" />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86a27607a548effa4fd499aaf65d986e945ed5f73791", async() => {
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
");
#nullable restore
#line 27 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (ViewBag.Usuario != "LanRhXXX")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/conferencia/conferencias\">Conferencias</a>\r\n                    <a href=\"/Ponente/ponente\">Invitados</a>\r\n");
#nullable restore
#line 31 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/conferencia/Pasadas\">Mis Conferencias</a>\r\n                    <a href=\"/conferencia/Futuras\">Calendario</a>\r\n                    <a href=\"/Ponente/ponente\">Invitados</a>\r\n");
#nullable restore
#line 37 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Login\">Login</a>\r\n");
#nullable restore
#line 41 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Logout\"><i class=\"fa fa-power-off\" aria-hidden=\"true\"></i></a>\r\n                    <a href=\"/#\">");
#nullable restore
#line 45 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                            Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 46 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
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
                BeginWriteAttribute("value", " value=\"", 1855, "\"", 1878, 1);
#nullable restore
#line 56 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 1863, ViewBag.Buscar, 1863, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button class=\"button jhan\" type=\"submit\"><i class=\"fa fa-search\" aria-hidden=\"true\"></i> Buscar</button>\r\n        </div>\r\n    </div>\r\n\r\n    <section class=\"seccion contenedor\">\r\n\r\n");
#nullable restore
#line 63 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
         if (ViewBag.Usuario != "LanRhXXX")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a href=\"/conferencia/create\" class=\"button hollow\">Programar Conferencia</a>\r\n            <bir />\r\n");
#nullable restore
#line 67 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <h2>Conferencias</h2>\r\n");
#nullable restore
#line 70 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
         if (TempData["COMPRA"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-danger\">\r\n                ");
#nullable restore
#line 73 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
           Write(TempData["COMPRA"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 76 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <ul class=\"lista-precios clearfix\">\r\n");
#nullable restore
#line 80 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
             foreach (var item in conferencias)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                    <div class=\"tabla-precio\">\r\n");
#nullable restore
#line 84 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                         foreach (var compra in compras)
                        {
                            if (compra.IdConferencia == item.Id)
                            {
                                presentes++;
                                estado = true;
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                         if (estado)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"calendariocomprado\">\r\n                                <h3>");
#nullable restore
#line 95 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                               Write(item.TituloConf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                            </div>\r\n");
#nullable restore
#line 97 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"calendario\">\r\n                                <h3>");
#nullable restore
#line 101 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                               Write(item.TituloConf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                            </div>\r\n");
#nullable restore
#line 103 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <a class=\"course-card--image-wrapper--Sxd90\"");
                BeginWriteAttribute("href", " href=\"", 3525, "\"", 3575, 2);
                WriteAttributeValue("", 3532, "/conferencia/Detalle?idConferencia=", 3532, 35, true);
#nullable restore
#line 105 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 3567, item.Id, 3567, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <img");
                BeginWriteAttribute("alt", " alt=\"", 3611, "\"", 3617, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"240\" height=\"135\"");
                BeginWriteAttribute("src", " src=\"", 3643, "\"", 3664, 1);
#nullable restore
#line 106 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 3649, item.ImagePath, 3649, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("srcset", " srcset=\"", 3665, "\"", 3712, 4);
#nullable restore
#line 106 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 3674, item.ImagePath, 3674, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3689, "1x,", 3690, 4, true);
#nullable restore
#line 106 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue(" ", 3693, item.ImagePath, 3694, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3709, "2x", 3710, 3, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </a>\r\n\r\n");
                WriteLiteral("                        <div> __________________________</div>\r\n                        <ul>\r\n                            <li><i class=\"fa fa-user\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 112 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                         Write(item.Ponentes.NomApe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 113 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                            Write(string.Format("{0: hh:mm tt}", item.FechaConf));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-calendar\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 114 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                             Write(string.Format("{0:dd MMMM yyyy}", item.FechaConf));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        </ul>\r\n");
#nullable restore
#line 116 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                         if (ViewBag.Usuario != "LanRhXXX")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/#\" class=\"button-green hollow\"> Registrados: ");
#nullable restore
#line 118 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                              Write(presentes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 119 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                            presentes = 0;
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                             if (estado)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a href=\"#\" class=\"button-green hollow\">Conferencia comprada</a>\r\n");
#nullable restore
#line 126 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                estado = false;
                                presentes = 0;
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a href=\"#\" class=\"button hollow\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5189, "\"", 5237, 5);
                WriteAttributeValue("", 5199, "Registrar(", 5199, 10, true);
#nullable restore
#line 131 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 5209, item.Id, 5209, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5217, ",\'", 5217, 2, true);
#nullable restore
#line 131 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
WriteAttributeValue("", 5219, item.TituloConf, 5219, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5235, "\')", 5235, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 131 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                                                                                              Write(string.Format("{0:N2}", item.PrecioConf));

#line default
#line hidden
#nullable disable
                WriteLiteral(" S/.</a>\r\n");
#nullable restore
#line 132 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                                presentes = 0;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </li>\r\n");
#nullable restore
#line 137 "D:\Visual\Gold-Conference\GoldConf\Views\Conferencia\Conferencias.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </ul>
    </section>

    <footer class=""site-footer"">
        <div class=""contenedor clearfix"">
            <div class=""footer-informacion"">
                <h3>Sobre <span>gold conference</span></h3>
                <p>
                    Somos su conexión virtual a los conferencistas más destacadas y renombradas de Perú, Latinoamérica y el Mundo. Actualmente, abarcamos el continente americano acercando las mentes más brillantes de todo el mundo a las empresas e instituciones que buscan una figura sobresaliente para sus eventos privados y corporativos. Contamos con más de 20 conferencistas de una gran variedad de disciplinas centradas únicamente en tecnologías como HTML5, XML, CSS, JavaScript, PHP, WordPress), entre otras.
                    En GOLD CONFERENCE tenemos el ponente ideal para su reunión y presupuesto.
                </p>
            </div>

            <div class=""ultimos-tweets"">
                <h3>Últimos <span>tweets</span></h3>
                <a class=""twitter-t");
                WriteLiteral(@"imeline"" data-height=""400"" data-theme=""light"" data-link-color=""#fe4918"" href=""https://twitter.com/JhanCarlosI"">Tweets by</a>
                <script async src=""//platform.twitter.com/widgets.js"" charset=""utf-8""></script>
            </div>

            <div class=""menu"">
                <h3>Redes <span>sociales</span></h3>
                <nav class=""redes-sociales"">
                    <a href=""https://www.facebook.com/Gold-Conference-Online-101111435084124/""><i class=""fa fa-facebook""></i></a>
                    <a href=""https://twitter.com/gold_conference""><i class=""fa fa-twitter""></i></a>
                    <a href=""https://www.youtube.com/channel/UCVbYnjINFhIA_qLPC9zAa8Q""><i class=""fa fa-youtube-play""></i></a>
                    <a href=""https://www.instagram.com/GOLDCONF_/""><i class=""fa fa-instagram""></i></a>
                </nav>
            </div>
        </div>

        <p class=""copyright"">
            Todos los derechos Reservados GOLD CONFERENCE 2020.
        </p>

    </foot");
                WriteLiteral("er>\r\n\r\n    <script src=\"https://code.jquery.com/jquery-1.12.0.min.js\"></script>\r\n    <script src=\"/js/Nuestro.js\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@10\"></script>\r\n");
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
            WriteLiteral(@"

<script>
    function Registrar(idF,titulo) {
        var dataString = ""idF="" + idF;
        Swal.fire({
            title: '¿Estás seguro?',
            text: ""Estás por comprar la conferencia "" + titulo,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si, comprar!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: ""/conferencia/comprar"",
                    type: ""get"",
                    data: dataString
                });
                Swal.fire(
                    'Comprado!',
                    'Se añadió a tu listas de conferencias',
                    'success'
                )
            }
        })
    }
</script>");
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

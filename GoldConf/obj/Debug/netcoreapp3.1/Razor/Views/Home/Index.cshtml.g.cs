#pragma checksum "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bf295cca052bee630bd1992ef619ede1181f490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\_ViewImports.cshtml"
using GoldConf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf295cca052bee630bd1992ef619ede1181f490", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdcc855e83a87d6560769b7be82a94b7774f6ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
   var ponentes = (List<Ponente>)Model; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bf295cca052bee630bd1992ef619ede1181f4903731", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <title></title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 187, "\"", 197, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""apple-touch-icon"" href=""apple-touch-icon.png"">
    <!-- Place favicon.ico in the root directory -->

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/3.0.3/normalize.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" />
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans|Oswald|PT+Sans"" rel=""stylesheet"">

    <link rel=""stylesheet"" href=""/css/colorbox.css"">

    <link rel=""stylesheet"" href=""/css/Nosotros.css"">

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js""></script>
");
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bf295cca052bee630bd1992ef619ede1181f4905788", async() => {
                WriteLiteral(@"

    <header class=""site-header"">
        <div class=""hero"">
            <div class=""contenido-header"">
                <nav class=""redes-sociales"">
                    <a href=""https://www.facebook.com/Gold-Conference-Online-101111435084124/""><i class=""fa fa-facebook""></i></a>
                    <a href=""https://twitter.com/""><i class=""fa fa-twitter""></i></a>
                    <a href=""https://www.youtube.com/""><i class=""fa fa-youtube-play""></i></a>
                    <a href=""https://www.instagram.com/""><i class=""fa fa-instagram""></i></a>
                </nav>

                <div class=""informacion-evento"">
                    <div class=""clearfix"">
                        <p class=""fecha""><i class=""fa fa-calendar"" aria-hidden=""true""></i> ");
#nullable restore
#line 38 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                                                                                      Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        <p class=""ciudad""><i class=""fa fa-map-marker"" aria-hidden=""true""></i> Cajamarca, PERÚ</p>
                    </div>

                    <div class=""gold"">
                        <h1 class=""nombre-sitio"">GOLD CONF</h1>
                        <p class=""slogan"">La mejor conferencia de <span>diseño web</span></p>
                    </div>

                </div>
                <!--.informacion-evento-->

            </div>
        </div>
        <!--.hero-->
    </header>

    <div class=""barra"">
        <div class=""contenedor clearfix"">
            <div class=""logo"">
                <a href=""#"">
                    <img src=""img/LOGO.png"" alt=""logo"">
                </a>
            </div>

            <div class=""menu-movil"">
                <span></span>
                <span></span>
                <span></span>
            </div>

            <nav class=""navegacion-principal clearfix"">
                <a href=""conferencia/CompraConf"">Mis Conf");
                WriteLiteral("erencias</a>\r\n                <a href=\"#\">Calendario</a>\r\n                <a href=\"ponente/ponente\">Invitados</a>\r\n");
#nullable restore
#line 73 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <a href=\"/Auth/Login\">Login</a>");
#nullable restore
#line 75 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <a href=\"/Auth/Logout\">LogOut</a>\r\n                    <a href=\"/#\">");
#nullable restore
#line 79 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                            Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>");
#nullable restore
#line 79 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </nav>
        </div>
        <!--.contenedor-->
    </div>
    <!--.barra-->
    <section class=""seccion contenedor"">
        <h2>Bienvenido a Gold Conference</h2>
        <p>
            Somos su conexión virtual a los conferencistas más destacadas y renombradas de Perú, Latinoamérica y el Mundo. Actualmente, abarcamos el continente americano acercando las mentes más brillantes de todo el mundo a las empresas e instituciones que buscan una figura sobresaliente para sus eventos privados y corporativos. Contamos con más de 20 conferencistas de una gran variedad de disciplinas centradas únicamente en tecnologías como HTML5, XML, CSS, JavaScript, PHP, WordPress), entre otras.
            En GOLD CONFERENCE tenemos el ponente ideal para su reunión y presupuesto.
        </p>
    </section>
    <!--seccion-->

    <section class=""programa"">
        <div class=""contenedor-video"">
            <video autoplay loop poster=""bg-talleres.jpg"">
                <source src=""video/video.mp4"" ty");
                WriteLiteral(@"pe=""video/mp4"">
                <source src=""video/video.webm"" type=""video/webm"">
                <source src=""video/video.ogv"" type=""video/ogg"">
            </video>
        </div>
        <!--.contenedor-video-->
        <div class=""contenido-programa"">
            <div class=""contenedor"">
                <div class=""programa-evento"">
                    <h2>Programa del Evento</h2>

                    <nav class=""menu-programa"">
                        <a href=""#conferencias"">
                            <i class=""fa fa-comment"" aria-hidden=""true""></i> Conferencias
                        </a>
                        <a href=""#talleres"">
                            <i class=""fa fa-code"" aria-hidden=""true""></i> Talleres
                        </a>
                    </nav>

                    <div id=""conferencias"" class=""info-curso ocultar clearfix"">
                        <div class=""detalle-evento"">
                            <h3>Como ser freelancer</h3>
                     ");
                WriteLiteral(@"       <p><i class=""fa fa-clock-o"" aria-hidden=""true""></i> 10:00</p>
                            <p><i class=""fa fa-calendar"" aria-hidden=""true""></i> 12-Oct-2020</p>
                            <p><i class=""fa fa-user"" aria-hidden=""true""></i> Susan Sanchez</p>
                        </div>
                        <div class=""detalle-evento"">
                            <h3>Tecnologías del Futuro PHP</h3>
                            <p><i class=""fa fa-clock-o"" aria-hidden=""true""></i> 15:00</p>
                            <p><i class=""fa fa-calendar"" aria-hidden=""true""></i> 20-Oct-2020</p>
                            <p><i class=""fa fa-user"" aria-hidden=""true""></i> Juan Sanchez</p>
                        </div>
                        <a href=""conferencia/conferencias"" class=""button float-right"">Ver todos</a>
                    </div>
                    <!--#talleres-->

                    <div id=""talleres"" class=""info-curso ocultar clearfix"">
                        <div class=""detalle-eve");
                WriteLiteral(@"nto"">
                            <h3>HTML5 y CSS3</h3>
                            <p><i class=""fa fa-clock-o"" aria-hidden=""true""></i> 11:00</p>
                            <p><i class=""fa fa-calendar"" aria-hidden=""true""></i> 25-Nov-2020</p>
                            <p><i class=""fa fa-user"" aria-hidden=""true""></i> Juan Sanchez</p>
                        </div>
                        <div class=""detalle-evento"">
                            <h3>WordPress</h3>
                            <p><i class=""fa fa-clock-o"" aria-hidden=""true""></i> 19:00</p>
                            <p><i class=""fa fa-calendar"" aria-hidden=""true""></i> 26-Nov-2020</p>
                            <p><i class=""fa fa-user"" aria-hidden=""true""></i> Harold Garcia</p>
                        </div>
                        <a href=""conferencia/conferencias"" class=""button float-right"">Ver todos</a>
                    </div>
                    <!--#talleres-->
                </div>
                <!--.programa-evento-->");
                WriteLiteral(@"
            </div>
            <!--.contenedor-->
        </div>
        <!--.contenido-programa-->
    </section>
    <!--.programa-->

    <section class=""invitados contenedor seccion"">
        <h2>Nuestros conferencistas</h2>
        <ul class=""lista-invitados clearfix"">
");
#nullable restore
#line 162 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
             foreach (var item in ponentes)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                    <div class=\"invitado\">\r\n                        <a class=\"invitado-info\"");
                BeginWriteAttribute("href", " href=\"", 7755, "\"", 7771, 2);
                WriteAttributeValue("", 7762, "#", 7762, 1, true);
#nullable restore
#line 166 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
WriteAttributeValue("", 7763, item.Id, 7763, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 7807, "\"", 7825, 1);
#nullable restore
#line 167 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
WriteAttributeValue("", 7813, item.Imagen, 7813, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Imagen invitado\">\r\n                            <p>");
#nullable restore
#line 168 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                          Write(item.NomApe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </a>\r\n                    </div>\r\n                    <!-- END .invitado -->\r\n                </li>\r\n");
                WriteLiteral("                <div style=\"display:none;\">\r\n\r\n                    <div class=\"invitado-info\"");
                BeginWriteAttribute("id", " id=\"", 8120, "\"", 8133, 1);
#nullable restore
#line 176 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
WriteAttributeValue("", 8125, item.Id, 8125, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <h2>");
#nullable restore
#line 177 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                       Write(item.NomApe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 8212, "\"", 8230, 1);
#nullable restore
#line 178 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
WriteAttributeValue("", 8218, item.Imagen, 8218, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 8231, "\"", 8237, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <h4>Título profesional</h4>\r\n                        <p>");
#nullable restore
#line 180 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                      Write(item.NomApe);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                        <h4>Educación y Logros</h4>
                        <p>Graduado en la Universidad Nacional de Ingeniería, realizo una maestría en Ingeniería de Sistemas en la UPC, certificado en desarrollo de software, uso de herramientas informáticas en la industria.</p>

                        <h4>Contactos</h4>
                        <p>");
#nullable restore
#line 186 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                      Write(item.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 187 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                      Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>            \r\n");
#nullable restore
#line 191 "C:\Users\Edwin Vásquez\Downloads\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </ul>
        <!-- END lista-invitados -->
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
            <div class=""menu"">
                <h3>Redes <span>sociales</span></h3>
         ");
                WriteLiteral(@"       <nav class=""redes-sociales"">
                    <a href=""https://www.facebook.com/Gold-Conference-Online-101111435084124/""><i class=""fa fa-facebook""></i></a>
                    <a href=""https://twitter.com/""><i class=""fa fa-twitter""></i></a>
                    <a href=""https://www.youtube.com/""><i class=""fa fa-youtube-play""></i></a>
                    <a href=""https://www.instagram.com/""><i class=""fa fa-instagram""></i></a>
                </nav>
            </div>
        </div>

        <p class=""copyright"">
            Todos los derechos Reservados GOLD CONFERENCE 2020.
        </p>

    </footer>

    <script src=""https://code.jquery.com/jquery-1.12.0.min.js""></script>
    <script src=""js/plugins.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-animateNumber/0.0.14/jquery.animateNumber.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.countdown/2.2.0/jquery.countdown.min.js""></script>
    <script src=""https://cdnjs.clo");
                WriteLiteral(@"udflare.com/ajax/libs/lettering.js/0.7.0/jquery.lettering.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.colorbox/1.6.4/jquery.colorbox-min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/waypoints/4.0.1/jquery.waypoints.min.js""></script>
    <script src=""js/main.js""></script>
    <script src=""js/cotizador.js""></script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCeSzprwFmUOSsAIf36sT9hONLvf3ReD_4&callback=initMap"" async defer></script>

");
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
            WriteLiteral("\r\n\r\n");
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

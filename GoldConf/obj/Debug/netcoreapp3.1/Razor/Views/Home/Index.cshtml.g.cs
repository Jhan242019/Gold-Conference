#pragma checksum "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fdf17c4ccffb7f152ee7143cac3385c08bcf617"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fdf17c4ccffb7f152ee7143cac3385c08bcf617", @"/Views/Home/Index.cshtml")]
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdf17c4ccffb7f152ee7143cac3385c08bcf6173515", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\n    <title></title>\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 141, "\"", 151, 0);
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
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdf17c4ccffb7f152ee7143cac3385c08bcf6175543", async() => {
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
#line 38 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
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
                <a href=""conferencia/CompraConf"">Mis Conferencias</a>
                <a ");
                WriteLiteral("href=\"#\">Calendario</a>\n                <a href=\"ponente/ponente\">Invitados</a>\n");
#nullable restore
#line 73 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                 if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Login\">Login</a>\n");
#nullable restore
#line 76 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"/Auth/Logout\">LogOut</a>\n                    <a href=\"/#\">");
#nullable restore
#line 80 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
                            Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n");
#nullable restore
#line 81 "D:\Proyecto DIARS\Gold-Conference\GoldConf\Views\Home\Index.cshtml"
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
                <source src=""video/video.mp4"" type=""video/mp4"">
 ");
                WriteLiteral(@"               <source src=""video/video.webm"" type=""video/webm"">
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
                            <p><i class=""fa fa-clock-o"" aria-");
                WriteLiteral(@"hidden=""true""></i> 10:00</p>
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
                        <div class=""detalle-evento"">
                            <h3>HTML5 y CSS3</h3>");
                WriteLiteral(@"
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
                <!--.programa-evento-->
            </div>
            <!--.contenedor-->
        </div>
   ");
                WriteLiteral(@"     <!--.contenido-programa-->
    </section>
    <!--.programa-->



    <section class=""invitados contenedor seccion"">
        <h2>Nuestros conferencistas</h2>
        <ul class=""lista-invitados clearfix"">


            <li>
                <div class=""invitado"">
                    <a class=""invitado-info"" href=""#invitado1"">
                        <img src=""img/invitados/invitado1.jpg"" alt=""Imagen invitado"">
                        <p>Rafael  Bautista</p>
                    </a>
                </div>
                <!-- END .invitado -->
            </li>

            <div style=""display:none;"">

                <div class=""invitado-info"" id=""invitado1"">
                    <h2>Rafael</h2>
                    <img src=""img/invitado1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7996, "\"", 8002, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <h4>Título profesional</h4>
                    <p>Ingeniero de Software</p>

                    <h4>Educación y Logros</h4>
                    <p>Graduado en la Universidad Nacional de Ingeniería, realizo una maestría en Ingeniería de Software en La Universidad de los Andes de Colombia, certificado en desarrollo de software, uso de y uso de tendencias tecnológicas.</p>

                    <h4>Experiencia Laboral</h4>
                    <p>
                        Trabajo de docente en la Universidad Mayor de San Marcos en la Carrera de ingeniería de Sistemas desde el año 2010 hasta 2016, dirigió múltiples proyectos de software e investigación para la optimización de procesos de las elecciones presidenciales 2016 y evitar el fraude. Impulso un proyecto “programando como jugando” para que los niños de nivel primario se les enseñe a programar mediante juegos y mucho más.

                        Contacto: r.bautista@gmail.com
                    </p>
                </div>

           ");
                WriteLiteral(@" </div>


            <li>
                <div class=""invitado"">
                    <a class=""invitado-info"" href=""#invitado2"">
                        <img src=""img/invitados/invitado2.jpg"" alt=""Imagen invitado"">
                        <p>Shari Herrera</p>
                    </a>
                </div>
                <!-- END .invitado -->
            </li>

            <div style=""display:none;"">

                <div class=""invitado-info"" id=""invitado2"">
                    <h2>Shari</h2>
                    <img src=""img/invitado2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 9577, "\"", 9583, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <h4>Título profesional</h4>
                    <p>Ingeniería de Sistemas</p>

                    <h4>Educación y Logros</h4>
                    <p>Graduado en la Universidad Nacional de Ingeniería, realizo una maestría en Ingeniería de Sistemas en la UPC, certificado en desarrollo de software, uso de herramientas informáticas en la industria.</p>

                    <h4>Experiencia Laboral</h4>
                    <p>
                        Trabaja como docente en la carrera de ingeniería en la UNT desde el año 2014, ha sido jefe de procesos industriales en la mucha empresa de Trujillo, ha desarrollado un sistema de seguridad en los movimientos financieros del BCP entre otros.

                        Contacto: s.herrera@gmail.com

                    </p>
                </div>

            </div>


            <li>
                <div class=""invitado"">
                    <a class=""invitado-info"" href=""#invitado3"">
                        <img src=""img/invitados/invitado3.jpg"" al");
                WriteLiteral(@"t=""Imagen invitado"">
                        <p>Juan Sanchez</p>
                    </a>
                </div>
                <!-- END .invitado -->
            </li>

            <div style=""display:none;"">

                <div class=""invitado-info"" id=""invitado3"">
                    <h2>Juan</h2>
                    <img src=""img/invitado3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 10961, "\"", 10967, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    <h4>Título profesional</h4>
                    <p>Analista Programador</p>

                    <h4>Educación y Logros</h4>
                    <p>Magíster Gestión de Proyectos. Posgrado en Ingeniería de programación. Certificado en manejo y seguridad de la información. Especialización en oratoria.</p>

                    <h4>Experiencia Laboral</h4>
                    <p>
                        Magister en Gestión de Proyecto, especialista en Telecomunicaciones, con más de 15 años de experiencia en el mercado laboral público y privado, y 12 años como docente universitario. Ponente en UPAO, UDEP, UNAC, UIGV, etc. Publicación de diversos PAPER de investigación: UNI revista TELCON, UIGV revista de la facultad de Ingeniería De Sistemas.

                        Contacto: j.sanchez@gmail.com
                    </p>

                </div>

            </div>


            <li>
                <div class=""invitado"">
                    <a class=""invitado-info"" href=""#invitado4"">
       ");
                WriteLiteral(@"                 <img src=""img/invitados/invitado4.jpg"" alt=""Imagen invitado"">
                        <p>Susana Rivera</p>
                    </a>
                </div>
                <!-- END .invitado -->
            </li>

            <div style=""display:none;"">

                <div class=""invitado-info"" id=""invitado4"">
                    <h2>Susana</h2>
                    <img src=""img/invitado4.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 12406, "\"", 12412, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    <h4>Título profesional</h4>
                    <p>Ingeniero en ciencias de la computación</p>

                    <h4>Educación y Logros</h4>
                    <p>Certificación Agile Scrum Master. Diplomado en Enseñanza de las Ciencias para la Ingeniería, Escuela de Postgrado Universidad Nacional de Trujillo. Certificado Lauréate en Educación Superior.</p>

                    <h4>Experiencia Laboral</h4>
                    <p>
                        Dirigió el proyecto de Gestión Académica – UPN, Proyecto optimización de matriculas -UPN. Proyectos Proyecto mejoramiento de la calidad en los productos Nestlé.

                        Contacto: s.rivera@gmail.com
                    </p>
                </div>

            </div>


            <li>
                <div class=""invitado"">
                    <a class=""invitado-info"" href=""#invitado5"">
                        <img src=""img/invitados/invitado5.jpg"" alt=""Imagen invitado"">
                        <p>Harold Garcia</p>
    ");
                WriteLiteral(@"                </a>
                </div>
                <!-- END .invitado -->
            </li>

            <div style=""display:none;"">

                <div class=""invitado-info"" id=""invitado5"">
                    <h2>Harold</h2>
                    <img src=""img/invitado5.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 13723, "\"", 13729, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    <h4>Título profesional</h4>
                    <p>Ingeniería de Sistemas</p>

                    <h4>Educación y Logros</h4>
                    <p>Graduado en la Universidad Nacional de Ingeniería, realizo una maestría en Ingeniería de Sistemas en la UPC, certificado en desarrollo web, seguridad de la información y base de datos.</p>

                    <h4>Experiencia Laboral</h4>
                    <p>
                        Trabaja como docente en la carrera de ingeniería en la UPC desde el año 2016, es trabajador activo en la base de datos de la COVID19 en Perú, manejos estadísticos y tomar proyecciones para la prevención del contagio. Apoyo en el manejo de padrones para distintos bonos dados por el estado.

                        Contacto: h.garcia@gmail.com
                    </p>
                </div>

            </div>


            <li>
                <div class=""invitado"">
                    <a class=""invitado-info"" href=""#invitado6"">
                        <img s");
                WriteLiteral(@"rc=""img/invitados/invitado6.jpg"" alt=""Imagen invitado"">
                        <p>Susan Sanchez</p>
                    </a>
                </div>
                <!-- END .invitado -->
            </li>

            <div style=""display:none;"">

                <div class=""invitado-info"" id=""invitado6"">
                    <h2>Susan</h2>
                    <img src=""img/invitado6.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 15144, "\"", 15150, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    <h4>Título profesional</h4>
                    <p>Ingeniero de Software</p>

                    <h4>Educación y Logros</h4>
                    <p>Graduado en la Universidad Nacional de Ingeniería, realizo una maestría en Ingeniería de sistemas en La Universidad Gabriela Mistral de Chile, certificado en desarrollo java script.</p>

                    <h4>Experiencia Laboral</h4>
                    <p>
                        Trabajo de docente en la UNMS en la Carrera de ingeniería de Sistemas desde el año 2009 hasta 2016, dirigió múltiples proyectos de software para la universidad que laboraba. Impulso un proyecto “Escuela de Negocios y Tecnología” para que capacitar a personas emprendedoras con sus negocios relacionados a la y mucho más.

                        Contacto: s.sanchez@gmail.com

                    </p>

                </div>

            </div>


        </ul>
        <!-- END lista-invitados -->
    </section>
    <!-- END .invitados -->

    <footer class=""site-f");
                WriteLiteral(@"ooter"">
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
                <nav class=""redes-sociales"">
                    <a href=""https://www.facebook.com/Gold-Conference-O");
                WriteLiteral(@"nline-101111435084124/""><i class=""fa fa-facebook""></i></a>
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
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/lettering.js/0.7.0/jquery.lettering.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/aja");
                WriteLiteral(@"x/libs/jquery.colorbox/1.6.4/jquery.colorbox-min.js""></script>
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
            WriteLiteral("\n\n");
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

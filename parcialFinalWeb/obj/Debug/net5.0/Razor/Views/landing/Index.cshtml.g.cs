#pragma checksum "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b99d9c0bd8fa14b19639a399c53242142367e63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_landing_Index), @"mvc.1.0.view", @"/Views/landing/Index.cshtml")]
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
#line 1 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\_ViewImports.cshtml"
using parcialFinalWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\_ViewImports.cshtml"
using parcialFinalWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b99d9c0bd8fa14b19639a399c53242142367e63", @"/Views/landing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_landing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.usuarios>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
   ViewBag.Title = "Langing Page"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
   
    var experienciasList = ViewBag.Experiencias;
    var habilidadesList = ViewBag.Habilidades;
    var portafoliosList = ViewBag.Portafolios;
    var certificadosList = ViewBag.Certificados;
    var gradosList = ViewBag.Grados;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <div class=\"container bg-light bg-gradient\">\n        <div class=\"row py-4\">\n            <div class=\"col-12 text-center \">\n                <h1 class=\"display-3\">");
#nullable restore
#line 15 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                 Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n    <div class=\"row pb-4\">\n        <div class=\"col-6 pt-5 align-content-center\">\n            <img class=\"d-block m-auto\"");
            BeginWriteAttribute("src", " src=\"", 659, "\"", 676, 1);
#nullable restore
#line 20 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 665, Model.foto, 665, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" />\n        </div>\n\n        <div class=\"col-6 pt-5\">\n            <h4 class=\"display-6 text-warning\">Nombre Completo:</h4>\n            <p class=\"fw-bold\">");
#nullable restore
#line 25 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                          Write(Model.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                         Write(Model.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <h4 class=\"display-6 text-warning\">Información Personal</h4>\n");
#nullable restore
#line 27 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
             if (Model.introduccion != null && Model.introduccion != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><strong>Introducción:</strong> <br>");
#nullable restore
#line 29 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                 Write(Model.introduccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>            \n");
#nullable restore
#line 30 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4 class=\"display-6 text-warning\">Contactos</h4>\n            <p><i class=\"fa-solid fa-square-envelope fa-xl\"></i><strong> Correo Electronico:</strong> <br> ");
#nullable restore
#line 32 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                                                                      Write(Model.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 33 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
             if (Model.linkedin != null && Model.linkedin != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1461, 1);
#nullable restore
#line 35 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 1446, Model.linkedin, 1446, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-black\"><p><i class=\"fa-brands fa-linkedin fa-xl\"></i><strong> Linkedin:</strong> <br><span class=\"text-info\">Link del perfil -></span></p></a>            \n");
#nullable restore
#line 36 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
             if (Model.facebook != null && Model.facebook != "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1762, "\"", 1784, 1);
#nullable restore
#line 39 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 1769, Model.facebook, 1769, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-black\"><p><i class=\"fa-brands fa-facebook-square fa-xl\"></i><strong> Facebook:</strong> <br><span class=\"text-info\">Link del perfil -></span></p></a>            \n");
#nullable restore
#line 40 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 43 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
     if (habilidadesList.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row py-5"">
            <div class=""col-12"">
                <div class=""row"">
                    <div class=""col-3"">
                        <h3 class=""display-6 ms-3 fw-bold fst-italic"">Mis Habilidades</h3>
                    </div>
                    <div class=""col-9"">
                        <hr class=""dashed"">
                    </div>
                </div>

                <br />
");
#nullable restore
#line 57 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                 foreach (var item in habilidadesList)
                {
                    String x = "";
                    if (item.calificacion == 1)
                    {
                        x = "20%";
                    }
                    else if (item.calificacion == 2)
                    {
                        x = "40%";
                    }
                    else if (item.calificacion == 3)
                    {
                        x = "60%";
                    }
                    else if (item.calificacion == 4)
                    {
                        x = "80%";
                    }
                    else if (item.calificacion == 5)
                    {
                        x = "100%";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"h6 mt-3 float-none px-4 text-danger\"><i>");
#nullable restore
#line 80 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                                 Write(item.habilidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\n                    <div class=\"progress mx-4\" style=\"height: 25px;\">\n                        <div class=\"progress-bar progress-bar-striped bg-info\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 3503, "\"", 3520, 2);
            WriteAttributeValue("", 3511, "width:", 3511, 6, true);
#nullable restore
#line 82 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue(" ", 3517, x, 3518, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3521, "\"", 3555, 1);
#nullable restore
#line 82 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 3537, item.calificacion, 3537, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"5\"> ");
#nullable restore
#line 82 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                                                                                                                                                       Write(item.calificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5</div>\n                    </div>\n");
#nullable restore
#line 84 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>");
#nullable restore
#line 86 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 88 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
     if (gradosList.Count != 0 || certificadosList.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <hr class=""dashed "">
        <div class=""row py-5 "">
            
            <div class=""col-6 mycontent-left"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h3 class=""display-6 text-center fw-bold fst-italic"">Grados Academicos</h3>
                    </div>
                </div>

                <br />
");
#nullable restore
#line 101 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                 foreach (var item in gradosList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row mt-5"">
                        <div class=""col-4"">
                            <i class=""fa-solid fa-graduation-cap fa-6x float-end text-success""></i>
                        </div>
                        <div class=""col-8"">
                            <h4>");
#nullable restore
#line 108 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                           Write(item.universidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <h6 class=\"text-primary fst-italic\">");
#nullable restore
#line 109 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                           Write(item.profesion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                            <p class=\"text-muted\">");
#nullable restore
#line 110 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                             Write(item.objetivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n");
#nullable restore
#line 113 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div class=""col-6"">
                <div class=""row"">
                    <div class=""col-12"">
                        <h3 class=""display-6 text-center fw-bold fst-italic"">Cursos/Certificados</h3>
                    </div>
                </div>

                <br />
");
#nullable restore
#line 124 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                 foreach (var item in certificadosList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row mt-5"">
                        <div class=""col-4"">
                            <i class=""fa-solid fa-book-open fa-6x float-end text-danger""></i>
                        </div>
                        <div class=""col-8"">
                            <h4>");
#nullable restore
#line 131 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                           Write(item.institucion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <h6 class=\"text-primary fst-italic\">");
#nullable restore
#line 132 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                           Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                            <h6 class=\"text-muted\">");
#nullable restore
#line 133 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                              Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5631, "\"", 5650, 1);
#nullable restore
#line 134 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 5638, item.enlace, 5638, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"h6 text-decoration-none text-info fst-italic\">Enlace al curso ></a>\n                        </div>\n                    </div>\n");
#nullable restore
#line 137 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n");
#nullable restore
#line 140 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 142 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
     if (portafoliosList.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row py-5"">
            <div class=""col-12"">
                <div class=""row"">
                    <div class=""col-3"">
                        <h3 class=""display-6 ms-3 fw-bold fst-italic"">Portafolio</h3>
                    </div>
                    <div class=""col-9"">
                        <hr class=""dashed"">
                    </div>
                </div>

                <br />
                <div class=""accordion accordion-flush mx-4"" id=""accordionFlushExample"">
");
#nullable restore
#line 157 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                     foreach (var item in portafoliosList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"accordion-item \">\n                            <h2 class=\"accordion-header \"");
            BeginWriteAttribute("id", " id=\"", 6575, "\"", 6612, 2);
            WriteAttributeValue("", 6580, "flush-heading_", 6580, 14, true);
#nullable restore
#line 160 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 6594, item.idPortafolio, 6594, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <button class=\" accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#flush-collapse_");
#nullable restore
#line 161 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                                                                                                               Write(item.idPortafolio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 6804, "\"", 6853, 2);
            WriteAttributeValue("", 6820, "flush-collapse_", 6820, 15, true);
#nullable restore
#line 161 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 6835, item.idPortafolio, 6835, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <h4><i class=\"fa-solid fa-folder-plus \"></i> ");
#nullable restore
#line 162 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                                            Write(item.nombreProyecto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                </button>\n                            </h2>\n                            <div");
            BeginWriteAttribute("id", " id=\"", 7071, "\"", 7109, 2);
            WriteAttributeValue("", 7076, "flush-collapse_", 7076, 15, true);
#nullable restore
#line 165 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 7091, item.idPortafolio, 7091, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse \"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 7147, "\"", 7197, 2);
            WriteAttributeValue("", 7165, "flush-heading_", 7165, 14, true);
#nullable restore
#line 165 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
WriteAttributeValue("", 7179, item.idPortafolio, 7179, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-parent=\"#accordionFlushExample\">\n                                <div class=\"accordion-body ps-5\">\n                                    <h5 class=\"ms-5 text-black\">Rol en el proyecto: <span class=\"text-danger\">");
#nullable restore
#line 167 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                                                                         Write(item.rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\n                                    <h6 class=\"text-muted ms-5\">");
#nullable restore
#line 168 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                           Write(item.resumen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                    <h6 class=\"text-primary mt-4 ms-5\">Responsabilidades:</h6>\n                                    <h6 class=\"text-muted ms-5\">");
#nullable restore
#line 170 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                           Write(item.responsabilidades);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                    <h6 class=\"text-primary mt-4 ms-5\">Tecnologias usadas:</h6>\n                                    <h6 class=\"text-muted ms-5\">");
#nullable restore
#line 172 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                                           Write(item.tecnologiasUsadas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 176 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 180 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 182 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
     if (experienciasList.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row py-5"">
            <div class=""col-12"">
                <div class=""row"">
                    <div class=""col-3"">
                        <h3 class=""display-6 ms-3 fw-bold fst-italic"">Experiencia Laboral</h3>
                    </div>
                    <div class=""col-9"">
                        <hr class=""dashed"">
                    </div>
                </div>

                <br />
");
#nullable restore
#line 196 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                 foreach (var item in experienciasList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row py-4"">
                        <div class=""col-5"">
                            <i class=""fa-solid fa-briefcase fa-4x float-end text-info""></i>
                        </div>
                        <div class=""col-7"">
                            <h4>");
#nullable restore
#line 203 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                           Write(item.experiencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <h6 class=\"text-danger\">");
#nullable restore
#line 204 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                                               Write(item.anios);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Años</h6>\n                        </div>\n                    </div>          \n");
#nullable restore
#line 207 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n");
#nullable restore
#line 210 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\landing\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.usuarios> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10cb33bf14ccc581748d459f8f2571e3f2706412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_certificadoscursos_CrearCertificadosCursos), @"mvc.1.0.view", @"/Views/certificadoscursos/CrearCertificadosCursos.cshtml")]
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
#line 1 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\_ViewImports.cshtml"
using parcialFinalWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\_ViewImports.cshtml"
using parcialFinalWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10cb33bf14ccc581748d459f8f2571e3f2706412", @"/Views/certificadoscursos/CrearCertificadosCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_certificadoscursos_CrearCertificadosCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.certificadoscursos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
   ViewBag.Title = "Crear Certificados Cursos"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Crear certificado de curso para ");
#nullable restore
#line 5 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                               Write(ViewBag.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 7 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-horizontal\">\n                    n\n                    <hr />\n                    ");
#nullable restore
#line 14 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 17 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.nombre, "Nombre del Certificado de Curso", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 19 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.EditorFor(model => model.nombre, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 20 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.nombre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 25 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.institucion, "Institución", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 27 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.EditorFor(model => model.institucion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 28 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.institucion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 33 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.descripcion, "Descripción", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 35 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.TextAreaFor(model => model.descripcion, 5, 90, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 36 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.descripcion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 41 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.enlace, "Enlace", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 43 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.EditorFor(model => model.enlace, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 44 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.enlace, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 49 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.idUsuario, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 51 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.TextBox("idUsuario", (int)ViewBag.IdUsuario, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 52 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.idUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" name=""response"" value=""Crear Experiencia""");
            BeginWriteAttribute("formaction", " formaction=", 3290, "", 3322, 1);
#nullable restore
#line 58 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
WriteAttributeValue("", 3302, Url.Action("Crear"), 3302, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-primary\" />\n                        </div>\n                    </div>\n                </div>");
#nullable restore
#line 61 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 64 "C:\Users\Marco\Desktop\parcialFinalWeb-m-usuario\parcialFinalWeb\Views\certificadoscursos\CrearCertificadosCursos.cshtml"
Write(Html.ActionLink("Regresar a la lista", "Index", null, new { id = (int)ViewBag.IdUsuario }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.certificadoscursos> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "625fb1de610657ed2b143b489567add8fd69c7ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_certificadoscursos_EditarCertificadosCursos), @"mvc.1.0.view", @"/Views/certificadoscursos/EditarCertificadosCursos.cshtml")]
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
#line 1 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\_ViewImports.cshtml"
using parcialFinalWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\_ViewImports.cshtml"
using parcialFinalWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"625fb1de610657ed2b143b489567add8fd69c7ca", @"/Views/certificadoscursos/EditarCertificadosCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_certificadoscursos_EditarCertificadosCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.certificadoscursos>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
   ViewBag.Title = "Editar Certificados Cursos"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Editar Certificado de Curso</h2>\n\n");
#nullable restore
#line 7 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-horizontal\">\n                    <hr />\n                    ");
#nullable restore
#line 13 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 14 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
               Write(Html.HiddenFor(model => model.idCertifiado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 15 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
               Write(Html.HiddenFor(model => model.idUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 18 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.nombre, "Nombre del Certificado de Curso", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 20 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.EditorFor(model => model.nombre, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 21 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.nombre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 26 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.institucion, "Institución", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 28 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.EditorFor(model => model.institucion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 29 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.institucion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 34 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.descripcion, "Descripción", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 36 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.TextAreaFor(model => model.descripcion, 5, 90, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 37 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.descripcion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 42 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                   Write(Html.LabelFor(model => model.enlace, "Enlace", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 44 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.EditorFor(model => model.enlace, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 45 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                       Write(Html.ValidationMessageFor(model => model.enlace, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" name=""response"" value=""Editar Certificado de Curso""");
            BeginWriteAttribute("formaction", " formaction=", 2854, "", 2887, 1);
#nullable restore
#line 51 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
WriteAttributeValue("", 2866, Url.Action("Editar"), 2866, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-primary\" />\n                        </div>\n                    </div>\n                </div>");
#nullable restore
#line 54 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 57 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\EditarCertificadosCursos.cshtml"
Write(Html.ActionLink("Regresar a la lista", "Index", new { id = Model.idUsuario }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.certificadoscursos> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b136e7ff6aceb5d0fcbf657f191d3b62d45103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_certificadoscursos_Index), @"mvc.1.0.view", @"/Views/certificadoscursos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b136e7ff6aceb5d0fcbf657f191d3b62d45103", @"/Views/certificadoscursos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_certificadoscursos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<parcialFinalWebEntidades.certificadoscursos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   ViewBag.Title = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Certificados Cursos ");
#nullable restore
#line 5 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
                   Write(ViewBag.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<p>\n    ");
#nullable restore
#line 8 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
Write(Html.ActionLink("Agregar Certificados Cursos", "CrearCertificadosCursos", new { id = ViewBag.IdUsuario }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>

<table class=""table table-light table-striped"">
    <tr>
        <th>
            Nombre del certificado de curso
        </th>
        <th>
            Institución del certificado de curso
        </th>
        <th>
            Descripción del certificado de curso
        </th>
        <th>
            Enlace
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 28 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 32 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 35 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   Write(item.institucion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 38 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 41 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   Write(item.enlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 44 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   Write(Html.ActionLink("Editar", "EditarCertificadosCursos", new { id = item.idCertifiado }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 45 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
   Write(Html.ActionLink("Eliminar", "EliminarCertificadosCursos", new { id = item.idCertifiado }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 47 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
#nullable restore
#line 50 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\certificadoscursos\Index.cshtml"
Write(Html.ActionLink("Regresar a usuarios", "Index", "usuarios", null, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<parcialFinalWebEntidades.certificadoscursos>> Html { get; private set; }
    }
}
#pragma warning restore 1591

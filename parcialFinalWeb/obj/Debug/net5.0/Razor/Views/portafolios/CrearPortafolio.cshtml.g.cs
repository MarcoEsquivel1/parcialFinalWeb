#pragma checksum "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47a1aedf6203f5a3e69f836a2849dacc6bc67f83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_portafolios_CrearPortafolio), @"mvc.1.0.view", @"/Views/portafolios/CrearPortafolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47a1aedf6203f5a3e69f836a2849dacc6bc67f83", @"/Views/portafolios/CrearPortafolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_portafolios_CrearPortafolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.portafolios>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
  
    ViewBag.Title = "Crear Experiencia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Crear experiencia para ");
#nullable restore
#line 7 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
                      Write(ViewBag.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 15 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
       Write(Html.LabelFor(model => model.nombreProyecto, "Nombre del Proyecto", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.EditorFor(model => model.nombreProyecto, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.ValidationMessageFor(model => model.nombreProyecto, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
       Write(Html.LabelFor(model => model.rol, "Rol en el Proyecto", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 28 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.EditorFor(model => model.rol, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.ValidationMessageFor(model => model.rol, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
       Write(Html.LabelFor(model => model.resumen, "Resumen del Proyecto", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 36 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.TextAreaFor(model => model.resumen, 5, 90, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.ValidationMessageFor(model => model.resumen, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
       Write(Html.LabelFor(model => model.responsabilidades, "Responsabilidades en el Proyecto", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 44 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.TextAreaFor(model => model.responsabilidades, 5, 90, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.ValidationMessageFor(model => model.responsabilidades, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
       Write(Html.LabelFor(model => model.tecnologiasUsadas, "Tecnologias usadas en el Proyecto", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 52 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.TextAreaFor(model => model.tecnologiasUsadas, 5, 90, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.ValidationMessageFor(model => model.tecnologiasUsadas, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 58 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
       Write(Html.LabelFor(model => model.idUsuario, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 60 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.TextBox("idUsuario", (int)ViewBag.IdUsuario, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 61 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
           Write(Html.ValidationMessageFor(model => model.idUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" name=\"response\" value=\"Crear Experiencia\"");
            BeginWriteAttribute("formaction", " formaction=", 3393, "", 3425, 1);
#nullable restore
#line 67 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
WriteAttributeValue("", 3405, Url.Action("Crear"), 3405, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 71 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 74 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\portafolios\CrearPortafolio.cshtml"
Write(Html.ActionLink("Regresar a la lista", "Index", new { id = (int)ViewBag.IdUsuario }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.portafolios> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0dfee71bc10e0baafc02c8b2ab4ee81c78e7f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_habilidades_CrearHabilidad), @"mvc.1.0.view", @"/Views/habilidades/CrearHabilidad.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e0dfee71bc10e0baafc02c8b2ab4ee81c78e7f6", @"/Views/habilidades/CrearHabilidad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_habilidades_CrearHabilidad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.habilidades>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
   ViewBag.Title = "Crear Habilidad"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Crear habilidad para ");
#nullable restore
#line 5 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                    Write(ViewBag.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 7 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-horizontal\">\n                    <hr />\n                    ");
#nullable restore
#line 13 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 16 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                   Write(Html.LabelFor(model => model.habilidad, "Nombre de la habilidad", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 18 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                       Write(Html.EditorFor(model => model.habilidad, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 19 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                       Write(Html.ValidationMessageFor(model => model.habilidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 24 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                   Write(Html.LabelFor(model => model.calificacion, "Calificacion de la Habilidad", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 26 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                       Write(Html.EditorFor(model => model.calificacion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 27 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                       Write(Html.ValidationMessageFor(model => model.calificacion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 32 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                   Write(Html.LabelFor(model => model.idUsuario, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 34 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                       Write(Html.TextBox("idUsuario", (int)ViewBag.IdUsuario, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 35 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                       Write(Html.ValidationMessageFor(model => model.idUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" name=""response"" value=""Crear Habilidad""");
            BeginWriteAttribute("formaction", " formaction=", 2185, "", 2217, 1);
#nullable restore
#line 41 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
WriteAttributeValue("", 2197, Url.Action("Crear"), 2197, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-primary\" />\n                        </div>\n                    </div>\n                </div>");
#nullable restore
#line 44 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 47 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\habilidades\CrearHabilidad.cshtml"
Write(Html.ActionLink("Regresar a la lista", "Index", new { id = (int)ViewBag.IdUsuario }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.habilidades> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
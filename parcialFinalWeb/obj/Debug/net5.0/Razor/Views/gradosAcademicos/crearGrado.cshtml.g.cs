#pragma checksum "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c690bb3eeaee9288abac341a49b88e2fce971881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_gradosAcademicos_crearGrado), @"mvc.1.0.view", @"/Views/gradosAcademicos/crearGrado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c690bb3eeaee9288abac341a49b88e2fce971881", @"/Views/gradosAcademicos/crearGrado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_gradosAcademicos_crearGrado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.gradosacademicos>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
  
    ViewBag.Title = "Crear grado academico";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Agregar grado academico.</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 15 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 17 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
   Write(Html.Hidden("idUsuario", (int)ViewBag.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 20 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
       Write(Html.LabelFor(model => model.universidad, "Nombre de la universidad:", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 22 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
           Write(Html.EditorFor(model => model.universidad, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
           Write(Html.ValidationMessageFor(model => model.universidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
       Write(Html.LabelFor(model => model.profesion, "Profesion:", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 29 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
           Write(Html.EditorFor(model => model.profesion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
           Write(Html.ValidationMessageFor(model => model.profesion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
       Write(Html.LabelFor(model => model.objetivo, "Objetivo:", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 36 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
           Write(Html.TextAreaFor(model => model.objetivo, 5, 90, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
           Write(Html.ValidationMessageFor(model => model.objetivo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" name=\"response\" value=\"Crear \"");
            BeginWriteAttribute("formaction", " formaction=", 1950, "", 1982, 1);
#nullable restore
#line 44 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
WriteAttributeValue("", 1962, Url.Action("Crear"), 1962, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 51 "C:\practicasasp\parcialFinal\parcialFinalWeb\parcialFinalWeb\Views\gradosAcademicos\crearGrado.cshtml"
Write(Html.ActionLink("Regresar a la lista", "Index", new { id = (int)ViewBag.IdUsuario }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.gradosacademicos> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

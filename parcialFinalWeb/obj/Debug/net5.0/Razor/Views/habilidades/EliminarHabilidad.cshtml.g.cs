#pragma checksum "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d564c69f2cc18c4e55b9788001182079673c719d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_habilidades_EliminarHabilidad), @"mvc.1.0.view", @"/Views/habilidades/EliminarHabilidad.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d564c69f2cc18c4e55b9788001182079673c719d", @"/Views/habilidades/EliminarHabilidad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f282d2ad0ffe4d5af97a072edc3fa45650bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_habilidades_EliminarHabilidad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<parcialFinalWebEntidades.habilidades>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
   ViewBag.Title = "Eliminar Habilidad"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Eliminar Habilidad</h2>\n\n<h3>¿Estas seguro de eliminar esta habilidad?</h3>\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            Nombre de la Habilidad:\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 16 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
       Write(Html.DisplayFor(model => model.habilidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            Calificacion de la Habilidad:\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 24 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
       Write(Html.DisplayFor(model => model.calificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n");
#nullable restore
#line 28 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
           Write(Html.HiddenFor(model => model.idHabilidad));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
                           Write(Html.HiddenFor(model => model.habilidad));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
                                           Write(Html.HiddenFor(model => model.calificacion));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
                                                           Write(Html.HiddenFor(model => model.idUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                <div class=""form-actions no-color"">
                                                                                    <input type=""submit"" name=""response"" value=""Eliminar Habilidad""");
            BeginWriteAttribute("formaction", " formaction=", 1188, "", 1223, 1);
#nullable restore
#line 37 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
WriteAttributeValue("", 1200, Url.Action("Eliminar"), 1200, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-danger\" />\n\n                                                                                </div>");
#nullable restore
#line 39 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"mt-3\">\n    ");
#nullable restore
#line 42 "C:\UNICAESWEB\DPWPractica\parcialFinalWeb\parcialFinalWeb\Views\habilidades\EliminarHabilidad.cshtml"
Write(Html.ActionLink("Regresar a la lista", "Index", null, new { id = Model.idUsuario }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<parcialFinalWebEntidades.habilidades> Html { get; private set; }
    }
}
#pragma warning restore 1591

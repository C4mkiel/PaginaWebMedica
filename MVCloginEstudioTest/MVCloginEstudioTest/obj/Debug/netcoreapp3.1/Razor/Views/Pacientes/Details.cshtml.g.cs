#pragma checksum "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd3232db60903fcbde7f095872b986c12ba1c32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_Details), @"mvc.1.0.view", @"/Views/Pacientes/Details.cshtml")]
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
#line 1 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\_ViewImports.cshtml"
using MVCloginEstudioTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\_ViewImports.cshtml"
using MVCloginEstudioTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd3232db60903fcbde7f095872b986c12ba1c32", @"/Views/Pacientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b2ab796ef05672a683c43d588b941cc7d67409", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCloginEstudioTest.Models.Pacientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles del paciente</h1>\r\n\r\n<div>\r\n    <h4>Paciente</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombrePaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombrePaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApellidoPaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApellidoPaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MotConsulta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.MotConsulta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consulta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consulta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
 if (Model.Atencion != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Atencion medica</h2>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n        <th>Alergias</th>\r\n        <th>Signo vital</th>\r\n        <th>Enfermedad cronica</th>\r\n        <th>Diagnostico</th>\r\n        <th>Tratamiento</th>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
             foreach (var item in Model.Atencion)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Alergias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SignoVital));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnfermedadCronica));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Diagnostico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tratamiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 77 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 81 "C:\Users\camil\source\repos\MVCloginEstudioTest\MVCloginEstudioTest\Views\Pacientes\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.IdPaciente }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd3232db60903fcbde7f095872b986c12ba1c3211251", async() => {
                WriteLiteral("Ir a la lista de pacientes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCloginEstudioTest.Models.Pacientes> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9727ba641fa9f36b888c021a2ca6c6a6c4f940cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonagemHabilidades_Create), @"mvc.1.0.view", @"/Views/PersonagemHabilidades/Create.cshtml")]
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
#line 1 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9727ba641fa9f36b888c021a2ca6c6a6c4f940cc", @"/Views/PersonagemHabilidades/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonagemHabilidades_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemHabilidadesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
   ViewBag.Title = "create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Cadastro de habilidades para ");
#nullable restore
#line 5 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
                            Write(Model.Personagem.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 13 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
       Write(Html.LabelFor(model => model.PersonagemId, htmlAttributes: new { @class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 15 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
           Write(Html.EditorFor(model => model.PersonagemId, new { htmlAttributes = new 
                    { @class = "form-control", @readonly = "readonly"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 20 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
       Write(Html.LabelFor(model => model.Habilidade, htmlAttributes: new { @class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"cold-md-6\">\r\n                ");
#nullable restore
#line 22 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
           Write(Html.DropDownListFor(model => model.HabilidadeId, new SelectList(@ViewBag.ListaHabilidades, "Id", "Nome"),
                    "---Selecione---", new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-primary\"/>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 34 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
Write(Html.ActionLink("Retornar", "Index", "PersonagemHabilidades", new{id = Model.PersonagemId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemHabilidadesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

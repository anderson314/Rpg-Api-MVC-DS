#pragma checksum "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa1f6b5d4856c1f1a39081cc783a4c8f9a10dd3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_CadastrarUsuario), @"mvc.1.0.view", @"/Views/Usuario/CadastrarUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa1f6b5d4856c1f1a39081cc783a4c8f9a10dd3e", @"/Views/Usuario/CadastrarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_CadastrarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.UsuarioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
  
    ViewBag.Title = "Registrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Criação de novos usuários</h2>\r\n<hr>\r\n");
#nullable restore
#line 15 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
 using (Html.BeginForm("Registrar", "Usuarios", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Usuário</label>\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 22 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
           Write(Html.EditorFor(model => model.Username, new { htmlAttributes = new { @class = "form-control"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Senha</label>\r\n            <div class=\"col-md-2\">\r\n                ");
#nullable restore
#line 28 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
           Write(Html.PasswordFor(model => model.PasswordString, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <input type=\"submit\" value=\"Registrar\" class=\"btn  btn-primary\">\r\n        ");
#nullable restore
#line 32 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
   Write(Html.ActionLink("Retornar", "Index", "Home", null, new { @class = "btn btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Usuario\CadastrarUsuario.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.UsuarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

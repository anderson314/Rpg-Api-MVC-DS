#pragma checksum "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d46352078286db38d0b37f6d38f25472d90cc4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arma_Index), @"mvc.1.0.view", @"/Views/Arma/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d46352078286db38d0b37f6d38f25472d90cc4b", @"/Views/Arma/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Arma_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.ArmaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
        ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Relação de Armas</h2>\r\n<p>\r\n    ");
#nullable restore
#line 6 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
Write(Html.ActionLink("Criar nova Arma", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 11 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 14 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 24 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 27 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 30 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 33 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.ActionLink("Editar", "Edit", new { id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 34 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 35 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
       Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\ander\Desktop\Curso Des. Sis\2° Modulo\Desenvolvimento de Sistemas\Projeto RpgAPi\RpgMvc\Views\Arma\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.ArmaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

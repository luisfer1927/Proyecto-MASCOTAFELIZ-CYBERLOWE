#pragma checksum "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f13116f5a9f54f64a1e407c374b5150a57563a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Propietario.Pages_Propietario_List), @"mvc.1.0.razor-page", @"/Pages/Propietario/List.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Propietario
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
#line 1 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13116f5a9f54f64a1e407c374b5150a57563a4b", @"/Pages/Propietario/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Propietario_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de propietarios de mascotas</h1>\r\n<table class=\"table\">\r\n");
#nullable restore
#line 7 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
     foreach (var Propietario in Model.Propietarios)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
           Write(Propietario.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\proyecto\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Propietario\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.ListModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
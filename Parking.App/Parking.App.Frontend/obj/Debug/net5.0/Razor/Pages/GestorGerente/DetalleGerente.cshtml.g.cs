#pragma checksum "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4103877838c70ba6cbc5b8ac4f2211b84b91591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Parking.App.Frontend.Pages.GestorGerente.Pages_GestorGerente_DetalleGerente), @"mvc.1.0.razor-page", @"/Pages/GestorGerente/DetalleGerente.cshtml")]
namespace Parking.App.Frontend.Pages.GestorGerente
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
#line 1 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\_ViewImports.cshtml"
using Parking.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4103877838c70ba6cbc5b8ac4f2211b84b91591", @"/Pages/GestorGerente/DetalleGerente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5182fab9718811fb5f0fab9a2a7b9acebe20c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestorGerente_DetalleGerente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle del Gerente ");
#nullable restore
#line 5 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml"
                   Write(Model.gerente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ul>\r\n       \r\n        <li>Número de Identificación: ");
#nullable restore
#line 8 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml"
                                 Write(Model.gerente.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Número Telefonico: ");
#nullable restore
#line 9 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml"
                          Write(Model.gerente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Dirección:");
#nullable restore
#line 10 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml"
                 Write(Model.gerente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Correo electronico: ");
#nullable restore
#line 11 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml"
                           Write(Model.gerente.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Contraseña: ");
#nullable restore
#line 12 "D:\Parking\MisionTic-Parking-Criollo-sDevop\Parking.App\Parking.App.Frontend\Pages\GestorGerente\DetalleGerente.cshtml"
                   Write(Model.gerente.Contrasena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n \r\n    \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parking.App.Frontend.Pages.DetalleGerenteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Parking.App.Frontend.Pages.DetalleGerenteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Parking.App.Frontend.Pages.DetalleGerenteModel>)PageContext?.ViewData;
        public Parking.App.Frontend.Pages.DetalleGerenteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

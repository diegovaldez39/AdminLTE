#pragma checksum "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\Formularios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e840b846eb07473b33e857170fe93f9ac295e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Formularios), @"mvc.1.0.view", @"/Views/Home/Formularios.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\_ViewImports.cshtml"
using AdminLTECreativa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\_ViewImports.cshtml"
using AdminLTECreativa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e840b846eb07473b33e857170fe93f9ac295e1", @"/Views/Home/Formularios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24e4690f348caf55d0b8affb5759b50ccab9945", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Formularios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\Formularios.cshtml"
  
    ViewData["Title"] = "Formularios";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Formularios</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 565, 1);
#nullable restore
#line 17 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\Formularios.cshtml"
WriteAttributeValue("", 538, Url.Action("Index","Home"), 538, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"">Formularios</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <!-- Default box -->
                    <div class=""card"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Formularios disponibles</h3>
                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                    <i class=""fas fa-minus""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""card-body"">
                  ");
            WriteLiteral(@"          <div class=""container-fluid"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <!--Formulario 1-->
                                        <div class=""col-md-4"">
                                            <div class=""card-tex-center"">
                                                <div class=""card-block"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2064, "\"", 2110, 1);
#nullable restore
#line 48 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\Formularios.cshtml"
WriteAttributeValue("", 2071, Url.Action("Bonificacion","Solicitud"), 2071, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" class=""card-footer btn bg-primary text-white"">Solicitud de pago de bonificación</a>
                                                </div>
                                            </div>
                                        </div><!--Formulario 1-->
                                        <!--Formulario 2-->
                                        <div class=""col-md-4"">
                                            <div class=""card-tex-center"">
                                                <div class=""card-block"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2708, "\"", 2749, 1);
#nullable restore
#line 56 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\Formularios.cshtml"
WriteAttributeValue("", 2715, Url.Action("HExtras","Solicitud"), 2715, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" class=""card-footer btn bg-primary text-white"">Solicitud de pago de horas extras</a>
                                                </div>
                                            </div>
                                        </div><!--Formulario 2-->
                                        <!--Formulario 3-->
                                        <div class=""col-md-4"">
                                            <div class=""card-tex-center"">
                                                <div class=""card-block"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3347, "\"", 3393, 1);
#nullable restore
#line 64 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\Formularios.cshtml"
WriteAttributeValue("", 3354, Url.Action("AdelSalarial","Solicitud"), 3354, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" class=""card-footer btn bg-primary text-white"">Solicitud de anticipo salarial</a>
                                                </div>
                                            </div>
                                        </div><!--Formulario 3-->
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.card-body -->
                        <div class=""card-footer"">
                            Creativa Consultores
                        </div>
                        <!-- /.card-footer-->
                    </div>
                    <!-- /.card -->
                </div>
            </div>
        </div>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
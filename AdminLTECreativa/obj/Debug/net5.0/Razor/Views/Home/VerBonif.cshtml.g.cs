#pragma checksum "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8298561c0063094ff83977c87051614bdb463b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerBonif), @"mvc.1.0.view", @"/Views/Home/VerBonif.cshtml")]
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
#nullable restore
#line 2 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8298561c0063094ff83977c87051614bdb463b37", @"/Views/Home/VerBonif.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24e4690f348caf55d0b8affb5759b50ccab9945", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerBonif : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminLTECreativa.Models.Solicitude>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8298561c0063094ff83977c87051614bdb463b373699", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>");
#nullable restore
#line 10 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
      Write(Model.Tiposolicitud);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 10 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                         Write(Model.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""../../plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""../../dist/css/adminlte.min.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8298561c0063094ff83977c87051614bdb463b376171", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Content Wrapper. Contains page content -->
        <div class=""content"">
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <h1 style=""text-align:center"">Solicitud pago de ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                                               Write(Model.Tiposolicitud);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <h6");
                BeginWriteAttribute("class", " class=\"", 1309, "\"", 1317, 0);
                EndWriteAttribute();
                WriteLiteral(@">Importante: Dicho pago ser?? sujeto a evaluaci??n por parte de administraci??n y departamento de recursos humanos de Visible Outsource, por lo cual debe ser solicitado con al menos siete d??as de anticipaci??n.</h6>
                </div><!-- /.container-fluid -->
            </section>
            <!-- Main content -->
            <section class=""content"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <!-- left column -->
                        <div class=""col-md-6"">
                            <!-- general form elements -->
                            <div class=""card card-primary"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Datos personales</h3>
                                </div>
                                <!-- /.card-header -->
                                <!-- form start -->
                                <div class=""card-body"">
               ");
                WriteLiteral("                     <div class=\"form-group\">\r\n                                        <label for=\"email\">Correo:</label>\r\n                                        <input type=\"email\" name=\"email\" required class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2567, "\"", 2593, 1);
#nullable restore
#line 50 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 2581, Model.Email, 2581, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly />
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""name"">Nombres:</label>
                                        <input type=""text"" class=""form-control"" name=""name""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2881, "\"", 2906, 1);
#nullable restore
#line 54 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 2895, Model.Name, 2895, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""lastname"">Apellidos:</label>
                                        <input type=""text"" class=""form-control"" name=""lastname""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3202, "\"", 3231, 1);
#nullable restore
#line 58 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 3216, Model.Lastname, 3216, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""dui"">Numero de documento unico de identidad:</label>
                                        <input type=""text"" class=""form-control"" name=""dui""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3546, "\"", 3570, 1);
#nullable restore
#line 62 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 3560, Model.Dui, 3560, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                    </div>
                                </div>
                                <!-- /.card-body -->
                            </div>
                            <!-- /.card -->
                        </div>
                        <!--/.col (left) -->
                        <!-- right column -->
                        <div class=""col-md-6"">
                            <!-- general form elements disabled -->
                            <div class=""card card-warning"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Datos generales</h3>
                                </div>
                                <!-- /.card-header -->
                                <!-- form start -->
                                <div class=""card-body"">
                                    <div class=""form-group"">
                                        <label for=""fecha"">Fecha Solicitado: </lab");
                WriteLiteral("el>\r\n                                        <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4658, "\"", 4684, 1);
#nullable restore
#line 82 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 4672, Model.Fecha, 4672, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly name=\"fecha\" required class=\"form-control\" />\r\n                                    </div>\r\n");
#nullable restore
#line 84 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                     if (Model.Cargo != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"form-group\">\r\n                                            <label for=\"cargo\">Cargo desempe??ado:</label>\r\n                                            <input type=\"text\" class=\"form-control\" name=\"cargo\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5141, "\"", 5167, 1);
#nullable restore
#line 88 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 5155, Model.Cargo, 5155, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                        </div>\r\n");
#nullable restore
#line 90 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"form-group\">\r\n                                        <label for=\"inputGroupSelect01\">Por este medio solicito el pago de ");
#nullable restore
#line 92 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                                                                                      Write(Model.Tiposolicitud);

#line default
#line hidden
#nullable disable
                WriteLiteral(" correspondiente al mes:</label>\r\n                                        <input type=\"text\" class=\"form-control\" name=\"inputGroupSelect01\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5595, "\"", 5619, 1);
#nullable restore
#line 93 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 5609, Model.Mes, 5609, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                    </div>\r\n");
#nullable restore
#line 95 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                     if (Model.Tiposolicitud.Equals("Anticipo Salarial"))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""form-group"">
                                            <label for=""mesdesc"">A descontar del mes de: </label>
                                            <input type=""text"" class=""form-control"" name=""mesdesc""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6069, "\"", 6097, 1);
#nullable restore
#line 99 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 6083, Model.Mesdesc, 6083, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                                <!-- /.card-body -->\r\n\r\n                                <div class=\"card-footer\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 6390, "\"", 6434, 1);
#nullable restore
#line 106 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Home\VerBonif.cshtml"
WriteAttributeValue("", 6397, Url.Action("SolicitudeBonif","Home"), 6397, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-default"">Regresar</a>
                                </div>
                            </div>
                            <!-- /.card -->
                        </div>
                        <!--/.col (right) -->
                    </div>
                    <!-- /.row -->
                </div><!-- /.container-fluid -->
            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->

    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src=""../../plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- bs-custom-file-input -->
    <script src=""../../plugins/bs-custom-file-input/bs-custom-file-input.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""../../dist/js/adminlte.min.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""../../dist/js/demo.js""></script>
    <script type=""text/javasc");
                WriteLiteral("ript\">\r\n        $(document).ready(function () {\r\n            bsCustomFileInput.init();\r\n        });</script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminLTECreativa.Models.Solicitude> Html { get; private set; }
    }
}
#pragma warning restore 1591

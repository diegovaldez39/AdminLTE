#pragma checksum "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Shared\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1c61826ac704e24e3cac419c07ff37514be3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a1c61826ac704e24e3cac419c07ff37514be3e5", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24e4690f348caf55d0b8affb5759b50ccab9945", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Navbar -->
<nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
            <a");
            BeginWriteAttribute("href", " href=\"", 372, "\"", 406, 1);
#nullable restore
#line 10 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Shared\_Navbar.cshtml"
WriteAttributeValue("", 379, Url.Action("Index","Home"), 379, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link"">Home</a>
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
            <a href=""#"" class=""nav-link"">Contact</a>
        </li>
    </ul>
    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">        
        <!-- Notifications Dropdown Menu -->
        <li class=""nav-item d-none d-sm-inline-block"">
            <a");
            BeginWriteAttribute("href", " href=\"", 770, "\"", 808, 1);
#nullable restore
#line 20 "C:\Users\HP\Desktop\AdminLTECreativa\AdminLTECreativa\Views\Shared\_Navbar.cshtml"
WriteAttributeValue("", 777, Url.Action("Logout","Account"), 777, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link"">Cerrar Sesion</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"" role=""button"">
                <i class=""fas fa-th-large""></i>
            </a>
        </li>
    </ul>
</nav>
<!-- /.navbar -->");
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
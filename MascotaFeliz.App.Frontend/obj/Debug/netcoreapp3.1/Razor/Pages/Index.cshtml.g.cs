#pragma checksum "C:\proyectos\MTIC2022G13T1\MascotaFeliz.App.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0632de9f6340c93ace70e4f4e096bcdc75b684c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages
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
#line 1 "C:\proyectos\MTIC2022G13T1\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0632de9f6340c93ace70e4f4e096bcdc75b684c6", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Front/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\proyectos\MTIC2022G13T1\MascotaFeliz.App.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0632de9f6340c93ace70e4f4e096bcdc75b684c64151", async() => {
                WriteLiteral("\r\n\t<meta charset=\"utf-8\">\r\n\t<title>Inicio MF</title>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0632de9f6340c93ace70e4f4e096bcdc75b684c64481", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <link rel=""stylesheet"" href=""./style/menu.css"">
		<link rel=""preconnect"" href=""https://fonts.googleapis.com"">
		<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
		<link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@300;500;700&display=swap"" rel=""stylesheet"">
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0632de9f6340c93ace70e4f4e096bcdc75b684c66691", async() => {
                WriteLiteral(@"
	<style>
        body {
        margin: 0;
        padding: 0;
        font-family: 'Montserrat', sans-serif;
        color: #666;
        background: purple;
        
        font-size: 1em;
        line-height: 1.5em;
        }

        h1 {
            font-size: 2.3em;
            line-height: 1.3em;
            margin: 70px 0 0 0;
            text-align: center;
            font-weight: 300;
        }

        img {
            max-width: 100%;
            text-align: center;
            padding:0 0 0 0;
        }


        /* CABECERA DE PAGINA */


        #main-content {
            background: white;
            margin: 100px  auto;
            padding: 20px;
            text-align: center;

        }

        .content{
            display: flex;
        }


        .Table, th, td {

            border: 1px solid;
        }

        .boton {
            background: #008CBA;
            color: aliceblue;
            font-weight: 600;
            bo");
                WriteLiteral(@"rder: none;
            padding: 0.5rem;
            border-radius: 3px;
            
        }
        
        .boton:hover {
            background:#B5B2B2;
            color: black;
            font-weight: 600;
            padding: 0.5rem;
            cursor: pointer;
        }
        .boton-eliminar{
            background: #A22522;
            color: aliceblue;
            font-weight: 600;
            border: none;
            padding: 0.5rem;
            border-radius: 3px;
        }
        .boton-eliminar:hover{
            background: #B5B2B2;
            color: black;
            font-weight: 600;
            border: none;
            padding: 0.5rem;
            border-radius: 3px;
            cursor: pointer;
        }

        #inicio{
            background-image: linear-gradient(rgba(0,0,0,0.5), rgba(0,0,0,0.5)), url(./IMG/indeximg.jpg) ;
            height: 100vh;
            background-position: center center;
            background-size: cover;
       ");
                WriteLiteral(@"     display: flex;
            flex-direction: column;
            justify-content: center;
            padding-left: 3rem ;
        }

        h2{
            font-size: 5rem;
            
        }
        .titulo-principal{
            color: white;
            width: 100%;
        }
        .cuerpo-principal{
            color: aliceblue;
            font-size: 1.5rem;
            
        }

        #main-footer {
            position: absolute;
            /* bottom: 0; */
            width: 100%;
            background: #333;
            color: white;
            text-align: center;
            padding: 0;
        }

	

    </style>
	<header id=""main-header"">
		
		<a id=""logo-header"" href=""Index.html"">
			<span class=""site-name"">MASCOTA FELIZ</span>
		</a> 

		<nav>
			<ul class=""navegacion"">
				<li><a href=""Index.html"">Inicio</a></li>
				<li><a href=""#"">Mascotas</a>
					<ul> 
						<li class=""menu""><a href=""Crear_Mascota.html"" class=""submenu-primero"">Cre");
                WriteLiteral(@"ar Mascotas</a></li>
						<li><a href=""Consulta_Mascota.html"">Listar Mascotas</a></li> 
					</ul> 
				</li>
				<li><a href=""#"">Propietarios</a>
					<ul> 
						<li><a href=""Crear_Duenos.html"" class=""submenu-primero"">Crear Propietarios</a></li> 
						<li><a href=""Consulta_Duenos.html"">Listar Propietarios</a></li> 
					</ul> 
				</li>
				<li><a href=""#"">Veterinarios</a>
					<ul> 
						<li><a href=""Crear_Veterinarios.html"" class=""submenu-primero"">Crear Veterinario</a></li> 
						<li><a href=""Consulta_Veterinarios.html"">Listar Veterinarios</a></li> 
					</ul> 
				</li>
			</ul>
		</nav>

	</header>
	<main>
		<div></div>
		<section id=""inicio"">
			<div class=""contenedor"">
				<h2 class=""titulo-principal"">Bienvenido</h2>
			</div>
			<div class=""contenedor"">
				<p class=""cuerpo-principal"">Sabemos lo que significan para ti. Por eso, el mejor lugar es Mascota feliz.</p>
			</div>
		</section>

	</main>
	

	
");
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
            WriteLiteral("\r\n\r\n<footer id=\"main-footer\">\r\n\t<p>&copy; 2022 IKIGAI - Grupo 13 - Ciclo 3</p>\r\n</footer>\r\n\r\n\t\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

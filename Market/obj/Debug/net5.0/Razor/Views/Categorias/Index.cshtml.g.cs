#pragma checksum "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d8b5521d251968cab95637af9fc9b7455d67d54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Index), @"mvc.1.0.view", @"/Views/Categorias/Index.cshtml")]
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
#line 1 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\_ViewImports.cshtml"
using Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\_ViewImports.cshtml"
using Market.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
using Market.Core.Application.ViewModels.Categorias;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d8b5521d251968cab95637af9fc9b7455d67d54", @"/Views/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719c0b55ecfa23acf0174c8495de1ca9434b3103", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriaViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categorias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
  
    ViewData["Title"] = "Categorias";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">

  <div class=""row"">
    <div class=""col-12"">
        <div class=""card"">       
             <div class=""card-header bg-dark"">
               <div class=""d-flex justify-content-between align-items-center"">
                <h3 class=""font-weight-bold text-white"">Mantenimiento de Categorias</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d8b5521d251968cab95637af9fc9b7455d67d546225", async() => {
                WriteLiteral("Nueva Categoria");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n               </div>\r\n             </div>\r\n       </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                  if (Model == null || Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-12"">
               <div class=""p-4 mb-3 bg-light rounded mt-2"">
                  <h4 class=""fst-italic text-center"">No hay categorias creadas.</h4>
                  <label class=""text-primary"">Info:</label>
                  <p class=""mb-0 fst-italic"">Crea una nueva categoria o varias categorias.</p>
               </div>
            </div>
");
#nullable restore
#line 29 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
             foreach (CategoriaViewModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                 <div class=""col-4 mt-2"">
                    <div class=""card border-radius bg-black""> 
                        <div class=""card-body border-radius"">
                            <div class=""bg-primary border-radius"">
                                <h4 class=""card-title fst-italic text-white text-center"">");
#nullable restore
#line 38 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                                                                                    Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <hr>\r\n                            <h6 class=\"text-info\">Descripcion:</h6>\r\n                            <p class=\"card-text text-white-50 fst-italic\">");
#nullable restore
#line 42 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                                                                     Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""d-flex justify-content-between align-items-center"">                                                                                        
                              <small class=""font-weight-bold text-white fs-12"">Cant. Articulos: | <font size=""3"" color=""teal"">");
#nullable restore
#line 44 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                                                                                                                         Write(item.CountArti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font> |</small>\r\n                             <small class=\"font-weight-bold text-white fs-12\">Cant. Usuarios: | <font size=\"3\" color=\"cyan\">");
#nullable restore
#line 45 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                                                                                                                       Write(item.CountArti);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</font> |</small>
                            </div>
                            <hr>
                            <div class=""d-grid gap-2 d-md-flex justify-content-md-end mt-1"">
                                <div class=""btn-group"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d8b5521d251968cab95637af9fc9b7455d67d5411509", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d8b5521d251968cab95637af9fc9b7455d67d5414032", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>                               \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
                              
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Categorias\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n       \r\n    </div>\r\n  </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

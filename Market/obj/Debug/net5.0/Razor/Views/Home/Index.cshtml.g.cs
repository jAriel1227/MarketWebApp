#pragma checksum "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f02f735b2f34f71061373dbb1edfb514afaacc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
using Market.Core.Application.ViewModels.Articulos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
using Market.Core.Application.ViewModels.Categorias;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f02f735b2f34f71061373dbb1edfb514afaacc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719c0b55ecfa23acf0174c8495de1ca9434b3103", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticulosViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""card-row"">
        <div class=""col-12"">
          <div class=""card"">
              <div class=""card-header bg-dark"">
                 <div class=""d-flex justify-content-between align-items-center"">
                     <h3 class=""font-weight-bold text-white"">Listado de Anuncios</h3>                     
                 </div>
              </div>
          </div>
    </div>
      <section>
            <div class=""col-3"">
            <div class=""card shadow-sm mt-2"">
                <div class=""card-header bg-dark text-light"">
                    <h4>Filtrar Catg.</h4>
                </div>
                <div class=""card-body bg-light"">
                    <h4 class=""card-title"">Categorias</h4>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f02f735b2f34f71061373dbb1edfb514afaacc5601", async() => {
                WriteLiteral(@"

                        <div class=""mb-3"">
                            <div class=""form-check"">                                
                                <input class=""form-check-input"" type=""checkbox"" name=""IdCategory"" value=""null"" id=""category-all""checked>
                                 <label class=""form-check-label"" for=""category-all"">Todas las categorias</label>
                            </div>
                        </div>

");
#nullable restore
#line 37 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                         foreach (CategoriaViewModel category in ViewBag.Categories)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"mb-3\">\r\n                                <div class=\"form-check\">                                    \r\n                                    <input class=\"form-check-input\" type=\"checkbox\" name=\"IdCategory\"");
                BeginWriteAttribute("value", " value=\"", 1857, "\"", 1877, 1);
#nullable restore
#line 41 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
WriteAttributeValue("", 1865, category.Id, 1865, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1878, "\"", 1904, 2);
                WriteAttributeValue("", 1883, "category-", 1883, 9, true);
#nullable restore
#line 41 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
WriteAttributeValue("", 1892, category.Id, 1892, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1975, "\"", 2002, 2);
                WriteAttributeValue("", 1981, "category-", 1981, 9, true);
#nullable restore
#line 42 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
WriteAttributeValue("", 1990, category.Id, 1990, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                                                                                           Write(category.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 45 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n      </section>\r\n\r\n    </div>\r\n       <div class=\"card-body\">                \r\n           <div class=\"row\">\r\n\r\n");
#nullable restore
#line 57 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                     if (Model == null || Model.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-12"">                       
                          <div class=""p-4 mb-3 bg-light rounded mt-2"">
                              <h4 class=""fst-italic text-center"">No hay anuncios creados.</h4>
                               <label class=""text-primary"">Info:</label>
                               <p class=""mb-0 fst-italic"">Crea un nuevo anuncio o varios anuncios.</p>
                          </div>
                        </div>
");
#nullable restore
#line 66 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                         foreach (ArticulosViewModel item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4\">\r\n                              <div class=\"card shadow-sm border-radius\">\r\n                               <img class=\"db-placebolder-img card-img-top image-size\"");
            BeginWriteAttribute("src", " src=\"", 3364, "\"", 3383, 1);
#nullable restore
#line 73 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
WriteAttributeValue("", 3370, item.Gallery, 3370, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                 <div class=\"card-body color-cont border-radius\">\r\n                                   <h4 class=\"card-title text-white\">");
#nullable restore
#line 75 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                                                                Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                   <hr>\r\n                                   <p class=\"card-text text-white\">");
#nullable restore
#line 77 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                                                              Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                   <div class=\"d-flex justify-content-between align-items-center\">\r\n                                        <small class=\"font-weight-bold text-white fs-12\">");
#nullable restore
#line 79 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                                                                                    Write(item.Categorias.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>   \r\n                                        <small class=\"font-weight-bold text-success fs-12\">$ ");
#nullable restore
#line 80 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                                                                                        Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small> \r\n                                   </div>                             \r\n                                 </div>\r\n                              </div>\r\n                            </div>  \r\n");
#nullable restore
#line 85 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\jarie\source\repos\MarketWepApp\Market\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </div>\r\n       </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArticulosViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

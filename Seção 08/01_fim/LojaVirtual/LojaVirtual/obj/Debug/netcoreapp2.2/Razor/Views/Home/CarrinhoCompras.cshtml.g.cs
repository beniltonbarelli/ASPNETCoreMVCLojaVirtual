#pragma checksum "C:\Users\Benilton Barelli\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 08\01_fim\LojaVirtual\LojaVirtual\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarrinhoCompras.cshtml", typeof(AspNetCore.Views_Home_CarrinhoCompras))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae", @"/Views/Home/CarrinhoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Benilton Barelli\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 08\01_fim\LojaVirtual\LojaVirtual\Views\Home\CarrinhoCompras.cshtml"
  
    ViewData["Title"] = "CarrinhoCompras";

#line default
#line hidden
            BeginContext(53, 2057, true);
            WriteLiteral(@"
<main role=""main"">





    <section class=""container"" id=""order"" style=""margin-top: 50px"">

        <h2 class=""title-doc""># Order </h2>


        <h4 class=""subtitle-doc"">
            # Shopping cart
            <a href=""#"" data-html=""code_cart"" class=""showcode"">[code]</a>
        </h4>
        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table table-hover shopping-cart-wrap"">
                    <thead class=""text-muted"">
                        <tr>
                            <th scope=""col"">Product</th>
                            <th scope=""col"" width=""120"">Quantity</th>
                            <th scope=""col"" width=""120"">Price</th>
                            <th scope=""col"" width=""200"" class=""text-right"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <figure class=""media"">
             ");
            WriteLiteral(@"                       <div class=""img-wrap""><img src=""images/items/1.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                           ");
            WriteLiteral("         ");
            EndContext();
            BeginContext(2110, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae5516", async() => {
                BeginContext(2118, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2128, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2166, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae6723", async() => {
                BeginContext(2174, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2184, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2222, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae7930", async() => {
                BeginContext(2230, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2240, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2278, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae9137", async() => {
                BeginContext(2286, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2296, 2013, true);
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 145</var>
                                    <small class=""text-muted"">(USD5 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                   data-original-title=""Save to Wishlist""> <i class=""fa fa-heart""></i></a>
                                <a href="""" class=""btn btn-outline-danger""> × Remove</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <figure class=""media"">
                                    <div class=""img-wrap""");
            WriteLiteral(@"><img src=""images/items/2.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                                    ");
            EndContext();
            BeginContext(4309, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae12394", async() => {
                BeginContext(4317, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4327, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4365, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae13602", async() => {
                BeginContext(4373, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4383, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4421, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae14810", async() => {
                BeginContext(4429, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4439, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4477, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae16018", async() => {
                BeginContext(4485, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4495, 2023, true);
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 35</var>
                                    <small class=""text-muted"">(USD10 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                   data-original-title=""Save to Wishlist""> <i class=""fa fa-heart""></i></a>
                                <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <figure class=""media"">
                                    <div class=");
            WriteLiteral(@"""img-wrap""><img src=""images/items/3.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                                    ");
            EndContext();
            BeginContext(6518, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae19286", async() => {
                BeginContext(6526, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6536, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6574, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae20494", async() => {
                BeginContext(6582, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6592, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6630, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae21702", async() => {
                BeginContext(6638, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6648, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6686, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a07e9e10d2e088fa1ed6abd2dd26cac4b674ae22910", async() => {
                BeginContext(6694, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6704, 4594, true);
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 45</var>
                                    <small class=""text-muted"">(USD15 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                   data-original-title=""Save to Wishlist""> <i class=""fa fa-heart""></i></a>
                                <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div> <!-- card.// -->
        </div> <!-- code-wrap.// -->
    </section>
    <br />
    <br ");
            WriteLiteral(@"/>
    <section class=""container"">
        <div class=""row"">
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Cálculo de frete
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Some info: </dt>
                            <dd>
                                Dolor sit amet, consectetur adipisicing elit do eiusmod
                                tempor incididunt
                            </dd>
                        </dl>
                        <dl>
                            <dt>Parameter: </dt>
                            <dd>Value name</dd>
                        </dl>
                        <dl>
                            <dt>Discount:</dt>
                            <dd>USD 658</dd>
                        </dl>
       ");
            WriteLiteral(@"             </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Cupom desconto
                    <a href=""#"" data-html=""code_desc_align"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_align"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Some info: </dt>
                            <dd> Everything in this life is always tempporary</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Parameter: </dt>
                            <dd>Value name</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Color:</dt>
                            <dd>Orange and Black</dd>
                        </dl>
                        <dl c");
            WriteLiteral(@"lass=""dlist-align"">
                            <dt>Material:</dt>
                            <dd>Leather</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Total a pagar
                    <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_right"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Parameter: </dt>
                            <dd class=""text-right"">Value name</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Color:</dt>
                            <dd class=""text-right"">Orange and Black</dd>
                        </dl>
                        <dl class=""dlist-align"">
    ");
            WriteLiteral(@"                        <dt>Material:</dt>
                            <dd class=""text-right"">Leather</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Total cost: </dt>
                            <dd class=""text-right h5 b""> USD195 </dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
        </div>
    </section>
</main>

");
            EndContext();
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

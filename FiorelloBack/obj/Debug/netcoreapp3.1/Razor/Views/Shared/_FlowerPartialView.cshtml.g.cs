#pragma checksum "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f8b9901960bdd1b61a8d6a6902045971b41ab08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FlowerPartialView), @"mvc.1.0.view", @"/Views/Shared/_FlowerPartialView.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f8b9901960bdd1b61a8d6a6902045971b41ab08", @"/Views/Shared/_FlowerPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15b2ec63cc027bd18e29e820bbf24b1f12b23dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FlowerPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Flower>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "flower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-aos-offset", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
 foreach (Flower flower in Model)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f8b9901960bdd1b61a8d6a6902045971b41ab084513", async() => {
                WriteLiteral("\r\n    <div >\r\n        <div class=\"productImage\">\r\n");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
             foreach (FlowerImage image in flower.FlowerImages)
            {


                if (image.isMain)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <img");
                BeginWriteAttribute("src", " src=\"", 588, "\"", 606, 1);
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
WriteAttributeValue("", 594, image.Image, 594, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 607, "\"", 639, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"productTitle\">\r\n            <p>");
#nullable restore
#line 28 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
          Write(flower.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"productPrice\">\r\n");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
             if (flower.CampaignId == null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"addToCardBtn\" data-id=\"");
#nullable restore
#line 33 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                               Write(flower.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Add to cart</span><span>$</span><span>");
#nullable restore
#line 33 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                                                 Write(flower.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span class=\"addToCardBtn\" data-id=\"");
#nullable restore
#line 37 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                               Write(flower.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Add to cart</span><span style=\"text-decoration: line-through;\">$");
#nullable restore
#line 37 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                                                                           Write(flower.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                <span>$</span><span>");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                Write(flower.Price * (100 - flower.Campaign.DiscountPercent)/100);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div class=\"addToCart\">\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                  WriteLiteral(flower.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 174, "product", 174, 7, true);
            AddHtmlAttributeValue(" ", 181, "col-lg-3", 182, 9, true);
            AddHtmlAttributeValue(" ", 190, "col-md-6", 191, 9, true);
            AddHtmlAttributeValue("\r\n             ", 199, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
              foreach (FlowerCategory flowerCategory in flower.FlowerCategories)
	{
		 

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
     Write(flowerCategory.Category.Name.ToLower() + " ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                        ;
             }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 214, 142, false);
            AddHtmlAttributeValue("\r\n             ", 356, "all", 371, 18, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\FiorelloBack\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Flower>> Html { get; private set; }
    }
}
#pragma warning restore 1591
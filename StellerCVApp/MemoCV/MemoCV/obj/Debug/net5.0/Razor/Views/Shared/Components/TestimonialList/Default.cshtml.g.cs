#pragma checksum "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a31ad3c732fbeea30ce54f2a0a972cea29e0276fcc1954dc0dc0b2b943bcb87d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a31ad3c732fbeea30ce54f2a0a972cea29e0276fcc1954dc0dc0b2b943bcb87d", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2f4f056741db09c5b51dcaadcde0f68c0f1f606638a5fd3144a887667eb0e306", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""testmonial"" class=""section"">
    <div class=""container text-center"">
        <h6 class=""subtitle"">Referanslarım</h6>
        <h6 class=""section-title mb-4"">İnsanlar Hakkımda Ne Düşünüyor?</h6>
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
");
#nullable restore
#line 14 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                 foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"carousel-item active\">\n                    <div class=\"card testmonial-card border\">\n                        <div class=\"card-body\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 960, "\"", 980, 1);
            WriteAttributeValue("", 966, 
#nullable restore
#line 18 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                                       item.ImageURL

#line default
#line hidden
#nullable disable
            , 966, 14, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 981, "\"", 987, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <p>");
            Write(
#nullable restore
#line 19 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                                item.Comment

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\n                            <h1 class=\"title\">");
            Write(
#nullable restore
#line 20 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                                               item.ClientName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\n                            <h1 class=\"subtitle\">");
            Write(
#nullable restore
#line 21 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                  item.Company

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 25 "C:\Users\Mhmtnr\Desktop\CVApp-main\MemoCV\MemoCV\Views\Shared\Components\TestimonialList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
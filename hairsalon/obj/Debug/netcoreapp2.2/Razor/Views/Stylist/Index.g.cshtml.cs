#pragma checksum "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c129d36f1123062d155b035269f5426168aa1527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_Index), @"mvc.1.0.view", @"/Views/Stylist/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylist/Index.cshtml", typeof(AspNetCore.Views_Stylist_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c129d36f1123062d155b035269f5426168aa1527", @"/Views/Stylist/Index.cshtml")]
    public class Views_Stylist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
  Html.RenderPartial("_navbar"); 

#line default
#line hidden
            BeginContext(35, 32, true);
            WriteLiteral("<h1>List of Stylists</h1>\n\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
   foreach(var stylist in Model)
  {

#line default
#line hidden
            BeginContext(104, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 110, "\"", 141, 2);
            WriteAttributeValue("", 117, "Stylist/", 117, 8, true);
#line 7 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
WriteAttributeValue("", 125, stylist.GetId(), 125, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(142, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(144, 17, false);
#line 7 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
                                  Write(stylist.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(161, 8, true);
            WriteLiteral(" Level: ");
            EndContext();
            BeginContext(170, 18, false);
#line 7 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
                                                            Write(stylist.GetLevel());

#line default
#line hidden
            EndContext();
            BeginContext(188, 9, true);
            WriteLiteral("</a><br>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(201, 46, true);
            WriteLiteral("</ul>\n\n<a href=/stylist/new>ADD A STYLIST</a>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
 if(Model.Count > 0)
{

#line default
#line hidden
            BeginContext(270, 39, true);
            WriteLiteral("  <a href=/client/new>ADD A CLIENT</a>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Index.cshtml"
}

#line default
#line hidden
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

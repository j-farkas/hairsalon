#pragma checksum "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d582a356957d4f4a6180eda722ee2c447c444fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_Show), @"mvc.1.0.view", @"/Views/Stylist/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylist/Show.cshtml", typeof(AspNetCore.Views_Stylist_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d582a356957d4f4a6180eda722ee2c447c444fb5", @"/Views/Stylist/Show.cshtml")]
    public class Views_Stylist_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
  Html.RenderPartial("_navbar"); 

#line default
#line hidden
            BeginContext(35, 31, true);
            WriteLiteral("<h1>List of Clients</h1>\n\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
   foreach(var client in Model)
  {

#line default
#line hidden
            BeginContext(102, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 108, "\"", 138, 2);
            WriteAttributeValue("", 115, "/Client/", 115, 8, true);
#line 7 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 123, client.GetId(), 123, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(139, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(141, 16, false);
#line 7 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
                                 Write(client.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(157, 9, true);
            WriteLiteral("</a><br>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(170, 83, true);
            WriteLiteral("</ul>\n\n<a href=/stylist/new>ADD A STYLIST</a>\n<a href=/client/new>ADD A CLIENT</a>\n");
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
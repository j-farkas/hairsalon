#pragma checksum "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091fa22b0be1a0b89a581cd6f0c92d19450ccb57"
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
#line 2 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091fa22b0be1a0b89a581cd6f0c92d19450ccb57", @"/Views/Stylist/Show.cshtml")]
    public class Views_Stylist_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
  Html.RenderPartial("_navbar"); 

#line default
#line hidden
            BeginContext(60, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(66, 15, false);
#line 4 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
Write(Model.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(81, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(85, 22, false);
#line 4 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
                  Write(Model.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(107, 17, true);
            WriteLiteral("</h2>\n<h4>Level: ");
            EndContext();
            BeginContext(125, 16, false);
#line 5 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
      Write(Model.GetLevel());

#line default
#line hidden
            EndContext();
            BeginContext(141, 10, true);
            WriteLiteral("</h4>\n<h4>");
            EndContext();
            BeginContext(152, 23, false);
#line 6 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
Write(Model.GetScissorsName());

#line default
#line hidden
            EndContext();
            BeginContext(175, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(179, 19, false);
#line 6 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
                          Write(Model.GetScissors());

#line default
#line hidden
            EndContext();
            BeginContext(198, 27, true);
            WriteLiteral(" </h4>\n<h6>Hair Collected: ");
            EndContext();
            BeginContext(226, 15, false);
#line 7 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
               Write(Model.GetHair());

#line default
#line hidden
            EndContext();
            BeginContext(241, 36, true);
            WriteLiteral("</h6>\n<h6>Hair Needed to next level:");
            EndContext();
            BeginContext(278, 20, false);
#line 8 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
                         Write(Model.GetNextLevel());

#line default
#line hidden
            EndContext();
            BeginContext(298, 18, true);
            WriteLiteral("</h6>\n<h1>List of ");
            EndContext();
            BeginContext(317, 15, false);
#line 9 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
       Write(Model.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(332, 22, true);
            WriteLiteral("\'s Clients:</h1>\n<ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
   foreach(var client in @Client.GetClients(@Model.GetId()))
  {

#line default
#line hidden
            BeginContext(419, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 425, "\"", 455, 2);
            WriteAttributeValue("", 432, "/Client/", 432, 8, true);
#line 13 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 440, client.GetId(), 440, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(456, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(458, 16, false);
#line 13 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
                                 Write(client.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(474, 9, true);
            WriteLiteral("</a><br>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(487, 83, true);
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

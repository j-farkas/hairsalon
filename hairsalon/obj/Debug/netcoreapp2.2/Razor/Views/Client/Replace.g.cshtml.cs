#pragma checksum "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82005658b71e53c492f93929525a0c31d5ca8096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Replace), @"mvc.1.0.view", @"/Views/Client/Replace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Replace.cshtml", typeof(AspNetCore.Views_Client_Replace))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82005658b71e53c492f93929525a0c31d5ca8096", @"/Views/Client/Replace.cshtml")]
    public class Views_Client_Replace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
  Html.RenderPartial("_navbar"); 

#line default
#line hidden
            BeginContext(35, 11, true);
            WriteLiteral("<p>Replace ");
            EndContext();
            BeginContext(47, 15, false);
#line 2 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
      Write(Model.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(62, 3, true);
            WriteLiteral("\'s ");
            EndContext();
            BeginContext(66, 23, false);
#line 2 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
                         Write(Model.GetScissorsName());

#line default
#line hidden
            EndContext();
            BeginContext(89, 6, true);
            WriteLiteral(" With ");
            EndContext();
            BeginContext(96, 19, false);
#line 2 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
                                                       Write(Model.GetDropInfo());

#line default
#line hidden
            EndContext();
            BeginContext(115, 21, true);
            WriteLiteral("?</p>\n\n<form class=\"\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 136, "\"", 176, 3);
            WriteAttributeValue("", 145, "/Stylist/", 145, 9, true);
#line 4 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
WriteAttributeValue("", 154, Model.GetId(), 154, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 168, "/Replace", 168, 8, true);
            EndWriteAttribute();
            BeginContext(177, 119, true);
            WriteLiteral(" method=\"post\">\n<input type=\"hidden\" id=\"change\" name=\"change\" value=\"true\">\n<input type=\"hidden\" id=\"drop\" name=\"drop\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 296, "\"", 324, 1);
#line 6 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
WriteAttributeValue("", 304, Model.GetDropInfo(), 304, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(325, 60, true);
            WriteLiteral(">\n<button type=\"submit\">Yes</button>\n</form>\n\n<form class=\"\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 385, "\"", 425, 3);
            WriteAttributeValue("", 394, "/Stylist/", 394, 9, true);
#line 10 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Client/Replace.cshtml"
WriteAttributeValue("", 403, Model.GetId(), 403, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 417, "/Replace", 417, 8, true);
            EndWriteAttribute();
            BeginContext(426, 120, true);
            WriteLiteral(" method=\"post\">\n<input type=\"hidden\" id=\"change\" name=\"change\" value=\"false\">\n<button type=\"submit\">No</button>\n</form>\n");
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

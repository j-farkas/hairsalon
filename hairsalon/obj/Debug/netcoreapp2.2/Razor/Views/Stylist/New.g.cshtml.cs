#pragma checksum "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96ba76711ca5ff70eee3777fcb7c5515742f14f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_New), @"mvc.1.0.view", @"/Views/Stylist/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylist/New.cshtml", typeof(AspNetCore.Views_Stylist_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96ba76711ca5ff70eee3777fcb7c5515742f14f", @"/Views/Stylist/New.cshtml")]
    public class Views_Stylist_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/hairsalon/hairsalon/Views/Stylist/New.cshtml"
  Html.RenderPartial("_navbar"); 

#line default
#line hidden
            BeginContext(35, 296, true);
            WriteLiteral(@"<form class="""" action=""/Stylist"" method=""post"">
  <label for=""name"">Name: </label>
  <input id=""name"" name=""name"" type=""text""><br><br>
  <label for=""description"">Description: </label>
  <input id=""description"" name=""description"" type=""text""><br><br>
<button type=""submit"">Submit</button>
</form>
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
#pragma checksum "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2b789dee6bfbc0f085439fc3bb042e241caa06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Processes_Modules), @"mvc.1.0.view", @"/Views/Processes/Modules.cshtml")]
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
#line 1 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\_ViewImports.cshtml"
using ProcessManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\_ViewImports.cshtml"
using ProcessManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2b789dee6bfbc0f085439fc3bb042e241caa06", @"/Views/Processes/Modules.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd28f61673038dac782f044bce86dacf3cbf2fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Processes_Modules : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Processes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
  
    ViewData["Title"] = "Modules";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Modules of ");
#nullable restore
#line 8 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
#nullable restore
#line 9 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
Write(Html.ActionLink("< Go back", "Index", "Processes", null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Path</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
         foreach (ProcessModule module in Model.Modules)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 22 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
               Write(module.ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 23 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
               Write(module.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Processes\Modules.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Processes> Html { get; private set; }
    }
}
#pragma warning restore 1591
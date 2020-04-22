#pragma checksum "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95ad16e15975ed195c49dad09bced20dc570e42d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProcessesView), @"mvc.1.0.view", @"/Views/Shared/ProcessesView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ad16e15975ed195c49dad09bced20dc570e42d", @"/Views/Shared/ProcessesView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd28f61673038dac782f044bce86dacf3cbf2fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProcessesView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Processes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
 foreach (var process in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            <div class=\"btn-group-sm text-center\">\r\n                ");
#nullable restore
#line 8 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
           Write(Html.ActionLink("Modules", "Modules", "Processes", new { id = process.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 9 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
           Write(Html.ActionLink("Threads", "Threads", "Processes", new { id = process.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 10 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
           Write(Html.ActionLink("Stop", "Remove", "Processes", new { id = process.Id }, new { style="color: red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
           Write(Html.ActionLink("Folder", "OpenFolder", "Processes", new { id = process.Id }, new { style = "color: green;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.Cpu.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.Memory.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.Thread);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.FilePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
       Write(process.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\TR2\Desktop\ProcessManager\ProcessManager\Views\Shared\ProcessesView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Processes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
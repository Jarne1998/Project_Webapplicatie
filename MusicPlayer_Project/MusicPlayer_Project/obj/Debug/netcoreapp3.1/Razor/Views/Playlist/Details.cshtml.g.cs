#pragma checksum "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Playlist\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a82e0a002f2077d3e1220b5b265ccef5476d9b1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Playlist_Details), @"mvc.1.0.view", @"/Views/Playlist/Details.cshtml")]
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
#line 1 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\_ViewImports.cshtml"
using MusicPlayer_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\_ViewImports.cshtml"
using MusicPlayer_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82e0a002f2077d3e1220b5b265ccef5476d9b1c", @"/Views/Playlist/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0585917027de4af064080aa831b9c4f12bbb675a", @"/Views/_ViewImports.cshtml")]
    public class Views_Playlist_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicPlayer_Project.ViewModels.PlaylistDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Playlist\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Playlist\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    Voornaam: ");
#nullable restore
#line 10 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Playlist\Details.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Datum aangemaakt ");
#nullable restore
#line 13 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Playlist\Details.cshtml"
                Write(Html.DisplayFor(ModelItem => Model.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\jarne\Desktop\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Playlist\Details.cshtml"
Write(Html.ActionLink("terug", "index", "Playlist"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicPlayer_Project.ViewModels.PlaylistDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

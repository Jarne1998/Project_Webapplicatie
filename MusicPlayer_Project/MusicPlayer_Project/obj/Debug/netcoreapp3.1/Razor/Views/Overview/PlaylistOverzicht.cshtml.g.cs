#pragma checksum "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6529f7b09314cbf19bf3697428392046b1a66a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Overview_PlaylistOverzicht), @"mvc.1.0.view", @"/Views/Overview/PlaylistOverzicht.cshtml")]
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
#line 1 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\_ViewImports.cshtml"
using MusicPlayer_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\_ViewImports.cshtml"
using MusicPlayer_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6529f7b09314cbf19bf3697428392046b1a66a8c", @"/Views/Overview/PlaylistOverzicht.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0585917027de4af064080aa831b9c4f12bbb675a", @"/Views/_ViewImports.cshtml")]
    public class Views_Overview_PlaylistOverzicht : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicPlayer_Project.ViewModels.PlaylistOverviewViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml"
   
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml"
     foreach (var playlist in Model.Playlists)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-md-4\" style=\"float: left;\">\r\n            <img class=\"card-img-top\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\"><strong>");
#nullable restore
#line 13 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml"
                                        Write(playlist.NamePlaylist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>Bevat:</p>\r\n                <ul>\r\n                    <li>");
#nullable restore
#line 16 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml"
                   Write(playlist.SongsInPlaylist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 17 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml"
                   Write(playlist.DateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Overview\PlaylistOverzicht.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicPlayer_Project.ViewModels.PlaylistOverviewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

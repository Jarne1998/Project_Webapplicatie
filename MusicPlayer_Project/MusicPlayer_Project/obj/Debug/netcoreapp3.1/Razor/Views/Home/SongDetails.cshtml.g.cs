#pragma checksum "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937790c1b5364ac375ae9f767f0b708291f45796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SongDetails), @"mvc.1.0.view", @"/Views/Home/SongDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937790c1b5364ac375ae9f767f0b708291f45796", @"/Views/Home/SongDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0585917027de4af064080aa831b9c4f12bbb675a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SongDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicPlayer_Project.ViewModels.SongDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th class=\"col-md-2\">\r\n                ");
#nullable restore
#line 11 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml"
           Write(Html.DisplayNameFor(v => v.Songs[0].SongID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml"
         foreach (var playlist in Model.Songs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml"
               Write(Html.DisplayFor(modelItem => playlist.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\jarne\Documents\ThomasMore\ThomasMore\Projecten\Project_Webapplicatie\MusicPlayer_Project\MusicPlayer_Project\Views\Home\SongDetails.cshtml"
Write(Html.ActionLink("Back", "index", "Home"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicPlayer_Project.ViewModels.SongDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
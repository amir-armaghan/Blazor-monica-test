#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Help.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1889c4a94df3d85e04bc04110895d9f473aaab1"
// <auto-generated/>
#pragma warning disable 1591
namespace blzZmq1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using blzZmq1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using blzZmq1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using NetMQ.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/help")]
    public partial class Help : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>How to Use Monica Interface</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n\r\n    <p>\r\n        To use Monica service you need to have at least 4 files with\r\n        these names: Sim.json Site.json, Crop.json, and Climate.csv.  You may also need\r\n        a few JSON files as parameters.\r\n    </p>\r\n\r\n    <p>\r\n        Since this web interface does not have access to users’\r\n        local directories, you need to upload your Sim, Site, Crop and Climate files\r\n        into the program, and if there is any link to the parameters, those JSON parameter\r\n        files should be accessible in your github repository. So the program can read\r\n        them from your github repository.\r\n    </p>\r\n\r\n    <p>\r\n        Note: You can also use this program if any of these files\r\n        are missing (we will use some default data), but remember; this case is only\r\n        for testing purposes (e.g. for students).\r\n    </p>\r\n\r\n    <p><b>Login to your github</b></p>\r\n\r\n    <p>\r\n        You can find the login box on the Home page.\r\n        Just use your normal github username and password.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"541\" height=\"426\" src=\"help/image001.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        If you don’t log in to your github, you can\r\n        still use this program, but some features will not be enabled.\r\n    </p>\r\n\r\n    <p class=\"MsoListParagraphCxSpLast\">&nbsp;</p>\r\n\r\n    <p><b>Upload Data:</b></p>\r\n\r\n    <p>\r\n        Use this page to upload your Sim, Site, Crop,\r\n        and climate files. (sim, site and crop files are in JSON format and the climate\r\n        file is in CSV format).\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"751\" height=\"532\" id=\"Picture 3\" src=\"help/image002.jpg\">\r\n    </p>\r\n\r\n    <p>\r\n        Be careful that the name of the files must\r\n        correctly start with (sim/site/crop or climate). Please note that if you upload\r\n        two or more files with the same structure (e.g. two sim files), the system will\r\n        ignore the second one and you may confuse which file has been used to make the\r\n        result.\r\n    </p>\r\n\r\n    <p>\r\n        Please note that if you don’t upload one of\r\n        these files, the system will ask you a confirmation and then you need to\r\n        approve that a sample file will be used instead of the missing file. (We\r\n        activated these default values only for educational purposes).\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        If you are logged into your github, you\r\n        will have some options at the bottom of this page.\r\n    </p>\r\n\r\n    <p>\r\n        <b>\r\n            Read Monica parameters from the Default\r\n            server:\r\n        </b> will read the parameters form sample data if it is mentioned in\r\n        your sim/site/crop file.\r\n    </p>\r\n\r\n    <p>\r\n        <b>Read Monica parameters from your github</b>:\r\n        will show you a box to enter your parameters path in your github repository.\r\n        You can copy the path from your browser when you are in your github. Please see\r\n        the image blew\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"752\" height=\"538\" src=\"help/image003.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        Please note that this app will ignore the “include-file-base-path”\r\n        option inside your sim/crop/site and will use the path which is defined here in\r\n        this page. This is especially notable for old Monica users who needed to set the\r\n        path of the parameters inside the main files.\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        When you send your request to the Monica\r\n        ZMQ server, the app needs some time to read and merge your data, send it to the\r\n        simulator and show the result to you. If your files are big or you have many\r\n        parameters, reading from your local machine or github is not real-time and\r\n        takes a little bit of time.\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        This app can also provide the results in\r\n        two ways for you.\r\n    </p>\r\n\r\n    <p>\r\n        <b>Show me a download link:</b> your result\r\n        will be saved on our server for a few days. You can download the results in\r\n        JSON and CSV format or you can copy the link and share it with other people. So\r\n        others just need to have this unique link to see your result. We recommend you\r\n        to download your result if you need it for further use, because depending on\r\n        the server load, old results will be deleted time by time.\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        <b>Export into my github</b>: This option\r\n        will ask you a path to your github to put/commit your results there. We suggest\r\n        you to use the same path as your parameters on your github.\r\n    </p>\r\n\r\n    <p>\r\n        Please note that the path is absolute and\r\n        doesn’t have “/” at its end.\r\n    </p>\r\n\r\n    <p class=\"MsoListParagraphCxSpLast\">&nbsp;</p>\r\n\r\n    <p><b>Results’ chart</b></p>\r\n\r\n    <p>\r\n        On this page you have three options to load\r\n        your results on a chart.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"753\" height=\"395\" id=\"Picture 1\" src=\"help/image004.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        If you are logged in, and you have entered\r\n        a right path in\r\n    </p>\r\n\r\n    <p>\r\n        Upload Data <span style=\"font-family:Wingdings\">à</span>\r\n        Result Options <span style=\"font-family:Wingdings\">à</span> Export it into my\r\n        github<span style=\"font-family:Wingdings\">à</span> github Path\r\n    </p>\r\n\r\n    <p>\r\n        And you have some results inside this\r\n        directory in your repository, then you can select your result among them.\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        <img width=\"753\" height=\"395\" id=\"Picture 2\" src=\"help/image005.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        By selecting one, the system will read your\r\n        JSON result from your repository and will show you an option to choose your\r\n        Chart Group\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"753\" height=\"433\" id=\"Picture 4\" src=\"help/image006.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        If your result is valid, depending on your\r\n        result, you will have a few groups to choose from. After selecting one, you will\r\n        be asked to choose the right x Axis.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"753\" height=\"433\" id=\"Picture 5\" src=\"help/image007.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        When the app draws the chart, by default,\r\n        the first item is enabled as y Axis.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"751\" height=\"454\" id=\"Picture 6\" src=\"help/image008.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        You can enable or disable different items\r\n        by clicking on the name. (The list is placed at the right side of the chart)\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"752\" height=\"518\" id=\"Picture 7\" src=\"help/image009.jpg\">\r\n    </p>\r\n\r\n    <p>\r\n        If you want to zoom in; on the chart, you\r\n        can just click, hold the button and drag your mouse to the new area, then\r\n        release it to see the result in detail.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"752\" height=\"434\" src=\"help/image010.gif\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        There are also some options to export the\r\n        chart as an image by clicking on the three horizontal lines at the top right of\r\n        the chart.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"752\" height=\"489\" id=\"Picture 8\" src=\"help/image011.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p><b>View result from shared link:</b></p>\r\n\r\n    <p>\r\n        This option lets you paste your result link\r\n        to see its chart. If someone shares a link to you, you need to enter that link\r\n        here to see the chart.\r\n    </p>\r\n\r\n    <p>\r\n        Please note that this is a link to a JSON\r\n        file, so CSV links will not work here.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"752\" height=\"258\" id=\"Picture 9\" src=\"help/image012.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p><b>Upload Monica result file:</b></p>\r\n\r\n    <p>\r\n        If you have saved your result before, you\r\n        can drop it anytime here to see it on a chart. Old results (only in JSON format)\r\n        should also work fine.\r\n    </p>\r\n\r\n    <p class=\"MsoListParagraphCxSpLast\">\r\n        <img width=\"752\" height=\"364\" id=\"Picture 10\" src=\"help/image013.jpg\">\r\n    </p>\r\n\r\n    <p><b>Settings:</b></p>\r\n\r\n    <p>\r\n        <img width=\"752\" height=\"469\" id=\"Picture 11\" src=\"help/image014.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        Setting page contains very important information\r\n        about the Monica ZMQ server. You need to ask about the right configuration\r\n        before using this program. There are probably some default settings here, but\r\n        you need to be sure these are addressing a right Monica ZMQ server.\r\n    </p>\r\n\r\n    <p>\r\n        To change a setting you just need to\r\n        replace the default value. (There is no save button, it will be saved\r\n        automatically.)\r\n    </p>\r\n\r\n    <p>\r\n        If you have logged into your github\r\n        account, you may see your repository name in the “User Name” field.\r\n    </p>\r\n\r\n    <p>\r\n        <b>Github Path Validator:</b> is a tool, to\r\n        check whether the app has access to read your parameters correctly or not. (Use\r\n        this tool when you are logged-in.)\r\n    </p>\r\n\r\n    <p>\r\n        If you enter a right path; by clicking on\r\n        the “Validate the path” button, a green checkmark icon will be shown.\r\n    </p>\r\n\r\n    <p>\r\n        <img width=\"751\" height=\"537\" id=\"Picture 14\" src=\"help/image015.jpg\">\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n    <p>\r\n        If you are logged-in, your setting form the\r\n        setting page and your github paths (parameters and export path) will be saved\r\n        on your browser’s local storage, so next time you use this service you don’t\r\n        need to fill these fields again, but if you use a different browser, you need\r\n        to log-in again. In this case, you can save different settings (by the same or a\r\n        different github user) it also means that you cannot reach your previous\r\n        settings by logging-in from different browsers. But in the same browser your\r\n        setting will remain valid even after closing the browser. If you want to clear\r\n        the setting you need to logout.\r\n    </p>\r\n\r\n    <p>&nbsp;</p>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

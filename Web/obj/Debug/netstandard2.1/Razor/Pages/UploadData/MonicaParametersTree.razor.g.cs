#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56146160928b4e2ddbe5c6b0144152eec462f156"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages.UploadData
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using NetMQ.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/uploadData/Tree")]
    public partial class MonicaParametersTree : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.AddAttribute(5, "style", "margin-bottom: 16px");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "margin-bottom: 16px");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h3>Files and directories</h3>\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "tree-base");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTree>(17);
            __builder.AddAttribute(18, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.TreeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.TreeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
                                         SelectedTreeItemChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 22 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
                                                                        entries

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Expand", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.TreeExpandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.TreeExpandEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
                                                                                          LoadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "Style", "width: 100%; height: 300px");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTreeLevel>(24);
                __builder2.AddAttribute(25, "Text", new System.Func<System.Object, System.String>(
#nullable restore
#line 23 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
                                                GetTextForNode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Template", new Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenTreeItem>(
#nullable restore
#line 23 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
                                                                           FileOrFolderTemplate

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-8");
            __builder.AddAttribute(35, "style", "margin-bottom: 16px");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<h3>Replace File</h3>\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenFileInput<string>>(41);
            __builder.AddAttribute(42, "Style", "width:400px;");
            __builder.AddAttribute(43, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 32 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
                                                                            args => FileInputChange(args)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\armaghan\source\repos\blzZmq1\Web\Pages\UploadData\MonicaParametersTree.razor"
      
    IEnumerable<string> entries = null;
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();
    double fileUploadProgressStatus = 0;
    string uploadUrl = "/Upload/Parameters";

    void Log(string eventName, string value)
    {
        events.Add(DateTime.Now, $"{eventName}: {value}");
    }

    protected override void OnInitialized()
    {
        var hostUploadUrl = Path.Combine(HostEnvironment.BaseAddress, uploadUrl);
        Console.WriteLine(hostUploadUrl);
        if (!Directory.Exists(hostUploadUrl))
            Directory.CreateDirectory(hostUploadUrl);

        Console.WriteLine(HostEnvironment.BaseAddress);
        
        entries = Directory.GetDirectories(Directory.GetCurrentDirectory())
                           .Where(entry =>
                           {
                               var name = Path.GetFileName(entry);

                               return !name.StartsWith(".") && name != "bin" && name != "obj";
                           });

    }

    string GetTextForNode(object data)
    {
        return Path.GetFileName((string)data);
    }

    RenderFragment<RadzenTreeItem> FileOrFolderTemplate = (context) => builder =>
    {
        string path = context.Value as string;
        bool isDirectory = Directory.Exists(path);

        builder.OpenComponent<RadzenIcon>(0);
        builder.AddAttribute(1, "Icon", isDirectory ? "folder" : "insert_drive_file");
        if (!isDirectory)
        {
            builder.AddAttribute(2, "Style", "margin-left: 24px");
        }
        builder.CloseComponent();
        builder.AddContent(3, context.Text);
    };

    void LoadFiles(TreeExpandEventArgs args)
    {
        var directory = args.Value as string;

        args.Children.Data = Directory.EnumerateFileSystemEntries(directory);
        args.Children.Text = GetTextForNode;
        args.Children.HasChildren = (path) => Directory.Exists((string)path);
        args.Children.Template = FileOrFolderTemplate;
    }

    void FileInputChange(string value)
    {
        Console.WriteLine(value);
    }

    void SelectedTreeItemChange(TreeEventArgs args)
    {
        Task.FromResult(ShowInfoMessageAsync(args.Text, args.Value.ToString()));
    }

    void OnProgress(UploadProgressArgs args)
    {
        this.fileUploadProgressStatus = args.Progress;

        if (args.Progress == 100)
        {
            Task.Delay(2000);
            this.fileUploadProgressStatus = 0;
            Task.FromResult(ShowSuccessMessageAsync("File Upload", "File has been uploaded."));
        }
    }

    void Completed()
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebAssemblyHostEnvironment HostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Radzen.NotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591

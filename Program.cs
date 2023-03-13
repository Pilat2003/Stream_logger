using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace anakonda;
class Program
{
    public static bool Execute = true;
    static void Main(string[] args)
    {
        Stream input = Console.OpenStandardInput();
        StreamReader inputRead = new StreamReader(input);

        Stream output = Console.OpenStandardOutput();
        StreamWriter outputWriter = new StreamWriter(output);
        //Console.WriteLine("Hello, World!");
        
    string[] a = new string[] {"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Stdio.Host\",\"Message\":\"Starting OmniSharp on Windows 10.0.19044.0 (x64)\"},\"Seq\":1,\"Type\":\"event\"}",
    

    "{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Services.DotNetCliService\",\"Message\":\"Checking the 'DOTNET_ROOT' environment variable to find a .NET SDK\"},\"Seq\":2,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Services.DotNetCliService\",\"Message\":\"Using the 'dotnet' on the PATH.\"},\"Seq\":3,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Services.DotNetCliService\",\"Message\":\"DotNetPath set to dotnet\"},\"Seq\":4,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.MSBuild.Discovery.MSBuildLocator\",\"Message\":\"Located 1 MSBuild instance(s)\r\n            1: .NET Core SDK 7.0.101 17.4.0 - \\\"C:\\Program Files\\dotnet\\sdk\\7.0.101\\\\\"\"},\"Seq\":5,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.MSBuild.Discovery.MSBuildLocator\",\"Message\":\"Registered MSBuild instance: .NET Core SDK 7.0.101 17.4.0 - \\\"C:\\Program Files\\dotnet\\sdk\\7.0.101\\\\\"\"},\"Seq\":6,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.WorkspaceInitializer\",\"Message\":\"Invoking Workspace Options Provider: OmniSharp.Roslyn.CSharp.Services.CSharpFormattingWorkspaceOptionsProvider, Order: 0\"},\"Seq\":7,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Cake.CakeProjectSystem\",\"Message\":\"Detecting Cake files in 'C:\\Users\\Komputer\\.vscode\\extensions\\ms-dotnettools.csharp-1.25.4-win32-x64\\.omnisharp\\1.39.4-net6.0'.\"},\"Seq\":8,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Cake.CakeProjectSystem\",\"Message\":\"Did not find any Cake files\"},\"Seq\":9,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.MSBuild.ProjectSystem\",\"Message\":\"No solution files found in 'C:\\Users\\Komputer\\.vscode\\extensions\\ms-dotnettools.csharp-1.25.4-win32-x64\\.omnisharp\\1.39.4-net6.0'\"},\"Seq\":10,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Script.ScriptProjectSystem\",\"Message\":\"Detecting CSX files in 'C:\\Users\\Komputer\\.vscode\\extensions\\ms-dotnettools.csharp-1.25.4-win32-x64\\.omnisharp\\1.39.4-net6.0'.\"},\"Seq\":11,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Script.ScriptProjectSystem\",\"Message\":\"Did not find any CSX files\"},\"Seq\":12,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.WorkspaceInitializer\",\"Message\":\"Configuration finished.\"},\"Seq\":13,\"Type\":\"event\"}",
"{\"Event\":\"log\",\"Body\":{\"LogLevel\":\"INFORMATION\",\"Name\":\"OmniSharp.Stdio.Host\",\"Message\":\"Omnisharp server running using Stdio at location 'C:\\Users\\Komputer\\.vscode\\extensions\\ms-dotnettools.csharp-1.25.4-win32-x64\\.omnisharp\\1.39.4-net6.0' on host -1.\"},\"Seq\":14,\"Type\":\"event\"}",
"{\"Event\":\"started\",\"Body\":null,\"Seq\":15,\"Type\":\"event\"}"};
    
    
   StringBuilder log = new StringBuilder();
   log.AppendLine("[ARGS]");
   foreach (string item in args)
   {
    log.AppendLine(item);
   }
   log.AppendLine("[**ARGS**]");
    
    foreach (string item in a)
    {
        outputWriter.WriteLine(item);
        outputWriter.Flush();
    }

    
        log.AppendLine(inputRead.ReadLine());
    
    
    File.WriteAllText(@"C:\Users\Komputer\Desktop\log.txt", log.ToString());
    }
}
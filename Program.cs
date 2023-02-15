using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace anakonda;
class Program
{
    public static bool Execute = true;
    static void Main(string[] args)
    {
        Stream input = Console.OpenStandardInput();
        StreamReader inputRead = new StreamReader(input);
        //Console.WriteLine("Hello, World!");
     Process process = new Process();
// Configure the process using the StartInfo properties.
process.StartInfo.FileName = @"C:\Users\Stanowisko\.vscode\extensions\ms-dotnettools.csharp-1.25.4-win32-x64\.omnisharp\1.39.4-net6.0\os.exe";
process.StartInfo.RedirectStandardInput = true;
process.StartInfo.RedirectStandardOutput= true;

        FileStream s = File.Open(@"C:\Users\Stanowisko\Desktop\anakonda\output\data.txt", FileMode.OpenOrCreate);
        s.SetLength(0);
        StreamWriter w = new StreamWriter(s);


        process.Start();

        Thread.Sleep(2000);

        StreamReader r = new StreamReader(process.StandardOutput.BaseStream);
        string message = "";
        message += "[ARGS] \n";
        foreach(string bfv in args){
        message += bfv + "\n";
        }
        message += "\n";

        Task.Run(()=>{
            Thread.Sleep(100000);
            Execute = false;
        });
                while(Execute){
            while(r.Peek() != -1){
             message+= "[VS Code] \n";
            message+= r.ReadLine();
             message+= "[*VS Code*] \n";
        }

        while(r.Peek() != -1){
             message+= "[Omni] \n";
             string ss = r.ReadLine();
             System.Console.WriteLine(ss);
            message+= ss;
             message+= "[*Omni*] \n";
        }
       
        
        }


         w.WriteLine(message);
        w.Flush();
        w.Close();
        s.Close();
    }
}

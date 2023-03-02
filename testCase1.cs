using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace anakonda;
class Program
{
    static void Main(string[] args)
    {
         Process process = new Process();
// Configure the process using the StartInfo properties.
process.StartInfo.FileName = @"E:\github\Stream_logger\test\progr\anakonda.exe";
process.StartInfo.RedirectStandardInput = true;
process.StartInfo.RedirectStandardOutput= true;

    process.Start();

    StreamWriter w = new StreamWriter(process.StandardInput.BaseStream);
    StreamReader r = new StreamReader(process.StandardOutput.BaseStream);
     System.Console.WriteLine("Writing");
    for (int i = 0; i < 100; i++)
    {
        w.WriteLine($"{i}. Message");
        w.Flush();
        Thread.Sleep(50);
    }
    
    System.Console.WriteLine("Reading");
    
    for (int i = 0; i < 100; i++)
    {
        System.Console.WriteLine(r.ReadLine());
        Thread.Sleep(50);
    }
    Console.ReadLine();
    Console.WriteLine("END");
    Console.ReadLine();
    }
}

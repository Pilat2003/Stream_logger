using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace anakonda;
class xProgram
{
    static void xMain(string[] args)
    {
         
    StreamWriter w = new StreamWriter(Console.OpenStandardOutput());
    StreamReader r = new StreamReader(Console.OpenStandardInput());
     System.Console.WriteLine("Writing");
    
    
    System.Console.WriteLine("Reading");
    
    for (int i = 0; i < 100; i++)
    {
        r.ReadLine();
        Thread.Sleep(50);
    }
    for (int i = 0; i < 100; i++)
    {
        w.WriteLine($"{i}. Message");
        w.Flush();
        Thread.Sleep(50);
    }
    Console.ReadLine();
    Console.WriteLine("END");
    Console.ReadLine();
    }
}

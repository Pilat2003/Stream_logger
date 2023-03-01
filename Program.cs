﻿using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace anakonda;
class Program
{
    public static bool Execute = true;
    public static string message = "";
    public static  Action<Task<string>> ReadVSCode = (a)=>{
        
        message+= "[VS Code] \n";
            message+= a.Result;
             message+= "[*VS Code*] \n";
             if(Execute)
              inputRead.ReadLineAsync().ContinueWith(ReadVSCode);
    };

    public static  Action<Task<string>> ReadOmni = (a)=>{
        message+= "[Omnisharp] \n";
            message+= a;
             message+= "[*Omnisharp*] \n";
             if(Execute)
             r.ReadLineAsync().ContinueWith(ReadOmni);
    };

    public static StreamReader inputRead;
    public static StreamReader r;
    static void Main(string[] args)
    {
        Stream input = Console.OpenStandardInput();
        inputRead = new StreamReader(input);
        //Console.WriteLine("Hello, World!");
     Process process = new Process();
// Configure the process using the StartInfo properties.
process.StartInfo.FileName = @"C:\Users\Klasa3\.vscode\extensions\ms-dotnettools.csharp-1.25.4-win32-x64\.omnisharp\1.39.4-net6.0\omnisharp.exe";
process.StartInfo.RedirectStandardInput = true;
process.StartInfo.RedirectStandardOutput= true;

        process.Start();


        r = new StreamReader(process.StandardOutput.BaseStream);
        message = "";
        message += "[ARGS] \n";
        foreach(string bfv in args){
        message += bfv + "\n";
        }
        message += "\n";
        
       
 
            Thread.Sleep(10000);
            Execute = false;
            message += r.ReadToEnd();
            message += inputRead.ReadToEnd();
           // FileStream s = File.Open(@"C:\Users\Klasa3\Documents\data.txt", FileMode.OpenOrCreate);
       // s.SetLength(0);
       // StreamWriter w = new StreamWriter(s);
        File.WriteAllText(@"C:\Users\Klasa3\Documents\data.txt", message);
            
        // w.WriteLine(message);
        //w.Flush();
        //w.Close();
        //s.Close();
    }
}

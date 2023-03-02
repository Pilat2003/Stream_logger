using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace anakonda;
class cProgram
{
    public static bool Execute = true;
    public static string message = "";

public static Stream _stdInput;
public static Stream _stdOutput;

public static async void ReadLoop(){

    try{

        StreamReader r = new StreamReader(_stdInput);
        StreamWriter w = new StreamWriter(_stdOutput);
        string t = await  r.ReadLineAsync();
        w.WriteLine(t);
        w.Flush();
        r.Close();
        w.Close();
       

    }
    catch(IOException ex){

    }
    finally{
        ReadLoop();
    }

}
     
    static void cMain(string[] args)
    {
     _stdInput = Console.OpenStandardInput();
     _stdOutput = Console.OpenStandardOutput();



      StreamWriter w = new StreamWriter(_stdOutput);
      StreamReader r = new StreamReader(_stdInput);
     Process process = new Process();
// Configure the process using the StartInfo properties.
process.StartInfo.FileName = @"E:\github\Stream_logger\test\testcase2\End.exe";
process.StartInfo.RedirectStandardInput = true;
process.StartInfo.RedirectStandardOutput= true;

        process.Start();

        
        while(Execute){
            Thread.Sleep(100);
        }

        File.WriteAllText(@"C:\Users\Klasa3\Documents\data.txt", message);
}
}

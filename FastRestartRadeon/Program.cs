using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.IO;

namespace FastRestartRadeon
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Process.GetProcessesByName("RadeonSoftware.exe").Length == 0)
            {
                ConsoleColor foreground = Console.ForegroundColor;
                foreach (var process in Process.GetProcessesByName("RadeonSoftware"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    process.Kill();
                    Console.WriteLine("Se cerro el proceso RadeonSoftware");
                    Thread.Sleep(500);
                    string direc = @"C:\Program Files\AMD\CNext\CNext";
                    if (!File.Exists(direc))
                    {
                        Process.Start(@"C:\Program Files\AMD\CNext\CNext\RadeonSoftware.exe");
                        Console.WriteLine("Se esta iniciando el proceso de Radeon");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("No se encontro RadeonSoftware.exe");
                        Thread.Sleep(2000);
                    }
                }
            }
        }
    }   
}

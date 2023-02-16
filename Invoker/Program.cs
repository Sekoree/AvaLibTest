// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

internal class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Press any key to start the Avalonia app...");
        Console.ReadKey();
        StartAvaDesktopApp();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    
    [DllImport("AvaLibTest.dll", EntryPoint = "StartAva", CharSet = CharSet.Unicode)]
    static extern void StartAvaDesktopApp();
}
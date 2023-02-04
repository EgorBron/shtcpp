using System.Runtime.InteropServices;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(MyPlus(1, 2));

[DllImport("mydll.dll")]
static extern int MyPlus(int x, int y);
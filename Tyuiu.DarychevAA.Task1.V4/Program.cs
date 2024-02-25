using System.Data;

namespace Tyuiu.DarychevAA.Task1.V4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {        
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm_DAA());
        }
    }
}
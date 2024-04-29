using System.Security.Cryptography.X509Certificates;
using CalculatorApp;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
   
}



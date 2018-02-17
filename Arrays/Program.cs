using CommandDotNet;
using CommandDotNet.Models;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            AppRunner<App> appRunner = new AppRunner<App>(new AppSettings
            {
                Case = Case.KebabCase
            });

            appRunner.Run(args);
        }
    }
}

using OpenAvrilCFSD.ClientAssembly;

namespace OpenAvrilCFSD.ClientAssembly
{
    class Program
    {
        

        static void Main(string[] args)
        {
            System.Console.WriteLine("started progrma entry.");
            var framework = IO.app_FUNCT_generate_Program();
            while (framework == null) { /* wait untill is created */ }
            framework.Initialise(framework);
        }


    }
}

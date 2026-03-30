//ServerAssembly

namespace OpenAvrilCFSD.ServerAssembly
{
    static class Program
    {
        static private OpenAvrilCFSD.ServerAssembly.Framework_Server _framework_ServerAssembly = null;

        static void Main()
        {
            System.Console.WriteLine("ENTERED => app entry point.");//TestBench
            _framework_ServerAssembly = new OpenAvrilCFSD.ServerAssembly.Framework_Server();
            while (_framework_ServerAssembly == null) { /* wait until class created */ }
            _framework_ServerAssembly.Initialise(_framework_ServerAssembly);
            System.Console.WriteLine("Created: Server App Architechture.");//TestBench
        }

        static public OpenAvrilCFSD.ServerAssembly.Framework_Server Get_framework_Server()
        {
            return _framework_ServerAssembly;
        }
    }
}
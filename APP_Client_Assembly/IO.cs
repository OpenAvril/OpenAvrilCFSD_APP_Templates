using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAvrilCFSD.ClientAssembly
{
    public class IO
    {
        private Framework_Client framework_Client;

        public static Framework_Client app_FUNCT_generate_Program()
        {
            System.Console.WriteLine("entered app_FUNCT_generate_Program().");//TESTBENCH

            System.Console.WriteLine("started Classe(s) - DECLAIRE, DEFINE INITIALISE, Registers - DECLAIRE.");//TESTBENCH
            stat_CLASS_boot1_DEFINE_Framework();
            stat_CLASS_boot3_INITIALISE_Framework();
            System.Console.WriteLine("done Classe(s) - DECLAIRE, DEFINE INITIALISE, Registers - DECLAIRE.");//TESTBENCH

            System.Console.WriteLine("started Structure(s) - DECLAIRE, DEFINE INITIALISE, Registers - DECLAIRE.");//TESTBENCH
            stat_CLASS_get_framework_Client().stat_STRUCT_create_All();
            System.Console.WriteLine("done Structure(s) - DECLAIRE, DEFINE INITIALISE, Registers - DECLAIRE.");//TESTBENCH

            System.Console.WriteLine("started Registers - DEFINE");//TESTBENCH

            stat_CLASS_get_framework_Client()->dyn_REG_boot1_DEFINE_Framework_Server(stat_CLASS_get_framework_Client());
            System.Console.WriteLine("done Registers - DEFINE.");//TESTBENCH

            System.Console.WriteLine("started Registers - SUBSTANTIATE.");//TESTBENCH

            stat_CLASS_get_framework_Client()->dyn_REG_boot2_SUBSTANTIATE_Framework_Server(stat_CLASS_get_framework_Client());
            System.Console.WriteLine("done Registers - SUBSTANTIATE.");//TESTBENCH

            System.Console.WriteLine("started Registers - INITIALISE.");//TESTBENCH
            stat_CLASS_get_framework_Client()->dyn_REG_boot3_INITIALISE_Framework_Server(stat_CLASS_get_framework_Client());
            System.Console.WriteLine("done Registers - INITIALISE.");//TESTBENCH

            System.Console.WriteLine("started Program - INSTANTIATE.");//TESTBENCH
            stat_CLASS_get_framework_Client()->dyn_PGM_boot4_INSTANTIATE_Framework_Server(stat_CLASS_get_framework_Client());
            System.Console.WriteLine("done Program - INSTANTIATE.");//TESTBENCH

            System.Console.WriteLine(" ");//TESTBENCH
            System.Console.WriteLine("        ,     \\      /      ,");//TESTBENCH
            System.Console.WriteLine("       / \\    )\\ __ /(     / \\ ");//TESTBENCH
            System.Console.WriteLine("      /   \\   (_\\  /_)    /   \\ ");//TESTBENCH
            System.Console.WriteLine("____ / ____\\__ \\@  @/ ___/_____\\_____");//TESTBENCH
            System.Console.WriteLine("|              |\\../|               |");//TESTBENCH
            System.Console.WriteLine("|               \\VV/                |");//TESTBENCH
            System.Console.WriteLine("|      MIT OpenAvrilCFSD.ClientAssembly     |");//TESTBENCH
            System.Console.WriteLine("|___________________________________|");//TESTBENCH
            System.Console.WriteLine("|    / \\ /        \\\\        \\ /\\    |");//TESTBENCH
            System.Console.WriteLine("|  /    V          ))        V   \\  |");//TESTBENCH
            System.Console.WriteLine("|/                //               \\| ");//TESTBENCH
            System.Console.WriteLine("`                 V                 '");//TESTBENCH
            System.Console.WriteLine(" ");//TESTBENCH
            System.Console.WriteLine("exiting app_FUNCT_generate_Program().");//TESTBENCH
            return stat_CLASS_get_framework_Client();
        }
        // private.
        static private void stat_CLASS_boot1_DEFINE_Framework()
        {
            framework_Client = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_Framework()
        {
            framework_Client = new Framework_Client();
            while (stat_CLASS_get_framework_Client() == null) { }
        }
        static private Framework_Client stat_CLASS_get_framework_Client()
        {
            return framework_Client;
        }
    }
}

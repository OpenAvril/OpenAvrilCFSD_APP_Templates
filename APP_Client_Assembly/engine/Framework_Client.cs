using APP_ClientAssembly.structs;
using APP_ClientAssembly.threads;

namespace OpenAvrilCFSD.ClientAssembly
{
    public class Framework_Client
    {
        static private Client _stat_CLASS_app_Client;
        //static private Networking_Client _stat_PGM_networkingClient;
        static private Concurrent _stat_STRUCT_Concurrent;
        static private Input _stat_STRUCT_Input;
        static private IO_Listen_Respond _stat_STRUCT_IO_Listen_Respond;
        static private Output _stat_STRUCT_Output;
        
    
// public.
        public Framework_Client() 
        {
            System.Console.WriteLine("entered CONSTRUCTOR Framework_Client().");//TESTBENCH
            stat_CLASS_boot0_DECLAIRE_Framework_Client();
            stat_CLASS_boot1_DEFINE_Framework_Client();
            stat_CLASS_boot3_INITIALISE_Framework_Client();
            stat_REG_boot0_DECLAIRE_Framework_Client();
            System.Console.WriteLine("exiting CONSTRUCTOR Framework_Client().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Framework_Client()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Framework_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Framework_Client().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Framework_Client()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Framework_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Framework_Client().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Framework_Client()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Framework_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Framework_Client().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Framework_Client()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Framework_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Framework_Client().");//TESTBENCH
        }
        public static Concurrent dyn_STRUCT_get_Concurrent()
        {
            return stat_CLASS_get_Concurrent();
        }
        public static Input dyn_STRUCT_get_Input()
        {
            return stat_CLASS_get_Input();
        }
        public static IO_Listen_Respond dyn_STRUCT_get_IO_Listen_Respond()
        {
            return stat_CLASS_get_IO_Listen_Respond();
        }
        public static Output dyn_STRUCT_get_Output()
        {
            return stat_CLASS_get_Output();
        }
        static public void stat_CLASS_boot0_DECLAIRE_Framework_Client()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Framework_Client().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Framework_Client().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Framework_Client()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Framework_Client().");//TESTBENCH
            stat_CLASS_boot1_DEFINE_app_Client();
            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Framework_Client().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Framework_Client()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Framework_Client().");//TESTBENCH
            stat_CLASS_boot3_INITIALISE_app_Client();
            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Framework_Client().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Framework_Client()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Framework_Client().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Framework_Client().");//TESTBENCH
        }
        public void stat_STRUCT_create_All()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE().");//TESTBENCH
            stat_STRUCT_boot3_INITIALISE_Concurrent();
            //stat_CLASS_get_Concurrent()->
            stat_STRUCT_boot3_INITIALISE_Input();
            stat_STRUCT_boot3_INITIALISE_IO_Listen_Respond();
            stat_STRUCT_boot3_INITIALISE_Output();
            System.Console.WriteLine("exiting stat_STRUCTstat_STRUCT_boot3_INITIALISE_Output()_boot3_INITIALISE().");//TESTBENCH
        }
        // private.
        private static void stat_CLASS_boot1_DEFINE_app_Client()
        {
            _stat_CLASS_app_Client = null;
        }
        private static void stat_CLASS_boot3_INITIALISE_app_Client()
        {
            _stat_CLASS_app_Client = new Client();
            while (stat_CLASS_get_app_Client() == null) { }
        }
        private static void stat_STRUCT_boot3_INITIALISE_Concurrent()
        {
            _stat_STRUCT_Concurrent = new Concurrent();
        }
        private static void stat_STRUCT_boot3_INITIALISE_Input()
        {
            _stat_STRUCT_Input = new Input();
        }
        private static void stat_STRUCT_boot3_INITIALISE_IO_Listen_Respond()
        {
            _stat_STRUCT_IO_Listen_Respond = new IO_Listen_Respond();
        }
        private static void stat_STRUCT_boot3_INITIALISE_Output()
        {
            _stat_STRUCT_Output = new Output();
        }
        private static Client stat_CLASS_get_app_Client()
        {
            return _stat_CLASS_app_Client;
        }
        private static Concurrent stat_CLASS_get_Concurrent()
        {
            return _stat_STRUCT_Concurrent;
        }
        private static Input stat_CLASS_get_Input()
        {
            return _stat_STRUCT_Input;
        }
        private static IO_Listen_Respond stat_CLASS_get_IO_Listen_Respond()
        {
            return _stat_STRUCT_IO_Listen_Respond;
        }
        private static Output stat_CLASS_get_Output()
        {
            return _stat_STRUCT_Output;
        }
    }
}

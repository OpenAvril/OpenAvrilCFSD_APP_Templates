namespace OpenAvrilCFSD.ClientAssembly
{
    public class Client
    {
        static private OpenAvrilCFSD.ClientAssembly.Algorithims _stat_CLASS_algorithms;
        static private OpenAvrilCFSD.ClientAssembly.Data _stat_CLASS_data;
        static private OpenAvrilCFSD.ClientAssembly.Execute _stat_CLASS_execute;
        static private OpenAvrilCFSD.ClientAssembly.Global _stat_CLASS_global;
// public.
        public Client() 
        {
            System.Console.WriteLine("entered CONSTRUCTOR Client().");//TESTBENCH
            stat_CLASS_boot0_DECLAIRE_Client();
            stat_CLASS_boot1_DEFINE_Client();
            stat_CLASS_boot3_INITIALISE_Client();
            stat_REG_boot0_DECLAIRE_Client();
            System.Console.WriteLine("exiting CONSTRUCTOR Client().");//TESTBENCH
        }
        public Algorithims dyn_CLASS_get_algorithms()
        {
            return stat_CLASS_get_algorithms();
        }
        public Data Get_dyn_CLASS_data()
        {
            return Get_stat_CLASS_data();
        }
        public Execute dyn_CLASS_get_execute()
        {
            return stat_CLASS_get_execute();
        }
        public Global dyn_CLASS_get_global()
        {
            return stat_CLASS_get_global();
        }
        public void dyn_REG_boot1_DEFINE_Client()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Client().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Client()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Client().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Client()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Client().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Client()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Client().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Client().");//TESTBENCH
        }
        static public void stat_CLASS_boot0_DECLAIRE_Client()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Client().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Client().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Client()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Client().");//TESTBENCH
            stat_CLASS_boot1_DEFINE_global();
            stat_CLASS_boot1_DEFINE_algorithms();
            stat_CLASS_boot1_DEFINE_data();
            stat_CLASS_boot1_DEFINE_execute();
            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Client().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Client()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Client().");//TESTBENCH
            stat_CLASS_boot3_INITIALISE_global();
            stat_CLASS_boot3_INITIALISE_algorithms();
            stat_CLASS_boot3_INITIALISE_data();
            stat_CLASS_boot3_INITIALISE_execute();
            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Client().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Client()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Client().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Client().");//TESTBENCH
        }
// private.
        static private void stat_CLASS_boot1_DEFINE_algorithms()
        {
            _stat_CLASS_algorithms = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_algorithms()
        {
            _stat_CLASS_algorithms = new Algorithms();
            while (stat_CLASS_get_algorithms() == null) { }
        }
        static private void stat_CLASS_boot1_DEFINE_data()
        {
            _stat_CLASS_data = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_data()
        {
            _stat_CLASS_data = new Data();
            while (Get_stat_CLASS_data() == null) { }
        }
        static private void stat_CLASS_boot1_DEFINE_execute()
        {
            _stat_CLASS_execute = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_execute()
        {
            _stat_CLASS_execute = new Execute();
            while (stat_CLASS_get_execute() == null) { }
        }
        static private void stat_CLASS_boot1_DEFINE_global()
        {
            _stat_CLASS_global = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_global()
        {
            _stat_CLASS_global = new Global();
            while (stat_CLASS_get_global() == null) { }
        }
        static private Algorithims stat_CLASS_get_algorithms()
        {
            return _stat_CLASS_algorithms;
        }
        static private Data Get_stat_CLASS_data()
        {
            return _stat_CLASS_data;
        }
        static private Execute stat_CLASS_get_execute()
        {
            return _stat_CLASS_execute;
        }
        static private Global stat_CLASS_get_global()
        {
            return _stat_CLASS_global;
        }
    }
}
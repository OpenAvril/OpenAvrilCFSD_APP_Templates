
namespace OpenAvrilCFSD.ClientAssembly
{
    public class Algorithims
    {
        static private IO_Listen_Respond _stat_REG_thread_ListenRespond;
        static private Concurrent[] _stat_REG_Array_Of_thread_Concurrent;
        //user algorithims.
// public.
        public Algorithims(int numberOfCores) 
        {
            System.Console.WriteLine("entered CONSTRUCTOR Algorithims().");//TESTBENCH
            stat_CLASS_boot0_DECLAIRE_Algorithims();
            stat_CLASS_boot1_DEFINE_Algorithims();
            stat_CLASS_boot3_INITIALISE_Algorithims();
            stat_REG_boot0_DECLAIRE_Algorithims();
            System.Console.WriteLine("exiting CONSTRUCTOR Algorithims().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Algorithims()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Algorithims().");//TESTBENCH
            stat_STRUCT_boot1_DEFINE_thread_ListenRespond();
            stat_STRUCT_boot1_DEFINE_thread_Concurrent();
            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Algorithims().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Algorithims()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Algorithims().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Algorithims().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Algorithims(IO_Listen_Respond strucutListenRespond, Concurrent strucutConcurrent)
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Algorithims().");//TESTBENCH
            stat_STRUCT_boot3_INITIALISE_thread_ListenRespond(strucutListenRespond);
            stat_STRUCT_boot3_INITIALISE_thread_Concurrent(strucutConcurrent);
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Algorithims().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Algorithims()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Algorithims().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Algorithims().");//TESTBENCH
        }
        static public void stat_CLASS_boot0_DECLAIRE_Algorithims()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Algorithims().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Algorithims().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Algorithims()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Algorithims().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Algorithims().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Algorithims()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Algorithims().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Algorithims().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Algorithims()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Algorithims().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Algorithims().");//TESTBENCH
        }
    // private.
        private static void stat_STRUCT_boot1_DEFINE_thread_ListenRespond()
        {
            _stat_REG_thread_ListenRespond = null;
        }
        private static void stat_STRUCT_boot3_INITIALISE_thread_ListenRespond(IO_Listen_Respond strucutListenRespond)
        {
            _stat_REG_thread_ListenRespond = new IO_Listen_Respond();
            while (stat_STRUCT_get_Array_Of_Concurrent() == null) { }
            _stat_REG_thread_ListenRespond = strucutListenRespond;
        }
        private static void stat_STRUCT_boot1_DEFINE_thread_Concurrent()
        {
            _stat_REG_Array_Of_thread_Concurrent = null;
        }
        private static void stat_STRUCT_boot3_INITIALISE_thread_Concurrent(Concurrent strucutConcurrent)
        {
            _stat_REG_Array_Of_thread_Concurrent = new Concurrent[3];
            while (stat_STRUCT_get_Array_Of_Concurrent() == null) { }
            for (byte concurrentThreadId = 0; concurrentThreadId < stat_STRUCT_get_Array_Of_Concurrent().Length; concurrentThreadId++)
            {
                _stat_REG_Array_Of_thread_Concurrent[concurrentThreadId] = strucutConcurrent;
            }
        }
        private static IO_Listen_Respond Get_stat_REG_thread_ListenRespond()
        {
            return _stat_REG_thread_ListenRespond;
        }
        private static Concurrent[] stat_STRUCT_get_Array_Of_Concurrent()
        {
            return _stat_REG_Array_Of_thread_Concurrent;
        }
    }
}

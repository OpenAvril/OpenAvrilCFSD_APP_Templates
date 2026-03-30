using System;
using System.Threading;

namespace OpenAvrilCFSD.ClientAssembly
{
    public class Execute
    {
        private OpenAvrilCFSD.ClientAssembly.Execute_Control _stat_CLASS_execute_Control;
        private OpenAvrilCFSD.ClientAssembly.Networking_Client _networking_Client;
        private IntPtr programId_ConcurrentQue_C;
        private IntPtr programId_WriteQue_C_IA;
        private IntPtr programId_WriteQue_C_OR;

        private Thread[] _threads = {null, null, null, null, null, null};//number of app shell threads.

        public Execute(int numberOfCores) 
        {
            System.Console.WriteLine("entered CONSTRUCTOR Execute().");//TESTBENCH
            stat_CLASS_boot0_DECLAIRE_Execute();
            stat_CLASS_boot1_DEFINE_Execute();
            stat_CLASS_boot3_INITIALISE_Execute();
            stat_REG_boot0_DECLAIRE_Execute();
            System.Console.WriteLine("exiting CONSTRUCTOR Execute().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Execute()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Execute().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Execute()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Execute().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Execute()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Execute().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Execute()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Execute().");//TESTBENCH
        }
        static public void stat_CLASS_boot0_DECLAIRE_Execute()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Execute().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Execute()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Execute().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Execute()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Execute().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Execute()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Execute().");//TESTBENCH
        }







        public void Initialise_Control(int numberOfCores, Global global)
        {
            Set_stat_CLASS_execute_Control(new OpenAvrilCFSD.ClientAssembly.Execute_Control(numberOfCores));
            while (stat_CLASS_get_execute_Control() == null) { }
        }

        public void Initialise_NetworkingPipes(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            Set_networking_Client(new OpenAvrilCFSD.ClientAssembly.Networking_Client());
            Get_networking_Client().Initialise_networking_Client();
        }

        public void Initialise_Libraries()
        {
            programId_ConcurrentQue_C = OpenAvrilCFSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Initialise_LaunchEnableForConcurrentThreadsAt();
            System.Console.WriteLine("created Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT");

            programId_WriteQue_C_IA = OpenAvrilCFSD.Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION.Initialise_WriteEnable();
            System.Console.WriteLine("created Library_For_WriteEnableForThreadsAt_CLIENTINPUTACTION");

            programId_WriteQue_C_OR = OpenAvrilCFSD.Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.Initialise_WriteEnable();
            System.Console.WriteLine("created Library_For_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE");

        }
        public void Initialise_Threads(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            byte threadIdCounter = 0;
            obj.Get_client().stat_CLASS_get_execute().Set_thread(threadIdCounter, Thread.CurrentThread);
            obj.Get_client().stat_CLASS_get_execute().stat_CLASS_get_execute_Control().Set_flag_ThreadInitialised(obj, threadIdCounter, false);
            System.Console.WriteLine("Thread Initalised => CurrentThread()" + (threadIdCounter).ToString());//TESTBENCH

            threadIdCounter++;
            obj.Get_client().stat_CLASS_get_execute().Set_thread(threadIdCounter, new Thread(() => _networking_Client.Thread_IO_Client(threadIdCounter)));
            obj.Get_client().stat_CLASS_get_execute().Get_thread(threadIdCounter).Start();
            System.Console.WriteLine("Thread Initalised => Thread_IO_Client on core " + (threadIdCounter).ToString());//TESTBENCH

            threadIdCounter++;
            while (threadIdCounter < obj.Get_client().stat_CLASS_get_global().Get_numberOfCores())
            {
                obj.Get_client().stat_CLASS_get_execute().Set_thread(threadIdCounter, new Thread(() => obj.Get_client().stat_CLASS_get_algorithms().Get_concurrent((byte)(threadIdCounter - (byte)2)).Thread_Concurrent(threadIdCounter)));
                obj.Get_client().stat_CLASS_get_execute().Get_thread(threadIdCounter).Start();
                System.Console.WriteLine("Thread Initalised => Thread_Concurrent on core " + (threadIdCounter).ToString());//TESTBENCH
                threadIdCounter++;
            }
        }

        public void Create_And_Run_Graphics(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            System.Console.WriteLine("starting = > gameInstance");//TESTBENCH
            using (OpenAvrilCFSD.ClientAssembly.Game_Instance gameInstance = new OpenAvrilCFSD.ClientAssembly.Game_Instance())
            {
                gameInstance.Run(obj.Get_client().Get_stat_CLASS_data().Get_settings().Get_refreshRate());
            }
        }

        public OpenAvrilCFSD.ClientAssembly.Execute_Control stat_CLASS_get_execute_Control()
        {
            return _stat_CLASS_execute_Control;
        }
        public OpenAvrilCFSD.ClientAssembly.Networking_Client Get_networking_Client()
        {
            return _networking_Client;
        }


        public IntPtr Get_program_ConcurrentQue_C()
        {
            return programId_ConcurrentQue_C;

        }
        public IntPtr Get_program_WriteQue_C_IA()
        {
            return programId_WriteQue_C_IA;
        }
        public IntPtr Get_program_WriteQue_C_OR()
        {
            return programId_WriteQue_C_OR;
        }
        public Thread Get_thread(byte index)
        {
            return _threads[index];
        }

        private void Set_stat_CLASS_execute_Control(OpenAvrilCFSD.ClientAssembly.Execute_Control execute_Control)
        {
            _stat_CLASS_execute_Control = execute_Control;
        }
        private void Set_networking_Client(OpenAvrilCFSD.ClientAssembly.Networking_Client networking_Client)
        {
            _networking_Client = networking_Client;
        }
        private void Set_program_ConcurrentQue_C(IntPtr programID)
        {
            programId_ConcurrentQue_C = programID;
        }
        private void Set_programId_WriteQue_C_IA(IntPtr programId)
        {
            programId_WriteQue_C_IA = programId;
        }
        private void Set_programId_WriteQue_C_OR(IntPtr programId)
        {
            programId_WriteQue_C_OR = programId;
        }
        private void Set_thread(byte index, Thread thread) 
        {
            _threads[index] = thread;
        }
    }   
}

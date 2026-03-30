namespace OpenAvrilCFSD.ClientAssembly
{
    public struct Concurrent
    {
// public.
        public void dyn_APP_Thread_Concurrent(Framework_Client obj, byte threadId)
        {
            byte _concurrentThreadId = (byte)(threadId - 1);
            bool doneOnce_A = false;
            while (obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().dyn_CLASS_get_execute_Control().Get_flag_SystemInitialised() == true)
            {
                if (doneOnce_A == false)
                {
                    doneOnce_A = true;
                    obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().dyn_CLASS_get_execute_Control().Set_flag_ThreadInitialised(obj, threadId, false);
                }
            }
            while (obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().dyn_CLASS_get_execute_Control().Get_exitApplication() == false)
            {
                if (obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_dyn_CLASS_data_Control().Get_flag_IsLoaded_Stack_OutputRecieve())
                {
                    Console.WriteLine("Thread[" + threadId.ToString() + "] => Get_flag_IsLoaded_Stack_OutputRecieve = " + obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_dyn_CLASS_data_Control().Get_flag_IsLoaded_Stack_OutputRecieve());//TestBench
                    OpenAvrilCFSD.ImportCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE.app_FUNCT_write_Start(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_WriteQue_C_OR(), (byte)(_concurrentThreadId + 1));
                    obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_algorithms().Get_concurrent(_concurrentThreadId).Get_concurrent_Control().SelectSet_Algorithm_Subset(obj, obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj).Get_praiseEventId(), _concurrentThreadId);
                    obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_dyn_CLASS_data_Control().Pop_Stack_OutputRecieve(obj, obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_output_Instnace().Get_BACK_outputDoubleBuffer(obj), obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_output_Instnace().Get_stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output());
                    obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Flip_OutBufferToWrite();
                    obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_dyn_CLASS_data_Control().Do_Store_PraiseOutputRecieve_To_GameInstanceData(obj, obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_output_Instnace().Get_stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output().ElementAt(1));
                    obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_dyn_CLASS_data_Control().Set_isPraiseActive(obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_output_Instnace().Get_FRONT_outputDoubleBuffer(obj).Get_praiseEventId(), false);
                    OpenAvrilCFSD.ImportCLIBLaunchEnableForConcurrentThreadsAtCLIENT.app_FUNCT_thread_End(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_ConcurrentQue_C(), _concurrentThreadId);
                    if (obj.dyn_CLASS_get_app_Client().Get_dyn_CLASS_data().Get_dyn_CLASS_data_Control().Get_flag_IsLoaded_Stack_OutputRecieve())
                    {
                        if (OpenAvrilCFSD.ImportCLIBLaunchEnableForConcurrentThreadsAtCLIENT.app_FUNCT_get_Flag_ConcurrentCoreState(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_ConcurrentQue_C(), OpenAvrilCFSD.ImportCLIBLaunchEnableForConcurrentThreadsAtCLIENT.app_FUNCT_get_coreId_To_launch(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_ConcurrentQue_C())) == OpenAvrilCFSD.ImportCLIBLaunchEnableForConcurrentThreadsAtCLIENT.app_FUNCT_get_Flag_Idle(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_ConcurrentQue_C()))
                        {
                            OpenAvrilCFSD.ImportCLIBLaunchEnableForConcurrentThreadsAtCLIENT.Request_Wait_Launch(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_ConcurrentQue_C(), OpenAvrilCFSD.Library_For_LaunchEnableForConcurrentThreadsAt_CLIENT.Get_coreId_To_Launch(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_ConcurrentQue_C()));
                        }
                    }
                    OpenAvrilCFSD.ImportCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE.app_FUNCT_write_End(obj.dyn_CLASS_get_app_Client().dyn_CLASS_get_execute().Get_program_WriteQue_C_OR(), (byte)(_concurrentThreadId + 1));
                }
            }
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
    }
}

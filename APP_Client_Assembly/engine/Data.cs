using APP_ClientAssembly.structs;

namespace OpenAvrilCFSD.ClientAssembly
{
    public class Data
    {
        static private Data_Control _stat_CLASS_data_Control;
        static private Output[] _stat_REG_Buffer_Reference_For_Core_Of_Output;
        static private Input[] _stat_REG_doublebuffer_Client_InputSend;
        static private Output[] _stat_REG_doublebuffer_Client_OutputRecieve;
        static private List<Input> _stat_REG_Stack_At_Client_InputSend_List_Of_Input;
        static private List<Output> _stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output;
// public.
        public Data()
        {
            System.Console.WriteLine("entered CONSTRUCTOR Data().");//TESTBENCH
            stat_CLASS_boot0_DECLAIRE_Data();
            stat_CLASS_boot1_DEFINE_Data();
            stat_CLASS_boot3_INITIALISE_Data();
            stat_REG_boot0_DECLAIRE_Data();
            System.Console.WriteLine("exiting CONSTRUCTOR Data().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Data()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Data().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Data()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Data().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Data()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Data().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Data()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Data().");//TESTBENCH
        }
        public Output Get_stat_REG_Buffer_Reference_For_Core_Of_Output(byte concurrentCoreId)
        {
            return _stat_REG_Buffer_Reference_For_Core_Of_Output[concurrentCoreId];
        }
        public Output Get_FRONT_outputDoubleBuffer(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            return _stat_REG_doublebuffer_Client_OutputRecieve[BoolToInt16(obj.Get_client().Get_stat_CLASS_data().Get_state_Buffer_Output_ToWrite())];
        }
        public Output Get_BACK_outputDoubleBuffer(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            return _stat_REG_doublebuffer_Client_OutputRecieve[BoolToInt16(!obj.Get_client().Get_stat_CLASS_data().Get_state_Buffer_Output_ToWrite())];
        }

        public List<Output> Get_stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output()
        {
            return _stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output;
        }
        public Input Get_FRONT_inputDoubleBuffer(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            return _stat_REG_doublebuffer_Client_InputSend[BoolToInt16(obj.Get_client().Get_stat_CLASS_data().Get_state_Buffer_Input_ToWrite())];
        }
        public Input Get_BACK_inputDoubleBuffer(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            return _stat_REG_doublebuffer_Client_InputSend[BoolToInt16(!obj.Get_client().Get_stat_CLASS_data().Get_state_Buffer_Input_ToWrite())];
        }
        public List<Input> Get_stat_REG_Stack_At_Client_InputSend_List_Of_Input()
        {
            return _stat_REG_Stack_At_Client_InputSend_List_Of_Input;
        }
        public void Set_inputDoubleBuffer(OpenAvrilCFSD.ClientAssembly.Framework_Client obj, Input value)
        {
            _stat_REG_doublebuffer_Client_InputSend[BoolToInt16(obj.Get_client().Get_stat_CLASS_data().Get_state_Buffer_Input_ToWrite())] = value;
        }
        private void Set_stat_REG_Buffer_Reference_For_Core_Of_Output(byte concurrenctCoreId, Output input_Instance)
        {
            _stat_REG_Buffer_Reference_For_Core_Of_Output[concurrenctCoreId] = input_Instance;
        }
        private void Set_stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output(List<Output> stack_Client_OutputRecieves)
        {
            _stat_REG_Stack_At_Client_OutputRecieve_List_Of_Output = stack_Client_OutputRecieves;
        }
        static public void stat_CLASS_boot0_DECLAIRE_Data()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Data().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Data()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Data().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Data()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Data().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Data()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Data().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Data().");//TESTBENCH
        }
        // private.
        private UInt16 BoolToInt16(bool value)
        {
            UInt16 temp = new UInt16();
            if (value)
            {
                temp = (UInt16)1;
            }
            else if (!value)
            {
                temp = (UInt16)0;
            }
            return temp;
        }
    }
}

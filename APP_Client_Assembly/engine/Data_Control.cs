using APP_ClientAssembly.structs;
using APP_ClientAssembly.structs.user_praise_files;
using System.Threading;

namespace OpenAvrilCFSD.ClientAssembly
{
    public class Data_Control
    {
        private bool _state_Buffer_Input_ToWrite;
        private bool _state_Buffer_Output_ToWrite
        private bool _flag_IsLoaded_Stack_InputAction;
        private bool _flag_IsLoaded_Stack_OutputRecieve;
        private bool[] _isPraiseActive;

        public Data_Control()
        {
            Set_flag_IsLoaded_Stack_InputAction(false);
            Set_flag_IsLoaded_Stack_OutputRecieve(false);
        }
        public void Initialise(OpenAvrilCFSD.ClientAssembly.Framework_Client obj)
        {
            _isPraiseActive = new bool[obj.Get_client().stat_CLASS_get_global().Get_stat_REG_numberOfPraises()];
            for (int index = 0; index < obj.Get_client().stat_CLASS_get_global().Get_stat_REG_numberOfPraises(); index++)
            {
                Set_isPraiseActive(index, false);
            }
        }
        public void Flip_InBufferToWrite()
        {
            Set_state_Buffer_Input_ToWrite(!Get_state_Buffer_Input_ToWrite());
        }
        public void Flip_OutBufferToWrite()
        {
            Set_state_Buffer_Output_ToWrite(!Get_state_Buffer_Output_ToWrite());
        }
        public void Push_Stack_Client_InputAction(OpenAvrilCFSD.ClientAssembly.Framework_Client obj,
            List<Input> stack_Client_InputSend,
            Input BACK_inputDoubleBuffer
        )
        {
            System.Console.WriteLine("entered => Push_Stack_Client_InputAction()");//TestBench
            stack_Client_InputSend.Add(BACK_inputDoubleBuffer);
            if(stack_Client_InputSend.Count > 1)
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_InputAction(true);
                System.Console.WriteLine("Set_flag_IsLoaded_Stack_InputAction = true, " + "stack.count = " + stack_Client_InputSend.Count);//TestBench
            }
            else
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_InputAction(false);
                System.Console.WriteLine("Set_flag_IsLoaded_Stack_InputAction = false, " + "stack.count = " + stack_Client_InputSend.Count);//TestBench
            }
            System.Console.WriteLine("exiting => Push_Stack_Client_InputAction()");//TestBench
        }
        public void Push_Stack_Client_OutputRecieve(OpenAvrilCFSD.ClientAssembly.Framework_Client obj,
            List<Output> stack_Client_OutputRecieves,
            Output FRONT_outputDoubleBuffer
        )
        {
            stack_Client_OutputRecieves.Add(FRONT_outputDoubleBuffer);
            if (stack_Client_OutputRecieves.Count >= 2)
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_OutputRecieve(true);
            }
            else
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_OutputRecieve(false);
            }
        }
        public void Pop_Stack_InputAction(OpenAvrilCFSD.ClientAssembly.Framework_Client obj,
            Input FRONT_inputDoubleBuffer,
            List<Input> stack_Client_InputSend
        )
        {
            FRONT_inputDoubleBuffer = stack_Client_InputSend.ElementAt(1);
            stack_Client_InputSend.RemoveAt(1);
            if (stack_Client_InputSend.Count >= 2)
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_InputAction(true);
            }
            else
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_InputAction(false);
            }
        }
        public void Pop_Stack_OutputRecieve(OpenAvrilCFSD.ClientAssembly.Framework_Client obj,
            Output buffer_Output_Recieve_Reference_ForCore,
            List<Output> stack_Client_OutputRecieves
        )
        {
            buffer_Output_Recieve_Reference_ForCore = stack_Client_OutputRecieves.ElementAt(1);
            stack_Client_OutputRecieves.RemoveAt(1);
            if (stack_Client_OutputRecieves.Count >= 2)
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_OutputRecieve(true);
            }
            else
            {
                obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_flag_IsLoaded_Stack_OutputRecieve(false);
            }
        }

        public void Do_Store_PraiseOutputRecieve_To_GameInstanceData(OpenAvrilCFSD.ClientAssembly.Framework_Client obj, Output stackSlot)
        {
            switch (stackSlot.Get_praiseEventId())
            {
                case 0:
                    break;

                case 1:
                    var output_Subset_Praise1 = (Praise1_Output)stackSlot.Get_praiseOutputBuffer_Subset();
                    obj.Get_client().Get_stat_CLASS_data().Get_gameInstance().Get_gameObjectFactory().Get_player().Get_CameraFP().Set_fowards(output_Subset_Praise1.Get_fowards());
                    obj.Get_client().Get_stat_CLASS_data().Get_gameInstance().Get_gameObjectFactory().Get_player().Get_CameraFP().Set_right(output_Subset_Praise1.Get_right());
                    obj.Get_client().Get_stat_CLASS_data().Get_gameInstance().Get_gameObjectFactory().Get_player().Get_CameraFP().Set_up(output_Subset_Praise1.Get_up());
                    obj.Get_client().Get_stat_CLASS_data().Get_stat_CLASS_data_Control().Set_isPraiseActive(1, false);
                    break;
            }
        }
        public bool Get_flag_IsLoaded_Stack_InputAction()
        {
            return _flag_IsLoaded_Stack_InputAction;
        }
        public bool Get_flag_IsLoaded_Stack_OutputRecieve()
        {
            return _flag_IsLoaded_Stack_OutputRecieve;
        }
        public bool Get_isPraiseActive(int praiseEventId)
        {
            return _isPraiseActive[praiseEventId];
        }
        public bool Get_state_Buffer_Input_ToWrite()
        {
            return _state_Buffer_Input_ToWrite;
        }
        public bool Get_state_Buffer_Output_ToWrite()
        {
            return _state_Buffer_Output_ToWrite;
        }
        public bool Get_IsSelected_PraiseEventId(int index)
        {
            return _isSelected_PraiseEventId[index];
        }

        public int GetLength_IsSelected_PraiseEventId()
        {
            return _isSelected_PraiseEventId.Length;
        }

        public void SetIsSelected_PraiseEventId(int index, bool value)
        {
            _isSelected_PraiseEventId[index] = value;
        }
        public void Set_flag_IsLoaded_Stack_InputAction(bool value)
        {
            _flag_IsLoaded_Stack_InputAction = value;
        }
        public void Set_flag_IsLoaded_Stack_OutputRecieve(bool value)
        {
            _flag_IsLoaded_Stack_OutputRecieve = value;
        }
        public void Set_isPraiseActive(int praiseEventId, bool value)
        {
            _isPraiseActive[praiseEventId] = value; 
        }
        private void Set_state_Buffer_Input_ToWrite(bool state_Buffer_Input_ToWrite)
        {
            _state_Buffer_Input_ToWrite = state_Buffer_Input_ToWrite;
        }
        private void Set_state_Buffer_Output_ToWrite(bool state_Buffer_Output_ToWrite)
        {
            _state_Buffer_Output_ToWrite = state_Buffer_Output_ToWrite;
        }
    }
}

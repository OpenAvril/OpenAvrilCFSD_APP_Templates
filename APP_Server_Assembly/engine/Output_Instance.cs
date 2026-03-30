
namespace OpenAvrilCFSD.ServerAssembly.Outputs
{
    public class Output_Instance
    {
        private OpenAvrilCFSD.ServerAssembly.Outputs.Output _empty_OutputBuffer;
        private OpenAvrilCFSD.ServerAssembly.Outputs.Output[] _outputDoubleBuffer;

        public Output_Instance() 
        {
            Set_empty_OutputBuffer(new OpenAvrilCFSD.ServerAssembly.Outputs.Output());
            while (Get_empty_OutputBuffer() == null) { }
            Get_empty_OutputBuffer().InitialiseControl();

            _outputDoubleBuffer = new OpenAvrilCFSD.ServerAssembly.Outputs.Output[2];
            for (byte index = 0; index < 2; index++)
            {
                _outputDoubleBuffer[index] = Get_empty_OutputBuffer();
                while (_outputDoubleBuffer[index] == null) { }
            }
        }

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

        public OpenAvrilCFSD.ServerAssembly.Outputs.Output Get_empty_OutputBuffer()
        {
            return _empty_OutputBuffer;
        }
        public OpenAvrilCFSD.ServerAssembly.Outputs.Output Get_FRONT_outputDoubleBuffer(OpenAvrilCFSD.ServerAssembly.Framework_Server obj)
        {
            return _outputDoubleBuffer[BoolToInt16(obj.Get_server().Get_data().Get_state_Buffer_Output_ToWrite())];
        }
        public OpenAvrilCFSD.ServerAssembly.Outputs.Output Get_BACK_outputDoubleBuffer(OpenAvrilCFSD.ServerAssembly.Framework_Server obj)
        {
            return _outputDoubleBuffer[BoolToInt16(!obj.Get_server().Get_data().Get_state_Buffer_Output_ToWrite())];
        }
        private void Set_empty_OutputBuffer(OpenAvrilCFSD.ServerAssembly.Outputs.Output value)
        {
            _empty_OutputBuffer = value;
        }
        public void Set_outputDoubleBuffer(OpenAvrilCFSD.ServerAssembly.Framework_Server obj, OpenAvrilCFSD.ServerAssembly.Outputs.Output value)
        {
            _outputDoubleBuffer[BoolToInt16(!obj.Get_server().Get_data().Get_state_Buffer_Output_ToWrite())] = value;
        }
    }
}

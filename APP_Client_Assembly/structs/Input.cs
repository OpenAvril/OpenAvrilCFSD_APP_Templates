using System;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct Input
    {
        private Input_Control _input_Control;
        private object _praiseInputBuffer_Subset;
        private byte _praiseEventId;
        private byte _playerId;

        public void InitialiseControl() 
        {
            Set_input_Control(new Input_Control());
            while (Get_input_Control() == null) { }
        }
        public Input_Control Get_input_Control()
        {
            return _input_Control;
        }
        public object Get_praiseInputBuffer_Subset()
        {
            return _praiseInputBuffer_Subset;
        }
        public byte Get_praiseEventId()
        {
            return _praiseEventId;
        }
        public byte Get_playerId()
        {
            return _playerId;
        }
        public void Set_input_Control(Input_Control value)
        {
            _input_Control = value;
        }
        public void Set_praiseInputBuffer_Subset(object value)
        {
            _praiseInputBuffer_Subset = value;
        }
        
        public void Set_praiseEventId(byte value)
        {
            _praiseEventId = value;
        }
        public void Set_playerId(byte value)
        {
            _playerId = value;
        }
    }
}
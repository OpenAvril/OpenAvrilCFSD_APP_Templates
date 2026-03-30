using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct Input
    {
        static private Input_Control _stat_CLASS_Input_Control;
        static private object _stat_REG_BufferSubset_Input;
        static private byte _stat_REG_playerId;
        static private byte _stat_REG_praiseEventId;
// public.
        public Input_Control dyn_CLASS_get_Input_Control()
        {
            return stat_REG_get_Input_Control();
        }
        public void dyn_REG_boot0_DECLAIRE_Input()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Input().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Input().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Input().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_playerId();
            stat_REG_boot2_SUBSTANTIATE_praiseEventId();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Input().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Input().");//TESTBENCH
            stat_REG_boot3_INITIALISE_playerId();
            stat_REG_boot3_INITIALISE_praiseEventId();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Input().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Input()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_Input().");//TESTBENCH
            stat_CLASS_boot1_DEFINE_Input_Control();
            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_Input().");//TESTBENCH
            stat_CLASS_boot3_INITIALISE_Input_Control();
            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_Input().");//TESTBENCH
        }
        public object dyn_REG_get_BufferSubset_Input()
        {
            return stat_REG_get_BufferSubset_Input();
        }
        public byte dyn_REG_get_playerId()
        {
            return stat_REG_get_playerId();
        }
        public byte dyn_REG_get_praiseEventId()
        {
            return stat_REG_get_praiseEventId();
        }
        public void dyn_REG_set_BufferSubset_Input(Praise0_Input objPraise0_Input)
        {
            dyn_REG_set_BufferSubset_Input(objPraise0_Input);
        }
        public void dyn_REG_set_BufferSubset_Input(Praise1_Input objPraise1_Input)
        {
            dyn_REG_set_BufferSubset_Input(objPraise1_Input);
        }
        public void dyn_REG_set_BufferSubset_Input(Praise2_Input objPraise2_Input)
        {
            dyn_REG_set_BufferSubset_Input(objPraise2_Input);
        }
        public void dyn_REG_set_playerId(byte newValue)
        {
            dyn_REG_set_playerId(newValue);
        }
        public void dyn_REG_set_praiseEventId(byte newValue)
        {
            dyn_REG_set_praiseEventId(newValue);
        }
        // private.
        static private void stat_CLASS_boot1_DEFINE_Input_Control()
        {
            _stat_CLASS_Input_Control = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_Input_Control()
        {
            _stat_CLASS_Input_Control = new Input_Control();
            while (stat_REG_get_Input_Control() == null) { }
        }
        static private void stat_REG_boot2_SUBSTANTIATE_playerId()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_playerId().");//TESTBENCH
            _stat_REG_playerId = new byte();
            _stat_REG_playerId = Byte.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_playerId().");//TESTBENCH
        }
        static private void stat_REG_boot2_SUBSTANTIATE_praiseEventId()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praiseEventId().");//TESTBENCH
            _stat_REG_praiseEventId = new byte();
            _stat_REG_praiseEventId = Byte.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praiseEventId().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_playerId()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_playerId().");//TESTBENCH
            _stat_REG_playerId = (byte)(0.0);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_playerId().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praiseEventId()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praiseEventId().");//TESTBENCH
            _stat_REG_praiseEventId = (byte)(0.0);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praiseEventId().");//TESTBENCH
        }
// private.
        static private Input_Control stat_REG_get_Input_Control()
        {
            return _stat_CLASS_Input_Control;
        }
        static private Object stat_REG_get_BufferSubset_Input()
        {
            return _stat_REG_BufferSubset_Input;
        }
        static private byte stat_REG_get_playerId()
        {
            return _stat_REG_playerId;
        }
        static private byte stat_REG_get_praiseEventId()
        {
            return _stat_REG_praiseEventId;
        }
        public void stat_REG_set_BufferSubset_Input(Praise0_Input objPraise0_Input)
        {
            _stat_REG_BufferSubset_Input = (Object)objPraise0_Input;
        }
        public void stat_REG_set_BufferSubset_Input(Praise1_Input objPraise1_Input)
        {
            _stat_REG_BufferSubset_Input = (Object)objPraise1_Input;
        }
        public void stat_REG_set_BufferSubset_Input(Praise2_Input objPraise2_Input)
        {
            _stat_REG_BufferSubset_Input = (Object)objPraise2_Input;
        }
        public void stat_REG_set_playerId(byte newValue)
        {
            _stat_REG_playerId = newValue;
        }
        public void stat_REG_set_praiseEventId(byte newValue)
        {
            _stat_REG_praiseEventId = newValue;
        }
    }
}
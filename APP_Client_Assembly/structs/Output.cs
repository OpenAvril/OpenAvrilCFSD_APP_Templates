using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct Output
    {
        static private Output_Control _stat_CLASS_Output_Control;
        static private object _stat_REG_BufferSubset_Output;
        static private byte _stat_REG_playerId;
        static private byte _stat_REG_praiseEventId;
        // public.
        public Output_Control dyn_CLASS_get_Output_Control()
        {
            return stat_CLASS_get_Output_Control();
        }
        public void dyn_REG_boot0_DECLAIRE_Output()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Output().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Output().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Output().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_playerId();
            stat_REG_boot2_SUBSTANTIATE_praiseEventId();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Output().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Output().");//TESTBENCH
            stat_REG_boot3_INITIALISE_playerId();
            stat_REG_boot3_INITIALISE_praiseEventId();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Output().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Output()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_Output().");//TESTBENCH
            stat_CLASS_boot1_DEFINE_Output_Control();
            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_Output().");//TESTBENCH
            stat_CLASS_boot3_INITIALISE_Output_Control();
            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_Output().");//TESTBENCH
        }
        public object dyn_REG_get_BufferSubset_Output()
        {
            return stat_REG_get_BufferSubset_Output();
        }
        public byte dyn_REG_get_playerId()
        {
            return stat_REG_get_playerId();
        }
        public byte dyn_REG_get_praiseEventId()
        {
            return stat_REG_get_praiseEventId();
        }
        public void dyn_REG_set_BufferSubset_Output(Praise0_Output objPraise0_Output)
        {
            dyn_REG_set_BufferSubset_Output(objPraise0_Output);
        }
        public void dyn_REG_set_BufferSubset_Output(Praise1_Output objPraise1_Output)
        {
            dyn_REG_set_BufferSubset_Output(objPraise1_Output);
        }
        public void dyn_REG_set_BufferSubset_Output(Praise2_Output objPraise2_Output)
        {
            dyn_REG_set_BufferSubset_Output(objPraise2_Output);
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
        static private void stat_CLASS_boot1_DEFINE_Output_Control()
        {
            _stat_CLASS_Output_Control = null;
        }
        static private void stat_CLASS_boot3_INITIALISE_Output_Control()
        {
            _stat_CLASS_Output_Control = new Output_Control();
            while (stat_CLASS_get_Output_Control() == null) { }
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
        static private Output_Control stat_CLASS_get_Output_Control()
        {
            return _stat_CLASS_Output_Control;
        }
        static private Object stat_REG_get_BufferSubset_Output()
        {
            return _stat_REG_BufferSubset_Output;
        }
        static private byte stat_REG_get_playerId()
        {
            return _stat_REG_playerId;
        }
        static private byte stat_REG_get_praiseEventId()
        {
            return _stat_REG_praiseEventId;
        }
        public void stat_REG_set_BufferSubset_Output(Praise0_Output objPraise0_Output)
        {
            _stat_REG_BufferSubset_Output = (Object)objPraise0_Output;
        }
        public void stat_REG_set_BufferSubset_Output(Praise1_Output objPraise1_Output)
        {
            _stat_REG_BufferSubset_Output = (Object)objPraise1_Output;
        }
        public void stat_REG_set_BufferSubset_Output(Praise2_Output objPraise2_Output)
        {
            _stat_REG_BufferSubset_Output = (Object)objPraise2_Output;
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
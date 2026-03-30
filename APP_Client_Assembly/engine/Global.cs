namespace OpenAvrilCFSD.ClientAssembly
{
    public class Global
    {
        static private byte _stat_REG_numberOfCores;
        static private byte _stat_REG_numberOfPraises;
// public.
        public Global() 
        {
            System.Console.WriteLine("entered CONSTRUCTOR Global().");//TESTBENCH
            stat_CLASS_boot0_DECLAIRE_Global();
            stat_CLASS_boot1_DEFINE_Global();
            stat_CLASS_boot3_INITIALISE_Global();
            stat_REG_boot0_DECLAIRE_Global();
            System.Console.WriteLine("exiting CONSTRUCTOR Global().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_Global()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Global().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Global().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Global()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Global().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_numberOfCores();
            stat_REG_boot2_SUBSTANTIATE_numberOfPraises();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Global().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Global()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Global().");//TESTBENCH
            stat_REG_boot3_INITIALISE_numberOfCores();
            stat_REG_boot3_INITIALISE_numberOfPraises();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Global().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Global()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Global().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Global().");//TESTBENCH
        }
        public byte dyn_REG_get_numberOfCores()
        {
            return stat_REG_get_numberOfCores();
        }

        public byte dyn_REG_get_numberOfPraises()
        {
            return stat_REG_get_numberOfPraises();
        }
        static public void stat_CLASS_boot0_DECLAIRE_Global()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Global().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Global().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Global()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Global().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Global().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Global()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Global().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Global().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Global()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Global().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Global().");//TESTBENCH
        }
    // private.
        static private void stat_REG_boot2_SUBSTANTIATE_numberOfCores()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_numberOfCores().");//TESTBENCH
            _stat_REG_numberOfCores = new byte();
            _stat_REG_numberOfCores = Byte.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_numberOfCores().");//TESTBENCH
        }
        static private void stat_REG_boot2_SUBSTANTIATE_numberOfPraises()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_numberOfPraises().");//TESTBENCH
            _stat_REG_numberOfPraises = new byte();
            _stat_REG_numberOfPraises = Byte.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_numberOfPraises().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_numberOfCores()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_numberOfCores().");//TESTBENCH
            _stat_REG_numberOfCores = (byte)(4);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_numberOfCores().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_numberOfPraises()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_numberOfPraises().");//TESTBENCH
            _stat_REG_numberOfPraises = (byte)(1);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_numberOfPraises().");//TESTBENCH
        }
        static private byte stat_REG_get_numberOfCores()
        {
            return _stat_REG_numberOfCores;
        }
        static private byte stat_REG_get_numberOfPraises()
        {
            return _stat_REG_numberOfPraises;
        }
    }
}

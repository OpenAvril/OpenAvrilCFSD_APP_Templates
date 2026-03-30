
namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public struct Praise1_Output
    {
        static private double _stat_REG_Output_praise1_value;
        // public.
        public void dyn_REG_boot1_DECLAIRE_praise1_Output()
        {
            System.Console.WriteLine("entered stat_REG_boot1_DECLAIRE_praise1_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot1_DECLAIRE_praise1_Output().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_praise1_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_praise1_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_praise1_Output().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_praise1_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_praise1_Output().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_praise1_value();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_praise1_Output().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_praise1_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_praise1_Output().");//TESTBENCH
            stat_REG_boot3_INITIALISE_praise1_value();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_praise1_Output().");//TESTBENCH
        }
        public double dyn_REG_get_praise1_value()
        {
            return stat_REG_get_praise1_value();
        }
        static public void dyn_REG_set_praise1_value(double newValue)
        {
            stat_REG_set_praise1_value(newValue);
        }
        public void dyn_PGM_boot4_INSTANCIATE_praise1_Output()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_praise1_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_praise1_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DECLAIRE_praise1_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DECLAIRE_praise1_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DECLAIRE_praise1_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_praise1_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_praise1_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_praise1_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_praise1_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_praise1_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_praise1_Output().");//TESTBENCH
        }
        // private.
        static private void stat_REG_boot2_SUBSTANTIATE_praise1_value()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise1_valueA().");//TESTBENCH
            _stat_REG_Output_praise1_value = new double();
            _stat_REG_Output_praise1_value = double.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise1_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise1_value()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise1_valueA().");//TESTBENCH
            _stat_REG_Output_praise1_value = (float)(1.1);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise1_valueA().");//TESTBENCH
        }
        public double stat_REG_get_praise1_value()
        {
            return _stat_REG_Output_praise1_value;
        }
        static public void stat_REG_set_praise1_value(double newValue)
        {
            _stat_REG_Output_praise1_value = newValue;
        }
    }
}


namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public struct Praise2_Output
    {
        static private double _stat_REG_Output_praise2_value;
        // public.
        public void dyn_REG_boot2_DECLAIRE_praise2_Output()
        {
            System.Console.WriteLine("entered stat_REG_boot2_DECLAIRE_praise2_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot2_DECLAIRE_praise2_Output().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_praise2_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_praise2_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_praise2_Output().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_praise2_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_praise2_Output().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_praise2_value();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_praise2_Output().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_praise2_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_praise2_Output().");//TESTBENCH
            stat_REG_boot3_INITIALISE_praise2_value();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_praise2_Output().");//TESTBENCH
        }
        public double dyn_REG_get_praise2_value()
        {
            return stat_REG_get_praise2_value();
        }
        static public void dyn_REG_set_praise2_value(double newValue)
        {
            stat_REG_set_praise2_value(newValue);
        }
        public void dyn_PGM_boot4_INSTANCIATE_praise2_Output()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_praise2_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_praise2_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot2_DECLAIRE_praise2_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot2_DECLAIRE_praise2_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot2_DECLAIRE_praise2_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_praise2_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_praise2_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_praise2_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_praise2_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_praise2_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_praise2_Output().");//TESTBENCH
        }
        // private.
        static private void stat_REG_boot2_SUBSTANTIATE_praise2_value()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise2_valueA().");//TESTBENCH
            _stat_REG_Output_praise2_value = new double();
            _stat_REG_Output_praise2_value = double.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise2_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise2_value()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise2_valueA().");//TESTBENCH
            _stat_REG_Output_praise2_value = (float)(2.2);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise2_valueA().");//TESTBENCH
        }
        public double stat_REG_get_praise2_value()
        {
            return _stat_REG_Output_praise2_value;
        }
        static public void stat_REG_set_praise2_value(double newValue)
        {
            _stat_REG_Output_praise2_value = newValue;
        }
    }
}

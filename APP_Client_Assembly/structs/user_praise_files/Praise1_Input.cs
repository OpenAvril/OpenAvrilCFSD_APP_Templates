namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public struct Praise1_Input
    {
        static private float _Stat_REG_Input_praise1_valueA;
        static private float _Stat_REG_Input_praise1_valueB;
// public.
        public void dyn_REG_boot1_DECLAIRE_praise1_Input()
        {
            System.Console.WriteLine("entered stat_REG_boot1_DECLAIRE_praise1_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot1_DECLAIRE_praise1_Input().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_praise1_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_praise1_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_praise1_Input().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_praise1_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_praise1_Input().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_praise1_valueA();
            stat_REG_boot2_SUBSTANTIATE_praise1_valueB();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_praise1_Input().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_praise1_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_praise1_Input().");//TESTBENCH
            stat_REG_boot3_INITIALISE_praise1_valueA();
            stat_REG_boot3_INITIALISE_praise1_valueB();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_praise1_Input().");//TESTBENCH
        }
        public float dyn_REG_get_praise1_valuea()
        {
            return stat_REG_get_praise1_valueA();
        }
        public float dyn_REG_get_praise1_valueB()
        {
            return stat_REG_get_praise1_valueB();
        }
        public void dyn_PGM_boot4_INSTANCIATE_praise1_Input()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_praise1_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_praise1_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DECLAIRE_praise1_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DECLAIRE_praise1_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DECLAIRE_praise1_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_praise1_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_praise1_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_praise1_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_praise1_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_praise1_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_praise1_Input().");//TESTBENCH
        }
// private.
        static private void stat_REG_boot2_SUBSTANTIATE_praise1_valueA()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise1_valueA().");//TESTBENCH
            _Stat_REG_Input_praise1_valueA = new float();
            _Stat_REG_Input_praise1_valueA = float.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise1_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot2_SUBSTANTIATE_praise1_valueB()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise1_valueB().");//TESTBENCH
            _Stat_REG_Input_praise1_valueB = new float();
            _Stat_REG_Input_praise1_valueB = float.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise1_valueB().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise1_valueA()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise1_valueA().");//TESTBENCH
            _Stat_REG_Input_praise1_valueA = (float)(1.1);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise1_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise1_valueB()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise1_valueB().");//TESTBENCH
            _Stat_REG_Input_praise1_valueB = (float)(1.1);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise1_valueB().");//TESTBENCH
        }
        public float stat_REG_get_praise1_valueA()
        {
            return _Stat_REG_Input_praise1_valueA;
        }
        public float stat_REG_get_praise1_valueB() 
        {
            return _Stat_REG_Input_praise1_valueB;
        }
    }
}

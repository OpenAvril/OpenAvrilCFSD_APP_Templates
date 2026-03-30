namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public struct Praise0_Input
    {
        static private float _Stat_REG_Input_praise0_valueA;
        static private float _Stat_REG_Input_praise0_valueB;
// public.
        public void dyn_REG_boot0_DECLAIRE_praise0_Input()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_praise0_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_praise0_Input().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_praise0_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_praise0_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_praise0_Input().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_praise0_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_praise0_Input().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_praise0_valueA();
            stat_REG_boot2_SUBSTANTIATE_praise0_valueB();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_praise0_Input().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_praise0_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_praise0_Input().");//TESTBENCH
            stat_REG_boot3_INITIALISE_praise0_valueA();
            stat_REG_boot3_INITIALISE_praise0_valueB();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_praise0_Input().");//TESTBENCH
        }
        public float dyn_REG_get_praise0_valueA()
        {
            return stat_REG_get_praise0_valueA();
        }
        public float dyn_REG_get_praise0_valueB()
        {
            return stat_REG_get_praise0_valueB();
        }
        public void dyn_PGM_boot4_INSTANCIATE_praise0_Input()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_praise0_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_praise0_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_praise0_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_praise0_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_praise0_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_praise0_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_praise0_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_praise0_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_praise0_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_praise0_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_praise0_Input().");//TESTBENCH
        }
// private.
        static private void stat_REG_boot2_SUBSTANTIATE_praise0_valueA()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise0_valueA().");//TESTBENCH
            _Stat_REG_Input_praise0_valueA = new float();
            _Stat_REG_Input_praise0_valueA = float.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise0_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot2_SUBSTANTIATE_praise0_valueB()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise0_valueB().");//TESTBENCH
            _Stat_REG_Input_praise0_valueB = new float();
            _Stat_REG_Input_praise0_valueB = float.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise0_valueB().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise0_valueA()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise0_valueA().");//TESTBENCH
            _Stat_REG_Input_praise0_valueA = (float)(0.0);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise0_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise0_valueB()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise0_valueB().");//TESTBENCH
            _Stat_REG_Input_praise0_valueB = (float)(0.0);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise0_valueB().");//TESTBENCH
        }
        public float stat_REG_get_praise0_valueA()
        {
            return _Stat_REG_Input_praise0_valueA;
        }
        public float stat_REG_get_praise0_valueB() 
        {
            return _Stat_REG_Input_praise0_valueB;
        }
    }
}

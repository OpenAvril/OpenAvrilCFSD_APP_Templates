using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct User_I
    {
        static private Praise0_Input _stat_STRUCT_Praise0_Input;
        static private Praise1_Input _stat_STRUCT_Praise1_Input;
        static private Praise2_Input _stat_STRUCT_Praise2_Input;
        // public.
        public void dyn_REG_boot0_DECLAIRE_User_I()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_User_I().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_User_I()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_User_I().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_User_I()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_User_I().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_User_I()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_User_I().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_User_I()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_User_I().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_User_I()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_User_I().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_User_I()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_User_I().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_User_I().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_User_I()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_User_I().");//TESTBENCH
            stat_STRUCT_boot3_INITIALISE_praise0_Input();
            stat_STRUCT_boot3_INITIALISE_praise1_Input();
            stat_STRUCT_boot3_INITIALISE_praise2_Input();
            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_User_I().");//TESTBENCH
        }
        public Praise0_Input dyn_STRUCT_get_Praise0_Input()
        {
            return stat_STRUCT_get_Praise0_Input();
        }
        public Praise1_Input dyn_STRUCT_get_Praise1_Input()
        {
            return stat_STRUCT_get_Praise1_Input();
        }
        public Praise2_Input dyn_STRUCT_get_Praise2_Input()
        {
            return stat_STRUCT_get_Praise2_Input();
        }
        // private.
        static private void stat_STRUCT_boot3_INITIALISE_praise0_Input()
        {
            _stat_STRUCT_Praise0_Input = new Praise0_Input();
        }
        static private void stat_STRUCT_boot3_INITIALISE_praise1_Input()
        {
            _stat_STRUCT_Praise1_Input = new Praise1_Input();
        }
        static private void stat_STRUCT_boot3_INITIALISE_praise2_Input()
        {
            _stat_STRUCT_Praise2_Input = new Praise2_Input();
        }
        static private Praise0_Input stat_STRUCT_get_Praise0_Input()
        {
            return _stat_STRUCT_Praise0_Input;
        }
        static private Praise1_Input stat_STRUCT_get_Praise1_Input()
        {
            return _stat_STRUCT_Praise1_Input;
        }
        static private Praise2_Input stat_STRUCT_get_Praise2_Input()
        {
            return _stat_STRUCT_Praise2_Input;
        }
    }
}

using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct User_O
    {
        static private Praise0_Output _stat_STRUCT_Praise0_Output;
        static private Praise1_Output _stat_STRUCT_Praise1_Output;
        static private Praise2_Output _stat_STRUCT_Praise2_Output;
        // public.
        public void dyn_REG_boot0_DECLAIRE_User_O()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_User_O().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_User_O()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_User_O().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_User_O()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_User_O().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_User_O()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_User_O().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_User_O()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_User_O().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_User_O()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_User_O().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_User_O()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_User_O().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_User_O().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_User_O()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_User_O().");//TESTBENCH
            stat_STRUCT_boot3_INITIALISE_praise0_Output();
            stat_STRUCT_boot3_INITIALISE_praise1_Output();
            stat_STRUCT_boot3_INITIALISE_praise2_Output();
            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_User_O().");//TESTBENCH
        }
        public Praise0_Output dyn_STRUCT_get_Praise0_Output()
        {
            return stat_STRUCT_get_Praise0_Output();
        }
        public Praise1_Output dyn_STRUCT_get_Praise1_Output()
        {
            return stat_STRUCT_get_Praise1_Output();
        }
        public Praise2_Output dyn_STRUCT_get_Praise2_Output()
        {
            return stat_STRUCT_get_Praise2_Output();
        }
        // private.
        static private void stat_STRUCT_boot3_INITIALISE_praise0_Output()
        {
            _stat_STRUCT_Praise0_Output = new Praise0_Output();
        }
        static private void stat_STRUCT_boot3_INITIALISE_praise1_Output()
        {
            _stat_STRUCT_Praise1_Output = new Praise1_Output();
        }
        static private void stat_STRUCT_boot3_INITIALISE_praise2_Output()
        {
            _stat_STRUCT_Praise2_Output = new Praise2_Output();
        }
        static private Praise0_Output stat_STRUCT_get_Praise0_Output()
        {
            return _stat_STRUCT_Praise0_Output;
        }
        static private Praise1_Output stat_STRUCT_get_Praise1_Output()
        {
            return _stat_STRUCT_Praise1_Output;
        }
        static private Praise2_Output stat_STRUCT_get_Praise2_Output()
        {
            return _stat_STRUCT_Praise2_Output;
        }
    }
}

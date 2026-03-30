using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct User_Alg
    {
        static private Praise0_Algorithim _stat_STRUCT_Praise0_Algorithim;
        static private Praise1_Algorithim _stat_STRUCT_Praise1_Algorithim;
        static private Praise2_Algorithim _stat_STRUCT_Praise2_Algorithim;
        // public.
        public void dyn_REG_boot0_DECLAIRE_User_Alg()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_User_Alg().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_User_Alg()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_User_Alg().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_User_Alg()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_User_Alg().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_User_Alg()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_User_Alg().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_User_Alg()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_User_Alg().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_User_Alg()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_User_Alg().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_User_Alg()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_User_Alg().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_User_Alg().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_User_Alg()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_User_Alg().");//TESTBENCH
            stat_STRUCT_boot3_INITIALISE_praise0_Algorithim();
            stat_STRUCT_boot3_INITIALISE_praise1_Algorithim();
            stat_STRUCT_boot3_INITIALISE_praise2_Algorithim();
            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_User_Alg().");//TESTBENCH
        }
        public Praise0_Algorithim dyn_STRUCT_get_Praise0_Algorithim()
        {
            return stat_STRUCT_get_Praise0_Algorithim();
        }
        public Praise1_Algorithim dyn_STRUCT_get_Praise1_Algorithim()
        {
            return stat_STRUCT_get_Praise1_Algorithim();
        }
        public Praise2_Algorithim dyn_STRUCT_get_Praise2_Algorithim()
        {
            return stat_STRUCT_get_Praise2_Algorithim();
        }
        // private.
        static private void stat_STRUCT_boot3_INITIALISE_praise0_Algorithim()
        {
            _stat_STRUCT_Praise0_Algorithim = new Praise0_Algorithim();
        }
        static private void stat_STRUCT_boot3_INITIALISE_praise1_Algorithim()
        {
            _stat_STRUCT_Praise1_Algorithim = new Praise1_Algorithim();
        }
        static private void stat_STRUCT_boot3_INITIALISE_praise2_Algorithim()
        {
            _stat_STRUCT_Praise2_Algorithim = new Praise2_Algorithim();
        }
        static private Praise0_Algorithim stat_STRUCT_get_Praise0_Algorithim()
        {
            return _stat_STRUCT_Praise0_Algorithim;
        }
        static private Praise1_Algorithim stat_STRUCT_get_Praise1_Algorithim()
        {
            return _stat_STRUCT_Praise1_Algorithim;
        }
        static private Praise2_Algorithim stat_STRUCT_get_Praise2_Algorithim()
        {
            return _stat_STRUCT_Praise2_Algorithim;
        }
    }
}

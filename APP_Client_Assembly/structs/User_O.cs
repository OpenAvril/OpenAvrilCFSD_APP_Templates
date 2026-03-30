using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public class User_O
    {
        static private Praise1_Output praise1_Output;
        static private Praise2_Output praise2_Output;

        public void dyn_REG_boot1_DEFINE_Execute()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_Execute().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_Execute()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_Execute().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_Execute()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_Execute().");//TESTBENCH
        }
        public void dyn_PGM_boot4_INSTANCIATE_Execute()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_Execute().");//TESTBENCH
        }
        static public void stat_CLASS_boot0_DECLAIRE_Execute()
        {
            System.Console.WriteLine("entered stat_CLASS_boot0_DECLAIRE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot0_DECLAIRE_Execute().");//TESTBENCH
        }
        static public void stat_CLASS_boot1_DEFINE_Execute()
        {
            System.Console.WriteLine("entered stat_CLASS_boot1_DEFINE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot1_DEFINE_Execute().");//TESTBENCH
        }
        static public void stat_CLASS_boot3_INITIALISE_Execute()
        {
            System.Console.WriteLine("entered stat_CLASS_boot3_INITIALISE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_CLASS_boot3_INITIALISE_Execute().");//TESTBENCH
        }
        static public void stat_REG_boot0_DECLAIRE_Execute()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_Execute().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_Execute().");//TESTBENCH
        }

        public Praise1_Output GetPraise0_Outnput()
        {
            return praise1_Output;
        }

        public Praise2_Output GetPraise1_Output()
        {
            return praise2_Output;
        }
    }
}

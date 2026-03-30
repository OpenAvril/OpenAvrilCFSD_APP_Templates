using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public struct User_Alg
    {
        private Praise0_Algorithm _praise0_Algorithm = null;
        private Praise1_Algorithm _praise1_Algorithm = null;

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

        public Praise0_Algorithm Get_praise0_Algorithm()
        {
            return _praise0_Algorithm;
        }

        public Praise1_Algorithm Get_praise1_Algorithm()
        {
            return _praise1_Algorithm;
        }

        private void Set_praise0_Algorithm(Praise0_Algorithm praise0_Algorithm)
        {
            _praise0_Algorithm = praise0_Algorithm;
        }
        private void Set_praise1_Algorithm(Praise1_Algorithm praise1_Algorithm)
        {
            _praise1_Algorithm = praise1_Algorithm;
        }
    }
}

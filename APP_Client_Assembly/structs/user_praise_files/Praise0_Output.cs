using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public struct Praise0_Output
    {
        static private double _stat_REG_Output_praise0_value;
    // public.
        public void dyn_REG_boot0_DECLAIRE_praise0_Output()
        {
            System.Console.WriteLine("entered stat_REG_boot0_DECLAIRE_praise0_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot0_DECLAIRE_praise0_Output().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_praise0_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_praise0_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_praise0_Output().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_praise0_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_praise0_Output().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_praise0_value();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_praise0_Output().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_praise0_Output()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_praise0_Output().");//TESTBENCH
            stat_REG_boot3_INITIALISE_praise0_value();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_praise0_Output().");//TESTBENCH
        }
        public double dyn_REG_get_praise0_value()
        {
            return stat_REG_get_praise0_value();
        }
        public void dyn_REG_set_praise0_value(double newValue)
        {
            stat_REG_set_praise0_value(newValue);
        }
        public void dyn_PGM_boot4_INSTANCIATE_praise0_Output()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_praise0_Output().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_praise0_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot0_DECLAIRE_praise0_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot0_DECLAIRE_praise0_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot0_DECLAIRE_praise0_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_praise0_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_praise0_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_praise0_Output().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_praise0_Output()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_praise0_Output().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_praise0_Output().");//TESTBENCH
        }
        // private.
        static private void stat_REG_boot2_SUBSTANTIATE_praise0_value()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise0_valueA().");//TESTBENCH
            _stat_REG_Output_praise0_value = new double();
            _stat_REG_Output_praise0_value = double.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise0_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise0_value()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise0_valueA().");//TESTBENCH
            _stat_REG_Output_praise0_value = (float)(0.0);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise0_valueA().");//TESTBENCH
        }
        static public double stat_REG_get_praise0_value()
        {
            return _stat_REG_Output_praise0_value;
        }
        static public void stat_REG_set_praise0_value(double newValue)
        {
            _stat_REG_Output_praise0_value = newValue;
        }
    }
}
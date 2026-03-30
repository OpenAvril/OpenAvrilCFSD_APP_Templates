using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public struct Praise2_Input
    {
        static private float _Stat_REG_Input_praise2_valueA;
        static private float _Stat_REG_Input_praise2_valueB;
        // public.
        public void dyn_REG_boot2_DECLAIRE_praise2_Input()
        {
            System.Console.WriteLine("entered stat_REG_boot2_DECLAIRE_praise2_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_REG_boot2_DECLAIRE_praise2_Input().");//TESTBENCH
        }
        public void dyn_REG_boot1_DEFINE_praise2_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot1_DEFINE_praise2_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_REG_boot1_DEFINE_praise2_Input().");//TESTBENCH
        }
        public void dyn_REG_boot2_SUBSTANTIATE_praise2_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot2_SUBSTANTIATE_praise2_Input().");//TESTBENCH
            stat_REG_boot2_SUBSTANTIATE_praise2_valueA();
            stat_REG_boot2_SUBSTANTIATE_praise2_valueB();
            System.Console.WriteLine("exiting dyn_REG_boot2_SUBSTANTIATE_praise2_Input().");//TESTBENCH
        }
        public void dyn_REG_boot3_INITIALISE_praise2_Input()
        {
            System.Console.WriteLine("entered dyn_REG_boot3_INITIALISE_praise2_Input().");//TESTBENCH
            stat_REG_boot3_INITIALISE_praise2_valueA();
            stat_REG_boot3_INITIALISE_praise2_valueB();
            System.Console.WriteLine("exiting dyn_REG_boot3_INITIALISE_praise2_Input().");//TESTBENCH
        }
        public float dyn_REG_get_praise2_valuea()
        {
            return stat_REG_get_praise2_valueA();
        }
        public float dyn_REG_get_praise2_valueB()
        {
            return stat_REG_get_praise2_valueB();
        }
        public void dyn_PGM_boot4_INSTANCIATE_praise2_Input()
        {
            System.Console.WriteLine("entered dyn_PGM_boot4_INSTANCIATE_praise2_Input().");//TESTBENCH

            System.Console.WriteLine("exiting dyn_PGM_boot4_INSTANCIATE_praise2_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot2_DECLAIRE_praise2_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot2_DECLAIRE_praise2_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot2_DECLAIRE_praise2_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot1_DEFINE_praise2_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot1_DEFINE_praise2_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot1_DEFINE_praise2_Input().");//TESTBENCH
        }
        public void dyn_STRUCT_boot3_INITIALISE_praise2_Input()
        {
            System.Console.WriteLine("entered stat_STRUCT_boot3_INITIALISE_praise2_Input().");//TESTBENCH

            System.Console.WriteLine("exiting stat_STRUCT_boot3_INITIALISE_praise2_Input().");//TESTBENCH
        }
        // private.
        static private void stat_REG_boot2_SUBSTANTIATE_praise2_valueA()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise2_valueA().");//TESTBENCH
            _Stat_REG_Input_praise2_valueA = new float();
            _Stat_REG_Input_praise2_valueA = float.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise2_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot2_SUBSTANTIATE_praise2_valueB()
        {
            System.Console.WriteLine("entered stat_REG_boot2_SUBSTANTIATE_praise2_valueB().");//TESTBENCH
            _Stat_REG_Input_praise2_valueB = new float();
            _Stat_REG_Input_praise2_valueB = float.MaxValue;
            System.Console.WriteLine("exiting stat_REG_boot2_SUBSTANTIATE_praise2_valueB().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise2_valueA()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise2_valueA().");//TESTBENCH
            _Stat_REG_Input_praise2_valueA = (float)(2.2);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise2_valueA().");//TESTBENCH
        }
        static private void stat_REG_boot3_INITIALISE_praise2_valueB()
        {
            System.Console.WriteLine("entered stat_REG_boot3_INITIALISE_praise2_valueB().");//TESTBENCH
            _Stat_REG_Input_praise2_valueB = (float)(2.2);
            System.Console.WriteLine("exiting stat_REG_boot3_INITIALISE_praise2_valueB().");//TESTBENCH
        }
        public float stat_REG_get_praise2_valueA()
        {
            return _Stat_REG_Input_praise2_valueA;
        }
        public float stat_REG_get_praise2_valueB()
        {
            return _Stat_REG_Input_praise2_valueB;
        }
    }
}

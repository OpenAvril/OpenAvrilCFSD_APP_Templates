using OpenAvrilCFSD.ClientAssembly;

namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public class Praise1_Algorithim
    {
        public Praise1_Algorithim()
        {

        }
        public void Do_Praise(Praise0_Input objSubset_Input, Praise0_Output objSubset)
        {
            objSubset.dyn_REG_set_praise0_value((double)objSubset_Input.dyn_REG_get_praise0_valueA() - (double)objSubset_Input.dyn_REG_get_praise0_valueB());
        }
    }
}
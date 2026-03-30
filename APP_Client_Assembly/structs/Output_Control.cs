using OpenAvrilCFSD.ClientAssembly.structs;
using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public class Output_Control
    {
        public Output_Control() 
        {

        }

        public void SelectSetIntputSubset(Output objOutput, User_O objUser_O, byte praiseEventId)
        {
            switch (praiseEventId)
            {
                case 0:
                    Praise0_Output objSubet_Praise0_Output = (Praise0_Output)objUser_O.dyn_STRUCT_get_Praise0_Output();
                    objOutput.dyn_REG_set_BufferSubset_Output(objSubet_Praise0_Output);
                    break;

                case 1:
                    Praise1_Output objSubet_Praise1_Output = (Praise1_Output)objUser_O.dyn_STRUCT_get_Praise1_Output();
                    objOutput.dyn_REG_set_BufferSubset_Output(objSubet_Praise0_Output);
                    break;

                case 2:
                    Praise2_Output objSubet_Praise2_Output = (Praise2_Output)objUser_O.dyn_STRUCT_get_Praise2_Output();
                    objOutput.dyn_REG_set_BufferSubset_Output(objSubet_Praise0_Output);
                    break;
            }
        }
    }
}

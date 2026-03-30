using OpenAvrilCFSD.ClientAssembly.structs;
using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public class Input_Control
    {
        public Input_Control()
        {

        }

        public void SelectSetIntputSubset(Input objInput, User_I objUser_I, byte praiseEventId)
        {
            switch (praiseEventId)
            {
                case 0:
                    Praise0_Input objSubet_Praise0_Input = (Praise0_Input)objUser_I.dyn_STRUCT_get_Praise0_Input();
                    objInput.dyn_REG_set_BufferSubset_Input(objSubet_Praise0_Input);
                    break;

                case 1:
                    Praise1_Input objSubet_Praise1_Input = (Praise1_Input)objUser_I.dyn_STRUCT_get_Praise1_Input();
                    objInput.dyn_REG_set_BufferSubset_Input(objSubet_Praise1_Input);
                    break;

		        case 2:
                    Praise2_Input objSubet_Praise2_Input = (Praise2_Input)objUser_I.dyn_STRUCT_get_Praise2_Input();
                    objInput.dyn_REG_set_BufferSubset_Input(objSubet_Praise2_Input);
                    break;
            }
		}
    }
}

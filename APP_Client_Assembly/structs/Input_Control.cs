using OpenAvrilCFSD.ClientAssembly;

namespace OpenAvrilCFSD.ClientAssembly.structs
{
    public class Input_Control
    {
        public Input_Control()
        {

        }

        public void SelectSetIntputSubset(Framework_Client obj, int praiseEventId)
        {
            switch (praiseEventId)
            {
                case 0:
                    obj.Get_client().Get_stat_CLASS_data().Get_input_Instnace().Get_FRONT_inputDoubleBuffer(obj).Set_praiseInputBuffer_Subset(obj.Get_client().Get_stat_CLASS_data().Get_user_I().GetPraise0_Input());
                    break;

                case 1:
                    obj.Get_client().Get_stat_CLASS_data().Get_input_Instnace().Get_FRONT_inputDoubleBuffer(obj).Set_praiseInputBuffer_Subset(obj.Get_client().Get_stat_CLASS_data().Get_user_I().GetPraise1_Input());
                    break;

		        case 2:
                    obj.Get_client().Get_stat_CLASS_data().Get_input_Instnace().Get_FRONT_inputDoubleBuffer(obj).Set_praiseInputBuffer_Subset(obj.Get_client().Get_stat_CLASS_data().Get_user_I().GetPraise2_Input());
                    break;
            }
		}
    }
}

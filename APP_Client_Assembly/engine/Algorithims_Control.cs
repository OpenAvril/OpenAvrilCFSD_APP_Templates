using OpenAvrilCFSD.ClientAssembly;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAvrilCFSD.ClientAssembly
{
    public class Algorithims_Control
    {
        public Algorithims_Control()
        {

        }

        public void SelectSet_Algorithm_Subset(Framework_Client obj, byte praiseEventId, byte concurrentCoreId)
        {
            switch (praiseEventId)
            {
            case 0:
                obj.Get_client().stat_CLASS_get_algorithms().Get_concurrent(concurrentCoreId).Set_Algorithm_Subset(obj.Get_client().stat_CLASS_get_algorithms().Get_user_Alg().Get_praise0_Algorithm());
                break;

            case 1:
                obj.Get_client().stat_CLASS_get_algorithms().Get_concurrent(concurrentCoreId).Set_Algorithm_Subset(obj.Get_client().stat_CLASS_get_algorithms().Get_user_Alg().Get_praise1_Algorithm());
                break;

            }
        }
    }
}

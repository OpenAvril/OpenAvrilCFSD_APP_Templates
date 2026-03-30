using OpenAvrilCFSD.ClientAssembly;

namespace OpenAvrilCFSD.ClientAssembly.structs.user_praise_files
{
    public class Praise0_Algorithm
    {
        public Praise0_Algorithm() 
        { 
        
        }
        public void Do_Praise(Game_Instance gameInstance, byte playerId, Praise0_Output in_SubSet)
        {
            if(in_SubSet.GetFlag_IsPingActive() == true) Console.WriteLine("ping sent and ecieved.");
        }
    }
}

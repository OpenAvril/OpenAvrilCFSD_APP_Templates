using OpenAvrilCFSD.ClientAssembly.structs;
using OpenAvrilCFSD.ClientAssembly.structs.user_praise_files;
using OpenTK;
using Valve.Sockets;

namespace OpenAvrilCFSD.ClientAssembly
{ 
    public struct IO_Listen_Respond
    {
        public void Encode_NetworkingSteam_At_Client_Input(Input input, byte[] buffer)
        {
            buffer[0] = input.dyn_REG_get_praiseEventId();
            buffer[1] = input.dyn_REG_get_playerId();
            switch (input.dyn_REG_get_praiseEventId())
            {
                case 0:
                    break;

                case 1:
  
                    break;
            }
        }
        public void Decode_NetworkingSteam_At_Client_Recieve(Output output, byte[] buffer)
        {
            output.dyn_REG_set_praiseEventId(buffer[0]);
            output.dyn_REG_set_playerId(buffer[1]);
            switch (output.dyn_REG_get_praiseEventId())
            {
                case 0:

                    break;

                case 1:

                    break;
            }
        }
    }
}

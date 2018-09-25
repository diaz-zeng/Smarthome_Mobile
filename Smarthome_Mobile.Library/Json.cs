using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Smarthome_Mobile.Library.Json
{
    public class Json
    {
        public static string getJsonString(Packet.DataPacket packet)
        {
            try
            {
                return JsonConvert.SerializeObject(packet);
            }
            catch
            {
                return null;
            }
        }
        public static Packet.DataPacket getPacket(string jsonString)
        {
            try
            {
                return JsonConvert.DeserializeObject<Packet.DataPacket>(jsonString);
            }
            catch
            {
                return null;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome_Mobile.Library.Packet
{
    public class DataPacket
    {
        public PacketType packetType
        {
            get;
            set;
        }
        public ControlType controlType
        {
            get;
            set;
        }
        public SensorType sensorType
        {
            get;
            set;
        }
        public bool boolValue
        {
            get;
            set;
        }
        public bool[] boolArrayValue
        {
            get;
            set;
        }
        public byte byteValue
        {
            get;
            set;
        }
        public byte[] byteArrayValue
        {
            get;
            set;
        }
        public int intValue
        {
            get;
            set;
        }
        public float floatValue
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;
using Smarthome_Mobile.Library;
using Smarthome_Mobile.Library.Packet;
using Smarthome_Mobile.Library.Json;
using BizIdeal.Data;
using BizIdeal.Protocols;
using BizIdeal.Protocols.Packets;

namespace Smarthome_Mobile.Server
{
    public partial class Form1 : Form
    {
        public static BIControllerManager mainCtrl = new BIControllerManager(new BI25sProtocol());
        static Socket serverSocket;
        static Socket[] clientSockets;
        static int threadNumber = 0;
        static int myPort = 8885;
        Thread myThread = new Thread(ListenClientConnect);
        IPAddress ip;
        static byte[] result = new byte[1024];
        public Form1()
        {
            InitializeComponent();
            portName.Items.AddRange(SerialPort.GetPortNames());
            mainCtrl.PacketReceived += MainCtrl_PacketReceived;
            mainCtrl.PacketReceived += MainCtrl_PacketReceived1;
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private static void ListenClientConnect()
        {
            clientSockets = new Socket[10];
            while(true)
            {
                clientSockets[threadNumber] = serverSocket.Accept();
                Thread receiveThread = new Thread(receiveMessage);
                receiveThread.Start(clientSockets[threadNumber]);
                threadNumber += 1;
                if(threadNumber==10)
                {
                    threadNumber = 0;
                }
            }
        }
        private static void receiveMessage(object clientSocket)
        {
            Socket myChilentSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    int receiveNumber = myChilentSocket.Receive(result);
                    DataPacket packet = Json.getPacket(Encoding.ASCII.GetString(result, 0, receiveNumber));
                    if (packet != null)
                    {
                        if (packet.packetType == PacketType.ControlOrder)
                        {
                            switch (packet.controlType)
                            {
                                case ControlType.Buzzer:
                                    {
                                        mainCtrl.Buzzer.SetAction(0xFFFF, packet.boolValue ? BIBuzzerAction.Beep : BIBuzzerAction.Mute);
                                        break;
                                    }
                                case ControlType.DCMotor:
                                    {
                                        mainCtrl.DCMotor.SetAction(0xFFFF, packet.boolValue ? BIDCMotorAction.Backward : BIDCMotorAction.Stop);
                                        break;
                                    }
                                case ControlType.DigitalDisPlay:
                                    {
                                        mainCtrl.DigitalDisplay.SetDispNumber(0xFFFF, packet.byteValue);
                                        break;
                                    }
                                case ControlType.StepMotor:
                                    {
                                        mainCtrl.StepMotor.SetAction(0xFFFF, packet.intValue);
                                        break;
                                    }
                                case ControlType.TTL_IO:
                                    {
                                        mainCtrl.TTLIO.SetState(0xFFFF
                                            , packet.boolArrayValue[0] ? BITtlIoLEDState.ON : BITtlIoLEDState.OFF
                                            , packet.boolArrayValue[1] ? BITtlIoLEDState.ON : BITtlIoLEDState.OFF
                                            , packet.boolArrayValue[2] ? BITtlIoLEDState.ON : BITtlIoLEDState.OFF
                                            , packet.boolArrayValue[3] ? BITtlIoLEDState.ON : BITtlIoLEDState.OFF);
                                        break;
                                    }
                                case ControlType.DoorControl:
                                    {
                                        mainCtrl.FourWayRelay.SetState(0xFFFF
                                            , packet.boolValue ? BISwitchState.ON : BISwitchState.OFF
                                            , packet.boolValue ? BISwitchState.ON : BISwitchState.OFF
                                            , packet.boolValue ? BISwitchState.ON : BISwitchState.OFF
                                            , packet.boolValue ? BISwitchState.ON : BISwitchState.OFF);
                                        break;
                                    }
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void MainCtrl_PacketReceived(object sender, BIPacketReceivedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                BI25sUpgoingPacket packet = new BI25sUpgoingPacket(e.BinaryData);
                {
                    if(packet!=null)
                    {
                        for (int i = 0; i < packet.DataCount; i++)
                        {
                            if (packet.DataList[i].SensorType == BISensorType.AmbientLightSensor_TSL2550D)
                            {
                                labLight.Text = packet.DataList[i].GetFloatValue().ToString("0.0");
                                DataPacket pac = new DataPacket() { packetType = PacketType.SensorData, sensorType = SensorType.Light, floatValue = packet.DataList[i].GetFloatValue()};
                                if (chart1.Series["Light"].Points.Count >= 30)
                                {
                                    chart1.Series["Light"].Points.RemoveAt(0);
                                }
                                chart1.Series["Light"].Points.Add(float.Parse(labLight.Text));
                                if(!LightUpdata.Enabled)
                                {
                                    LightUpdata.Enabled = true;
                                }
                                if (clientSockets != null)
                                {
                                    foreach (Socket item in clientSockets)
                                    {
                                        if (item != null)
                                        {
                                            try
                                            {
                                                item.Send(Encoding.ASCII.GetBytes(Json.getJsonString(pac)));
                                            }
                                            catch
                                            {
                                                
                                            }
                                        }
                                    }
                                    Thread.Sleep(500);
                                }
                            }
                            if (packet.DataList[i].SensorType == BISensorType.OnBoardTemperatureSensor_SHT10)
                            {
                                labTemp.Text = packet.DataList[i].GetFloatValue().ToString("0.0");
                                DataPacket pac = new DataPacket() { packetType = PacketType.SensorData, sensorType = SensorType.Temp, floatValue = packet.DataList[i].GetFloatValue() };
                                if (chart1.Series["Temp"].Points.Count >= 30)
                                {
                                    chart1.Series["Temp"].Points.RemoveAt(0);
                                }
                                chart1.Series["Temp"].Points.Add(float.Parse(labTemp.Text));
                                if (!TempUpdata.Enabled)
                                {
                                    TempUpdata.Enabled = true;
                                }
                                if (clientSockets != null)
                                {
                                    foreach (Socket item in clientSockets)
                                    {
                                        if (item != null)
                                        {
                                            try
                                            {
                                                item.Send(Encoding.ASCII.GetBytes(Json.getJsonString(pac)));
                                            }
                                            catch 
                                            {
                                                       
                                            }
                                        }
                                    }
                                    Thread.Sleep(500);
                                }
                            }
                            if (packet.DataList[i].SensorType == BISensorType.OnBoardHumiditySensor_SHT10)
                            {
                                labHumidity.Text = packet.DataList[i].GetFloatValue().ToString("0.0");
                                DataPacket pac = new DataPacket() { packetType = PacketType.SensorData, sensorType = SensorType.Humidity, floatValue = packet.DataList[i].GetFloatValue() };
                                if (chart1.Series["Humidity"].Points.Count >= 30)
                                {
                                    chart1.Series["Humidity"].Points.RemoveAt(0);
                                }
                                chart1.Series["Humidity"].Points.Add(float.Parse(labHumidity.Text));
                                if(!HumidityUpdata.Enabled)
                                {
                                    HumidityUpdata.Enabled = true;
                                }
                                if (clientSockets != null)
                                {
                                    foreach (Socket item in clientSockets)
                                    {
                                        if (item != null)
                                        {
                                            try
                                            {
                                                item.Send(Encoding.ASCII.GetBytes(Json.getJsonString(pac)));
                                            }
                                            catch
                                            {
                                                
                                            }
                                        }
                                    }
                                    Thread.Sleep(500);
                                }
                            }
                            if (packet.DataList[i].SensorType == BISensorType.SmogSensor_MQ2)
                            {
                                //labSmoke.Text = packet.DataList[i].GetFloatValue().ToString("0.0");
                                DataPacket pac = new DataPacket() { packetType = PacketType.SensorData, sensorType = SensorType.Smoke, floatValue = packet.DataList[i].GetFloatValue() };
                                if(clientSockets!=null)
                                {
                                    foreach (Socket item in clientSockets)
                                    {
                                        if (item != null)
                                        {
                                            try
                                            {
                                                item.Send(Encoding.ASCII.GetBytes(Json.getJsonString(pac)));
                                            }
                                            catch 
                                            {
                                                
                                            }
                                        }
                                    }
                                    Thread.Sleep(500);
                                }
                            }
                            if (packet.DataList[i].SensorType == BISensorType.GasSensor_MQ5)
                            {
                                //labGas.Text = packet.DataList[i].GetFloatValue().ToString("0.0");
                                DataPacket pac = new DataPacket() { packetType = PacketType.SensorData, sensorType = SensorType.Gas, floatValue = packet.DataList[i].GetFloatValue() };
                                if (clientSockets != null)
                                {
                                    foreach (Socket item in clientSockets)
                                    {
                                        if (item != null)
                                        {
                                            try
                                            {
                                                item.Send(Encoding.ASCII.GetBytes(Json.getJsonString(pac)));
                                            }
                                            catch
                                            {

                                            }
                                        }
                                    }
                                    Thread.Sleep(500);
                                }
                            }
                            if (packet.DataList[i].SensorType == BISensorType.ReedSwitch)
                            {
                                labFireWarning.Text = packet.DataList[i].GetByteValue() == 0 ?  "警告" : "安全" ;
                                DataPacket pac = new DataPacket() { packetType = PacketType.SensorData, sensorType = SensorType.ReedSwitch, byteValue = packet.DataList[i].GetByteValue()};
                                if (clientSockets != null)
                                {
                                    foreach (Socket item in clientSockets)
                                    {
                                        if (item != null)
                                        {
                                            try
                                            {
                                                item.Send(Encoding.ASCII.GetBytes(Json.getJsonString(pac)));
                                            }
                                            catch
                                            {

                                            }
                                        }
                                    }
                                    Thread.Sleep(500);
                                }
                            }

                        }
                    }
                }
            }), null);
        }

        private void MainCtrl_PacketReceived1(object sender, BIPacketReceivedEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                BI25sUpgoingPacket packet = new BI25sUpgoingPacket(e.BinaryData);
                if(packet!=null)
                {
                    switch(packet.BoardID)
                    {
                        case 1:
                            {
                                Node1_SA.Text = packet.ShortAddress.ToString("X2");
                                Node1_MAC.Text = BitConverter.ToString(packet.MacAddress);
                                Node1_RSSI.Text = packet.NodeBoadRSSI.ToString();
                                break;
                            }
                        case 2:
                            {
                                Node2_SA.Text = packet.ShortAddress.ToString("X2");
                                Node2_MAC.Text = BitConverter.ToString(packet.MacAddress);
                                Node2_RSSI.Text = packet.NodeBoadRSSI.ToString();
                                break;
                            }
                        case 3:
                            {
                                Node3_SA.Text = packet.ShortAddress.ToString("X2");
                                Node3_MAC.Text = BitConverter.ToString(packet.MacAddress);
                                Node3_RSSI.Text = packet.NodeBoadRSSI.ToString();
                                break;
                            }
                    }
                }
            }), null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“smarthome_DatabaseDataSet.FireWarning”中。您可以根据需要移动或删除它。
            this.fireWarningTableAdapter.Fill(this.smarthome_DatabaseDataSet.FireWarning);
            // TODO: 这行代码将数据加载到表“smarthome_DatabaseDataSet.SensorData”中。您可以根据需要移动或删除它。
            this.sensorDataTableAdapter.Fill(this.smarthome_DatabaseDataSet.SensorData);

        }

        private void sysRun_Click(object sender, EventArgs e)
        {
            try
            {
                if(sysRun.Text=="启动系统")
                {
                    mainCtrl.ClosePort();
                    mainCtrl.OpenPort(portName.Text,38400,Parity.Even,8,StopBits.One);
                    mainCtrl.StartReceiver();
                    sysRun.Text = "关闭系统";
                }
                else
                {
                    mainCtrl.ClosePort();
                    sysRun.Text = "启动系统";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void netRun_Click(object sender, EventArgs e)
        {
            try
            {
                ip = IPAddress.Parse(ipInput.Text);
                serverSocket.Bind(new IPEndPoint(ip, myPort));
                serverSocket.Listen(10);
                myThread.Start();
                netRun.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void labFireWarning_TextChanged(object sender, EventArgs e)
        {
            if(labFireWarning.Text=="警告")
            {
                fireWarningTableAdapter.Insert(DateTime.Now);
            }
        }

        private void btnReadFireWarning_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            fireWarningTableAdapter.Fill(this.smarthome_DatabaseDataSet.FireWarning);
        }

        private void btnReadSensorData_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            sensorDataTableAdapter.Fill(this.smarthome_DatabaseDataSet.SensorData);
        }

        private void TempUpdata_Tick(object sender, EventArgs e)
        {
            sensorDataTableAdapter.Insert("Temp", Double.Parse(labTemp.Text), DateTime.Now);
        }

        private void LightUpdata_Tick(object sender, EventArgs e)
        {
            sensorDataTableAdapter.Insert("Light", Double.Parse(labLight.Text), DateTime.Now);
        }

        private void HumidityUpdata_Tick(object sender, EventArgs e)
        {
            sensorDataTableAdapter.Insert("Humidity", Double.Parse(labHumidity.Text), DateTime.Now);
        }
    }
}

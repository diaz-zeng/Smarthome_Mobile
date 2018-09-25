using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net;
using System.Net.Sockets;
using Smarthome_Mobile.Library;
using Smarthome_Mobile.Library.Packet;
using Smarthome_Mobile.Library.Json;
using System.Threading;

namespace Smarthome_Mobile.Client.Phone
{
    [Activity(Label = "仪表板",Icon = "@drawable/i1")]
    public class DashboardActivity : Activity
    {
        static byte[] result = new byte[1024];
        static TextView Temp;
        static TextView Humidity;
        static TextView Light;
        static TextView FireWarning;
        static TextView SysState;
        static ProgressBar pbTemp;
        static ProgressBar pbHumidity;
        static ProgressBar pbLight;
        static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static int port = 8885;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Dashboard);
            // Create your application here
            Temp = FindViewById<TextView>(Resource.Id.labTemp);
            Humidity = FindViewById<TextView>(Resource.Id.labHumidity);
            Light = FindViewById<TextView>(Resource.Id.labLight);
            FireWarning = FindViewById<TextView>(Resource.Id.labFireWarning);
            SysState = FindViewById<TextView>(Resource.Id.labSysState);
            pbTemp = FindViewById<ProgressBar>(Resource.Id.progressBarTemp);
            pbHumidity = FindViewById<ProgressBar>(Resource.Id.progressBarHumidity);
            pbLight = FindViewById<ProgressBar>(Resource.Id.progressBarLight);
            try
            {
                IPAddress ip = IPAddress.Parse(Intent.GetStringExtra("Address"));
                clientSocket.Connect(new IPEndPoint(ip, port));
                Thread receiveThread = new Thread(receiveMessage);
                receiveThread.Start(clientSocket);
                SysState.Text = "在线";
                Toast.MakeText(this, "系统已上线", ToastLength.Long).Show();
            }
            catch
            {
                SysState.Text = "离线";
                Toast.MakeText(this, "系统连线失败，请检查设置然后重试！", ToastLength.Long).Show(); ;
            }
        }
        private void receiveMessage(object clientSocket)
        {
            Socket socket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    int receiveNumber = socket.Receive(result);
                    DataPacket packet = Json.getPacket(Encoding.ASCII.GetString(result, 0, receiveNumber));
                    if (packet != null)
                    {
                        if (packet.packetType == PacketType.SensorData)
                        {
                            if (packet.sensorType == SensorType.Temp)
                            {
                                RunOnUiThread(new Action(() =>
                                {
                                    Temp.Text = packet.floatValue.ToString("0.0");
                                    pbTemp.Progress = Convert.ToInt32(packet.floatValue);
                                }));
                            }
                            if (packet.sensorType == SensorType.Humidity)
                            {
                                RunOnUiThread(new Action(() =>
                                {
                                    Humidity.Text = packet.floatValue.ToString("0.0");
                                    pbHumidity.Progress = Convert.ToInt32(packet.floatValue);
                                }));
                            }
                            if (packet.sensorType == SensorType.Light)
                            {
                                RunOnUiThread(new Action(() =>
                                {
                                    Light.Text = packet.floatValue.ToString("0.0");
                                    pbLight.Progress = Convert.ToInt32(packet.floatValue / 10);
                                }));
                            }
                            if (packet.sensorType == SensorType.ReedSwitch)
                            {
                                RunOnUiThread(new Action(() =>
                                {
                                    if (packet.byteValue == 0)
                                    {
                                        FireWarning.Text = "警告";
                                    }
                                    else if (packet.byteValue != 0)
                                    {
                                        FireWarning.Text = "安全";
                                    }
                                }));
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }
    }
}
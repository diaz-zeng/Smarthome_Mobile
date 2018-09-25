using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Util;

namespace Smarthome_Mobile.Client.HD
{
    [Activity(Label = "智能家居", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static Button btnLogin;
        static EditText txtuserName;
        static EditText txtPassword;
        static EditText txtAddress;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            txtuserName = FindViewById<EditText>(Resource.Id.txtUsername);
            txtAddress = FindViewById<EditText>(Resource.Id.txtAddress);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            if (txtuserName.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                Intent intent = new Intent(this, typeof(DashboardActivity));
                intent.PutExtra("Address", txtAddress.Text);
                StartActivity(intent);
            }
        }
    }
}


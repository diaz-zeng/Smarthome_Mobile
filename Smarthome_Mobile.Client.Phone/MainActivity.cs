using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Smarthome_Mobile.Client.Phone
{
    [Activity(Label = "智能家居", MainLauncher = true, Icon = "@drawable/i1")]
    public class MainActivity : Activity
    {
        static Button btnLogin;
        static EditText txtuserName;
        static EditText txtPassword;
        static EditText txtAddress;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            txtuserName = FindViewById<EditText>(Resource.Id.txtUsername);
            txtAddress = FindViewById<EditText>(Resource.Id.txtAddress);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += BtnLogin_Click1;
        }

        private void BtnLogin_Click1(object sender, System.EventArgs e)
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


using Android.App;
using Android.Widget;
using Android.OS;
using Abbi.IO.Abbisdk;

namespace WalkMeSampleApp
{
    [Activity(Label = "WalkMeXamarinAndroidBinding", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ABBI.Start("YOUR_APPKEY", "YOUR_SECRET",
                       this.Application);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}


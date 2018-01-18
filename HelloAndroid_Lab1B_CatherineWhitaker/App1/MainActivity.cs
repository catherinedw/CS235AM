using Android.App;
using Android.Widget;
using Android.OS;


namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //instance variable to keep track of count
        int count = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource, this comes first
            SetContentView(Resource.Layout.Main);
            //We are grabbing these from the C# from the contentView
            TextView aLabel = FindViewById<TextView>(Resource.Id.aLabel);
            Button aButton = FindViewById<Button>(Resource.Id.aButton);
            TextView helloLabel = FindViewById<TextView>(Resource.Id.helloLabel);
            Button clearButton = FindViewById<Button>(Resource.Id.clearButton);
            //Reuse event handler
            aButton.Click += (sender, e) => {
                aLabel.Text = (++count).ToString() + " taps";
                //helloLabel.Text = "Hello from the button";
            };
            clearButton.Click += (sender, e) => {
                aLabel.Text = "";
                helloLabel.Text = "---";
            };
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

    }
}

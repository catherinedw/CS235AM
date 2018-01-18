using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true /*, Icon = "@*/)]
    public class MainActivity : Activity
    {
        //instance variable to keep track of count
        int count = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Create the user interface in code
            //Create container
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            //Create label
            var aLabel = new TextView(this);
            aLabel.SetText(Resource.String.aLabelText);
            var helloLabel = new TextView(this);
            helloLabel.SetText(Resource.String.helloLabelText);
            //Create button
            var aButton = new Button(this);
            aButton.SetText(Resource.String.aButtonText);
            //Create the event handler using lambda expression to count the number of taps
            aButton.Click += (sender, e) => {
                aLabel.Text = (++count).ToString() + " taps";
                helloLabel.SetText(Resource.String.helloButtonText); 
            };
            //Create clear button
            var clearButton = new Button(this);
            clearButton.SetText(Resource.String.clearButtonText);
            //Create the event handler to clear the text
            clearButton.Click += (sender, e) => {
                count = 0;
                aLabel.Text = "";
                helloLabel.SetText(Resource.String.helloLabelText);
            };

            //This puts our label an button in the layout. These all inherit from view.
            layout.AddView(aLabel);
            layout.AddView(aButton);
            layout.AddView(helloLabel);
            layout.AddView(clearButton);

            //This adds the layout to the activity.
            SetContentView(layout);
        }

    }
}
/* protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
 */

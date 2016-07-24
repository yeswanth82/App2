
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App2.Droid
{
    [Activity (Label = "Click 2 Coffee", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        int count1 = 1;
        int count2 = 1;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
                {
                    if (count == 1)
                    {
                        button.Text = string.Format("302  Processing!");
                        count++;
                    }
                    else if(count==2)
                    {
                        button.Text = string.Format("302 Delivered");
                        count++;
                    }
                    else if(count==3)
                    {
                        button.Text = string.Format("302 Close order");
                        count++;
                    }
                    else if(count==4)
                    {
                        button.Visibility = ViewStates.Gone;
                        count++;
                    }
                }
			};
            Button button1 = FindViewById<Button>(Resource.Id.myButton1);

            button1.Click += delegate {
                {
                    if (count1 == 1)
                    {
                        button1.Text = string.Format("102  Processing!");
                        count1++;
                    }
                    else if (count1 == 2)
                    {
                        button1.Text = string.Format("102 Delivered");
                        count1++;
                    }
                    else if (count1 == 3)
                    {
                        button1.Text = string.Format("102 Close order");
                        count1++;
                    }
                    else if (count1 == 4)
                    {
                        button1.Visibility = ViewStates.Gone;
                        count1++;
                    }
                }
            };
        }
	}
}



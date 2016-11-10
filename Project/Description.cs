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

namespace Project
{
    [Activity(Label = "Course")]
    public class Description : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Info);
            var helloLabel = FindViewById<TextView>(Resource.Id.infom);
            //var data = GetIntent("description");
            string sender = Intent.GetStringExtra("description");
            helloLabel.Text = sender;
            // Create your application here
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                var helloLabel = FindViewById<TextView>(Resource.Id.infom);
                helloLabel.Text = data.GetStringExtra("description");
            }
        }
    }
}
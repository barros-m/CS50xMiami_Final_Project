using Android.App;
using Android.OS;
using Project;
using System.Timers;

namespace App2
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Stack overflow
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 sec.
            timer.AutoReset = false; // Do not reset the timer after it's elapsed
            timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                StartActivity(typeof(MainActivity));
            };
            timer.Start();
        }
    }
}
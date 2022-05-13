using Android.App;
using Android.Content;
using Android.Content.PM;
using AndroidX.AppCompat.App;

namespace BugTest2.Droid {
	[Activity(Theme = "@style/MainTheme.Splash",
			  MainLauncher = true,
			  LaunchMode = LaunchMode.SingleInstance,
			  NoHistory = true,
			  ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashActivity : AppCompatActivity {
		// Launches the startup task
		protected override void OnResume() {
			base.OnResume();
			StartActivity(new Intent(Application.Context, typeof(MainActivity)));
		}
	}
}

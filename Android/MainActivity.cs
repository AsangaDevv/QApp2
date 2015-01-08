using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


namespace QuizzApp.Android
{
	[Activity(Label = "@string/app_name", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			Forms.Init(this, bundle);
			SetPage(App.GetMainPage());
		}
	}
}


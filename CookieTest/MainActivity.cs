﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace CookieTest
{
	[Activity(Label = "CookieTest", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);
			
			button.Click += delegate
			{
				try
				{
					CookieManager.Instance.RemoveAllCookie();
				}
				catch (Exception ex)
				{
					Toast.MakeText(this, ex.ToString(), ToastLength.Long);
				}
			};
		}
	}
}



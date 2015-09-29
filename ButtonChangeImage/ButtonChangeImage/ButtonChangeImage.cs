using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ButtonChangeImage
{
	public class App : Application
	{
		public App ()
		{



			MainPage = new MyPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


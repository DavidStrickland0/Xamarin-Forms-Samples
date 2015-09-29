using System;

using Xamarin.Forms;

namespace BoolToImageConvertor
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			//MainPage = new WithConvertor();
			//MainPage = new DirectBinding();
			//MainPage = new NoXAMLWithConvertor();
			//MainPage = new NoXAMLNoBinding();
			MainPage = new NoXAMLDirectBinding();
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


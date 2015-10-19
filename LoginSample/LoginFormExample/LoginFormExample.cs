// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;

using Xamarin.Forms;

namespace LoginFormExample
{
    public class App : Application
    {
        public App ()
        {
            // The root page of your application
			//MainPage = new LoginViewPage();
			//MainPage = new LoginViewFormInCS();
			MainPage = new LoginViewPage2();
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


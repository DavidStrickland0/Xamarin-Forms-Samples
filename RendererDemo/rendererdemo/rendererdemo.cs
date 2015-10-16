// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;

using Xamarin.Forms;

namespace rendererdemo
{
    public class App : Application
    {
        public App ()
        {
            var lcb = new LegalCheckbox();
            // The root page of your application
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        lcb,
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };
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


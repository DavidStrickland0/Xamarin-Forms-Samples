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
            var CheckButton = new Button();
            var result = new Label();
            CheckButton.Clicked += (sender, e) =>
            {
                if (lcb.Checked)
                {
                    result.Text = "Its Checked";
                }
                else
                {
                    result.Text = "Not Checked";
                }
            };
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        lcb,
                        CheckButton,
                        result
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


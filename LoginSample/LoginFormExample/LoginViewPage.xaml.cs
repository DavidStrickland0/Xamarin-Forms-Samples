// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginFormExample
{
    public partial class LoginViewPage : ContentPage
    {
        public LoginViewPage ()
        {
            InitializeComponent ();
            BindingContext = new LoginViewModel();
        }
    }
}


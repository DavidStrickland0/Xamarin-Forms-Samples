// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace LoginFormExample
{
    public class LoginViewModel
    {
        public LoginViewModel() {
            LoginCommand = new Command<string>((string parameter) => 
                {
                    System.Diagnostics.Debug.WriteLine(parameter);
                    //do something with the string username
                });
        }

        public ICommand LoginCommand { get; private set; }
    }
}


// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace LoginFormExample
{
    public class LoginViewModel2
    {
        public LoginViewModel2() {

			LoginCommand2 = new Command<string>((string parameter) => 
				{
					System.Diagnostics.Debug.WriteLine(Name);
					//do something with the string username
				});
        }

		public string Name{ get; set; }
		public ICommand LoginCommand2 { get; private set; }
    }
}


﻿// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;
using Xamarin.Forms;

namespace rendererdemo
{
    public class LegalCheckbox : View
    {
		public bool Checked { 
			get; 
			set; 
		}
        public LegalCheckbox ()
        {
        }

		public EventHandler OnDoStuff;
		public void DoStuff()
		{
			if(OnDoStuff!=null)
			{
				OnDoStuff (this, new EventArgs ());
			}
		}
    }
}


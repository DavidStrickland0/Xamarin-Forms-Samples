// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using System;
using Xamarin.Forms;
using rendererdemo;
using rendererdemo.Droid;
using Android.Widget;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(LegalCheckbox), typeof(CheckBoxRenderer))]
namespace rendererdemo.Droid
{
    public class CheckBoxRenderer : ViewRenderer<LegalCheckbox, CheckBox>
    {
        protected override void OnElementChanged (ElementChangedEventArgs<LegalCheckbox> e)
        {
            base.OnElementChanged (e);
            CheckBox control = new Android.Widget.CheckBox(this.Context);
            control.Checked = false;
            control.Text = "I agree to terms";
            control.SetTextColor (Android.Graphics.Color.Rgb (60, 60, 60));
            base.SetNativeControl(control);
        }
    }
}


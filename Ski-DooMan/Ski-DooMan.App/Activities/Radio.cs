using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ski_DooMan.App.Manager;

namespace Ski_DooMan.App.Activities
{
    [Activity(Label = "Radio")]
    public class Radio : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Radio);

            RadioManager.Instance.StartPlayer("placeholder.mp3");
            // Create your application here
        }
    }
}
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

namespace Ski_DooMan.App.Activities
{
    [Activity(Label = "City")]
    public class City : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.city);
            Button Node6Btn = this.FindViewById<Button>(Resource.Id.node6);


        }

        void GoRadio()
        {

        }

        void GoDialog()
        {


        }

        void GoMap()
        {

        }

       
    }
}
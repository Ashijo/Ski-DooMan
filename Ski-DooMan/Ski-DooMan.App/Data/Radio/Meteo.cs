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

namespace Ski_DooMan.App.Data.Radio
{
    public static class Meteo
    {
        public static List<string> GetData()
        {
            return new List<string>()
            {
                "Attention! la {0} n'a pas été déblayé",
                "Attention! il y a un accident sur la {0}",
                "Attention! il y a de grande bourasque de vent sur la {0}"
            };
        }




    }
}
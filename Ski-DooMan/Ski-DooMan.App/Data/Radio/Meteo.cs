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
                "tout est clean",
                "y fait bo",
                "esti ksa gliss"
            };
        }
    }
}
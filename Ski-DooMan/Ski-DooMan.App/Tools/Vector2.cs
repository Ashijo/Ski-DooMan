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

namespace Ski_DooMan.App.Tools
{
    public class Vector2
    {
        float x { get; set; }
        float y { get; set; }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
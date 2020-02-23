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

namespace Ski_DooMan.App.Entities.GameEnt
{
    public class Npc
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }

        public Quest deverly { get; set;}
        public Quest narative { get; set; }

    }
}
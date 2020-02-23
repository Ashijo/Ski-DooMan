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
using Ski_DooMan.App.Tools;

namespace Ski_DooMan.App.Entities.MapEnt
{
    public class Place : Node
    {
        public bool hasAQuest;
        public Place(int id, Vector2 position, string name) : base(id, position, name, true, 25)
        {
            hasAQuest = false;
        }
    }
}
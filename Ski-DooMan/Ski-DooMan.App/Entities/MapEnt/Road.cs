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

namespace Ski_DooMan.App.Entities.MapEnt
{
    public class Road
    {
        public string name;
        public int id;
        public Node aNode;
        public Node bNode;

        public RoadEvent roadEvent;

        public Road(Node a, Node b, int id, string name = "a road")
        {
            aNode = a;
            bNode = b;
            this.name = name;
            this.id = id;
            roadEvent = RoadEvent.Nothing;
        }

        public void ResetState()
        {
            roadEvent = RoadEvent.Nothing;
        }
    }
}
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
    public class Node
    {
        public int id { get; protected set; }
        public Vector2 position { get; protected set; }
        public float size { get; protected set; }
        public string name;

        public bool isPlace;

        public Node() { }
        public Node(int id, Vector2 position, string name, bool isPlace = false, float size = 15)
        {
            this.id = id;
            this.position = position;
            this.size = size;
            this.name = name;
            this.isPlace = isPlace;
        }
    }
}
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
        Random rand;

        public Npc(int id, string name, string img, Quest deverly, Quest narative)
        {
            this.id = id;
            this.name = name;
            this.img = img;
            this.deverly = deverly;
            this.narative = narative;
        }

        public Quest GetMyQuest()
        {
            if(definedQuest == null) {
                if(rand == null)
                    rand = new Random();

                if (rand.Next(0, 2) == 0)
                    definedQuest = deverly;
                else
                    definedQuest = narative;
            }

            return definedQuest;

        }

        public Quest definedQuest;

        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }

        public Quest deverly { get; set; }
        public Quest narative { get; set; }

    }
}
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
using Ski_DooMan.App.Entities.GameEnt;
using Ski_DooMan.App.Tools;

namespace Ski_DooMan.App.Manager
{
    public class GameManager
    {
        List<Npc> npcs;
        List<Npc> usedNpc;

        private static GameManager instance = null;

        private GameManager()
        {
            npcs = Seeder.GetNpcs();
            usedNpc = new List<Npc>();
        }

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }

        public void ResetState()
        {
            usedNpc = new List<Npc>();
        }

        public Npc GetAnNPC()
        {
            Random random = new Random();

            var i = random.Next(npcs.Count - usedNpc.Count);
            var choosenOne = npcs.Where(np => !usedNpc.Select(use => use.id).Contains(np.id)).ToArray()[i];
            usedNpc.Add(choosenOne);

            return choosenOne;
        }

    }
}
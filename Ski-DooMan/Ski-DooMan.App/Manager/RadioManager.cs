using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.SimpleAudioPlayer;
using Ski_DooMan.App.Data.Radio;
using Ski_DooMan.App.Tools;

namespace Ski_DooMan.App.Manager
{
    public class RadioManager
    {

        List<string> meteo;
        Dictionary<string, string> npcs;
        Dictionary<Value, List<string>> musics;



        int meteoCall = 0;

        #region instance
        private static RadioManager instance = null;

        private RadioManager()
        {
            musics = Seeder.GetMusics();
            meteo = Meteo.GetData();
            npcs = NPC.GetData();
        }

        public static RadioManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RadioManager();
                }
                return instance;
            }
        }

        #endregion

        Random random;
        public string GetAMusic()
        {
            Array values = Enum.GetValues(typeof(Value));
            if(random == null)
                random = new Random();
            Value randomvalue = (Value)values.GetValue(random.Next(values.Length));

            return musics[randomvalue][random.Next(musics[randomvalue].Count)];
        }

        public string GetMeteo()
        {
            var asw = "";
            if (meteoCall < 4)
            {
                asw = string.Format(meteo[meteoCall], MapManager.Instance.GetRoadName(MapManager.Instance.trapperdRoads[meteoCall]));
            }
            meteoCall++;
            return asw;
        }

        public string GetANpc()
        {
            var npc = GameManager.Instance.GetAnNPC();
            var where = MapManager.Instance.GetAPertinentPlace();
            var deliver = MapManager.Instance.GetAPertinentPlace(where.id);
            MapManager.Instance.SetNpc(npc, where);
            var isDeliver = npc.GetMyQuest().questType;

            var questMsg = npcs[npc.name + (isDeliver ? "-deliver" : "")];

            if (isDeliver)
            {
                questMsg = string.Format(questMsg, where.name, deliver.name);
            }else {     
                questMsg = string.Format(questMsg, where.name);
            }

            return questMsg;
        }
    }

}
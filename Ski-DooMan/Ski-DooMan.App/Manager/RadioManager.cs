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
        Dictionary<string, string> npc;
        Dictionary<Value, List<string>> musics;

        int meteoCall = 0;

        #region instance
        private static RadioManager instance = null;

        private RadioManager()
        {
            musics = Seeder.GetMusics();
            meteo = Meteo.GetData();
            npc = NPC.GetData();
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

        public string GetAMusic()
        {
            Array values = Enum.GetValues(typeof(Value));
            Random random = new Random();
            Value randomvalue = (Value)values.GetValue(random.Next(values.Length));

            return musics[randomvalue][random.Next(musics[randomvalue].Count)];
        }

        public string GetMeteo()
        {
            var asw = "";
            if (meteoCall < 4)
            {
                asw = string.Format(meteo[meteoCall], MapManager.Instance.trapperdRoads[meteoCall]);
            }
            meteoCall++;
            return asw;
        }

        public string GetANpc()
        {

            return "";
        }
    }

}
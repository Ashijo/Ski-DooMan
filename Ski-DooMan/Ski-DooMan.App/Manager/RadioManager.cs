using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ski_DooMan.App.Manager
{
    public class RadioManager
    {
        protected MediaPlayer player;

        #region instance
        private static RadioManager instance = null;

        private RadioManager()
        { }

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

        public void StartPlayer(string fileName)
        {
            if (player == null)
            {
                player = new MediaPlayer();
            }
            else
            {
                player.Reset();
            }


            //player.SetDataSource("android.resource://Ski-DooMan.App/Raw/Audio/placeholder.mp3",
            player.Prepare();
            player.Start();
        }
    }
}
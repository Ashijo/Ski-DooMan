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

namespace Ski_DooMan.App.Manager
{
    public class RadioManager
    {
        


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

     
    }
   
}
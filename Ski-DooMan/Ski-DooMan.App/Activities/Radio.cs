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
using Ski_DooMan.App.Manager;

namespace Ski_DooMan.App.Activities
{
    [Activity(Label = "Radio")]
    public class Radio : Activity
    {
        string msg = "";
        string alert = "";

        TextView radioAnswer;
        TextView dangerMsg;

        Button meteo;
        Button npc;
        Button music;
        Button finish;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Radio);

            meteo = this.FindViewById<Button>(Resource.Id.meteo);
            npc = this.FindViewById<Button>(Resource.Id.npc);
            music = this.FindViewById<Button>(Resource.Id.music);
            finish = this.FindViewById<Button>(Resource.Id.finish);

            finish.Click += delegate
            {
                Reset();
                StartActivity(typeof(City));
            };

            meteo.Click += delegate
            {
                GetMeteo();
                UpdateAlerte();
                MsgVisible();
            };


            npc.Click += delegate
            {
                GetNpc();
                UpdateAlerte();
                MsgVisible();
            };

            music.Click += delegate
            {
                GetMusic();
                UpdateAlerte();
                MsgVisible();
            };

            radioAnswer = this.FindViewById<TextView>(Resource.Id.radioAnswer);
            dangerMsg = this.FindViewById<TextView>(Resource.Id.dangerMsg);
        }


        public void Reset()
        {
            alert = "";
            msg = "";
            radioAnswer.Visibility = ViewStates.Gone;
            dangerMsg.Visibility = ViewStates.Gone;
            finish.Visibility = ViewStates.Gone;

            meteo.Visibility = ViewStates.Visible;
            npc.Visibility = ViewStates.Visible;
            music.Visibility = ViewStates.Visible;
        }

        void MsgVisible()
        {
            radioAnswer.Visibility = ViewStates.Visible;
            dangerMsg.Visibility = ViewStates.Visible;
            finish.Visibility = ViewStates.Visible;

            radioAnswer.Text = msg;
            dangerMsg.Text = alert;

            meteo.Visibility = ViewStates.Gone;
            npc.Visibility = ViewStates.Gone;
            music.Visibility = ViewStates.Gone;


        }

        public void UpdateAlerte()
        {
            if (!MapManager.Instance.IsJourneySafe())
            {
                alert = "On a eu un probleme sur la route";
            }
        }

        public void GetMeteo()
        {
            msg = RadioManager.Instance.GetMeteo();
        }

        public void GetNpc()
        {
            msg = RadioManager.Instance.GetANpc();
        }

        public void GetMusic()
        {
            msg = RadioManager.Instance.GetAMusic();
        }

    }
}
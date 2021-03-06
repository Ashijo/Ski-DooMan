﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ski_DooMan.App.Entities.MapEnt;
using Ski_DooMan.App.Manager;

namespace Ski_DooMan.App.Activities
{
    [Activity(Label = "City")]
    public class City : Activity
    {
        ImageView img;
        TextView msg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.city);
            Button tavern = this.FindViewById<Button>(Resource.Id.tavern);
            Button explore = this.FindViewById<Button>(Resource.Id.explore);
            Button radio = this.FindViewById<Button>(Resource.Id.radio);
            Button character = this.FindViewById<Button>(Resource.Id.character);
            Button map = this.FindViewById<Button>(Resource.Id.map);
            Button end = this.FindViewById<Button>(Resource.Id.end);

            img = this.FindViewById<ImageView>(Resource.Id.img);
            msg = this.FindViewById<TextView>(Resource.Id.msg);

            bool badTravel = MapManager.Instance.IsJourneySafe();
            MapManager.Instance.ResetTravelSelect();

            explore.Click += delegate
            {
                Explore();
            };

            radio.Click += delegate
            {
                GoRadio();
            };

            character.Click += delegate
            {
                if (((Place)MapManager.Instance.characterPosition).hasAQuest && !((Place)MapManager.Instance.characterPosition).npc.definedQuest.questType)
                {
                    GoDialog();
                }
            };


            map.Click += delegate
            {
                GoMap();
            };

            radio.Click += delegate
            {
                GoRadio();
            };

            if (badTravel)
            {
                BadTravel();
            }
        }

        void GoRadio()
        {
            StartActivity(typeof(Radio));
        }

        void GoDialog()
        {
            StartActivity(typeof(Dialog));
        }

        void GoMap()
        {
            StartActivity(typeof(Map));
        }

        void EndTurn()
        {

        }

        void BadTravel()
        {
            img.Visibility = ViewStates.Gone;
            msg.Visibility = ViewStates.Visible;
            msg.Text = "On a eu un probleme sur la route";
        }

        void Explore()
        {
            img.Visibility = ViewStates.Gone;
            msg.Visibility = ViewStates.Visible;
            msg.Text = RadioManager.Instance.GetANpc();
        }
    }
}
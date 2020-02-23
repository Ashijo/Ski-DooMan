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
using Ski_DooMan.App.Entities.MapEnt;
using Ski_DooMan.App.Manager;

namespace Ski_DooMan.App.Activities
{
    [Activity(Label = "Dialog")]
    public class Dialog : Activity
    {
        LinearLayout header;
        TextView result;
        Button aAnswer;
        Button bAnswer;
        Button cAnswer;
        Button goBack;
        Entities.GameEnt.Npc currentNpc;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.dialog);

            TextView description = this.FindViewById<TextView>(Resource.Id.description);
            result = this.FindViewById<TextView>(Resource.Id.result);
            aAnswer = this.FindViewById<Button>(Resource.Id.aAnswer);
            bAnswer = this.FindViewById<Button>(Resource.Id.bAnswer);
            cAnswer = this.FindViewById<Button>(Resource.Id.cAnswer);

            header = this.FindViewById<LinearLayout>(Resource.Id.header);

            goBack = this.FindViewById<Button>(Resource.Id.goBack);

            goBack.Click += delegate
            {
                GoBack();
            };

            currentNpc = ((Place)MapManager.Instance.characterPosition).npc;
            description.Text = currentNpc.GetMyQuest().description;

            aAnswer.Text = currentNpc.GetMyQuest().answerA.title;
            bAnswer.Text = currentNpc.GetMyQuest().answerB.title;
            cAnswer.Text = currentNpc.GetMyQuest().answerC.title;


            aAnswer.Click += delegate
            {
                aResult();
                SwitchVisiblity();
            };
            bAnswer.Click += delegate
            {
                bResult();
                SwitchVisiblity();
            };
            cAnswer.Click += delegate
            {
                cResult();
                SwitchVisiblity();
            };

        }

        void aResult()
        {
            result.Text = currentNpc.GetMyQuest().answerA.label + " " + currentNpc.GetMyQuest().answerA.result;
        }

        void bResult()
        {
            result.Text = currentNpc.GetMyQuest().answerB.label + " " + currentNpc.GetMyQuest().answerB.result;
        }

        void cResult()
        {
            result.Text = currentNpc.GetMyQuest().answerC.label + " " + currentNpc.GetMyQuest().answerC.result;
        }

        void SwitchVisiblity()
        {
            aAnswer.Visibility = ViewStates.Gone;
            bAnswer.Visibility = ViewStates.Gone;
            cAnswer.Visibility = ViewStates.Gone;

            header.Visibility = ViewStates.Gone;

            result.Visibility = ViewStates.Visible;
            goBack.Visibility = ViewStates.Visible;
        }

        void GoBack()
        {
            MapManager.Instance.ResolveQuest(MapManager.Instance.characterPosition.id);
            StartActivity(typeof(City));
        }

    }
}